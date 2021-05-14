namespace CPFCNPJ
{
    partial class Form1
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
            this.txt_cpf_cnpj = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.btn_cnpj_retorno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF / CNPJ";
            // 
            // txt_cpf_cnpj
            // 
            this.txt_cpf_cnpj.Location = new System.Drawing.Point(82, 4);
            this.txt_cpf_cnpj.Name = "txt_cpf_cnpj";
            this.txt_cpf_cnpj.Size = new System.Drawing.Size(250, 20);
            this.txt_cpf_cnpj.TabIndex = 1;
            this.txt_cpf_cnpj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cpf_cnpj_KeyPress);
            this.txt_cpf_cnpj.Validated += new System.EventHandler(this.txt_cpf_cnpj_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Endereço";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(82, 36);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(250, 20);
            this.txt_nome.TabIndex = 4;
            // 
            // txt_endereco
            // 
            this.txt_endereco.Location = new System.Drawing.Point(82, 73);
            this.txt_endereco.Multiline = true;
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(250, 100);
            this.txt_endereco.TabIndex = 5;
            // 
            // btn_cnpj_retorno
            // 
            this.btn_cnpj_retorno.Location = new System.Drawing.Point(82, 179);
            this.btn_cnpj_retorno.Name = "btn_cnpj_retorno";
            this.btn_cnpj_retorno.Size = new System.Drawing.Size(250, 23);
            this.btn_cnpj_retorno.TabIndex = 6;
            this.btn_cnpj_retorno.Text = "Retorna";
            this.btn_cnpj_retorno.UseVisualStyleBackColor = true;
            this.btn_cnpj_retorno.Click += new System.EventHandler(this.btn_cnpj_retorno_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 213);
            this.Controls.Add(this.btn_cnpj_retorno);
            this.Controls.Add(this.txt_endereco);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_cpf_cnpj);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Consiste CPF/CNPJ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cpf_cnpj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_endereco;
        private System.Windows.Forms.Button btn_cnpj_retorno;
    }
}

