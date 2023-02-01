namespace rawimageviewer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new rawimageviewer.PictureBoxWithInterpolationMode();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOpen = new System.Windows.Forms.Button();
            this.textSize = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkboxInterpolation = new System.Windows.Forms.CheckBox();
            this.chkboxFit = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textPixelAmount = new System.Windows.Forms.Label();
            this.chk16bits = new System.Windows.Forms.CheckBox();
            this.chkAlpha = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSwap = new System.Windows.Forms.ComboBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.inputOffset = new System.Windows.Forms.NumericUpDown();
            this.inputHeight = new System.Windows.Forms.NumericUpDown();
            this.inputWidth = new System.Windows.Forms.NumericUpDown();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 178F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 561);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Default;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 513);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 522);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel2);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(600, 36);
            this.splitContainer1.SplitterDistance = 260;
            this.splitContainer1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.btnOpen);
            this.flowLayoutPanel1.Controls.Add(this.textSize);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(99, 31);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnOpen.Location = new System.Drawing.Point(3, 3);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 25);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open...";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // textSize
            // 
            this.textSize.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textSize.AutoSize = true;
            this.textSize.Location = new System.Drawing.Point(84, 8);
            this.textSize.Name = "textSize";
            this.textSize.Size = new System.Drawing.Size(12, 15);
            this.textSize.TabIndex = 1;
            this.textSize.Text = "-";
            this.textSize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.chkboxInterpolation);
            this.flowLayoutPanel2.Controls.Add(this.chkboxFit);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(120, 6);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel2.Size = new System.Drawing.Size(216, 25);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // chkboxInterpolation
            // 
            this.chkboxInterpolation.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chkboxInterpolation.AutoSize = true;
            this.chkboxInterpolation.Location = new System.Drawing.Point(96, 3);
            this.chkboxInterpolation.Name = "chkboxInterpolation";
            this.chkboxInterpolation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkboxInterpolation.Size = new System.Drawing.Size(117, 19);
            this.chkboxInterpolation.TabIndex = 1;
            this.chkboxInterpolation.Text = "Nearest neighbor";
            this.chkboxInterpolation.UseVisualStyleBackColor = true;
            this.chkboxInterpolation.CheckedChanged += new System.EventHandler(this.OnInput);
            // 
            // chkboxFit
            // 
            this.chkboxFit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chkboxFit.AutoSize = true;
            this.chkboxFit.Checked = true;
            this.chkboxFit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkboxFit.Location = new System.Drawing.Point(3, 3);
            this.chkboxFit.Name = "chkboxFit";
            this.chkboxFit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkboxFit.Size = new System.Drawing.Size(87, 19);
            this.chkboxFit.TabIndex = 0;
            this.chkboxFit.Text = "Fit to frame";
            this.chkboxFit.UseVisualStyleBackColor = true;
            this.chkboxFit.CheckedChanged += new System.EventHandler(this.OnInput);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.textPixelAmount);
            this.panel1.Controls.Add(this.chk16bits);
            this.panel1.Controls.Add(this.chkAlpha);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbSwap);
            this.panel1.Controls.Add(this.btnGuess);
            this.panel1.Controls.Add(this.inputOffset);
            this.panel1.Controls.Add(this.inputHeight);
            this.panel1.Controls.Add(this.inputWidth);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(609, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 513);
            this.panel1.TabIndex = 1;
            // 
            // textPixelAmount
            // 
            this.textPixelAmount.AutoSize = true;
            this.textPixelAmount.Location = new System.Drawing.Point(81, 56);
            this.textPixelAmount.Name = "textPixelAmount";
            this.textPixelAmount.Size = new System.Drawing.Size(80, 30);
            this.textPixelAmount.TabIndex = 15;
            this.textPixelAmount.Text = "Pixel amount:\r\n0\r\n";
            this.textPixelAmount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // chk16bits
            // 
            this.chk16bits.AutoSize = true;
            this.chk16bits.Location = new System.Drawing.Point(0, 8);
            this.chk16bits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chk16bits.Name = "chk16bits";
            this.chk16bits.Size = new System.Drawing.Size(125, 19);
            this.chk16bits.TabIndex = 14;
            this.chk16bits.Text = "16 bits per channel";
            this.chk16bits.UseVisualStyleBackColor = true;
            this.chk16bits.CheckedChanged += new System.EventHandler(this.OnInput);
            // 
            // chkAlpha
            // 
            this.chkAlpha.AutoSize = true;
            this.chkAlpha.Checked = true;
            this.chkAlpha.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAlpha.Location = new System.Drawing.Point(0, 31);
            this.chkAlpha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkAlpha.Name = "chkAlpha";
            this.chkAlpha.Size = new System.Drawing.Size(128, 19);
            this.chkAlpha.TabIndex = 13;
            this.chkAlpha.Text = "With alpha channel";
            this.chkAlpha.UseVisualStyleBackColor = true;
            this.chkAlpha.CheckedChanged += new System.EventHandler(this.OnInput);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Channel order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Dimensions";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Header offset";
            // 
            // cbSwap
            // 
            this.cbSwap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSwap.FormattingEnabled = true;
            this.cbSwap.Location = new System.Drawing.Point(0, 296);
            this.cbSwap.Name = "cbSwap";
            this.cbSwap.Size = new System.Drawing.Size(161, 23);
            this.cbSwap.TabIndex = 9;
            this.cbSwap.SelectedValueChanged += new System.EventHandler(this.OnInput);
            // 
            // btnGuess
            // 
            this.btnGuess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuess.Location = new System.Drawing.Point(0, 173);
            this.btnGuess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(161, 22);
            this.btnGuess.TabIndex = 8;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // inputOffset
            // 
            this.inputOffset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputOffset.Location = new System.Drawing.Point(1, 234);
            this.inputOffset.Maximum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            0});
            this.inputOffset.Name = "inputOffset";
            this.inputOffset.Size = new System.Drawing.Size(160, 23);
            this.inputOffset.TabIndex = 7;
            this.inputOffset.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputOffset.ValueChanged += new System.EventHandler(this.OnInput);
            // 
            // inputHeight
            // 
            this.inputHeight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputHeight.Location = new System.Drawing.Point(0, 145);
            this.inputHeight.Maximum = new decimal(new int[] {
            65565,
            0,
            0,
            0});
            this.inputHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputHeight.Name = "inputHeight";
            this.inputHeight.Size = new System.Drawing.Size(161, 23);
            this.inputHeight.TabIndex = 3;
            this.inputHeight.Value = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.inputHeight.ValueChanged += new System.EventHandler(this.OnInput);
            // 
            // inputWidth
            // 
            this.inputWidth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputWidth.Location = new System.Drawing.Point(0, 118);
            this.inputWidth.Maximum = new decimal(new int[] {
            65565,
            0,
            0,
            0});
            this.inputWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputWidth.Name = "inputWidth";
            this.inputWidth.Size = new System.Drawing.Size(161, 23);
            this.inputWidth.TabIndex = 2;
            this.inputWidth.Value = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.inputWidth.ValueChanged += new System.EventHandler(this.OnInput);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(768, 480);
            this.Name = "Form1";
            this.Text = "rawimageviewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputWidth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBoxWithInterpolationMode pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnOpen;
        private OpenFileDialog openFileDialog1;
        private SplitContainer splitContainer1;
        private FlowLayoutPanel flowLayoutPanel2;
        private CheckBox chkboxFit;
        private Panel panel1;
        private NumericUpDown inputWidth;
        private NumericUpDown inputHeight;
        private CheckBox chkboxInterpolation;
        private NumericUpDown inputOffset;
        private Button btnGuess;
        private ComboBox cbSwap;
        private Label label2;
        private Label label1;
        private Label textSize;
        private Label label3;
        private CheckBox chkAlpha;
        private CheckBox chk16bits;
        private Label textPixelAmount;
    }
}