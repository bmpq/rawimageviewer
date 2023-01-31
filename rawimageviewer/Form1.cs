using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace rawimageviewer
{
    public partial class Form1 : Form
    {
        byte[] loadedFile;

        public Form1()
        {
            loadedFile = new byte[2];

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbFormat.DataSource = Enum.GetValues(typeof(PixelFormat));
            cbFormat.SelectedIndex = 8;
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
                LoadFile(openFileDialog1.FileName, 1920, 800);
            }
        }

        private void LoadFile(string imgPath, int width, int height)
        {
            loadedFile = File.ReadAllBytes(imgPath);
            ReadConfig();
        }

        void ReadConfig()
        {
            PixelFormat format = PixelFormat.Format32bppArgb;

            Enum.TryParse<PixelFormat>(cbFormat.SelectedValue.ToString(), out format);

            pictureBox1.SizeMode = chkboxFit.Checked ? PictureBoxSizeMode.Zoom : PictureBoxSizeMode.Normal;
            pictureBox1.InterpolationMode = chkboxInterpolation.Checked 
                ? System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor
                : System.Drawing.Drawing2D.InterpolationMode.Default;

            Decode((int)inputWidth.Value, (int)inputHeight.Value, format);
        }

        private void Decode(int width, int height, PixelFormat format)
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

                Marshal.Copy(loadedFile, 0, bmpData.Scan0, Math.Min(loadedFile.Length, Math.Abs(bmpData.Stride) * bmp.Height));
                bmp.UnlockBits(bmpData);

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

        private void inputWidth_Validated(object sender, EventArgs e)
        {
            ReadConfig();
        }

        private void inputHeight_Validated(object sender, EventArgs e)
        {
            ReadConfig();
        }

        private void cbFormat_SelectedValueChanged(object sender, EventArgs e)
        {
            ReadConfig();
        }
    }
}