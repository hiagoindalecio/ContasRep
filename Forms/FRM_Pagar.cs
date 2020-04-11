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
    public partial class FRM_Pagar : Form
    {
        public FRM_Pagar()
        {
            InitializeComponent();
            Parametros();
            CarregarDatas();
            CarregarMoradores();
        }

        private static FRM_Pagar instance;

        public static FRM_Pagar Instance()
        {
            if (instance == null)
            {
                instance = new FRM_Pagar();
            }
            return instance;
        }

        public void Parametros()
        {
            this.Top = 0;
            this.Left = 0;
            this.Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            this.Height = 750;
        }

        public void CarregarDatas()
        {
            clsData objData = new clsData();
            MySqlDataReader sql_dr = objData.GetAllData();
            bool j;
            int i;
            while (sql_dr.Read())
            {
                j = false;
                for (i = 0; i < cmbAno.Items.Count; i++)
                {
                    if (Equals(cmbAno.Items[i].ToString(), sql_dr["ano"].ToString()))
                    {
                        j = true;
                    }
                }
                if (!j)
                {
                    cmbAno.Items.Add(sql_dr["ano"].ToString());
                }
            }
        }

        public void CarregarValores()
        {
            string filtro = "";
            double quantia;
            clsMoradores obj_moradores = new clsMoradores();
            MySqlDataReader sql_dr;
            clsData objData = new clsData();
            int idData = objData.GetIdByData(Convert.ToInt32(cmbMes.Text), Convert.ToInt32(cmbAno.Text));
            if (idData != 0)
            {
                filtro = "where id_data = " + idData.ToString();
                sql_dr = objData.GetDataById(idData);
                if (sql_dr.Read())
                {
                    //Buscando quantia total
                    quantia = Convert.ToDouble(sql_dr["quantia_total"]);
                    txtTotal.Text = "R$" + Math.Round(quantia, 2).ToString();
                }
            }
            else
            {
                MessageBox.Show("Data não encontrada!", "Tente novamente");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Equals(cmbAno.Text, "") || Equals(cmbMes.Text, ""))
            {
                MessageBox.Show("Por favor selecione uma data válida para realizar a pesquisa!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                CarregarValores();
            }
        }

        public void CarregarMoradores()
        {
            clsMoradores objMoradores = new clsMoradores();
            MySqlDataReader sql_dr;
            sql_dr = objMoradores.GetAllMoradores();
            while (sql_dr.Read())
            {
                //Jogando os moradores na lista
                if (Convert.ToBoolean(sql_dr["ativo"]))
                {
                    cmbMoradores.Items.Add(sql_dr["nome"].ToString());
                }
            }
        }
    }
}
