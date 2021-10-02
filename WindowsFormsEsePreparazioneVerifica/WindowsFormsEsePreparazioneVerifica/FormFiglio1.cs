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
    public partial class FormFiglio1 : Form
    {
        public bool pelleSelected;
        public bool stoffaSelected;
        public string marca;

        public FormFiglio1()
        {
            InitializeComponent();
        }

        private void FormFiglio1_Load(object sender, EventArgs e)
        {
            pelleSelected = true;
            stoffaSelected = false;
            chkPelle.Checked = true;
            chkStoffa.Checked = false;
            marca = "";
        }

        private void chkPelle_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPelle.Checked)
                pelleSelected = true;
            else
                pelleSelected = false;
        }

        private void chkStoffa_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStoffa.Checked)
                stoffaSelected = true;
            else
                stoffaSelected = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            marca = comboBox1.Text;
        }
    }
}
