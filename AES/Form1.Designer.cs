﻿
namespace AES
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.en_textBoxFile = new System.Windows.Forms.TextBox();
            this.en_buttonBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.en_textBoxKey = new System.Windows.Forms.TextBox();
            this.en_button = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.de_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.de_textBoxFile = new System.Windows.Forms.TextBox();
            this.de_textBoxKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.de_buttonBrowse = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // en_textBoxFile
            // 
            this.en_textBoxFile.AllowDrop = true;
            this.en_textBoxFile.Location = new System.Drawing.Point(20, 32);
            this.en_textBoxFile.Name = "en_textBoxFile";
            this.en_textBoxFile.Size = new System.Drawing.Size(255, 20);
            this.en_textBoxFile.TabIndex = 0;
            this.en_textBoxFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.en_textBoxFile_DragDrop);
            this.en_textBoxFile.DragOver += new System.Windows.Forms.DragEventHandler(this.en_textBoxFile_DragOver);
            // 
            // en_buttonBrowse
            // 
            this.en_buttonBrowse.Location = new System.Drawing.Point(281, 30);
            this.en_buttonBrowse.Name = "en_buttonBrowse";
            this.en_buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.en_buttonBrowse.TabIndex = 1;
            this.en_buttonBrowse.Text = "Browse";
            this.en_buttonBrowse.UseVisualStyleBackColor = true;
            this.en_buttonBrowse.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Key";
            // 
            // en_textBoxKey
            // 
            this.en_textBoxKey.Location = new System.Drawing.Point(20, 90);
            this.en_textBoxKey.Name = "en_textBoxKey";
            this.en_textBoxKey.Size = new System.Drawing.Size(336, 20);
            this.en_textBoxKey.TabIndex = 3;
            // 
            // en_button
            // 
            this.en_button.Location = new System.Drawing.Point(20, 133);
            this.en_button.Name = "en_button";
            this.en_button.Size = new System.Drawing.Size(336, 55);
            this.en_button.TabIndex = 5;
            this.en_button.Text = "Encrypt";
            this.en_button.UseVisualStyleBackColor = true;
            this.en_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(383, 238);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.en_button);
            this.tabPage1.Controls.Add(this.en_textBoxFile);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.en_buttonBrowse);
            this.tabPage1.Controls.Add(this.en_textBoxKey);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(375, 212);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Encrypt";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.de_button);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.de_textBoxFile);
            this.tabPage2.Controls.Add(this.de_textBoxKey);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.de_buttonBrowse);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(375, 212);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Decrypt";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // de_button
            // 
            this.de_button.Location = new System.Drawing.Point(20, 133);
            this.de_button.Name = "de_button";
            this.de_button.Size = new System.Drawing.Size(336, 55);
            this.de_button.TabIndex = 12;
            this.de_button.Text = "Decrypt";
            this.de_button.UseVisualStyleBackColor = true;
            this.de_button.Click += new System.EventHandler(this.de_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "File";
            // 
            // de_textBoxFile
            // 
            this.de_textBoxFile.AllowDrop = true;
            this.de_textBoxFile.Location = new System.Drawing.Point(20, 32);
            this.de_textBoxFile.Name = "de_textBoxFile";
            this.de_textBoxFile.Size = new System.Drawing.Size(255, 20);
            this.de_textBoxFile.TabIndex = 7;
            this.de_textBoxFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.en_textBoxFile_DragDrop);
            this.de_textBoxFile.DragOver += new System.Windows.Forms.DragEventHandler(this.en_textBoxFile_DragOver);
            // 
            // de_textBoxKey
            // 
            this.de_textBoxKey.Location = new System.Drawing.Point(20, 90);
            this.de_textBoxKey.Name = "de_textBoxKey";
            this.de_textBoxKey.Size = new System.Drawing.Size(336, 20);
            this.de_textBoxKey.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Key";
            // 
            // de_buttonBrowse
            // 
            this.de_buttonBrowse.Location = new System.Drawing.Point(281, 30);
            this.de_buttonBrowse.Name = "de_buttonBrowse";
            this.de_buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.de_buttonBrowse.TabIndex = 8;
            this.de_buttonBrowse.Text = "Browse";
            this.de_buttonBrowse.UseVisualStyleBackColor = true;
            this.de_buttonBrowse.Click += new System.EventHandler(this.de_buttonBrowse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 259);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AES";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox en_textBoxFile;
        private System.Windows.Forms.Button en_buttonBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox en_textBoxKey;
        private System.Windows.Forms.Button en_button;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button de_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox de_textBoxFile;
        private System.Windows.Forms.TextBox de_textBoxKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button de_buttonBrowse;
    }
}

