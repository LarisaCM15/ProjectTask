using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace ProjectTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            string scriptPath = Input.Text;


            if (File.Exists(scriptPath))
            {

                var proc = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "powershell.exe",
                        Arguments = $"-NoProfile -ExecutionPolicy Bypass -File \"{scriptPath}\"",
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        CreateNoWindow = true
                    }
                };
                proc.Start();
                while (!proc.StandardOutput.EndOfStream)
                {
                    string line = proc.StandardOutput.ReadLine();
                    OutputPS.Text = line;   
                }


               

            }
            else
            {
                MessageBox.Show("The file doesn't exist or the path is incorrect.");
            }
        }




        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Input_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Choose a PowerShell script";
            fdlg.Filter = "PowerShell scripts (*.ps1)|*.ps1|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                Input.Text = fdlg.FileName;
            }
            
        }

        private void ExecuteCommand_Click(object sender, EventArgs e)
        {
            string pathToScript = CmdBox.Text;

            if (File.Exists(pathToScript))
            {
                var proc1 = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        Arguments = $"/c \"{pathToScript}\"",
                        UseShellExecute = false,
                        RedirectStandardOutput = true
                        
                    }
                };
                proc1.Start();
                while (!proc1.StandardOutput.EndOfStream)
                {
                    string line1 = proc1.StandardOutput.ReadLine();
                    OutputCmd.Text = line1;
                }
            }
            else
            {
                MessageBox.Show("The file doesn't exist or the path is incorrect.");
            }
        }

        private void OutputCmd_TextChanged(object sender, EventArgs e)
        {

        }

        private void CmdBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BrowseBat_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Choose a Batch script";
            fdlg.Filter = "Batch scripts (*.bat)|*.bat|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                CmdBox.Text = fdlg.FileName;
            }
        }

        private void OutputPS_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
