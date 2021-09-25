using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_form_es_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnF1_Click(object sender, EventArgs e)
        {
            formFiglia1 f1 = new formFiglia1();
            f1.MdiParent = this;
            f1.Text = "Figlia 1";
            f1.Size = new Size(200, 150);
            f1.StartPosition = FormStartPosition.Manual;
            f1.Location = new Point(0, 50);
            f1.Show();
        }

        private void btnF2_Click(object sender, EventArgs e)
        {
            Figlia2 f2 = new Figlia2();
            f2.MdiParent = this;
            f2.Text = "Figlia 2";
            f2.Size = new Size(200, 150);
            f2.StartPosition = FormStartPosition.Manual;
            f2.Location = new Point(220, 50);
            f2.Show();
        }

        private void btnFunestreAperte_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sono state aperte " + this.MdiChildren.Length + " finestre figlie");

            foreach (Form f in this.MdiChildren)
            {
                MessageBox.Show("Finestra " + f.Text + " Aperta");
            }
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void apri1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
