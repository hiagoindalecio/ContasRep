namespace ContasRep
{
    partial class FRM_AddMorador
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
            this.cmbAtivo = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbAtivo);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(13, 97);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(413, 158);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Novo Morador";
            this.groupBox1.UseWaitCursor = true;
            // 
            // cmbAtivo
            // 
            this.cmbAtivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAtivo.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmbAtivo.FormattingEnabled = true;
            this.cmbAtivo.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cmbAtivo.Location = new System.Drawing.Point(96, 65);
            this.cmbAtivo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAtivo.Name = "cmbAtivo";
            this.cmbAtivo.Size = new System.Drawing.Size(104, 27);
            this.cmbAtivo.TabIndex = 46;
            this.cmbAtivo.UseWaitCursor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(279, 104);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 36);
            this.button2.TabIndex = 45;
            this.button2.Text = "Salvar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.UseWaitCursor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.label8.Text = "Ativo:";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 24);
            this.label1.TabIndex = 47;
            this.label1.Text = "Adicionar Morador";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.UseWaitCursor = true;
            // 
            // FRM_AddMorador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 271);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(455, 310);
            this.MinimumSize = new System.Drawing.Size(455, 310);
            this.Name = "FRM_AddMorador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Morador";
            this.UseWaitCursor = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAtivo;
    }
}