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
                
                var startInfo = new ProcessStartInfo
                {
                    FileName = "powershell.exe",
                    Arguments = $"-NoProfile -ExecutionPolicy Bypass -File \"{scriptPath}\"",
                    UseShellExecute = false
                   

                };

                Process.Start(startInfo);
                //Console.Read();
                
            }
            else
            {
                MessageBox.Show("Fișierul nu există sau calea este incorectă.");
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

        }

        private void OutputCmd_TextChanged(object sender, EventArgs e)
        {

        }

        private void CmdBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BrowseBat_Click(object sender, EventArgs e)
        {

        }
    }
}
