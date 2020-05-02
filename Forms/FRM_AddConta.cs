using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContasRep.Classes;
using MySql.Data.MySqlClient;

namespace ContasRep
{
    public partial class FRM_AddConta : Form
    {
        int dataId;
        public FRM_AddConta(int idData)
        {
            InitializeComponent();
            dataId = idData;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            clsContas objContas = new clsContas();
            objContas.Id_Data = dataId;
            objContas.Nome_Conta = txtNome.Text;
            var valor = txtValor.Text.Split('$');
            string valorReal = valor[1].Replace(',', '.');
            objContas.Valor_Conta = (valorReal);
            MessageBox.Show(objContas.insert());
            this.Close();
        }

        private void ValidarDinheiro(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)Keys.Back) && !(char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
