namespace CPFCNPJ
{
    partial class Form2
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
            this.txt_cnpj_cpf = new System.Windows.Forms.TextBox();
            this.txt_retorno = new System.Windows.Forms.TextBox();
            this.btn_chamar_cnpj = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CNPJ / CPF";
            // 
            // txt_cnpj_cpf
            // 
            this.txt_cnpj_cpf.Location = new System.Drawing.Point(24, 44);
            this.txt_cnpj_cpf.Name = "txt_cnpj_cpf";
            this.txt_cnpj_cpf.Size = new System.Drawing.Size(170, 20);
            this.txt_cnpj_cpf.TabIndex = 1;
            // 
            // txt_retorno
            // 
            this.txt_retorno.Location = new System.Drawing.Point(24, 96);
            this.txt_retorno.Multiline = true;
            this.txt_retorno.Name = "txt_retorno";
            this.txt_retorno.Size = new System.Drawing.Size(170, 116);
            this.txt_retorno.TabIndex = 2;
            // 
            // btn_chamar_cnpj
            // 
            this.btn_chamar_cnpj.Location = new System.Drawing.Point(24, 67);
            this.btn_chamar_cnpj.Name = "btn_chamar_cnpj";
            this.btn_chamar_cnpj.Size = new System.Drawing.Size(170, 23);
            this.btn_chamar_cnpj.TabIndex = 3;
            this.btn_chamar_cnpj.Text = "Consistir CNPJ";
            this.btn_chamar_cnpj.UseVisualStyleBackColor = true;
            this.btn_chamar_cnpj.Click += new System.EventHandler(this.btn_chamar_cnpj_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(24, 218);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 4;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.btn_chamar_cnpj);
            this.Controls.Add(this.txt_retorno);
            this.Controls.Add(this.txt_cnpj_cpf);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cnpj_cpf;
        private System.Windows.Forms.TextBox txt_retorno;
        private System.Windows.Forms.Button btn_chamar_cnpj;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button button1;
    }
}