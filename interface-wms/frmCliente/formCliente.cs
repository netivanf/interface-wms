using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interface_wms
{
    public partial class formCliente : Form
    {
        public formCliente()
        {
            InitializeComponent();
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            formClienteInserir abrirFormClienteInserir = new formClienteInserir();
            abrirFormClienteInserir.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            formMenuIncial abrirFormMenuInicial = new formMenuIncial();
            abrirFormMenuInicial.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formMenuCadastro abrirFormMenuCadastro = new formMenuCadastro();
            abrirFormMenuCadastro.ShowDialog();

        }

        

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
