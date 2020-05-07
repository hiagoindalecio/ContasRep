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
        int dataId, contaId;
        public FRM_AddConta(int idData, int idConta)
        {
            InitializeComponent();
            dataId = idData;
            contaId = idConta;
            VerificarExistencia();
        }

        private void VerificarExistencia()
        {
            if (Convert.ToBoolean(contaId))
            {
                clsContas objContas = new clsContas();
                MySqlDataReader sql_dr = objContas.GetContasByFiltro("where id_conta = " + contaId);
                sql_dr.Read();
                txtNome.Text = sql_dr["nome_conta"].ToString();
                txtValor.Text = "R$" + sql_dr["valor_conta"].ToString();
                bool paga = Convert.ToBoolean(sql_dr["paga"].ToString());
                if (paga)
                {
                    cmbPaga.Text = "Sim";
                }
                else
                {
                    cmbPaga.Text = "Não";
                }
                cmbPaga.Visible = true;
                lblPaga.Visible = true;
            }
            else
            {
                cmbPaga.Visible = false;
                lblPaga.Visible = false;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            clsContas objContas = new clsContas();
            objContas.Id_Data = dataId;
            objContas.Nome_Conta = txtNome.Text;
            var valor = txtValor.Text.Split('$');
            string valorReal = valor[1].Replace(',', '.');
            objContas.Valor_Conta = (valorReal);
            if (!Convert.ToBoolean(contaId))
            {
                objContas.Paga = 0;
                MessageBox.Show(objContas.insert());
            }
            else
            {
                objContas.Id_Conta = contaId;
                if (Equals(cmbPaga.Text, "Sim"))
                {
                    objContas.Paga = 1;
                }
                else
                {
                    objContas.Paga = 0;
                }
                MessageBox.Show(objContas.update());
            }
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
