namespace IMC_Jesher
{
    partial class frm_imc
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
            this.lblSeuPeso = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.lblSuaAltura = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblSeuIMC = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblmsgTela = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSeuPeso
            // 
            this.lblSeuPeso.AutoSize = true;
            this.lblSeuPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeuPeso.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblSeuPeso.Location = new System.Drawing.Point(36, 96);
            this.lblSeuPeso.Name = "lblSeuPeso";
            this.lblSeuPeso.Size = new System.Drawing.Size(79, 16);
            this.lblSeuPeso.TabIndex = 0;
            this.lblSeuPeso.Text = "Seu Peso:";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(120, 92);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(67, 20);
            this.txtPeso.TabIndex = 1;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(121, 128);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(67, 20);
            this.txtAltura.TabIndex = 3;
            // 
            // lblSuaAltura
            // 
            this.lblSuaAltura.AutoSize = true;
            this.lblSuaAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuaAltura.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblSuaAltura.Location = new System.Drawing.Point(36, 132);
            this.lblSuaAltura.Name = "lblSuaAltura";
            this.lblSuaAltura.Size = new System.Drawing.Size(83, 16);
            this.lblSuaAltura.TabIndex = 2;
            this.lblSuaAltura.Text = "Sua Altura:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(32, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Você está saudável?";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalcular.Location = new System.Drawing.Point(36, 167);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(152, 27);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.Red;
            this.lblResultado.Location = new System.Drawing.Point(87, 257);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(40, 21);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "-----";
            // 
            // lblSeuIMC
            // 
            this.lblSeuIMC.AutoSize = true;
            this.lblSeuIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeuIMC.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblSeuIMC.Location = new System.Drawing.Point(69, 241);
            this.lblSeuIMC.Name = "lblSeuIMC";
            this.lblSeuIMC.Size = new System.Drawing.Size(82, 16);
            this.lblSeuIMC.TabIndex = 7;
            this.lblSeuIMC.Text = "Seu IMC é:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(36, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 27);
            this.button1.TabIndex = 8;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lblmsgTela
            // 
            this.lblmsgTela.AutoSize = true;
            this.lblmsgTela.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmsgTela.ForeColor = System.Drawing.Color.Red;
            this.lblmsgTela.Location = new System.Drawing.Point(7, 299);
            this.lblmsgTela.Name = "lblmsgTela";
            this.lblmsgTela.Size = new System.Drawing.Size(12, 15);
            this.lblmsgTela.TabIndex = 9;
            this.lblmsgTela.Text = "-";
            // 
            // frm_imc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 347);
            this.Controls.Add(this.lblmsgTela);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblSeuIMC);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.lblSuaAltura);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lblSeuPeso);
            this.Name = "frm_imc";
            this.Text = "Calc_IMC";
            this.Load += new System.EventHandler(this.Frm_imc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeuPeso;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label lblSuaAltura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblSeuIMC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblmsgTela;
    }
}

