using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContasRep
{
    public partial class FRM_Fechamento : Form
    {
        public FRM_Fechamento()
        {
            InitializeComponent();
            Parametros();
        }

        public void Parametros()
        {
            this.Top = 0;
            this.Left = 0;
            this.Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            this.Height = 750;
            txtAno.MaxLength = 4;
            cmbMes.Focus();
        }

        private void ValidarAno(object sender, KeyPressEventArgs e)
        {
            if (txtAno.TextLength < 2)
            {
                txtAno.Text = "20";
                txtAno.SelectionStart = 2;
            }
            if (e.KeyChar == 08 && txtAno.TextLength <= 2)
            {
                e.Handled = true;
            }
            else if (!(char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void ValidarDinheiro(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
