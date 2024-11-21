using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RblDownload
{
    public partial class Form1 : Form
    {
        private string Loadfilepath;//下载路径
        public string LoadFilePath { 
            get 
            {
                return Loadfilepath;
            } 
            set
            {
                Loadfilepath = value;
                FilePathText.Text = Loadfilepath;
                X1Type.SelectedIndex = ReadFile(FilePathText.Text);
            } 
        }
        public Form1()
        {
            InitializeComponent();
        }
       
        //选择下载程序
        private void ChoseDLPathBtn_Click(object sender, EventArgs e)
        {
           using(OpenFileDialog openFileDialog = new OpenFileDialog())
           {
                openFileDialog.Filter = "X1内核程序|*.rbl";
                DialogResult result = openFileDialog.ShowDialog();
               
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(openFileDialog.FileName))
                {
                    FilePathText.Text = openFileDialog.FileName;
                    X1Type.SelectedIndex = ReadFile(FilePathText.Text);
                }
           }
        }

        private void DownloadBtn_Click(object sender, EventArgs e)
        {
            switch(X1Type.SelectedItem)
            {
                case "T113":
                    Console.WriteLine("1111111111");
                    CopyFile("1/3.rbl");
                    RunBatFile("1.bat");
                    break;
                case "R6":
                    Console.WriteLine("2222222222222222222");
                    CopyFile("1/4.rbl");
                    RunBatFile("2.bat");
                    break;
                default:
                    MessageBox.Show("下载失败，请确认文件类型为T113还是R6！");
                    break;

            }
        }

        //读取文件判断文件类型
        private int ReadFile(string Filepath)          
        {
            int headerSize = 16; // 读取文件头的前16个字节
            try
            {
                using (FileStream fileStream = new FileStream(Filepath, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader reader = new BinaryReader(fileStream))
                    {
                        byte[] header = reader.ReadBytes(headerSize);
                        string hexString = BitConverter.ToString(header).Replace("-", " ");
                        Console.WriteLine(hexString);
                        if (hexString == "31 32 33")
                        {
                            return 0;
                        }
                        else if (hexString == "34 35 36")
                        {
                            return 1;
                        }
                        else
                        {
                            MessageBox.Show("文件识别失败，请手动选择文件类型为T113还是R6！");
                            return -1;
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("读取文件失败："+ex.ToString());
                return -1;
            }
        }

        //运行批处理
        private void RunBatFile(string Filepath)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @Filepath; // 批处理文件的路径
            startInfo.UseShellExecute = false; // 不使用操作系统外壳程序启动
            startInfo.CreateNoWindow = false; // 创建新窗口

            using (Process process = Process.Start(startInfo))
            {
                // 同步等待批处理执行完成
                process.WaitForExit();
                process.Close();
            }

        }

        private void CopyFile(string Filepath)
        {
            File.Copy(FilePathText.Text, Filepath, true);
        }
  
    }
}
