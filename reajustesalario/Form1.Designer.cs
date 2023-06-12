namespace reajustesalario
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPercentualReajust = new System.Windows.Forms.TextBox();
            this.lblTotalComReajust = new System.Windows.Forms.TextBox();
            this.lblTotalSemReajust = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvLeitura = new System.Windows.Forms.DataGridView();
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.BtnSelecionarArquivo = new System.Windows.Forms.Button();
            this.ofdListaFuncionarios = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeitura)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblPercentualReajust);
            this.panel1.Controls.Add(this.lblTotalComReajust);
            this.panel1.Controls.Add(this.lblTotalSemReajust);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(93, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 69);
            this.panel1.TabIndex = 6;
            // 
            // lblPercentualReajust
            // 
            this.lblPercentualReajust.Location = new System.Drawing.Point(455, 44);
            this.lblPercentualReajust.Name = "lblPercentualReajust";
            this.lblPercentualReajust.Size = new System.Drawing.Size(100, 22);
            this.lblPercentualReajust.TabIndex = 7;
            // 
            // lblTotalComReajust
            // 
            this.lblTotalComReajust.Location = new System.Drawing.Point(254, 44);
            this.lblTotalComReajust.Name = "lblTotalComReajust";
            this.lblTotalComReajust.Size = new System.Drawing.Size(100, 22);
            this.lblTotalComReajust.TabIndex = 6;
            // 
            // lblTotalSemReajust
            // 
            this.lblTotalSemReajust.Location = new System.Drawing.Point(51, 47);
            this.lblTotalSemReajust.Name = "lblTotalSemReajust";
            this.lblTotalSemReajust.Size = new System.Drawing.Size(100, 22);
            this.lblTotalSemReajust.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(404, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Percentual reajuste";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(206, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total com reajuste";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Total sem reajuste";
            // 
            // dgvLeitura
            // 
            this.dgvLeitura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeitura.Location = new System.Drawing.Point(93, 136);
            this.dgvLeitura.Name = "dgvLeitura";
            this.dgvLeitura.RowHeadersWidth = 51;
            this.dgvLeitura.RowTemplate.Height = 24;
            this.dgvLeitura.Size = new System.Drawing.Size(555, 284);
            this.dgvLeitura.TabIndex = 7;
            this.dgvLeitura.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLeitura_CellContentClick);
            // 
            // txtArquivo
            // 
            this.txtArquivo.Location = new System.Drawing.Point(93, 12);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(513, 22);
            this.txtArquivo.TabIndex = 8;
            // 
            // BtnSelecionarArquivo
            // 
            this.BtnSelecionarArquivo.Location = new System.Drawing.Point(612, 11);
            this.BtnSelecionarArquivo.Name = "BtnSelecionarArquivo";
            this.BtnSelecionarArquivo.Size = new System.Drawing.Size(36, 23);
            this.BtnSelecionarArquivo.TabIndex = 9;
            this.BtnSelecionarArquivo.Text = "...";
            this.BtnSelecionarArquivo.UseVisualStyleBackColor = true;
            this.BtnSelecionarArquivo.Click += new System.EventHandler(this.BtnSelecionarArquivo_Click);
            // 
            // ofdListaFuncionarios
            // 
            this.ofdListaFuncionarios.DefaultExt = "*.txt:";
            this.ofdListaFuncionarios.FileName = "openFileDialog1";
            this.ofdListaFuncionarios.Filter = "Arquivos de texto|*.txt:";
            this.ofdListaFuncionarios.Title = "Seleção do arquivo com dados de funcionários";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSelecionarArquivo);
            this.Controls.Add(this.txtArquivo);
            this.Controls.Add(this.dgvLeitura);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeitura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox lblPercentualReajust;
        private System.Windows.Forms.TextBox lblTotalComReajust;
        private System.Windows.Forms.TextBox lblTotalSemReajust;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvLeitura;
        private System.Windows.Forms.TextBox txtArquivo;
        private System.Windows.Forms.Button BtnSelecionarArquivo;
        private System.Windows.Forms.OpenFileDialog ofdListaFuncionarios;
    }
}

