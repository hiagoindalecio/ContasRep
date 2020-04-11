namespace ContasRep
{
    partial class FRM_AddConta
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 24);
            this.label1.TabIndex = 49;
            this.label1.Text = "Adicionar Conta";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.UseWaitCursor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtValor);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(10, 96);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(413, 158);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Novo Morador";
            this.groupBox1.UseWaitCursor = true;
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("MS Gothic", 14.25F);
            this.txtValor.Location = new System.Drawing.Point(96, 65);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(148, 26);
            this.txtValor.TabIndex = 46;
            this.txtValor.Text = "R$";
            this.txtValor.UseWaitCursor = true;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarDinheiro);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.Location = new System.Drawing.Point(279, 104);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(126, 36);
            this.btnSalvar.TabIndex = 45;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.UseWaitCursor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("MS Gothic", 14.25F);
            this.txtNome.Location = new System.Drawing.Point(96, 34);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(309, 26);
            this.txtNome.TabIndex = 39;
            this.txtNome.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 68);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 19);
            this.label8.TabIndex = 36;
            this.label8.Text = "Valor:";
            this.label8.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 38;
            this.label4.Text = "Nome:";
            this.label4.UseWaitCursor = true;
            // 
            // FRM_AddConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 271);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(455, 310);
            this.MinimumSize = new System.Drawing.Size(455, 310);
            this.Name = "FRM_AddConta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Conta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValor;
    }
}