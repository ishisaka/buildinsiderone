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
        public BuildInsider() {
            InitializeComponent();
        }

        private void MessageButton_Click(object sender, EventArgs e) {
            MessageBox.Show("第1回 BuildInsider OFFLINEにようこそ");
        }
    }
}
