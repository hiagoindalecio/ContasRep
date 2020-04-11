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
    public partial class FRM_Pesquisar : Form
    {
        public FRM_Pesquisar()
        {
            InitializeComponent();
            Parametros();
            CarregarDatas();
        }

        private static FRM_Pesquisar instance;

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

        public static FRM_Pesquisar Instance()
        {
            if (instance == null)
            {
                instance = new FRM_Pesquisar();
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

        public void CarregarValores()
        {
            string filtro = "";
            double quantia;
            int quantosMoradores = 0;
            clsMoradores obj_moradores = new clsMoradores();
            MySqlDataReader sql_dr, sqldr = obj_moradores.GetAllMoradores();
            while (sqldr.Read())
            {
                if (Convert.ToBoolean(sqldr["ativo"].ToString()))
                {
                    quantosMoradores++;
                }
            }
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
                    txtTotal.Text = "R$" + Math.Round(quantia,2).ToString();
                    txtIndividual.Text = "R$" + Math.Round((quantia / quantosMoradores),2).ToString();
                    quantia = 0;
                    quantia = Convert.ToDouble(sql_dr["quantia_recebida"]);
                    txtRecebido.Text = "R$" + quantia.ToString();

                }
            }
            else
            {
                MessageBox.Show("Data não encontrada!", "Tente novamente");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Equals(cmbAno.Text, "") && !Equals(cmbMes.Text, ""))
            {
                CarregarValores();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos de data corretamente!", "ERRO");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FRM_AddAno form_add = new FRM_AddAno();
            form_add.ShowDialog();
        }
    }
}
