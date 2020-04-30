using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace ContasRep.Classes
{
    class clsData
    {
        public string ds_msg;

        int mId_data, mMes, mAno;
        float mQuantia_total, mQuantia_individual, mQuantia_Recebida;

        public int Id_data
        {
            get { return mId_data; }
            set { mId_data = value; }
        }
        public int Mes
        {
            get { return mMes; }
            set { mMes = value; }
        }
        public int Ano
        {
            get { return mAno; }
            set { mAno = value; }
        }
        public float Quantia_total
        {
            get { return mQuantia_total; }
            set { mQuantia_total = value; }
        }
        public float Quantia_individual
        {
            get { return mQuantia_individual; }
            set { mQuantia_individual = value; }
        }
        public float Quantia_Recebida
        {
            get { return mQuantia_Recebida; }
            set { mQuantia_Recebida = value; }
        }

        public MySqlDataReader GetDataById(int id)
        {
            clsConexao instancia_cnx = new clsConexao();
            MySqlCommand sql_cmd = new MySqlCommand();
            sql_cmd.CommandType = CommandType.Text;
            string sql_query = "SELECT id_data, mes, ano, quantia_total, quantia_Recebida FROM tb_data where id_data = " + id.ToString();
            sql_cmd.CommandText = sql_query;
            MySqlDataReader sql_dr = instancia_cnx.selecionar(sql_cmd);
            return sql_dr;
        }

        public int GetIdByData(int mes, int ano)
        {
            int id = 0;
            clsConexao instancia_cnx = new clsConexao();
            MySqlCommand sql_cmd = new MySqlCommand();
            sql_cmd.CommandType = CommandType.Text;
            string sql_query = "SELECT id_data, mes, ano, quantia_total, quantia_Recebida FROM tb_data where mes = " + mes.ToString() + " and ano = " + ano.ToString();
            sql_cmd.CommandText = sql_query;
            MySqlDataReader sql_dr = instancia_cnx.selecionar(sql_cmd);
            if (sql_dr.Read())
            {
                id = Convert.ToInt32(sql_dr["id_data"]);
            }
            return id;
        }

        public MySqlDataReader GetAllData()
        {
            clsConexao instancia_cnx = new clsConexao();
            MySqlCommand sql_cmd = new MySqlCommand();
            sql_cmd.CommandType = CommandType.Text;
            string sql_query = "SELECT id_data, mes, ano, quantia_total, quantia_Recebida FROM tb_data";
            sql_cmd.CommandText = sql_query;
            MySqlDataReader sql_dr = instancia_cnx.selecionar(sql_cmd);
            return sql_dr;
        }

        public void AddConta(float valor, int idData)
        {
            float quantia_total;
            clsConexao instancia_conexao = new clsConexao();
            MySqlCommand sql_cmd2 = new MySqlCommand("select quantia_total from tb_data where id_data = " + idData);
            MySqlDataReader sql_dr = instancia_conexao.selecionar(sql_cmd2);
            if (sql_dr.Read())
            {
                quantia_total = float.Parse(sql_dr["quantia_total"].ToString());
                string query = "update tb_data set quantia_total = " + (quantia_total + valor).ToString().Replace(',', '.') + " where id_data = " + idData;
                MySqlCommand sql_cmd = new MySqlCommand(query);
                sql_dr.Close();
                instancia_conexao.CRUD(sql_cmd);
            }
            
        }

        public void RemoveConta(float valor, int idData)
        {
            float quantia_total;
            clsConexao instancia_conexao = new clsConexao();
            MySqlCommand sql_cmd2 = new MySqlCommand("select quantia_total from tb_data where id_data = " + idData);
            MySqlDataReader sql_dr = instancia_conexao.selecionar(sql_cmd2);
            if (sql_dr.Read())
            {
                quantia_total = float.Parse(sql_dr["quantia_total"].ToString());
                string query = "update tb_data set quantia_total = " + (quantia_total - valor).ToString().Replace(',', '.') + " where id_data = " + idData;
                MySqlCommand sql_cmd = new MySqlCommand(query);
                sql_dr.Close();
                instancia_conexao.CRUD(sql_cmd);
            }

        }

        public string insertAno()
        {
            clsConexao instancia = new clsConexao();
            MySqlCommand sql_cmd2 = new MySqlCommand("select id_data from tb_data where ano = " + Ano);
            MySqlDataReader sql_dr = instancia.selecionar(sql_cmd2);
            if (!sql_dr.Read())
            {
                try
                {
                    clsConexao instancia_conexao = new clsConexao();
                    string query = "insert into tb_data values" +
                                    "(0, 1, " + Ano + ", 0, 0)," +
                                    "(0, 2, " + Ano + ", 0, 0)," +
                                    "(0, 3, " + Ano + ", 0, 0)," +
                                    "(0, 4, " + Ano + ", 0, 0)," +
                                    "(0, 5, " + Ano + ", 0, 0)," +
                                    "(0, 6, " + Ano + ", 0, 0)," +
                                    "(0, 7, " + Ano + ", 0, 0)," +
                                    "(0, 8, " + Ano + ", 0, 0)," +
                                    "(0, 9, " + Ano + ", 0, 0)," +
                                    "(0, 10, " + Ano + ", 0, 0)," +
                                    "(0, 11, " + Ano + ", 0, 0)," +
                                    "(0, 12, " + Ano + ", 0, 0);";
                    MySqlCommand sql_cmd = new MySqlCommand(query);
                    instancia_conexao.CRUD(sql_cmd);
                    ds_msg = "Ano inserido com sucesso!";
                }
                catch (Exception ex)
                {
                    ds_msg = "Erro ao inserir Ano!" + ex.Message;
                }
            }
            else
            {
                ds_msg = "O ano já existe no banco de dados!";
            }
            return ds_msg;
        }

        public string AddPagamento(double quantia_recebida)
        {
            clsConexao instancia_conexao = new clsConexao();
            try
            {
                var valor = quantia_recebida.ToString().Replace(',', '.');
                string query = "update tb_data set quantia_recebida = " + valor + " where id_data = " + Id_data;
                MySqlCommand sql_cmd = new MySqlCommand(query);
                instancia_conexao.CRUD(sql_cmd);
                ds_msg = "Pagamento registrado com sucesso na data selecionada.";
            }
            catch
            {
                ds_msg = "Erro ao registrar pagamento na data selecionada.";
            }
            return ds_msg;
        }
    }
}
