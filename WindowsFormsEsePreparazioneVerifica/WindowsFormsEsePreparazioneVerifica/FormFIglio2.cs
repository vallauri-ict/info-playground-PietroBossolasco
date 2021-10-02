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
    public partial class FormFIglio2 : Form
    {
        public Form1 f1 = new Form1();

        public FormFIglio2()
        {
            InitializeComponent();
        }

        private void FormFIglio2_Load(object sender, EventArgs e)
        {
            string marca = f1.marca;
            Console.WriteLine(marca);
        }
    }
}
