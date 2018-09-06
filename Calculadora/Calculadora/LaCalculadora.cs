using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void cmbOperador_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        

        private void btnOperar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Entidades.Calculadora.Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
