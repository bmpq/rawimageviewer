using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace rawimageviewer
{
    public partial class Form1 : Form
    {
        byte[] loadedFile;

        public Form1(string path)
        {
            loadedFile = new byte[2];

            InitializeComponent();

            if (path != null)
            {
                LoadFile(path);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbFormat.DataSource = Enum.GetValues(typeof(PixelFormat));
            cbFormat.SelectedIndex = 15;

            cbSwap.DataSource = Enum.GetValues(typeof(BitmapChannelSwapper.ColorSwapType));
            cbSwap.SelectedIndex = 3;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                OpenFileDialog();
            }
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
            }
        }

        private void LoadFile(string imgPath)
        {
            loadedFile = File.ReadAllBytes(imgPath);
            ReadConfig();
        }

        void ReadConfig()
        {
            PixelFormat format = PixelFormat.Format32bppArgb;

            var selectedFormat = cbFormat.SelectedValue;
            if (selectedFormat != null)
                Enum.TryParse(selectedFormat.ToString(), out format);

            BitmapChannelSwapper.ColorSwapType swapType = BitmapChannelSwapper.ColorSwapType.None;
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

                if (pictureBox1.Image != null)
                {
                    textFormatStatus.Text = "Decoded with " + format.ToString() + "\n(Stride: " + bmpData.Stride + ")";
                    textFormatStatus.ForeColor = default(Color);
                }
            }
            catch (ArgumentException e)
            {
                pictureBox1.Image = null;
            }

            if (pictureBox1.Image == null)
            {
                textFormatStatus.Text = "Failed to decode in " + format.ToString();
                textFormatStatus.ForeColor = Color.Red;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F15)
            {
                System.Environment.Exit(1);
            }
        }

        private void chkBoxScaling_CheckedChanged(object sender, EventArgs e)
        {
            chkboxInterpolation.Enabled = chkboxFit.Checked;
            ReadConfig();
        }

        private void OnInput(object sender, EventArgs e)
        {
            ReadConfig();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            GuessDimensions();
        }

        private void GuessDimensions()
        {
            int width = (int)Math.Sqrt(loadedFile.Length / 4);
            int height = (int)(width / 1.777777777777778);

            inputWidth.Value = width;
            inputHeight.Value = height;
        }
    }
}