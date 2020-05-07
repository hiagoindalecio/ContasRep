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
            TelaInicial();
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

        public void TelaInicial()
        {
            cmbAno.Items.Clear();
            cmbMes.Items.Clear();
            cmbMoradores.Items.Clear();
            CarregarMoradores();
            CarregarDatas();
            lstGeral.Items.Clear();
            lstIndividual.Items.Clear();
            lstGeral.Visible = false;
            lstIndividual.Visible = true;
            lstContas.Items.Clear();
            btnCancel.Visible = false;
            txtDescription.Text = "Contas que o morador irá pagar:";
            cmbAno.Enabled = true;
            cmbMes.Enabled = true;
            cmbMoradores.Enabled = true;
            ckbSelectAll.Visible = false;
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
            i = 1;
            do
            {
                if (i < 10)
                {
                    cmbMes.Items.Add("0" + (i++.ToString()));
                }
                else
                {
                    cmbMes.Items.Add(i++.ToString());
                }
            } while (i <= 12);
        }

        public void CarregarValores()
        {
            clsMoradores obj_moradores = new clsMoradores();
            clsData objData = new clsData();
            int idData = objData.GetIdByData(Convert.ToInt32(cmbMes.Text), Convert.ToInt32(cmbAno.Text));
            if (idData == 0)
            {
                MessageBox.Show("Data não encontrada!", "Tente novamente");
            }
        }

        public void Carregar(object sender, EventArgs e)
        {
            CarregarListaIndividual();
            ckbSelectAll.Visible = true;
        }

        public void CarregarListaIndividual()
        {
            if (Equals(cmbAno.Text, "") || Equals(cmbMes.Text, ""))
            {
                MessageBox.Show("Por favor selecione uma data válida para realizar a pesquisa!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbMoradores.SelectedItem = -1;
                cmbMoradores.Text = "";
            }
            else
            {
                clsData objData = new clsData();
                int idData = objData.GetIdByData(Convert.ToInt32(cmbMes.Text), Convert.ToInt32(cmbAno.Text)), idConta, valido = 1;
                clsPagamentos obj_pagamentos = new clsPagamentos();
                obj_pagamentos.Id_Data = idData;
                MySqlDataReader sql_dr = obj_pagamentos.GetPagamentosByIdDate();
                if (sql_dr.Read())
                {
                    DialogResult result = MessageBox.Show("Já existem pagamentos salvos nesta data, deseja sobrescrevê-los?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.Yes)
                    {
                        MessageBox.Show(obj_pagamentos.Delete());
                        valido = 1;
                    }
                    else
                        valido = 0;
                }
                if (valido == 1)
                {
                    cmbAno.Enabled = false;
                    cmbMes.Enabled = false;
                    btnCancel.Visible = true;
                    txtDescription.Text = "Contas que " + cmbMoradores.Text + " irá pagar:";
                    lstIndividual.Items.Clear();
                    string filtro = "";
                    clsContas objContas = new clsContas();
                    if (idData != 0)
                    {
                        filtro = "where id_data = " + idData.ToString();
                        sql_dr = objContas.GetContasByFiltro(filtro);
                        int count = 0;
                        while (sql_dr.Read())
                        {
                            //Jogando os dados no list view
                            ListViewItem instancia_lista = new ListViewItem(sql_dr["nome_conta"].ToString());
                            instancia_lista.SubItems.Add(sql_dr["valor_conta"].ToString());
                            lstIndividual.Items.Add(instancia_lista);
                            idConta = int.Parse(sql_dr["id_conta"].ToString());
                            count++;
                        }
                        if (lstContas.Items.Count != lstIndividual.Items.Count)
                        {
                            sql_dr.Close();
                            sql_dr = objContas.GetContasByFiltro(filtro);
                            while (sql_dr.Read())
                            {
                                ListViewItem instancia2 = new ListViewItem(sql_dr["nome_conta"].ToString());
                                instancia2.SubItems.Add("R$" + double.Parse(sql_dr["valor_conta"].ToString()));
                                instancia2.SubItems.Add("0");
                                lstContas.Items.Add(instancia2);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Data não encontrada!", "Tente novamente");
                    }
                }
                else
                    TelaInicial();
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

        public void SalvarMorador(string name)
        {
            int cont = 0, cont2 = 0;
            ListViewItem item = new ListViewItem(cmbMoradores.Text);
            string contas = "";
            while (cont < lstIndividual.Items.Count)
            {
                if (lstIndividual.Items[cont].Checked)
                {
                    while (cont2 < lstContas.Items.Count)
                    {
                        if (Equals(lstContas.Items[cont2].Text, lstIndividual.Items[cont].Text))
                        {
                            lstContas.Items[cont2].SubItems[2].Text = (Convert.ToInt32(lstContas.Items[cont2].SubItems[2].Text) + 1).ToString();
                        }
                        cont2++;
                    }
                    cont2 = 0;
                    if(!Equals(contas, ""))
                    {
                        for (int i = 0; i < lstContas.Items.Count; i++)
                        {
                            if (Equals(lstIndividual.Items[cont].Text, lstContas.Items[i].Text))
                            {
                                contas += "|" + lstIndividual.Items[cont].Text;
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < lstContas.Items.Count; i++)
                        {
                            if (Equals(lstIndividual.Items[cont].Text, lstContas.Items[i].Text))
                            {
                                contas += lstIndividual.Items[cont].Text;
                            }
                        }
                    }
                }
                cont++;
            }
            item.SubItems.Add("");
            item.SubItems.Add(contas);
            lstGeral.Items.Add(item);
            cmbMoradores.Items.Remove(cmbMoradores.Text);
            lstIndividual.Items.Clear();
            ckbSelectAll.Visible = false;
        }

        /*public void Finalizar()
        {
            int i = 0, j = 0, k = 0;
            clsContas obj_contas = new clsContas();
            MySqlDataReader sql_dr;
            while (i < lstGeral.Items.Count)
            {
                var array = lstGeral.Items[i].SubItems[1].Text.Split('|');
                //for ()
                double valor = 0;
                do{
                    //array[j + 1] = array[j + 1].Replace(',', '.');
                    int id = obj_contas.GetId(array[j].ToString(), array[j+1].ToString());
                    sql_dr = obj_contas.GetContasByFiltro("where id_conta = " + id);
                    if (sql_dr.Read())
                    {
                        int quantas = 0;
                        while(k < lstContas.Items.Count)
                        {
                            if(Equals(lstContas.Items[k].Text, array[j].ToString()))
                            {
                                quantas = int.Parse(lstContas.Items[k].SubItems[2].Text);
                            }
                            k++;
                        }
                        k = 0;
                        valor += Math.Round((float.Parse(sql_dr["valor_conta"].ToString()) / quantas),2);
                    }
                    j+=2;
                }while(j < array.Length);
                j = 0;
                ListViewItem item = new ListViewItem(lstGeral.Items[i].SubItems[0].Text);
                item.SubItems.Add("R$" + valor.ToString());
                lstGeral.Items[i] = item;
                i++;
            }
            ckbSelectAll.Checked = false;
        }*/

        public void AlterarListaContas()
        {
            for (int y = 0; y < lstContas.Items.Count; y++)
            {
                var array = lstContas.Items[y].SubItems[1].Text.Split('$');
                double valor = double.Parse(array[1]);
                int pagantes = int.Parse(lstContas.Items[y].SubItems[2].Text);
                ListViewItem item = new ListViewItem(lstContas.Items[y].Text);
                item.SubItems.Add(lstContas.Items[y].SubItems[1].Text);
                item.SubItems.Add(lstContas.Items[y].SubItems[2].Text);
                item.SubItems.Add("R$" + (Math.Round(valor / pagantes, 2)).ToString());
                lstContas.Items[y] = item;
            }
        }

        public void Finalizar()
        {
            AlterarListaContas();
            double total = 0;
            for (int i = 0; i < lstGeral.Items.Count; i++)
            {
                var array = lstGeral.Items[i].SubItems[2].Text.Split('|');
                for(int j = 0; j < array.Length; j++)
                {
                    for(int y = 0; y< lstContas.Items.Count; y++)
                    {
                        if(Equals(array[j], lstContas.Items[y].Text))
                        {
                            var valor = lstContas.Items[y].SubItems[3].Text.Split('$');
                            total += double.Parse(valor[1]);
                        }
                    }
                }
                ListViewItem item = new ListViewItem(lstGeral.Items[i].Text);
                item.SubItems.Add("R$" + total.ToString());
                item.SubItems.Add(lstGeral.Items[i].SubItems[2].Text);
                lstGeral.Items[i] = item;
                total = 0;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Equals(btnSalvar.Text, "Encerrar"))
            {
                EnviarDados();
                btnSalvar.Text = "Salvar";
                TelaInicial();
            }
            else if (Equals(btnSalvar.Text, "Salvar") && !Equals(cmbMoradores.Text, ""))
            {
                if (lstIndividual.CheckedItems.Count == 0)
                {
                    DialogResult result;
                    result = MessageBox.Show("Tem certeza que deseja salvar o morador sem nenhuma despesa?", "Atenção", MessageBoxButtons.YesNo);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        SalvarMorador(cmbMoradores.Text);
                    }
                }
                else
                {
                    SalvarMorador(cmbMoradores.Text);
                }
                if (cmbMoradores.Items.Count == 0)
                {
                    Finalizar();
                    lstIndividual.Visible = false;
                    lstGeral.Visible = true;
                    cmbMoradores.Enabled = false;
                    btnSalvar.Text = "Encerrar";
                    ckbSelectAll.Visible = false;
                    txtDescription.Text = "Visualização final de pagamentos:";
                }
            }
            else
            {
                MessageBox.Show("Selecione um morador primeiro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            ckbSelectAll.Checked = false;
        }

        private void EnviarDados()
        {
            double total_pagamentos = 0;
            clsMoradores obj_moradores = new clsMoradores();
            clsData obj_data = new clsData();
            clsPagamentos obj_pagamentos = new clsPagamentos();
            obj_pagamentos.Id_Data = obj_data.GetIdByData(Convert.ToInt32(cmbMes.Text), Convert.ToInt32(cmbAno.Text));
            for (int i = 0; i < lstGeral.Items.Count; i++)
            {
                MySqlDataReader sqldr = obj_moradores.GetMoradorByName(lstGeral.Items[i].Text);
                sqldr.Read();
                obj_pagamentos.Id_Morador = int.Parse(sqldr["id_morador"].ToString());
                var valor = lstGeral.Items[i].SubItems[1].Text.Split('$');
                obj_pagamentos.Valor_Pago = double.Parse(valor[1]);
                obj_pagamentos.Contas = lstGeral.Items[i].SubItems[2].Text;
                total_pagamentos += obj_pagamentos.Valor_Pago;
                if (i == lstGeral.Items.Count - 1)
                {
                    obj_data.Id_data = obj_pagamentos.Id_Data;
                    string resultado = obj_pagamentos.Pagar();
                    if (Equals(resultado, "Sucesso! "))
                    {
                        MessageBox.Show(resultado + obj_data.AddPagamento(total_pagamentos));
                    }
                    else
                    {
                        MessageBox.Show(resultado);
                    }
                }
                else
                {
                    obj_pagamentos.Pagar();
                }
            }
            
        }

        private void Validar(object sender, EventArgs e)
        {
            if (!Equals(cmbAno.Text, "") && !Equals(cmbMes.Text, "") && !Equals(cmbMoradores.Text, ""))
            {
                CarregarListaIndividual();
            }
        }

        private void SelecionarTudo(object sender, EventArgs e)
        {
            if (ckbSelectAll.Checked)
            {
                for (int i = 0; i < lstIndividual.Items.Count; i++)
                {
                    lstIndividual.Items[i].Checked = true;
                }
            }
            else
            {
                for (int i = 0; i < lstIndividual.Items.Count; i++)
                {
                    lstIndividual.Items[i].Checked = false;
                }
            }
        }

        private void Cancelar(object sender, EventArgs e)
        {
            TelaInicial();
        }
    }
}
