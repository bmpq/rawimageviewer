namespace rawimageviewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F15)
            {
                System.Environment.Exit(1);
            }
        }
    }
}