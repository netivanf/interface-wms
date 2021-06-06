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
    public partial class formMenuCadastro : Form
    {
        public formMenuCadastro()
        {
            InitializeComponent();
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            formCliente abrirformCliente = new formCliente();

            abrirformCliente.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            formMenuIncial abrirFormMenuInicial = new formMenuIncial();
            abrirFormMenuInicial.ShowDialog();

        }

        

        private void button12_Click(object sender, EventArgs e)
        {
            formTributo abrirFormTributo = new formTributo();
            abrirFormTributo.ShowDialog();

        }

      

        private void btnTipoTributoAbrir_Click(object sender, EventArgs e)
        {
            formTipoTributo abrirFormTipoTributo = new formTipoTributo();

            abrirFormTipoTributo.ShowDialog();

        }
    }
}
