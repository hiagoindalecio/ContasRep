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

namespace ContasRep
{
    public partial class FRM_Principal : Form
    {
        public FRM_Principal()
        {
            InitializeComponent();
            string dados = clsDados.BuscarDados();
            //MessageBox.Show(dados, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            mContas.Visible = true;
            mContas.Enabled = true;
        }

        private static FRM_Principal instance;

        public static FRM_Principal Instance()
        {
            if (instance == null)
            {
                instance = new FRM_Principal();
            }
            return instance;
        }

        private void mFechamento_Click(object sender, EventArgs e)
        {
            for (int intIndex = Application.OpenForms.Count - 1; intIndex > 0; intIndex--)
            {
                if (Application.OpenForms[intIndex] != this)
                    Application.OpenForms[intIndex].Close();
            }
            FRM_Pesquisar form_pesquisar = new FRM_Pesquisar();
            form_pesquisar.MdiParent = this;
            form_pesquisar.Show();
        }

        private void mCalcular_Click(object sender, EventArgs e)
        {
            for (int intIndex = Application.OpenForms.Count - 1; intIndex > 0; intIndex--)
            {
                if (Application.OpenForms[intIndex] != this)
                    Application.OpenForms[intIndex].Close();
            }
            FRM_Calculo form_calculo = new FRM_Calculo();
            form_calculo.MdiParent = this;
            form_calculo.Show();
        }

        private void mMoradores_Click(object sender, EventArgs e)
        {
            for (int intIndex = Application.OpenForms.Count - 1; intIndex > 0; intIndex--)
            {
                if (Application.OpenForms[intIndex] != this)
                    Application.OpenForms[intIndex].Close();
            }
            FRM_Moradores form_moradores = new FRM_Moradores();
            form_moradores.MdiParent = this;
            form_moradores.Show();
        }

        private void mContas_Click_1(object sender, EventArgs e)
        {
            for (int intIndex = Application.OpenForms.Count - 1; intIndex > 0; intIndex--)
            {
                if (Application.OpenForms[intIndex] != this)
                    Application.OpenForms[intIndex].Close();
            }
            FRM_Contas form_contas = new FRM_Contas();
            form_contas.MdiParent = this;
            form_contas.Show();
        }

        private void mPagar_Click(object sender, EventArgs e)
        {
            for (int intIndex = Application.OpenForms.Count - 1; intIndex > 0; intIndex--)
            {
                if (Application.OpenForms[intIndex] != this)
                    Application.OpenForms[intIndex].Close();
            }
            FRM_Pagar form_pagar = new FRM_Pagar();
            form_pagar.MdiParent = this;
            form_pagar.Show();
        }


    }
}
