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
    public partial class FRM_AddAno : Form
    {
        public FRM_AddAno()
        {
            InitializeComponent();
        }

        public void inserir()
        {
            clsData objData = new clsData();
            objData.Ano = Convert.ToInt32(txtAno.Text);
            MessageBox.Show(objData.insertAno());
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            inserir();
        }
    }
}
