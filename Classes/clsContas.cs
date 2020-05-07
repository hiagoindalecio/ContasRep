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
    class clsContas
    {
        public string ds_msg;

        int mId_Data, mId_Conta, mPaga;
        string mNome_Conta, mValor_Conta;

        public int Id_Data
        {
            get { return mId_Data; }
            set { mId_Data = value; }
        }
        public int Id_Conta
        {
            get { return mId_Conta; }
            set { mId_Conta = value; }
        }
        public string Nome_Conta
        {
            get { return mNome_Conta; }
            set { mNome_Conta = value; }
        }
        public string Valor_Conta
        {
            get { return mValor_Conta; }
            set { mValor_Conta = value; }
        }
        public int Paga
        {
            get { return mPaga; }
            set { mPaga = value; }
        }

        public MySqlDataReader GetContasByFiltro(string filtro)
        {
            clsConexao instancia_cnx = new clsConexao();
            MySqlCommand sql_cmd = new MySqlCommand();
            sql_cmd.CommandType = CommandType.Text;
            string sql_query = "SELECT id_conta, nome_conta, valor_conta, paga FROM tb_contas " + filtro;
            sql_cmd.CommandText = sql_query;
            MySqlDataReader sql_dr = instancia_cnx.selecionar(sql_cmd);
            return sql_dr;
        }

        public int GetId()
        {
            int id = 0;
            clsConexao instancia_cnx = new clsConexao();
            MySqlCommand sql_cmd = new MySqlCommand();
            sql_cmd.CommandType = CommandType.Text;
            string valor = Valor_Conta.Replace(',', '.');
            string sql_query = "SELECT id_conta FROM tb_contas where nome_conta = '" + Nome_Conta + "' and round(valor_conta,2) = " + valor + " and id_data = " + Id_Data;
            sql_cmd.CommandText = sql_query;
            MySqlDataReader sql_dr = instancia_cnx.selecionar(sql_cmd);
            if (sql_dr.Read())
            {
                id = int.Parse(sql_dr["id_conta"].ToString());
            }
            return id;
        }

        public string insert()
        {
            try
            {
                clsConexao instancia_conexao = new clsConexao();
                string query = "insert into tb_contas values (0, " + Id_Data + ", '" + Nome_Conta + "', " + Valor_Conta + 0 + ");";
                MySqlCommand sql_cmd = new MySqlCommand(query);
                instancia_conexao.CRUD(sql_cmd);
                ds_msg = "Conta inserida com sucesso!";
            }
            catch (Exception ex)
            {
                ds_msg = "Erro ao inserir conta!" + ex.Message;
            }
            return ds_msg;
        }

        public string update()
        {
            try
            {
                clsConexao instancia_conexao = new clsConexao();
                string query = "update tb_contas set nome_conta = '" + Nome_Conta + "', valor_conta = " + Valor_Conta + ", paga = " + Paga + " where id_conta = " + Id_Conta;
                MySqlCommand sql_cmd = new MySqlCommand(query);
                instancia_conexao.CRUD(sql_cmd);
                ds_msg = "Conta atualizada com sucesso!";
            }
            catch (Exception ex)
            {
                ds_msg = "Erro ao atualizada conta!" + ex.Message;
            }
            return ds_msg;
        }

        public string delete()
        {
            try
            {
                clsConexao instancia_conexao = new clsConexao();
                string query = "delete from tb_contas where id_conta = " + Id_Conta + ";";
                MySqlCommand sql_cmd = new MySqlCommand(query);
                instancia_conexao.CRUD(sql_cmd);
                ds_msg = "Conta excluida com sucesso!";
            }
            catch (Exception ex)
            {
                ds_msg = "Erro ao excluir conta!" + ex.Message;
            }
            return ds_msg;
        }
    }
}
