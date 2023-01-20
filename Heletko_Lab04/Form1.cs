using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Security.Cryptography;

namespace Heletko_Lab04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private byte[] MyCipherXOR(string fPath, string kPath)
        {
            byte[] inArray = File.ReadAllBytes(fPath);
            byte[] kArray = File.ReadAllBytes(kPath);
            int inpLength = inArray.Length;
            int kLength = kArray.Length;
            byte[] cArray = new byte[inpLength];
            for (int i = 0; i < inpLength; i++)
            {
                cArray[i] = (byte)(inArray[i] ^ kArray[i % kLength]);
            }
            return cArray;
        }
        private void MyFileSave(byte[] cArray, string sPath)
        {
            using (FileStream fs = File.Create(sPath))
            {
                fs.Write(cArray, 0, cArray.Length);
                fs.Close();
            }
        }

        private void sFileButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveDialog.FilterIndex = 2;
            saveDialog.RestoreDirectory = true;
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string fPath = saveDialog.FileName;
                sFilePathTextBox.Text = fPath;
            }
        }

        private void oFileButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openDialog = new OpenFileDialog())
            {
                openDialog.InitialDirectory = Directory.GetCurrentDirectory();
                openDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openDialog.FilterIndex = 2;
                openDialog.RestoreDirectory = true;

                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = openDialog.FileName;
                    oFilePathTextBox.Text = path;
                }
            }
        }

        private void sKeyButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveDialog.FilterIndex = 1;
            saveDialog.RestoreDirectory = true;
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveDialog.FileName;
                kPathTextBox.Text = path;
            }
        }

        private void oKeyButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openDialog = new OpenFileDialog())
            {
                openDialog.InitialDirectory = Directory.GetCurrentDirectory();
                openDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openDialog.FilterIndex = 1;
                openDialog.RestoreDirectory = true;

                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = openDialog.FileName;
                    kPathTextBox.Text = path;
                    kSizeLabel.Text = new FileInfo(path).Length.ToString() + " б";
                }
            }
        }

        private void genButton_Click(object sender, EventArgs e)
        {
            DialogResult resultDialog = MessageBox.Show("Згенерувати новий ключ?", "Увага!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultDialog == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;

                string path = oFilePathTextBox.Text;
                if (File.Exists(path))
                {
                    string kPath = kPathTextBox.Text;
                    string dirKeyPath = Path.GetDirectoryName(kPath);
                    if (Directory.Exists(dirKeyPath))
                    {
                        long fLength = new FileInfo(path).Length;
                        byte[] kArray = new byte[fLength];
                        RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
                        rng.GetBytes(kArray);

                        using (FileStream fs = File.Create(kPath))
                        {
                            fs.Write(kArray, 0, kArray.Length);
                            fs.Close();
                        }
                        kSizeLabel.Text = kArray.Length.ToString() + "б";
                    }
                    else
                    {
                        MessageBox.Show("Шлях до ключа не вказаний або файл не існує!");
                        oKeyButton.Focus();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Вхідний файл не існує!");
                    oFileButton.Focus();
                    return;
                }
                Cursor.Current = Cursors.Default;
            }
        }

        private void startButton_Click_1(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            string fPath = oFilePathTextBox.Text;
            string sPath = sFilePathTextBox.Text;
            string kPath = kPathTextBox.Text;
            if (File.Exists(fPath))
            {
                string sDirPath = Path.GetDirectoryName(sPath);
                if (Directory.Exists(sDirPath))
                {
                    if (File.Exists(kPath))
                    {
                        Stopwatch watch = new Stopwatch();
                        watch.Start();
                        byte[] cArray = MyCipherXOR(fPath, kPath);
                        MyFileSave(cArray, sPath);
                        watch.Stop();
                        tEncLabel.Text = watch.Elapsed.ToString(@"mm\:ss\.fff");
                        tEncLabel.Update();
                    }
                    else
                    {
                        MessageBox.Show("Шлях до файлу ключа не вказаний!");
                        genButton.Focus();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Шлях до вихідного файлу не вказаний!");
                    sFileButton.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Шлях для вхідного файлу не вказаний!");
                oFileButton.Focus();
                return;
            }
            Cursor.Current = Cursors.Default;
        }
    }
}
