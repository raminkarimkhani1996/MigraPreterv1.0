namespace Migrator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IP = new System.Windows.Forms.TextBox();
            this.prt = new System.Windows.Forms.TextBox();
            this.buildMigrater = new System.Windows.Forms.Button();
            this.messages = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.arch = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "PORT:";
            // 
            // IP
            // 
            this.IP.Location = new System.Drawing.Point(147, 32);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(261, 22);
            this.IP.TabIndex = 3;
            // 
            // prt
            // 
            this.prt.Location = new System.Drawing.Point(147, 86);
            this.prt.Name = "prt";
            this.prt.Size = new System.Drawing.Size(261, 22);
            this.prt.TabIndex = 4;
            // 
            // buildMigrater
            // 
            this.buildMigrater.Location = new System.Drawing.Point(147, 192);
            this.buildMigrater.Name = "buildMigrater";
            this.buildMigrater.Size = new System.Drawing.Size(261, 78);
            this.buildMigrater.TabIndex = 6;
            this.buildMigrater.Text = "Build Migrater";
            this.buildMigrater.UseVisualStyleBackColor = true;
            this.buildMigrater.Click += new System.EventHandler(this.button1_Click);
            // 
            // messages
            // 
            this.messages.Enabled = false;
            this.messages.Location = new System.Drawing.Point(431, 29);
            this.messages.Multiline = true;
            this.messages.Name = "messages";
            this.messages.Size = new System.Drawing.Size(609, 241);
            this.messages.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "ARCHITECTURE:";
            // 
            // arch
            // 
            this.arch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.arch.FormattingEnabled = true;
            this.arch.Items.AddRange(new object[] {
            "x64",
            "x86"});
            this.arch.Location = new System.Drawing.Point(147, 143);
            this.arch.Name = "arch";
            this.arch.Size = new System.Drawing.Size(261, 24);
            this.arch.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 306);
            this.Controls.Add(this.arch);
            this.Controls.Add(this.messages);
            this.Controls.Add(this.buildMigrater);
            this.Controls.Add(this.prt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "MigraPreter v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IP;
        private System.Windows.Forms.TextBox prt;
        private System.Windows.Forms.Button buildMigrater;
        private System.Windows.Forms.TextBox messages;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox arch;
    }
}

