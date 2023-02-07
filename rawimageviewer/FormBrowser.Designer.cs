namespace rawimageviewer
{
    partial class FormBrowser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnScan = new System.Windows.Forms.Button();
            this.textFramesAmount = new System.Windows.Forms.Label();
            this.textPath = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPageNext = new System.Windows.Forms.Button();
            this.btnPagePrev = new System.Windows.Forms.Button();
            this.inputPage = new System.Windows.Forms.TextBox();
            this.textPagesTotal = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.listView1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textPath, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(539, 747);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(3, 83);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(533, 621);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Date created";
            this.columnHeader2.Width = 280;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Size";
            this.columnHeader4.Width = 100;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.btnScan);
            this.flowLayoutPanel1.Controls.Add(this.textFramesAmount);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 43);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(533, 34);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btnScan
            // 
            this.btnScan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnScan.Location = new System.Drawing.Point(3, 3);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(94, 29);
            this.btnScan.TabIndex = 2;
            this.btnScan.Text = "Refresh";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // textFramesAmount
            // 
            this.textFramesAmount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textFramesAmount.AutoSize = true;
            this.textFramesAmount.Location = new System.Drawing.Point(103, 7);
            this.textFramesAmount.Name = "textFramesAmount";
            this.textFramesAmount.Size = new System.Drawing.Size(117, 20);
            this.textFramesAmount.TabIndex = 1;
            this.textFramesAmount.Text = "Frames in cache:";
            // 
            // textPath
            // 
            this.textPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textPath.AutoSize = true;
            this.textPath.Location = new System.Drawing.Point(3, 10);
            this.textPath.Name = "textPath";
            this.textPath.Size = new System.Drawing.Size(50, 20);
            this.textPath.TabIndex = 3;
            this.textPath.Text = "label1";
            this.textPath.Click += new System.EventHandler(this.textPath_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnPageNext, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnPagePrev, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.inputPage, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textPagesTotal, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 710);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(533, 34);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // btnPageNext
            // 
            this.btnPageNext.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnPageNext.Location = new System.Drawing.Point(349, 3);
            this.btnPageNext.Name = "btnPageNext";
            this.btnPageNext.Size = new System.Drawing.Size(94, 28);
            this.btnPageNext.TabIndex = 0;
            this.btnPageNext.Text = "Next";
            this.btnPageNext.UseVisualStyleBackColor = true;
            this.btnPageNext.Click += new System.EventHandler(this.btnPageNext_Click);
            // 
            // btnPagePrev
            // 
            this.btnPagePrev.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnPagePrev.Location = new System.Drawing.Point(89, 3);
            this.btnPagePrev.Name = "btnPagePrev";
            this.btnPagePrev.Size = new System.Drawing.Size(94, 28);
            this.btnPagePrev.TabIndex = 1;
            this.btnPagePrev.Text = "Prev";
            this.btnPagePrev.UseVisualStyleBackColor = true;
            this.btnPagePrev.Click += new System.EventHandler(this.btnPagePrev_Click);
            // 
            // inputPage
            // 
            this.inputPage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.inputPage.Location = new System.Drawing.Point(209, 3);
            this.inputPage.MaxLength = 10;
            this.inputPage.Name = "inputPage";
            this.inputPage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.inputPage.Size = new System.Drawing.Size(54, 27);
            this.inputPage.TabIndex = 2;
            this.inputPage.Text = "1";
            this.inputPage.WordWrap = false;
            this.inputPage.TextChanged += new System.EventHandler(this.inputPage_TextChanged);
            // 
            // textPagesTotal
            // 
            this.textPagesTotal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textPagesTotal.AutoSize = true;
            this.textPagesTotal.Location = new System.Drawing.Point(269, 7);
            this.textPagesTotal.Name = "textPagesTotal";
            this.textPagesTotal.Size = new System.Drawing.Size(43, 20);
            this.textPagesTotal.TabIndex = 3;
            this.textPagesTotal.Text = "/ 100";
            this.textPagesTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 747);
            this.Controls.Add(this.tableLayoutPanel1);
            this.KeyPreview = true;
            this.Name = "FormBrowser";
            this.Text = "Disk cache browser";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormBrowser_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader4;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label textFramesAmount;
        private Button btnScan;
        private Label textPath;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnPageNext;
        private Button btnPagePrev;
        private TextBox inputPage;
        private Label textPagesTotal;
    }
}