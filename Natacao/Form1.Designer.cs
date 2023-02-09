
namespace Natacao
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUltimoAniversario = new System.Windows.Forms.TextBox();
            this.txtDataNascimento = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.btnIdentificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR-A BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.Khaki;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtNome.Font = new System.Drawing.Font("OCR-A BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.White;
            this.txtNome.Location = new System.Drawing.Point(30, 47);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(346, 21);
            this.txtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OCR-A BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ano Nascimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("OCR-A BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(220, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ano Último Aniversario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("OCR-A BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(220, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "Categoria";
            // 
            // txtUltimoAniversario
            // 
            this.txtUltimoAniversario.BackColor = System.Drawing.Color.Khaki;
            this.txtUltimoAniversario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUltimoAniversario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtUltimoAniversario.Font = new System.Drawing.Font("OCR-A BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUltimoAniversario.ForeColor = System.Drawing.Color.White;
            this.txtUltimoAniversario.Location = new System.Drawing.Point(223, 109);
            this.txtUltimoAniversario.Name = "txtUltimoAniversario";
            this.txtUltimoAniversario.Size = new System.Drawing.Size(153, 21);
            this.txtUltimoAniversario.TabIndex = 6;
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.BackColor = System.Drawing.Color.Khaki;
            this.txtDataNascimento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDataNascimento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDataNascimento.Font = new System.Drawing.Font("OCR-A BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataNascimento.ForeColor = System.Drawing.Color.White;
            this.txtDataNascimento.Location = new System.Drawing.Point(29, 109);
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(153, 21);
            this.txtDataNascimento.TabIndex = 7;
            // 
            // txtCategoria
            // 
            this.txtCategoria.BackColor = System.Drawing.Color.Khaki;
            this.txtCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtCategoria.Font = new System.Drawing.Font("OCR-A BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.ForeColor = System.Drawing.Color.White;
            this.txtCategoria.Location = new System.Drawing.Point(223, 178);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(153, 21);
            this.txtCategoria.TabIndex = 8;
            // 
            // btnIdentificar
            // 
            this.btnIdentificar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnIdentificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIdentificar.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnIdentificar.FlatAppearance.BorderSize = 2;
            this.btnIdentificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnIdentificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIdentificar.Font = new System.Drawing.Font("OCR-A BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIdentificar.ForeColor = System.Drawing.Color.White;
            this.btnIdentificar.Location = new System.Drawing.Point(29, 162);
            this.btnIdentificar.Name = "btnIdentificar";
            this.btnIdentificar.Size = new System.Drawing.Size(153, 51);
            this.btnIdentificar.TabIndex = 9;
            this.btnIdentificar.Text = "Identificar Categoria";
            this.btnIdentificar.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(425, 225);
            this.Controls.Add(this.btnIdentificar);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtDataNascimento);
            this.Controls.Add(this.txtUltimoAniversario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUltimoAniversario;
        private System.Windows.Forms.TextBox txtDataNascimento;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Button btnIdentificar;
    }
}

