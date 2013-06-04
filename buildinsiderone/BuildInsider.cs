using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buildinsiderone
{
    public partial class BuildInsider : Form
    {
        private string message = "";

        public BuildInsider() {
            InitializeComponent();
        }

        private void MessageButton_Click(object sender, EventArgs e) {
            MessageLabel.Text = message;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            var aboutForm = new About();
            aboutForm.ShowDialog(this);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) {
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                var reader = new System.IO.StreamReader(
                    openFileDialog.FileName,
                    System.Text.Encoding.GetEncoding("utf-8")
                    );
                message = reader.ReadLine();
                reader.Close();
            }

        }
    }
}
