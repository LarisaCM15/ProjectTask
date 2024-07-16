namespace ProjectTask
{
    partial class Form1
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
            this.ExecuteScript = new System.Windows.Forms.Button();
            this.Input = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.CmdBox = new System.Windows.Forms.TextBox();
            this.ExecuteCommand = new System.Windows.Forms.Button();
            this.OutputCmd = new System.Windows.Forms.TextBox();
            this.BrowseBat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExecuteScript
            // 
            this.ExecuteScript.Location = new System.Drawing.Point(485, 52);
            this.ExecuteScript.Name = "ExecuteScript";
            this.ExecuteScript.Size = new System.Drawing.Size(94, 23);
            this.ExecuteScript.TabIndex = 0;
            this.ExecuteScript.Text = "ExecuteScript";
            this.ExecuteScript.UseVisualStyleBackColor = true;
            this.ExecuteScript.Click += new System.EventHandler(this.button1_Click);
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(91, 52);
            this.Input.Multiline = true;
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(273, 21);
            this.Input.TabIndex = 1;
            this.Input.Text = "Enter the path to PowerShell script...";
            this.Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Input.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(80, 102);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(284, 114);
            this.Output.TabIndex = 2;
            this.Output.Text = "Here you will see the output for your script";
            this.Output.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Output.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(383, 52);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(75, 23);
            this.BrowseButton.TabIndex = 3;
            this.BrowseButton.Text = "Browse...";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // CmdBox
            // 
            this.CmdBox.Location = new System.Drawing.Point(80, 283);
            this.CmdBox.Multiline = true;
            this.CmdBox.Name = "CmdBox";
            this.CmdBox.Size = new System.Drawing.Size(259, 21);
            this.CmdBox.TabIndex = 4;
            this.CmdBox.Text = "Here you enter the path to .bat script";
            this.CmdBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CmdBox.TextChanged += new System.EventHandler(this.CmdBox_TextChanged);
            // 
            // ExecuteCommand
            // 
            this.ExecuteCommand.Location = new System.Drawing.Point(485, 281);
            this.ExecuteCommand.Name = "ExecuteCommand";
            this.ExecuteCommand.Size = new System.Drawing.Size(94, 23);
            this.ExecuteCommand.TabIndex = 5;
            this.ExecuteCommand.Text = "ExecueBatScript";
            this.ExecuteCommand.UseVisualStyleBackColor = true;
            this.ExecuteCommand.Click += new System.EventHandler(this.ExecuteCommand_Click);
            // 
            // OutputCmd
            // 
            this.OutputCmd.Location = new System.Drawing.Point(80, 355);
            this.OutputCmd.Multiline = true;
            this.OutputCmd.Name = "OutputCmd";
            this.OutputCmd.Size = new System.Drawing.Size(259, 115);
            this.OutputCmd.TabIndex = 6;
            this.OutputCmd.Text = "Here you will see the output for your cmd command";
            this.OutputCmd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OutputCmd.TextChanged += new System.EventHandler(this.OutputCmd_TextChanged);
            // 
            // BrowseBat
            // 
            this.BrowseBat.Location = new System.Drawing.Point(383, 281);
            this.BrowseBat.Name = "BrowseBat";
            this.BrowseBat.Size = new System.Drawing.Size(75, 23);
            this.BrowseBat.TabIndex = 7;
            this.BrowseBat.Text = "BrowseBat";
            this.BrowseBat.UseVisualStyleBackColor = true;
            this.BrowseBat.Click += new System.EventHandler(this.BrowseBat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 534);
            this.Controls.Add(this.BrowseBat);
            this.Controls.Add(this.OutputCmd);
            this.Controls.Add(this.ExecuteCommand);
            this.Controls.Add(this.CmdBox);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.ExecuteScript);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExecuteScript;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.TextBox CmdBox;
        private System.Windows.Forms.Button ExecuteCommand;
        private System.Windows.Forms.TextBox OutputCmd;
        private System.Windows.Forms.Button BrowseBat;
    }
}

