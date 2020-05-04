namespace ContasRep
{
    partial class FRM_Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mPesquisar = new System.Windows.Forms.ToolStripMenuItem();
            this.mCalcular = new System.Windows.Forms.ToolStripMenuItem();
            this.mMoradores = new System.Windows.Forms.ToolStripMenuItem();
            this.mContas = new System.Windows.Forms.ToolStripMenuItem();
            this.mPagar = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Plum;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mPesquisar,
            this.mCalcular,
            this.mMoradores,
            this.mContas,
            this.mPagar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 80);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mPesquisar
            // 
            this.mPesquisar.Font = new System.Drawing.Font("MS Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mPesquisar.Image = global::ContasRep.Properties.Resources.iconfinder_11_Calendar_date_month_3104956;
            this.mPesquisar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mPesquisar.Name = "mPesquisar";
            this.mPesquisar.Size = new System.Drawing.Size(131, 76);
            this.mPesquisar.Text = "Pesquisar Data";
            this.mPesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mPesquisar.Click += new System.EventHandler(this.mFechamento_Click);
            // 
            // mCalcular
            // 
            this.mCalcular.Font = new System.Drawing.Font("MS Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mCalcular.Image = global::ContasRep.Properties.Resources.iconfinder_AccountingAuditor_4_2175890;
            this.mCalcular.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mCalcular.Name = "mCalcular";
            this.mCalcular.Size = new System.Drawing.Size(83, 76);
            this.mCalcular.Text = "Calcular";
            this.mCalcular.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mCalcular.Visible = false;
            this.mCalcular.Click += new System.EventHandler(this.mCalcular_Click);
            // 
            // mMoradores
            // 
            this.mMoradores.Font = new System.Drawing.Font("MS Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mMoradores.Image = global::ContasRep.Properties.Resources.iconfinder_jee_74_2180663;
            this.mMoradores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mMoradores.Name = "mMoradores";
            this.mMoradores.Size = new System.Drawing.Size(91, 76);
            this.mMoradores.Text = "Moradores";
            this.mMoradores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mMoradores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mMoradores.Click += new System.EventHandler(this.mMoradores_Click);
            // 
            // mContas
            // 
            this.mContas.Font = new System.Drawing.Font("MS Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mContas.Image = global::ContasRep.Properties.Resources.contrato__1_;
            this.mContas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mContas.Name = "mContas";
            this.mContas.Size = new System.Drawing.Size(76, 76);
            this.mContas.Text = "Contas";
            this.mContas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mContas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mContas.Click += new System.EventHandler(this.mContas_Click_1);
            // 
            // mPagar
            // 
            this.mPagar.Font = new System.Drawing.Font("MS Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mPagar.Image = global::ContasRep.Properties.Resources.pagar__1_;
            this.mPagar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mPagar.Name = "mPagar";
            this.mPagar.Size = new System.Drawing.Size(115, 76);
            this.mPagar.Text = "Pagar Contas";
            this.mPagar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mPagar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mPagar.Click += new System.EventHandler(this.mPagar_Click);
            // 
            // FRM_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 720);
            this.MinimumSize = new System.Drawing.Size(1200, 720);
            this.Name = "FRM_Principal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mês da Rep Gaymer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mPesquisar;
        private System.Windows.Forms.ToolStripMenuItem mCalcular;
        private System.Windows.Forms.ToolStripMenuItem mMoradores;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem mContas;
        private System.Windows.Forms.ToolStripMenuItem mPagar;
    }
}

