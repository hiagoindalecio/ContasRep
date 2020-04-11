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
    public partial class FRM_Moradores : Form
    {
        public FRM_Moradores()
        {
            InitializeComponent();
            Parametros();
            CarregarLista();
        }

        string nr_MoradorSelecionado = "0";

        private static FRM_Moradores instance;

        public static FRM_Moradores Instance()
        {
            if (instance == null)
            {
                instance = new FRM_Moradores();
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

        public void CarregarLista()
        {
            lstMoradores.Items.Clear();
            clsMoradores objMoradores = new clsMoradores();
            MySqlDataReader sql_dr;
            sql_dr = objMoradores.GetAllMoradores();
            while (sql_dr.Read())
            {
                //Jogando os dados no list view
                ListViewItem instancia_lista = new ListViewItem(sql_dr["id_morador"].ToString());
                instancia_lista.SubItems.Add(sql_dr["nome"].ToString());
                if (Convert.ToInt32(sql_dr["ativo"]) == 1)
                {
                    instancia_lista.SubItems.Add("Sim");
                }
                else
                {
                    instancia_lista.SubItems.Add("Não");
                }
                lstMoradores.Items.Add(instancia_lista);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            FRM_AddMorador formAdd = new FRM_AddMorador(0);
            formAdd.ShowDialog();
            CarregarLista();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!Equals(nr_MoradorSelecionado, "0"))
            {
                FRM_AddMorador formAdd = new FRM_AddMorador(Convert.ToInt32(nr_MoradorSelecionado));
                formAdd.ShowDialog();
                CarregarLista();
            }
            else
            {
                MessageBox.Show("Selecione um morador para editar!", "ERRO");
            }
        }

        private void SelecionarIndice(object sender, EventArgs e)
        {
            try
            {
                string vl_select = lstMoradores.SelectedItems[0].Text;
                nr_MoradorSelecionado = vl_select;
            }
            catch
            {
                nr_MoradorSelecionado = "0";
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (!Equals(nr_MoradorSelecionado, "0"))
            {
                DialogResult result = MessageBox.Show("Realmente deseja excluir o usuário " + lstMoradores.SelectedItems[0].SubItems[1].Text + "?", "Excluir Morador", MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    clsMoradores objMoradores = new clsMoradores();
                    objMoradores.Id_Morador = Convert.ToInt32(nr_MoradorSelecionado);
                    MessageBox.Show(objMoradores.delete());
                    CarregarLista();
                }
            }
            else
            {
                MessageBox.Show("Selecione um morador para excluir!", "ERRO");
            }
        }
    }
}
