namespace ContasRep
{
    partial class FRM_Pagar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.cmbMoradores = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstContas = new System.Windows.Forms.ListView();
            this.clnNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnValor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbAno = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbMes);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cmbAno);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnPagar);
            this.groupBox1.Controls.Add(this.cmbMoradores);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lstContas);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(13, 59);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(799, 501);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecionar Mês";
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(404, 104);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(108, 43);
            this.btnPagar.TabIndex = 49;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            // 
            // cmbMoradores
            // 
            this.cmbMoradores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMoradores.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmbMoradores.FormattingEnabled = true;
            this.cmbMoradores.Location = new System.Drawing.Point(99, 120);
            this.cmbMoradores.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMoradores.Name = "cmbMoradores";
            this.cmbMoradores.Size = new System.Drawing.Size(158, 27);
            this.cmbMoradores.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 123);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 19);
            this.label6.TabIndex = 47;
            this.label6.Text = "Morador: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 192);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 19);
            this.label5.TabIndex = 46;
            this.label5.Text = "Contas: ";
            // 
            // lstContas
            // 
            this.lstContas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnNome,
            this.clnValor});
            this.lstContas.Font = new System.Drawing.Font("MS Gothic", 12F);
            this.lstContas.Location = new System.Drawing.Point(7, 214);
            this.lstContas.Name = "lstContas";
            this.lstContas.Size = new System.Drawing.Size(784, 280);
            this.lstContas.TabIndex = 45;
            this.lstContas.UseCompatibleStateImageBehavior = false;
            // 
            // clnNome
            // 
            this.clnNome.Text = "Nome";
            // 
            // clnValor
            // 
            this.clnValor.Text = "Valor";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("MS Gothic", 14.25F);
            this.txtTotal.Location = new System.Drawing.Point(155, 76);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(149, 26);
            this.txtTotal.TabIndex = 39;
            this.txtTotal.Text = "R$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 79);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 19);
            this.label4.TabIndex = 38;
            this.label4.Text = "Total Contas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 47;
            this.label1.Text = "Pagar";
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
            this.cmbMes.Location = new System.Drawing.Point(54, 36);
            this.cmbMes.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(47, 27);
            this.cmbMes.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 50;
            this.label2.Text = "Mês: ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.button1.Image = global::ContasRep.Properties.Resources.procurar;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(238, 29);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 36);
            this.button1.TabIndex = 54;
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
            this.cmbAno.Location = new System.Drawing.Point(156, 35);
            this.cmbAno.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAno.Name = "cmbAno";
            this.cmbAno.Size = new System.Drawing.Size(74, 27);
            this.cmbAno.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 52;
            this.label3.Text = "Ano: ";
            // 
            // FRM_Pagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Pagar";
            this.ShowInTaskbar = false;
            this.Text = "Pagar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lstContas;
        private System.Windows.Forms.ColumnHeader clnNome;
        private System.Windows.Forms.ColumnHeader clnValor;
        private System.Windows.Forms.ComboBox cmbMoradores;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbAno;
        private System.Windows.Forms.Label label3;
    }
}