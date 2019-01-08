namespace Conversor_de_Moeda
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
            this.btnConv = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVal = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbEuro = new System.Windows.Forms.RadioButton();
            this.rbLibra = new System.Windows.Forms.RadioButton();
            this.rbDolar = new System.Windows.Forms.RadioButton();
            this.txtValConv = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConv
            // 
            this.btnConv.Location = new System.Drawing.Point(21, 227);
            this.btnConv.Name = "btnConv";
            this.btnConv.Size = new System.Drawing.Size(75, 23);
            this.btnConv.TabIndex = 0;
            this.btnConv.Text = "Converter";
            this.btnConv.UseVisualStyleBackColor = true;
            this.btnConv.Click += new System.EventHandler(this.btnConv_Click);
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(111, 227);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.EnabledChanged += new System.EventHandler(this.btnConv_Click);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(197, 227);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Sair";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Valor Convertido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Valor em R$";
            // 
            // txtVal
            // 
            this.txtVal.Location = new System.Drawing.Point(160, 51);
            this.txtVal.Name = "txtVal";
            this.txtVal.Size = new System.Drawing.Size(100, 20);
            this.txtVal.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbEuro);
            this.groupBox1.Controls.Add(this.rbLibra);
            this.groupBox1.Controls.Add(this.rbDolar);
            this.groupBox1.Location = new System.Drawing.Point(4, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Moeda";
            // 
            // rbEuro
            // 
            this.rbEuro.AutoSize = true;
            this.rbEuro.Location = new System.Drawing.Point(7, 68);
            this.rbEuro.Name = "rbEuro";
            this.rbEuro.Size = new System.Drawing.Size(47, 17);
            this.rbEuro.TabIndex = 2;
            this.rbEuro.TabStop = true;
            this.rbEuro.Text = "Euro";
            this.rbEuro.UseVisualStyleBackColor = true;
            // 
            // rbLibra
            // 
            this.rbLibra.AutoSize = true;
            this.rbLibra.Location = new System.Drawing.Point(7, 44);
            this.rbLibra.Name = "rbLibra";
            this.rbLibra.Size = new System.Drawing.Size(48, 17);
            this.rbLibra.TabIndex = 1;
            this.rbLibra.TabStop = true;
            this.rbLibra.Text = "Libra";
            this.rbLibra.UseVisualStyleBackColor = true;
            // 
            // rbDolar
            // 
            this.rbDolar.AutoSize = true;
            this.rbDolar.Checked = true;
            this.rbDolar.Location = new System.Drawing.Point(7, 20);
            this.rbDolar.Name = "rbDolar";
            this.rbDolar.Size = new System.Drawing.Size(50, 17);
            this.rbDolar.TabIndex = 0;
            this.rbDolar.TabStop = true;
            this.rbDolar.Text = "Dólar";
            this.rbDolar.UseVisualStyleBackColor = true;
            // 
            // txtValConv
            // 
            this.txtValConv.Location = new System.Drawing.Point(160, 191);
            this.txtValConv.Name = "txtValConv";
            this.txtValConv.ReadOnly = true;
            this.txtValConv.Size = new System.Drawing.Size(100, 20);
            this.txtValConv.TabIndex = 11;
            this.txtValConv.EnabledChanged += new System.EventHandler(this.btnConv_Click);
            this.txtValConv.TextChanged += new System.EventHandler(this.txtValConv_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 262);
            this.Controls.Add(this.txtValConv);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtVal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConv);
            this.Name = "Form1";
            this.Text = "Conversor de Moeda";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConv;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbEuro;
        private System.Windows.Forms.RadioButton rbLibra;
        private System.Windows.Forms.RadioButton rbDolar;
        private System.Windows.Forms.TextBox txtValConv;
    }
}

