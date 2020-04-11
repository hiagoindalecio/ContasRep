namespace ContasRep
{
    partial class FRM_Contas
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
            this.lstContas = new System.Windows.Forms.ListView();
            this.clnNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnValor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbAno = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contas";
            // 
            // lstContas
            // 
            this.lstContas.BackColor = System.Drawing.Color.Violet;
            this.lstContas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnNome,
            this.clnValor});
            this.lstContas.Font = new System.Drawing.Font("MS Gothic", 12F);
            this.lstContas.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lstContas.FullRowSelect = true;
            this.lstContas.Location = new System.Drawing.Point(6, 20);
            this.lstContas.Name = "lstContas";
            this.lstContas.Size = new System.Drawing.Size(784, 280);
            this.lstContas.TabIndex = 2;
            this.lstContas.UseCompatibleStateImageBehavior = false;
            this.lstContas.View = System.Windows.Forms.View.Details;
            this.lstContas.SelectedIndexChanged += new System.EventHandler(this.SelecionarIndice);
            // 
            // clnNome
            // 
            this.clnNome.Text = "Nome";
            this.clnNome.Width = 534;
            // 
            // clnValor
            // 
            this.clnValor.Text = "Valor";
            this.clnValor.Width = 242;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdicionar);
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.lstContas);
            this.groupBox1.Font = new System.Drawing.Font("MS Gothic", 14F);
            this.groupBox1.Location = new System.Drawing.Point(16, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1005, 305);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contas Cadastradas";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(796, 132);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(197, 50);
            this.btnAdicionar.TabIndex = 7;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(796, 76);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(197, 50);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(796, 20);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(197, 50);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.cmbMes);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.cmbAno);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("MS Gothic", 14F);
            this.groupBox2.Location = new System.Drawing.Point(16, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1005, 96);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pesquisa";
            // 
            // cmbMes
            // 
            this.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMes.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cmbMes.Location = new System.Drawing.Point(73, 44);
            this.cmbMes.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(47, 27);
            this.cmbMes.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 45;
            this.label2.Text = "Mês: ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.button1.Image = global::ContasRep.Properties.Resources.procurar;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(257, 37);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 36);
            this.button1.TabIndex = 49;
            this.button1.Text = "Pesquisar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbAno
            // 
            this.cmbAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAno.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmbAno.FormattingEnabled = true;
            this.cmbAno.Location = new System.Drawing.Point(175, 43);
            this.cmbAno.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAno.Name = "cmbAno";
            this.cmbAno.Size = new System.Drawing.Size(74, 27);
            this.cmbAno.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 47;
            this.label3.Text = "Ano: ";
            // 
            // FRM_Contas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Contas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstContas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader clnNome;
        private System.Windows.Forms.ColumnHeader clnValor;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbAno;
        private System.Windows.Forms.Label label3;
    }
}