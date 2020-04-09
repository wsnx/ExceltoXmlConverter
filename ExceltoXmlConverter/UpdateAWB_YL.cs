using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WinSCP;

namespace ExceltoXmlConverter
{
    public partial class UpdateAWB_YL : Form
    {
        public UpdateAWB_YL()
        {
            InitializeComponent();

        }
        CancellationTokenSource cts;
        public string txtFileName;
        public string txtTargetPath;
        DataSet dsExcel = new DataSet();
        private void btn_Upload_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Uploading excel File";
            txt_progress.Text = "";
            this.openFileDialog1.Filter = "xlsx|*.xlsx";
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.txt_FileFrom.Text = this.openFileDialog1.FileName;
                this.txt_FileName.Text = this.openFileDialog1.SafeFileName;
                btn_generateXml.Enabled =true;
                Show();
            }
        }
        private void Show()
        {
            Cursor.Current = Cursors.WaitCursor;
            dsExcel.Clear();
            String strXLSConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + this.txt_FileFrom.Text + "';Extended Properties=Excel 12.0;Mode=Share Deny Write;";

            try
            {
                using (System.Data.OleDb.OleDbConnection MyConnection = new System.Data.OleDb.OleDbConnection(strXLSConn))
                {
                    using (System.Data.OleDb.OleDbCommand myCommand = new System.Data.OleDb.OleDbCommand())
                    {
                        MyConnection.Open();

                        System.Data.OleDb.OleDbDataAdapter cmdExcel;

                        try
                        {
                            cmdExcel = new System.Data.OleDb.OleDbDataAdapter("select * from[Sheet1$]", MyConnection);
                            cmdExcel.Fill(dsExcel, "hasil");
                            dgsExcel.DataSource = dsExcel.Tables[0];
                            int i = dsExcel.Tables[0].Rows.Count;
                            txt_TotalLine.Text = "Total : "+ i.ToString();



                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                richTextBox1.AppendText( "\n Total :" + dsExcel.Tables[0].Rows.Count +" Line SO Succesfully Uploaded");
                btn_Upload.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }

        private void prosesData()
        {

            String strXLSConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + this.txt_FileFrom.Text.Trim() + "';Extended Properties=Excel 12.0;Mode=Share Deny Write;";

            try
            {
                this.progressBar1.Maximum = dsExcel.Tables[0].Rows.Count;
                this.progressBar1.Minimum = 0;
                this.progressBar1.Value = 0;
                for (int i = 0; i <= dsExcel.Tables[0].Rows.Count - 1; i++)
                {
                    progressBar1.Value++;
                    try
                    {
                        XElement n = new XElement
                      ("Message",
                        new XElement("SS",
                        new XElement("WHSEID", "GEO45"),
                        new XElement("STORERKEY", "YOLIIN001"),    
                        new XElement("ORDERKEY", dsExcel.Tables[0].Rows[i]["Orderkey"]),
                        new XElement("SHIPSTATUS", "O"),
                        new XElement("CARRIERCODE"),
                        new XElement("PROBILL", dsExcel.Tables[0].Rows[i]["AWB"]),
                        new XElement("TOTAL"),
                        new XElement("DIMENSIONALWEIGHT"),
                        new XElement("SHIPPINGPRICE")
            )
            );
                        n.Save(txtTargetPath + "//" + dsExcel.Tables[0].Rows[i]["Orderkey"].ToString() + ".xml");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
                var fileCount = (from file in Directory.EnumerateFiles(txt_FileTo.Text, "*.xml", SearchOption.AllDirectories)
                                 select file).Count();
                
                richTextBox1.AppendText("\n"+"Total: " + fileCount.ToString() +" file Stored in " + txt_FileTo.Text);
                MessageBox.Show("Succes");
                /*System.Diagnostics.Process.Start("explorer.exe", @"" + txtTargetPath + "");*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(  "\n" + "Generate File xml ....");

            int delayTimeMilliseconds = 100;
            await Task.Delay(delayTimeMilliseconds);
            string path = @"C:\DORCLDD\UpdateAWB\Temp";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            else
            {
                txt_FileTo.Text = @"C:\DORCLDD\UpdateAWB\Temp\";
                txtTargetPath = txt_FileTo.Text;
                //Delete Existing File
                DirectoryInfo di = new DirectoryInfo(txt_FileTo.Text);
                FileInfo[] files = di.GetFiles("*.xml")
                                     .Where(p => p.Extension == ".xml").ToArray();
                foreach (FileInfo file in files)
                    try
                    {
                        file.Attributes = FileAttributes.Normal;
                        File.Delete(file.FullName);
                    }
                    catch { }
                btn_UploadSFTP.Enabled = true;
                btn_generateXml.Enabled = false;
                prosesData();
            }

        }

        private async void btn_UploadSFTP_Click(object sender, EventArgs e)
        {

            richTextBox1.AppendText("\n Upload to sFTP"+"\n"+"Conecting to sFTP..");
            txt_progress.Text = "Starting Upload to sFTP..";

            UploadsFTPwitWinSCP();
            btn_UploadSFTP.Enabled = true;
        }
        private async Task UploadsFTPwitWinSCP()
        {
            cts = new CancellationTokenSource();
            int delayTimeMilliseconds = 1000;
            await Task.Delay(delayTimeMilliseconds);
            SessionOptions sessionOptions = new SessionOptions
            {
                Protocol = Protocol.Sftp,
                HostName = "182.23.64.244",
                UserName = "agiedi",
                Password ="edisftp",
               SshHostKeyFingerprint = "ssh-rsa 2048 Lut0jkyMwlKFD3bCRZsDduOMArHdfcpxTRaSab5EK68="
                //SshPrivateKeyPath = keyPath
            };
            
            using (WinSCP.Session session = new WinSCP.Session())
            {

              session.FileTransferProgress += SessionFileTransferProgress;
                // Connect
                session.Open(sessionOptions);

                richTextBox1.AppendText("\n" + "Transmitting Data...");
                // Upload files
                TransferOptions transferOptions = new TransferOptions();
                transferOptions.TransferMode = TransferMode.Binary;
                TransferOperationResult transferResult;
                transferResult =
                    session.PutFiles(@""+txt_FileTo.Text+"\\*.xml", "/AWB/", false, transferOptions);

                // Throw on any error
                transferResult.Check();


                foreach (TransferEventArgs transfer in transferResult.Transfers)
                {
                    jumlahSucces++;
                }

            }
            richTextBox1.AppendText("\n" + "Finish Upload File \n" + "Total :"+jumlahSucces + " Files Succesfully Uploaded in sFTP"); ;

        }

        private int jumlahSucces =0;
        private static string _lastFileName;
        private void SessionFileTransferProgress(object sender, FileTransferProgressEventArgs e)
        {

            // Print transfer progress
            this.progressBar1.Maximum = 100;
            this.progressBar1.Minimum = 0;
            var a = e.OverallProgress * 100;
            int i = Convert.ToInt32(a.ToString());
            this.progressBar1.Value = i;
            txt_progress.Text = a.ToString() + " % " ;

            // New line for every new file
            if ((_lastFileName != null) && (_lastFileName != e.FileName))
            {

            }

            // Print transfer progress

            // Remember a name of the last file reported
            _lastFileName = e.FileName;


        }



        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_UpdateTargetPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog folderBrowser = new OpenFileDialog();
            folderBrowser.ValidateNames = false;
            folderBrowser.CheckFileExists = false;
            folderBrowser.CheckPathExists = true;
            folderBrowser.FileName = "Selected Folder...";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                txtTargetPath = Path.GetDirectoryName(folderBrowser.FileName);
                txt_FileTo.Text = txtTargetPath;
            }
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            if (cts != null)
            {
                cts.Cancel();
            }
        }
    }
}
