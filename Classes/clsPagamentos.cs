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
    class clsPagamentos
    {
        public string ds_msg;
        int mId_Pagamento, mId_Morador, mId_Data;
        double mValor_Pago;

        public int Id_Morador
        {
            get { return mId_Morador; }
            set { mId_Morador = value; }
        }
        public int Id_Pagamento
        {
            get { return mId_Pagamento; }
            set { mId_Pagamento = value; }
        }
        public int Id_Data
        {
            get { return mId_Data; }
            set { mId_Data = value; }
        }
        public double Valor_Pago
        {
            get { return mValor_Pago; }
            set { mValor_Pago = value; }
        }

        public string Pagar()
        {
            try
            {
                clsConexao instancia_conexao = new clsConexao();
                var valor = Valor_Pago.ToString().Replace(',', '.');
                string query = "insert into tb_pagamentos values (0, " + Id_Morador.ToString() + ", " + Id_Data.ToString() + ", " + valor + ")";
                MySqlCommand sql_cmd = new MySqlCommand(query);
                instancia_conexao.CRUD(sql_cmd);
                if (!Equals(ds_msg, "Erro ao registrar pagamentos! Pode ser que algum pagamento não tenha sido registrado com sucesso. "))
                ds_msg = "Pagamentos registrados com sucesso! ";
            }
            catch (Exception ex)
            {
                ds_msg = "Erro ao registrar pagamentos! Pode ser que algum pagamento não tenha sido registrado com sucesso. " + ex.Message;
            }
            return ds_msg;
        }
    }
}
