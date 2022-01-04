using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            if(sfd.ShowDialog() == DialogResult.OK)
            {
                string  base64 = Convert.ToBase64String(File.ReadAllBytes(en_textBoxFile.Text)),
                        encrypted = CryptoAes.EncryptString(en_textBoxKey.Text, base64);

                File.WriteAllText(sfd.FileName, encrypted);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if(ofd.ShowDialog() == DialogResult.OK)
                en_textBoxFile.Text = ofd.FileName;
        }

        private void de_buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
                de_textBoxFile.Text = ofd.FileName;
        }

        private void de_button_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string base64 = CryptoAes.DecryptString(de_textBoxKey.Text, File.ReadAllText(de_textBoxFile.Text));

                File.WriteAllBytes(sfd.FileName, Convert.FromBase64String(base64));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void en_textBoxFile_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        private void en_textBoxFile_DragDrop(object sender, DragEventArgs e)
        {
            TextBox tbox = (TextBox)sender;

            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[]; // get all files droppeds  
            if (files != null && files.Any())
                tbox.Text = files.First(); //select the first one  
        }
    }
}
