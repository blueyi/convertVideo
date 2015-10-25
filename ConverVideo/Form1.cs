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

namespace ConverVideo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string fileName = "";
        private void openFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fileName = openFileDialog.FileName;
            }
            else
            {
                fileName = "";
                MessageBox.Show("File Open Error!");
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (fileName.Length != 0)
            {
                FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite);
                byte oldBuff = 0x53;
                byte[] newBuff = new byte[4];
                newBuff[0] = 0x48;
                newBuff[1] = 0x32;
                newBuff[2] = 0x36;
                newBuff[3] = 0x34;
                long[] offset = new long[2];
                int count = 0;
                for (long i = 0; i < fs.Length; ++i)
                {
                    byte currentBuf = Convert.ToByte(fs.ReadByte());
                    if (oldBuff == currentBuf)
                    {
                        int j = 1;
                        while (j < 4)
                        {
                            if (newBuff[j] != fs.ReadByte())
                                break;
                            j++;
                        }
                        if (j == 4)
                        {
                            fs.Seek(-4, SeekOrigin.Current);
                            fs.WriteByte(newBuff[0]);
                            count++;
                        }
                    }
                    else if (newBuff[0] == currentBuf)
                    {
                        int j = 1;
                        while (j < 4)
                        {
                            if (newBuff[j] != fs.ReadByte())
                                break;
                            j++;
                        }
                        if (j == 4)
                        {
                            MessageBox.Show("Don't need convert!");
                            fs.Close();
                            break;
                        }
                    }
                    if (count == 2)
                    {
                        fs.Close();
                        MessageBox.Show("Convert Completed");
                        break;
                    }
                }
            }
            else
                MessageBox.Show("No File");
        }

        private void convertToS_Click(object sender, EventArgs e)
        {
            if (fileName.Length != 0)
            {
                FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite);
                byte oldBuff = 0x53;
                byte[] newBuff = new byte[4];
                newBuff[0] = 0x48;
                newBuff[1] = 0x32;
                newBuff[2] = 0x36;
                newBuff[3] = 0x34;
                long[] offset = new long[2];
                int count = 0;
                for (long i = 0; i < fs.Length; ++i)
                {
                    byte currentBuf = Convert.ToByte(fs.ReadByte());
                    if (newBuff[0] == currentBuf)
                    {
                        int j = 1;
                        while (j < 4)
                        {
                            if (newBuff[j] != fs.ReadByte())
                                break;
                            j++;
                        }
                        if (j == 4)
                        {
                            fs.Seek(-4, SeekOrigin.Current);
                            fs.WriteByte(oldBuff);
                            count++;
                        }
                    }
                    else if (oldBuff == currentBuf)
                    {
                        int j = 1;
                        while (j < 4)
                        {
                            if (newBuff[j] != fs.ReadByte())
                                break;
                            j++;
                        }
                        if (j == 4)
                        {
                            MessageBox.Show("Don't need convert!");
                            fs.Close();
                            break;
                        }
                    }
                    if (count == 2)
                    {
                        fs.Close();
                        MessageBox.Show("Convert Completed");
                        break;
                    }
                }
            }
            else
                MessageBox.Show("No File");

        }
    }
}
