﻿namespace rawimageviewer
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSwap = new System.Windows.Forms.ComboBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.inputOffset = new System.Windows.Forms.NumericUpDown();
            this.textFormatStatus = new System.Windows.Forms.Label();
            this.cbFormat = new System.Windows.Forms.ComboBox();
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 249F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1113, 632);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Default;
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(858, 568);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 580);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.splitContainer1.Size = new System.Drawing.Size(858, 48);
            this.splitContainer1.SplitterDistance = 375;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.btnOpen);
            this.flowLayoutPanel1.Controls.Add(this.textSize);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 4);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(113, 41);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnOpen.Location = new System.Drawing.Point(3, 4);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(86, 33);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open...";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // textSize
            // 
            this.textSize.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textSize.AutoSize = true;
            this.textSize.Location = new System.Drawing.Point(95, 10);
            this.textSize.Name = "textSize";
            this.textSize.Size = new System.Drawing.Size(15, 20);
            this.textSize.TabIndex = 1;
            this.textSize.Text = "-";
            this.textSize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.chkboxInterpolation);
            this.flowLayoutPanel2.Controls.Add(this.chkboxFit);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 8);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel2.Size = new System.Drawing.Size(266, 32);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // chkboxInterpolation
            // 
            this.chkboxInterpolation.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chkboxInterpolation.AutoSize = true;
            this.chkboxInterpolation.Enabled = false;
            this.chkboxInterpolation.Location = new System.Drawing.Point(117, 4);
            this.chkboxInterpolation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkboxInterpolation.Name = "chkboxInterpolation";
            this.chkboxInterpolation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkboxInterpolation.Size = new System.Drawing.Size(146, 24);
            this.chkboxInterpolation.TabIndex = 1;
            this.chkboxInterpolation.Text = "Nearest neighbor";
            this.chkboxInterpolation.UseVisualStyleBackColor = true;
            this.chkboxInterpolation.CheckedChanged += new System.EventHandler(this.chkBoxScaling_CheckedChanged);
            // 
            // chkboxFit
            // 
            this.chkboxFit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chkboxFit.AutoSize = true;
            this.chkboxFit.Checked = true;
            this.chkboxFit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkboxFit.Location = new System.Drawing.Point(3, 4);
            this.chkboxFit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkboxFit.Name = "chkboxFit";
            this.chkboxFit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkboxFit.Size = new System.Drawing.Size(108, 24);
            this.chkboxFit.TabIndex = 0;
            this.chkboxFit.Text = "Fit to frame";
            this.chkboxFit.UseVisualStyleBackColor = true;
            this.chkboxFit.CheckedChanged += new System.EventHandler(this.chkBoxScaling_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbSwap);
            this.panel1.Controls.Add(this.btnGuess);
            this.panel1.Controls.Add(this.inputOffset);
            this.panel1.Controls.Add(this.textFormatStatus);
            this.panel1.Controls.Add(this.cbFormat);
            this.panel1.Controls.Add(this.inputHeight);
            this.panel1.Controls.Add(this.inputWidth);
            this.panel1.Location = new System.Drawing.Point(867, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 362);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Channel order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Offset";
            // 
            // cbSwap
            // 
            this.cbSwap.FormattingEnabled = true;
            this.cbSwap.Location = new System.Drawing.Point(0, 125);
            this.cbSwap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSwap.Name = "cbSwap";
            this.cbSwap.Size = new System.Drawing.Size(138, 28);
            this.cbSwap.TabIndex = 9;
            this.cbSwap.SelectedValueChanged += new System.EventHandler(this.OnInput);
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(3, 264);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(134, 29);
            this.btnGuess.TabIndex = 8;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // inputOffset
            // 
            this.inputOffset.Location = new System.Drawing.Point(0, 331);
            this.inputOffset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputOffset.Maximum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            0});
            this.inputOffset.Name = "inputOffset";
            this.inputOffset.Size = new System.Drawing.Size(137, 27);
            this.inputOffset.TabIndex = 7;
            this.inputOffset.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputOffset.ValueChanged += new System.EventHandler(this.OnInput);
            // 
            // textFormatStatus
            // 
            this.textFormatStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textFormatStatus.AutoSize = true;
            this.textFormatStatus.Location = new System.Drawing.Point(3, 41);
            this.textFormatStatus.MaximumSize = new System.Drawing.Size(240, 0);
            this.textFormatStatus.Name = "textFormatStatus";
            this.textFormatStatus.Size = new System.Drawing.Size(239, 40);
            this.textFormatStatus.TabIndex = 6;
            this.textFormatStatus.Text = "dsafadsf asbdfsbsdfgb sdfg sdfgdf asd fasd fasd ";
            // 
            // cbFormat
            // 
            this.cbFormat.FormattingEnabled = true;
            this.cbFormat.Location = new System.Drawing.Point(0, 9);
            this.cbFormat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbFormat.Name = "cbFormat";
            this.cbFormat.Size = new System.Drawing.Size(138, 28);
            this.cbFormat.TabIndex = 5;
            this.cbFormat.SelectedValueChanged += new System.EventHandler(this.OnInput);
            // 
            // inputHeight
            // 
            this.inputHeight.Location = new System.Drawing.Point(0, 230);
            this.inputHeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.inputHeight.Size = new System.Drawing.Size(137, 27);
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
            this.inputWidth.Location = new System.Drawing.Point(0, 195);
            this.inputWidth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.inputWidth.Size = new System.Drawing.Size(138, 27);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1113, 632);
            this.Controls.Add(this.tableLayoutPanel1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(729, 624);
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
        private ComboBox cbFormat;
        private Label textFormatStatus;
        private NumericUpDown inputOffset;
        private Button btnGuess;
        private ComboBox cbSwap;
        private Label label2;
        private Label label1;
        private Label textSize;
        private Label label3;
    }
}