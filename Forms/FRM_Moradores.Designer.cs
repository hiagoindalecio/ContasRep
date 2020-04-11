namespace ContasRep
{
    partial class FRM_Moradores
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstMoradores = new System.Windows.Forms.ListView();
            this.clnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnAtivo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Moradores";
            // 
            // lstMoradores
            // 
            this.lstMoradores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnId,
            this.clnNome,
            this.clnAtivo});
            this.lstMoradores.FullRowSelect = true;
            this.lstMoradores.Location = new System.Drawing.Point(6, 25);
            this.lstMoradores.MultiSelect = false;
            this.lstMoradores.Name = "lstMoradores";
            this.lstMoradores.Size = new System.Drawing.Size(859, 408);
            this.lstMoradores.TabIndex = 2;
            this.lstMoradores.UseCompatibleStateImageBehavior = false;
            this.lstMoradores.View = System.Windows.Forms.View.Details;
            this.lstMoradores.SelectedIndexChanged += new System.EventHandler(this.SelecionarIndice);
            // 
            // clnId
            // 
            this.clnId.Text = "ID";
            // 
            // clnNome
            // 
            this.clnNome.Text = "Nome";
            this.clnNome.Width = 613;
            // 
            // clnAtivo
            // 
            this.clnAtivo.Text = "Ativo";
            this.clnAtivo.Width = 181;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdicionar);
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.lstMoradores);
            this.groupBox1.Font = new System.Drawing.Font("MS Gothic", 14F);
            this.groupBox1.Location = new System.Drawing.Point(16, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1081, 447);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Moradores Cadastrados";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(871, 137);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(197, 50);
            this.btnAdicionar.TabIndex = 5;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(871, 81);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(197, 50);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(871, 25);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(197, 50);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // FRM_Moradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Moradores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Moradores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstMoradores;
        private System.Windows.Forms.ColumnHeader clnNome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ColumnHeader clnId;
        private System.Windows.Forms.ColumnHeader clnAtivo;
    }
}