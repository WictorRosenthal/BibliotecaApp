namespace BibliotecaApp
{
    partial class FormLivros
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.dtpAnoPublicacao = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Genero:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ISBN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ano Publicação:";
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Location = new System.Drawing.Point(15, 147);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(161, 21);
            this.cmbGenero.TabIndex = 4;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(15, 94);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(326, 20);
            this.txtTitulo.TabIndex = 5;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(366, 94);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(100, 20);
            this.txtISBN.TabIndex = 6;
            // 
            // dtpAnoPublicacao
            // 
            this.dtpAnoPublicacao.Location = new System.Drawing.Point(188, 148);
            this.dtpAnoPublicacao.Name = "dtpAnoPublicacao";
            this.dtpAnoPublicacao.Size = new System.Drawing.Size(155, 20);
            this.dtpAnoPublicacao.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cadastro:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(17, 229);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Pesquisar por Titulos:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(316, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(7, 64);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(247, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Livros";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(376, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(155, 63);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "Disponibilidade:";
            // 
            // FormLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 352);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpAnoPublicacao);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormLivros";
            this.Text = "FormLivros";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.DateTimePicker dtpAnoPublicacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}