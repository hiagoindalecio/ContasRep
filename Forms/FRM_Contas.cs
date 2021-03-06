﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContasRep.Classes;
using MySql.Data.MySqlClient;
using System.Data;

namespace ContasRep
{
    public partial class FRM_Contas : Form
    {
        public FRM_Contas()
        {
            InitializeComponent();
            Parametros();
            CarregarDatas();
        }

        private static FRM_Contas instance;

        public static FRM_Contas Instance()
        {
            if (instance == null)
            {
                instance = new FRM_Contas();
            }
            return instance;
        }

        string contaSelecionada = "0";

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

        public void CarregarLista()
        {
            lstContas.Items.Clear();
            string filtro = "";
            clsContas objContas = new clsContas();
            MySqlDataReader sql_dr;
            clsData objData = new clsData();
            int idData = objData.GetIdByData(Convert.ToInt32(cmbMes.Text), Convert.ToInt32(cmbAno.Text));
            if (idData != 0)
            {
                filtro = "where id_data = " + idData.ToString();
                sql_dr = objContas.GetContasByFiltro(filtro);
                while (sql_dr.Read())
                {
                    //Jogando os dados no list view
                    ListViewItem instancia_lista = new ListViewItem(sql_dr["nome_conta"].ToString());
                    instancia_lista.SubItems.Add(sql_dr["valor_conta"].ToString());
                    bool paga = Convert.ToBoolean(sql_dr["paga"].ToString());
                    if (paga)
                    {
                        instancia_lista.SubItems.Add("Sim");
                    }
                    else
                    {
                        instancia_lista.SubItems.Add("Não");
                    }
                    lstContas.Items.Add(instancia_lista);
                }
            }
            else
            {
                MessageBox.Show("Data não encontrada!", "Tente novamente");
            }
            contaSelecionada = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Equals(cmbMes.Text, "") && !Equals(cmbAno.Text, ""))
            {
                CarregarLista();
            }
            else
            {
                MessageBox.Show("Favor selecionar uma data válida!", "Atenção!");
            }
        }

        private void SelecionarIndice(object sender, EventArgs e)
        {
            try
            {
                string vl_select = lstContas.SelectedItems[0].Text;
                contaSelecionada = vl_select;
            }
            catch
            {
                contaSelecionada = "0";
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (!Equals(cmbMes.Text, "") || !Equals(cmbAno.Text, ""))
            {
                clsData objData = new clsData();
                FRM_AddConta form_adc = new FRM_AddConta(objData.GetIdByData(Convert.ToInt32(cmbMes.Text), Convert.ToInt32(cmbAno.Text)), 0);
                form_adc.ShowDialog();
                CarregarLista();
            }
            else
            {
                MessageBox.Show("Selecione a data corretamente para adicionar uma conta!", "Verifique novamente");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!Equals(contaSelecionada, "0"))
            {
                clsContas objContas = new clsContas();
                objContas.Nome_Conta = lstContas.SelectedItems[0].Text;
                objContas.Valor_Conta = lstContas.SelectedItems[0].SubItems[1].Text;
                clsData objData = new clsData();
                int idData = objData.GetIdByData(Convert.ToInt32(cmbMes.Text), Convert.ToInt32(cmbAno.Text));
                objContas.Id_Data = idData;
                int idConta = objContas.GetId();
                FRM_AddConta form_adc = new FRM_AddConta(idData, idConta);
                form_adc.ShowDialog();
                CarregarLista();
            }
            else if (Equals(contaSelecionada, "0"))
            {
                MessageBox.Show("Atenção, favor selecionar uma conta válida!", "Nenhuma Conta Selecionada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (!Equals(contaSelecionada, "0"))
            {
                clsContas objContas = new clsContas();
                string valorReal = lstContas.SelectedItems[0].SubItems[1].Text.Replace(',', '.');
                objContas.Valor_Conta = (valorReal);
                MessageBox.Show(objContas.delete());
                CarregarLista();
            }
            else if (Equals(contaSelecionada, "0"))
            {
                MessageBox.Show("Atenção, favor selecionar uma conta válida!", "Nenhuma Conta Selecionada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
