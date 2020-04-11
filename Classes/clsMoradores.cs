using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace ContasRep.Classes
{
    class clsMoradores
    {
        public string ds_msg;

        int mId_Morador;
        string mNome_Morador;
        bool mAtivo;

        public int Id_Morador
        {
            get { return mId_Morador; }
            set { mId_Morador = value; }
        }
        public string Nome_Morador
        {
            get { return mNome_Morador; }
            set { mNome_Morador = value; }
        }
        public bool Ativo
        {
            get { return mAtivo; }
            set { mAtivo = value; }
        }

        public string delete()
        {
            try
            {
                clsConexao instancia_conexao = new clsConexao();
                string nome = Nome_Morador;
                bool atividade = Ativo;
                string query = "delete from tb_moradores where tb_moradores.id_morador = " + Id_Morador + ";";
                MySqlCommand sql_cmd = new MySqlCommand(query);
                instancia_conexao.CRUD(sql_cmd);
                ds_msg = "Morador excluido com sucesso!";
            }
            catch (Exception ex)
            {
                ds_msg = "Erro ao excluir morador!" + ex.Message;
            }
            return ds_msg;
        }

        public string insert()
        {
            try
            {
                clsConexao instancia_conexao = new clsConexao();
                string nome = Nome_Morador;
                bool atividade = Ativo;
                string query = "insert into tb_moradores values (0, '" + nome + "', " + atividade + ");";
                MySqlCommand sql_cmd = new MySqlCommand(query);
                instancia_conexao.CRUD(sql_cmd);
                ds_msg = "Morador inserido com sucesso!";
            }
            catch (Exception ex)
            {
                ds_msg = "Erro ao inserir morador!" + ex.Message;
            }
            return ds_msg;
        }

        public string update()
        {
            try
            {
                clsConexao instancia_conexao = new clsConexao();
                string nome = Nome_Morador;
                bool atividade = Ativo;
                string query = "update tb_moradores set nome = '" + nome + "', ativo = " + atividade + " where id_morador = " + Id_Morador + ";";
                MySqlCommand sql_cmd = new MySqlCommand(query);
                instancia_conexao.CRUD(sql_cmd);
                ds_msg = "Morador atualizado com sucesso!";
            }
            catch (Exception ex)
            {
                ds_msg = "Erro ao atualizar morador!" + ex.Message;
            }
            return ds_msg;
        }

        public MySqlDataReader GetAllMoradores()
        {
            clsConexao instancia_cnx = new clsConexao();
            MySqlCommand sql_cmd = new MySqlCommand();
            sql_cmd.CommandType = CommandType.Text;
            string sql_query = "SELECT id_morador, nome, ativo FROM tb_moradores";
            sql_cmd.CommandText = sql_query;
            MySqlDataReader sql_dr = instancia_cnx.selecionar(sql_cmd);
            return sql_dr;
        }

        public MySqlDataReader GetMoradorByID(int id)
        {
            clsConexao instancia_cnx = new clsConexao();
            MySqlCommand sql_cmd = new MySqlCommand();
            sql_cmd.CommandType = CommandType.Text;
            string sql_query = "SELECT id_morador, nome, ativo FROM tb_moradores where id_morador = " + id.ToString();
            sql_cmd.CommandText = sql_query;
            MySqlDataReader sql_dr = instancia_cnx.selecionar(sql_cmd);
            return sql_dr;
        }
    }
}
