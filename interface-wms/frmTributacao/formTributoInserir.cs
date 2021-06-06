using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace interface_wms
{
    public partial class formTributoInserir : Form
    {
        public formTributoInserir()
        {
            InitializeComponent();
            fillCboCidade();
            fillCboTributo();
            
            

        }

        //procedimento para popular cbo de acordo com o parametro da cidade
        /*void fillCboTributo()
        {

            try
            {
                String Stringcon = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Netivan\source\repos\ProjetiIntegradoWMS\interface-wms\interface-wms\BDP2-WMSV2.mdb";
                OleDbConnection conn = new OleDbConnection(Stringcon);
                conn.Open();
                String SQL;

                //tblTipoTributo = tbTipo
                //tblTributo = tblTri

                SQL = "SELECT g1_tblTipoTributo.idTipoTributo, g1_tblTipoTributo.descTributo, g1_tblTipoTributo.codTributo, g1_tblTributo.idCidade FROM g1_tblTipoTributo INNER JOIN g1_tblTributo ON g1_tblTipoTributo.idTipoTributo = g1_tblTributo.idTipoTributo WHERE g1_tblTributo.idCidade =" + cboCidade.SelectedValue;

                OleDbCommand cmd = new OleDbCommand(SQL, conn);
                cmd.Connection = conn;


                OleDbDataReader dr = cmd.ExecuteReader();



                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(SQL, conn);
                //DataSet DS = new DataSet();

                dt.Load(dr);

                cboTipoTributo.DataSource = (dt);
                // cboTipoTributo.Items.Clear();
                cboTipoTributo.DisplayMember = "codTributo";
                cboTipoTributo.ValueMember = "idTipoTributo";

                

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        
        }*/


            void fillCboCidade()

            {
                try
                {
                    String Stringcon = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Netivan\source\repos\ProjetiIntegradoWMS\interface-wms\interface-wms\BDP2-WMSV2.mdb";
                    OleDbConnection conn = new OleDbConnection(Stringcon);
                    conn.Open();

                    String SQL;
                    SQL = "Select idCidade, descCidade from g1_tblCidade ORDER BY descCidade ";


                    OleDbDataAdapter adapter = new OleDbDataAdapter(SQL, conn);
                    DataSet DS = new DataSet();
                    adapter.Fill(DS, "g1_tblCidade");


                    cboCidade.Items.Clear();
                    cboCidade.DataSource = DS.Tables["g1_tblCidade"];
                    cboCidade.SelectedItem = "";
                    cboCidade.DisplayMember = "descCidade";
                    cboCidade.ValueMember = "idCidade";
                    



                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }

        void fillCboTributo()

        {
            try
            {
                String Stringcon = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Netivan\source\repos\ProjetiIntegradoWMS\interface-wms\interface-wms\BDP2-WMSV2.mdb";
                OleDbConnection conn = new OleDbConnection(Stringcon);
                conn.Open();

                String SQL;
                SQL = "Select * from g1_tblTipoTributo ORDER BY codTributo";

                OleDbCommand cmd = new OleDbCommand(SQL, conn);
                cmd.Connection = conn;

                OleDbDataReader dr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                //OleDbDataAdapter da = new OleDbDataAdapter(SQL, conn);
                //DataSet DS = new DataSet();

                dt.Load(dr);

                cboTipoTributo.DataSource = (dt);
                //cboTipoTributo.Items.Clear();
                cboTipoTributo.DisplayMember = "codTributo";
                cboTipoTributo.ValueMember = "idTipoTributo";
                cboTipoTributo.SelectedItem = "";

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }



        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            formCliente abrirFormCliente = new formCliente();

            abrirFormCliente.ShowDialog();

        }

        private void tmrDataHora_Tick(object sender, EventArgs e)
        {
            lblDataHora.Text = DateTime.Now.ToString("dd/MM/yyyy, HH:mm");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarForm())

            {
                
                if (ValidarDuplicidade() < 1)

                {

                    try
                    {
                        String Stringcon = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Netivan\source\repos\ProjetiIntegradoWMS\interface-wms\interface-wms\BDP2-WMSV2.mdb";
                        OleDbConnection conn = new OleDbConnection(Stringcon);
                        conn.Open();

                        String SQL;
                        SQL = "Insert Into g1_tblTributo (idCidade, idTipoTributo, aliquota) values ";
                        SQL += "('" + cboCidade.SelectedValue + "','" + cboTipoTributo.SelectedValue + "','" + txtAliquota.Text + "')";


                        OleDbCommand cmd = new OleDbCommand(SQL, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Dados gravados com sucesso.");

                        UserI LC = new UserI();

                        LC.limparCampos(tabIdentTributo1.Controls);

                        conn.Close();

                        formTributo voltarFormTipoTributo = new formTributo();
                        voltarFormTipoTributo.ShowDialog();
                        this.Close();
                    }

                    catch (Exception erro)
                    {

                        MessageBox.Show(erro.Message);
                    }

                }

                else
                {
                    MessageBox.Show("O registro já existe no Banco de Dados");
                    
                }

            }

            else
            { 
                MessageBox.Show("Favor preencher todos os campos.");

            }


        }


        private bool ValidarForm()
        {
            bool FormValido;

            if (cboCidade.Text == "")
                FormValido = false;
            else if (cboTipoTributo.Text == "")
                FormValido = false;
            else if (txtAliquota.Text == "")
                FormValido = false;
            else
                FormValido = true;
            return FormValido;
        }

       private int  ValidarDuplicidade()
        {

            try
            {
                String Stringcon = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Netivan\source\repos\ProjetiIntegradoWMS\interface-wms\interface-wms\BDP2-WMSV2.mdb";
                OleDbConnection conn = new OleDbConnection(Stringcon);
                conn.Open();

                String SQL;
                SQL = "SELECT COUNT (*) ";
                SQL += "FROM g1_tblTributo ";
                SQL += "WHERE g1_tblTributo.idCidade = " + cboCidade.SelectedValue + " And g1_tblTributo.idTipoTributo = " + cboTipoTributo.SelectedValue;

                                      
                    //+ "And g1_tblTributo.idTipoTributo = " + cboTipoTributo.SelectedValue ;
               

                OleDbCommand cmd = new OleDbCommand(SQL, conn);

                int teste = (Int32)cmd.ExecuteScalar();

                return teste;

                conn.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
                return 1;

            }

        }

       

        private void cboCidade_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //chama procedimento para alterar popular a cboTipoTributo baseado no valor campo cidade
            //fillCboTributo();

        }

       
    }
}
