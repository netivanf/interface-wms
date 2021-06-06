using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace interface_wms
{
    class UserI
    {
        public void limparCampos (Control.ControlCollection controles)
        {
            //Faz um laço para todos os controles passados no parâmetro
            foreach (Control item in controles)
            {
                //Se o contorle for um TextBox...
                if (item.GetType() == typeof(TextBox))
                {
                    item.Text = string.Empty;

                }
                if (item.GetType() == typeof(ComboBox))
                {
                    item.Text = string.Empty; //limpa todos os controles do tipo TextBox
                   
                }

            }
        }

        

        //public DtaHora()
        // {

        // }
    }
}
