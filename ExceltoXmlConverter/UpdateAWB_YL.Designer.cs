namespace ExceltoXmlConverter
{
    partial class UpdateAWB_YL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateAWB_YL));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.progressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.txt_progress = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txt_TotalLine = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_FileName = new System.Windows.Forms.Label();
            this.btn_generateXml = new System.Windows.Forms.Button();
            this.btn_UploadSFTP = new System.Windows.Forms.Button();
            this.btn_Upload = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_FileFrom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_FileTo = new System.Windows.Forms.TextBox();
            this.btn_UpdateTargetPath = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.dgsExcel = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgsExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.richTextBox1);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(890, 597);
            this.splitContainer1.SplitterDistance = 422;
            this.splitContainer1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.progressBar1,
            this.txt_progress});
            this.toolStrip1.Location = new System.Drawing.Point(0, 572);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(422, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // progressBar1
            // 
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(150, 22);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // txt_progress
            // 
            this.txt_progress.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_progress.Name = "txt_progress";
            this.txt_progress.Size = new System.Drawing.Size(0, 22);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txt_TotalLine});
            this.statusStrip1.Location = new System.Drawing.Point(0, 575);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(464, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txt_TotalLine
            // 
            this.txt_TotalLine.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_TotalLine.Name = "txt_TotalLine";
            this.txt_TotalLine.Size = new System.Drawing.Size(0, 17);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Title = "Pilih File excel";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.Title = "Select Folder....";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(16, 189);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(392, 349);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_UpdateTargetPath);
            this.groupBox1.Controls.Add(this.txt_FileTo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_FileFrom);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_Upload);
            this.groupBox1.Controls.Add(this.btn_UploadSFTP);
            this.groupBox1.Controls.Add(this.btn_generateXml);
            this.groupBox1.Controls.Add(this.txt_FileName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 183);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // txt_FileName
            // 
            this.txt_FileName.AutoSize = true;
            this.txt_FileName.Location = new System.Drawing.Point(6, 114);
            this.txt_FileName.Name = "txt_FileName";
            this.txt_FileName.Size = new System.Drawing.Size(23, 13);
            this.txt_FileName.TabIndex = 7;
            this.txt_FileName.Text = "File";
            this.txt_FileName.Visible = false;
            // 
            // btn_generateXml
            // 
            this.btn_generateXml.BackColor = System.Drawing.Color.LightGreen;
            this.btn_generateXml.Enabled = false;
            this.btn_generateXml.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generateXml.Location = new System.Drawing.Point(167, 127);
            this.btn_generateXml.Name = "btn_generateXml";
            this.btn_generateXml.Size = new System.Drawing.Size(92, 47);
            this.btn_generateXml.TabIndex = 3;
            this.btn_generateXml.Text = "Generate File .xml";
            this.btn_generateXml.UseVisualStyleBackColor = false;
            this.btn_generateXml.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_UploadSFTP
            // 
            this.btn_UploadSFTP.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_UploadSFTP.Enabled = false;
            this.btn_UploadSFTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UploadSFTP.Location = new System.Drawing.Point(285, 127);
            this.btn_UploadSFTP.Name = "btn_UploadSFTP";
            this.btn_UploadSFTP.Size = new System.Drawing.Size(101, 47);
            this.btn_UploadSFTP.TabIndex = 9;
            this.btn_UploadSFTP.Text = "Upload To SFTP";
            this.btn_UploadSFTP.UseVisualStyleBackColor = false;
            this.btn_UploadSFTP.Click += new System.EventHandler(this.btn_UploadSFTP_Click);
            // 
            // btn_Upload
            // 
            this.btn_Upload.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_Upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Upload.Location = new System.Drawing.Point(35, 127);
            this.btn_Upload.Name = "btn_Upload";
            this.btn_Upload.Size = new System.Drawing.Size(93, 47);
            this.btn_Upload.TabIndex = 2;
            this.btn_Upload.Text = "Upload File Excel";
            this.btn_Upload.UseVisualStyleBackColor = false;
            this.btn_Upload.Click += new System.EventHandler(this.btn_Upload_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Folder  file.xml";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Folder file.xlsx";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "1";
            // 
            // txt_FileFrom
            // 
            this.txt_FileFrom.Enabled = false;
            this.txt_FileFrom.Location = new System.Drawing.Point(105, 28);
            this.txt_FileFrom.Name = "txt_FileFrom";
            this.txt_FileFrom.Size = new System.Drawing.Size(271, 20);
            this.txt_FileFrom.TabIndex = 0;
            this.txt_FileFrom.Text = "......";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(145, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "2";
            // 
            // txt_FileTo
            // 
            this.txt_FileTo.Enabled = false;
            this.txt_FileTo.Location = new System.Drawing.Point(105, 72);
            this.txt_FileTo.Name = "txt_FileTo";
            this.txt_FileTo.Size = new System.Drawing.Size(271, 20);
            this.txt_FileTo.TabIndex = 6;
            this.txt_FileTo.Text = "C:\\\\DORCLDD\\UpdateAWB\\Temp";
            // 
            // btn_UpdateTargetPath
            // 
            this.btn_UpdateTargetPath.Location = new System.Drawing.Point(382, 72);
            this.btn_UpdateTargetPath.Name = "btn_UpdateTargetPath";
            this.btn_UpdateTargetPath.Size = new System.Drawing.Size(33, 23);
            this.btn_UpdateTargetPath.TabIndex = 16;
            this.btn_UpdateTargetPath.Text = "...";
            this.btn_UpdateTargetPath.UseVisualStyleBackColor = true;
            this.btn_UpdateTargetPath.Click += new System.EventHandler(this.btn_UpdateTargetPath_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(265, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "3";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.dgsExcel);
            this.groupBox2.Controls.Add(this.statusStrip2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(464, 575);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(87, 19);
            this.toolStripStatusLabel1.Text = "Excel File List";
            // 
            // statusStrip2
            // 
            this.statusStrip2.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip2.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip2.Location = new System.Drawing.Point(3, 16);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(458, 24);
            this.statusStrip2.TabIndex = 0;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // dgsExcel
            // 
            this.dgsExcel.BackgroundColor = System.Drawing.Color.White;
            this.dgsExcel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgsExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgsExcel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgsExcel.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgsExcel.Location = new System.Drawing.Point(3, 40);
            this.dgsExcel.Name = "dgsExcel";
            this.dgsExcel.Size = new System.Drawing.Size(458, 532);
            this.dgsExcel.TabIndex = 5;
            // 
            // UpdateAWB_YL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(890, 597);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateAWB_YL";
            this.Text = "Update AWB (xls to xml)";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgsExcel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel txt_TotalLine;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripProgressBar progressBar1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel txt_progress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_UpdateTargetPath;
        private System.Windows.Forms.TextBox txt_FileTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_FileFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Upload;
        private System.Windows.Forms.Button btn_UploadSFTP;
        private System.Windows.Forms.Button btn_generateXml;
        private System.Windows.Forms.Label txt_FileName;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgsExcel;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

