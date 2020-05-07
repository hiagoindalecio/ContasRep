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
using System.IO;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ContasRep
{
    public partial class FRM_Pesquisar : Form
    {
        public FRM_Pesquisar()
        {
            InitializeComponent();
            Parametros();
            CarregarDatas();
            btnRelatorio.Visible = false;
        }

        private static FRM_Pesquisar instance;

        public static Document documento;

        public int id_data = 0;

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
            double quantia = 0;
            int quantosMoradores = 0;
            clsMoradores obj_moradores = new clsMoradores();
            MySqlDataReader sql_dr = obj_moradores.GetAllMoradores();
            while (sql_dr.Read())
            {
                if (Convert.ToBoolean(sql_dr["ativo"].ToString()))
                {
                    quantosMoradores++;
                }
            }
            sql_dr.Close();
            clsData objData = new clsData();
            int idData = objData.GetIdByData(Convert.ToInt32(cmbMes.Text), Convert.ToInt32(cmbAno.Text));
            id_data = idData;
            clsContas objContas = new clsContas();
            sql_dr = objContas.GetContasByFiltro("where id_data = " + idData);
            if (sql_dr.Read())
            {
                //Buscando quantia total
                do
                {
                    quantia += Convert.ToDouble(sql_dr["valor_conta"]);
                } while (sql_dr.Read());
                sql_dr.Close();
                sql_dr = objData.GetDataById(idData);
                sql_dr.Read();
                txtTotal.Text = "R$" + Math.Round(quantia,2).ToString();
                txtIndividual.Text = "R$" + Math.Round((quantia / quantosMoradores),2).ToString();
                quantia = 0;
                quantia = Convert.ToDouble(sql_dr["quantia_recebida"]);
                txtRecebido.Text = "R$" + Math.Round(quantia,2);
                sql_dr.Close();
                clsPagamentos objPagamento = new clsPagamentos();
                objPagamento.Id_Data = idData;
                sql_dr = objPagamento.GetPagamentosByIdDate();
                while (sql_dr.Read())
                {
                    MySqlDataReader sql_dr2 = obj_moradores.GetMoradorByID(Convert.ToInt32(sql_dr["id_morador"]));
                    sql_dr2.Read();
                    ListViewItem item = new ListViewItem(sql_dr2["nome"].ToString());
                    sql_dr2.Close();
                    item.SubItems.Add("R$" + sql_dr["valor_pago"].ToString());
                    item.SubItems.Add(sql_dr["contas"].ToString());
                    lstPagamentos.Items.Add(item);
                }
                btnRelatorio.Visible = true;
            }
            else
            {
                MessageBox.Show("Data não encontrada!", "Tente novamente");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstPagamentos.Items.Clear();
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

        private void GerarRelatorio()
        {
            Document doc = new Document(PageSize.A4);
            doc.SetMargins(40, 40, 40, 80);
            doc.AddCreationDate();
            string diretorio = @Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Relatório- " + cmbMes.Text + "." + cmbAno.Text + ".pdf";
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(diretorio, FileMode.Create));
            doc.Open();
            string dados = "";
            Paragraph title = new Paragraph(dados);
            title.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold);
            title.Alignment = Element.ALIGN_CENTER;
            title.Add("Relatório Mensal - " + cmbMes.Text + "/" + cmbAno.Text);
            doc.Add(title);
            Paragraph txtValores = new Paragraph(dados);
            txtValores.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 10);
            txtValores.Alignment = Element.ALIGN_LEFT;
            Paragraph finalizacao = new Paragraph(dados);
            finalizacao.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Italic);
            finalizacao.Alignment = Element.ALIGN_JUSTIFIED;
            title.Clear();
            title.Add("\n\n+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-\n\nContas Cadastradas no Mês:\n");
            doc.Add(title);
            clsContas objContas = new clsContas();
            MySqlDataReader sqldr =  objContas.GetContasByFiltro("where id_data = " + id_data);
            int j = 1;
            while (sqldr.Read())
            {
                txtValores.Add("\nConta nº " + j++ + "\nNome da Conta: " + sqldr["nome_conta"].ToString() + "\nValor: R$" + sqldr["valor_conta"].ToString());
                txtValores.Add("_____________________________________________________________________________________");
            }
            doc.Add(txtValores);
            finalizacao.Add("Valor Total: " + txtTotal.Text);
            doc.Add(finalizacao);
            finalizacao.Clear();
            title.Clear();
            title.Add("\n\n+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-\n\nPagamentos Lançados:\n");
            doc.Add(title);
            txtValores.Clear();
            for (int i = 0; i < lstPagamentos.Items.Count; i++)
            {
                txtValores.Add("\nPagamento nº " + (i + 1) + "\nMorador: " + lstPagamentos.Items[i].Text + "\nValor: " + lstPagamentos.Items[i].SubItems[1].Text + "\nContas Pagas: " + lstPagamentos.Items[i].SubItems[2].Text.Replace('|', ','));
                txtValores.Add("_____________________________________________________________________________________");
            }
            doc.Add(txtValores);
            finalizacao.Add("Valor Total Recebido: " + txtRecebido.Text);
            doc.Add(finalizacao);
            doc.Close();
            documento = doc;
        }

        private void EmitirRelatorio(object sender, EventArgs e)
        {
            try
            {
                GerarRelatorio();
                MessageBox.Show("O documento foi salvo em sua pasta 'Documentos'.", "Êxito");
            }
            catch
            {
                MessageBox.Show("Não foi possível exportar!", "ERRO");
            }
        }
    }
}
