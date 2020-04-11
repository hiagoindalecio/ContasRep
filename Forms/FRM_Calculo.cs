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
    public partial class FRM_Calculo : Form
    {
        public FRM_Calculo()
        {
            InitializeComponent();
            Parametros();
        }

        private static FRM_Calculo instance;

        public static FRM_Calculo Instance()
        {
            if (instance == null)
            {
                instance = new FRM_Calculo();
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
    }
}
