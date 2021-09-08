
namespace WindowsFormsApp2
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
            this.btn01 = new System.Windows.Forms.Button();
            this.btn02 = new System.Windows.Forms.Button();
            this.btn03 = new System.Windows.Forms.Button();
            this.btn04 = new System.Windows.Forms.Button();
            this.btn05 = new System.Windows.Forms.Button();
            this.btn06 = new System.Windows.Forms.Button();
            this.btn07 = new System.Windows.Forms.Button();
            this.btn08 = new System.Windows.Forms.Button();
            this.btn09 = new System.Windows.Forms.Button();
            this.btnRandomTabela = new System.Windows.Forms.Button();
            this.txtProcura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.dgInformacao = new System.Windows.Forms.DataGridView();
            this.dgPalavra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgInformacao)).BeginInit();
            this.SuspendLayout();
            // 
            // btn01
            // 
            this.btn01.Location = new System.Drawing.Point(12, 12);
            this.btn01.Name = "btn01";
            this.btn01.Size = new System.Drawing.Size(83, 45);
            this.btn01.TabIndex = 2;
            this.btn01.UseVisualStyleBackColor = true;
            // 
            // btn02
            // 
            this.btn02.Location = new System.Drawing.Point(101, 12);
            this.btn02.Name = "btn02";
            this.btn02.Size = new System.Drawing.Size(83, 45);
            this.btn02.TabIndex = 3;
            this.btn02.UseVisualStyleBackColor = true;
            // 
            // btn03
            // 
            this.btn03.Location = new System.Drawing.Point(190, 12);
            this.btn03.Name = "btn03";
            this.btn03.Size = new System.Drawing.Size(83, 45);
            this.btn03.TabIndex = 4;
            this.btn03.UseVisualStyleBackColor = true;
            // 
            // btn04
            // 
            this.btn04.Location = new System.Drawing.Point(12, 63);
            this.btn04.Name = "btn04";
            this.btn04.Size = new System.Drawing.Size(83, 45);
            this.btn04.TabIndex = 5;
            this.btn04.UseVisualStyleBackColor = true;
            // 
            // btn05
            // 
            this.btn05.Location = new System.Drawing.Point(101, 63);
            this.btn05.Name = "btn05";
            this.btn05.Size = new System.Drawing.Size(83, 45);
            this.btn05.TabIndex = 6;
            this.btn05.UseVisualStyleBackColor = true;
            // 
            // btn06
            // 
            this.btn06.Location = new System.Drawing.Point(190, 63);
            this.btn06.Name = "btn06";
            this.btn06.Size = new System.Drawing.Size(83, 45);
            this.btn06.TabIndex = 7;
            this.btn06.UseVisualStyleBackColor = true;
            // 
            // btn07
            // 
            this.btn07.Location = new System.Drawing.Point(12, 114);
            this.btn07.Name = "btn07";
            this.btn07.Size = new System.Drawing.Size(83, 45);
            this.btn07.TabIndex = 8;
            this.btn07.UseVisualStyleBackColor = true;
            // 
            // btn08
            // 
            this.btn08.Location = new System.Drawing.Point(101, 114);
            this.btn08.Name = "btn08";
            this.btn08.Size = new System.Drawing.Size(83, 45);
            this.btn08.TabIndex = 9;
            this.btn08.UseVisualStyleBackColor = true;
            // 
            // btn09
            // 
            this.btn09.Location = new System.Drawing.Point(190, 114);
            this.btn09.Name = "btn09";
            this.btn09.Size = new System.Drawing.Size(83, 45);
            this.btn09.TabIndex = 10;
            this.btn09.UseVisualStyleBackColor = true;
            // 
            // btnRandomTabela
            // 
            this.btnRandomTabela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRandomTabela.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRandomTabela.Location = new System.Drawing.Point(300, 12);
            this.btnRandomTabela.Name = "btnRandomTabela";
            this.btnRandomTabela.Size = new System.Drawing.Size(101, 147);
            this.btnRandomTabela.TabIndex = 11;
            this.btnRandomTabela.Text = "Gerar Novo\r\nCaça Palavra\r\n";
            this.btnRandomTabela.UseVisualStyleBackColor = false;
            this.btnRandomTabela.Click += new System.EventHandler(this.btnRandomTabela_Click);
            // 
            // txtProcura
            // 
            this.txtProcura.Location = new System.Drawing.Point(12, 205);
            this.txtProcura.Name = "txtProcura";
            this.txtProcura.Size = new System.Drawing.Size(260, 20);
            this.txtProcura.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Procure a palavra";
            // 
            // btnProcurar
            // 
            this.btnProcurar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnProcurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProcurar.Location = new System.Drawing.Point(60, 231);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(146, 45);
            this.btnProcurar.TabIndex = 16;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = false;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // dgInformacao
            // 
            this.dgInformacao.AllowUserToAddRows = false;
            this.dgInformacao.AllowUserToDeleteRows = false;
            this.dgInformacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInformacao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgPalavra});
            this.dgInformacao.Location = new System.Drawing.Point(430, 12);
            this.dgInformacao.Name = "dgInformacao";
            this.dgInformacao.ReadOnly = true;
            this.dgInformacao.Size = new System.Drawing.Size(245, 150);
            this.dgInformacao.TabIndex = 17;
            // 
            // dgPalavra
            // 
            this.dgPalavra.HeaderText = "Palavra";
            this.dgPalavra.Name = "dgPalavra";
            this.dgPalavra.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 460);
            this.Controls.Add(this.dgInformacao);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProcura);
            this.Controls.Add(this.btnRandomTabela);
            this.Controls.Add(this.btn09);
            this.Controls.Add(this.btn08);
            this.Controls.Add(this.btn07);
            this.Controls.Add(this.btn06);
            this.Controls.Add(this.btn05);
            this.Controls.Add(this.btn04);
            this.Controls.Add(this.btn03);
            this.Controls.Add(this.btn02);
            this.Controls.Add(this.btn01);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgInformacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn01;
        private System.Windows.Forms.Button btn02;
        private System.Windows.Forms.Button btn03;
        private System.Windows.Forms.Button btn04;
        private System.Windows.Forms.Button btn05;
        private System.Windows.Forms.Button btn06;
        private System.Windows.Forms.Button btn07;
        private System.Windows.Forms.Button btn08;
        private System.Windows.Forms.Button btn09;
        private System.Windows.Forms.Button btnRandomTabela;
        private System.Windows.Forms.TextBox txtProcura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.DataGridView dgInformacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPalavra;
    }
}

