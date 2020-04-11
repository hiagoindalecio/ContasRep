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
    public partial class FRM_AddMorador : Form
    {
        int idSelec = 0;
        public FRM_AddMorador(int id)
        {
            InitializeComponent();
            idSelec = id;
            CarregarDados();
        }

        public void CarregarDados()
        {
            if (idSelec != 0)
            {
                clsMoradores objMoradores = new clsMoradores();
                MySqlDataReader sql_dr = objMoradores.GetMoradorByID(idSelec);
                if (sql_dr.Read())
                {
                    txtNome.Text = sql_dr["nome"].ToString();
                    if (Convert.ToInt32(sql_dr["ativo"]) == 1)
                    {
                        cmbAtivo.Text = "Sim";
                    }
                    else if (Convert.ToInt32(sql_dr["ativo"]) == 0)
                    {
                        cmbAtivo.Text = "Não";
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Equals(txtNome.Text, "") || Equals(cmbAtivo.Text, ""))
            {
                MessageBox.Show("Por favor preencha todos os campos para salvar o usuário!", "Atenção, preencha todos os campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                clsMoradores objMoradores = new clsMoradores();
                objMoradores.Nome_Morador = txtNome.Text;
                if (Equals(cmbAtivo.Text, "Sim"))
                {
                    objMoradores.Ativo = true;
                }
                else
                {
                    objMoradores.Ativo = false;
                }
                if (idSelec != 0)
                {
                    objMoradores.Id_Morador = idSelec;
                    objMoradores.update();
                }
                else
                {
                    objMoradores.insert();
                }
                MessageBox.Show(objMoradores.ds_msg);
                this.Close();
            }
        }
    }
}
