using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsEsePreparazioneVerifica
{
    public partial class Form1 : Form
    {
        public string marca;
        public FormFiglio1 ff1 = new FormFiglio1();
        public FormFIglio2 ff2 = new FormFIglio2();

        public Form1()
        {
            InitializeComponent();
        }

        private void apri1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ff1.MdiParent = this;
            ff1.Show();
        }

        private void apri2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.marca = ff1.marca;
            ff2.MdiParent = this;
            ff2.Show();
        }
    }
}
