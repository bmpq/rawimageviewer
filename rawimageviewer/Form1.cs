using System.Drawing.Imaging;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace rawimageviewer
{
    public partial class Form1 : Form
    {
        byte[] loadedFile;

        public Form1(string path)
        {
            loadedFile = new byte[4];

            InitializeComponent();

            cbSwap.DataSource = Enum.GetValues(typeof(BitmapChannelSwapper.ColorSwapType));
            cbSwap.SelectedIndex = 0;

            if (path != null && path != string.Empty)
            {
                LoadFile(path);

                if (path.EndsWith(".aecache"))
                    ReadMetadata();
                else
                    GuessDimensions();

                // adjust the window size according to the guessed dimensions
                float ratio = (float)inputWidth.Value / (float)inputHeight.Value;
                Size = new Size((int)(Size.Height * ratio), Size.Height);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog();
        }

        private void OpenFileDialog()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                LoadFile(openFileDialog1.FileName);

                if (openFileDialog1.FileName.EndsWith(".aecache"))
                    ReadMetadata();
                else
                    ReadConfig();
            }
        }

        private void LoadFile(string imgPath)
        {
            loadedFile = File.ReadAllBytes(imgPath);
        }

        void ReadConfig()
        {
            PixelFormat format = PixelFormat.Format32bppRgb;

            if (chk16bits.Checked)
                format = PixelFormat.Format64bppArgb;
            else if (chkAlpha.Checked)
                format = PixelFormat.Format32bppArgb;

            BitmapChannelSwapper.ColorSwapType swapType = BitmapChannelSwapper.ColorSwapType.Default;
            var selectedSwap = cbSwap.SelectedValue;
            if (selectedSwap != null)
                Enum.TryParse(selectedSwap.ToString(), out swapType);

            pictureBox1.SizeMode = chkboxFit.Checked ? PictureBoxSizeMode.Zoom : PictureBoxSizeMode.Normal;
            pictureBox1.InterpolationMode = chkboxInterpolation.Checked 
                ? System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor
                : System.Drawing.Drawing2D.InterpolationMode.Default;



            Decode((int)inputWidth.Value, (int)inputHeight.Value, (int)inputOffset.Value, format, swapType);
        }

        private void Decode(int width, int height, int offset, PixelFormat format, BitmapChannelSwapper.ColorSwapType swapType)
        {
            try
            {
                var bmp = new Bitmap(width, height, format);

                BitmapData bmpData = bmp.LockBits(
                    new Rectangle(0, 0,
                    bmp.Width,
                    bmp.Height),
                    ImageLockMode.WriteOnly,
                    bmp.PixelFormat);

                Marshal.Copy(loadedFile, offset, bmpData.Scan0, Math.Min(loadedFile.Length, Math.Abs(bmpData.Stride) * bmp.Height) - offset);

                bmp.UnlockBits(bmpData);

                bmp = BitmapChannelSwapper.SwapColors(bmp, swapType);

                pictureBox1.Image = bmp;
            }
            catch
            {
                pictureBox1.Image = null;
            }

            UpdateOutput();
        }

        private void UpdateOutput()
        {
            // space thousands separator (# ### ###)
            var f = new NumberFormatInfo { NumberGroupSeparator = " " };

            textSize.Text = "File size: " + loadedFile.Length.ToString("N0", f) + " bytes";

            textPixelAmount.Text = "Pixel amount:\n";
            textPixelAmount.Text += GetEstimatedPixelAmount().ToString("N0", f);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F15)
            {
                System.Environment.Exit(1);
            }
        }

        private void OnInput(object sender, EventArgs e)
        {
            chkboxInterpolation.Enabled = chkboxFit.Checked;

            if (chk16bits.Checked)
                chkAlpha.Checked = true;
            chkAlpha.Enabled = !chk16bits.Checked;

            ReadConfig();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            GuessDimensions();
        }

        int GetEstimatedPixelAmount()
        {
            int result;

            if (chk16bits.Checked)
                result = loadedFile.Length / 8;
            else
                result = loadedFile.Length / (chkAlpha.Checked ? 4 : 3);

            result -= (int)inputOffset.Value;

            result = Math.Max(result, 1);

            return result;
        }

        private void GuessDimensions()
        {
            int pixelAmount = GetEstimatedPixelAmount();

            // assume the 1:1 aspect ratio by default
            int width = (int)Math.Sqrt(pixelAmount);
            int height = width;

            if (pixelAmount > 8294400)
            {
                width = 3840;
                height = 2160;
            }
            else if (pixelAmount > 6144000)
            {
                width = 3840;
                height = 1608;
            }
            else if (pixelAmount > 3686400)
            {
                width = 2560;
                height = 1440;
            }
            else if (pixelAmount > 2073600)
            {
                width = 1920;
                height = 1080;
            }
            else if (pixelAmount > 1536000)
            {
                width = 1920;
                height = 800;
            }
            else if (pixelAmount > 921600)
            {
                width = 1280;
                height = 720;
            }

            if (pixelAmount < 140000)
            {
                if (pixelAmount > 129600) // 1080x1080 quarter preview
                {
                    width = 480;
                    height = 270;
                }
                else if (pixelAmount > 96000) // 1080x800 quarter preview
                {
                    width = 480;
                    height = 200;
                }
            }

            inputWidth.Value = width;
            inputHeight.Value = height;
        }

        private void btnMetaData_Click(object sender, EventArgs e)
        {
            ReadMetadata();
        }

        private void ReadMetadata()
        {
            if (loadedFile.Length < 24)
            {
                MessageBox.Show("No metadata (file too small)");
                return;
            }

            // the value at offset 16
            // is for the color depth (bits per channel)
            bool eightbpc = BitConverter.ToUInt32(loadedFile, 16) == 8;

            // theres is a width value at offset 8
            // but it is sometimes wrong when opening a frame of a precomp(???)
            // or it has something to do with masks i dont know
            // the width value at offset 20 is always correct
            // just need to divide it by the number of channels
            int width = BitConverter.ToInt32(loadedFile, 20) / (eightbpc ? 4 : 8);
            int height = BitConverter.ToInt32(loadedFile, 12);

            width = (int)Math.Clamp(width, inputWidth.Minimum, inputWidth.Maximum);
            height = (int)Math.Clamp(height, inputHeight.Minimum, inputHeight.Maximum);

            inputWidth.Value = width;
            inputHeight.Value = height;

            chk16bits.Checked = !eightbpc;

            chkAlpha.Checked = true;

            int offset = 25;
            if (!eightbpc)
                offset--;

            inputOffset.Value = offset;
            cbSwap.SelectedIndex = 3;
        }
    }
}