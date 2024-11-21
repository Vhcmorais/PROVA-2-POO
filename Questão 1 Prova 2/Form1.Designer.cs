namespace Questão_1_Prova_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            txtAssentosOuEixos = new TextBox();
            lbl1 = new Label();
            txtAno = new TextBox();
            lbl2 = new Label();
            lbl3 = new Label();
            txtPlaca = new TextBox();
            button1 = new Button();
            btnExcluir = new Button();
            cmbTipoVeiculos = new ComboBox();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtAssentosOuEixos);
            panel1.Controls.Add(lbl1);
            panel1.Controls.Add(txtAno);
            panel1.Controls.Add(lbl2);
            panel1.Controls.Add(lbl3);
            panel1.Controls.Add(txtPlaca);
            panel1.Location = new Point(12, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(358, 138);
            panel1.TabIndex = 2;
            // 
            // txtAssentosOuEixos
            // 
            txtAssentosOuEixos.Location = new Point(186, 97);
            txtAssentosOuEixos.Name = "txtAssentosOuEixos";
            txtAssentosOuEixos.Size = new Size(150, 31);
            txtAssentosOuEixos.TabIndex = 5;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl1.Location = new Point(13, 101);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(0, 22);
            lbl1.TabIndex = 4;
            // 
            // txtAno
            // 
            txtAno.Location = new Point(133, 60);
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(86, 31);
            txtAno.TabIndex = 3;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl2.Location = new Point(84, 66);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(43, 22);
            lbl2.TabIndex = 2;
            lbl2.Text = "Ano";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl3.Location = new Point(72, 23);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(54, 22);
            lbl3.TabIndex = 1;
            lbl3.Text = "Placa";
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(132, 17);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(150, 31);
            txtPlaca.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 221);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 3;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(130, 221);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(112, 34);
            btnExcluir.TabIndex = 4;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // cmbTipoVeiculos
            // 
            cmbTipoVeiculos.FormattingEnabled = true;
            cmbTipoVeiculos.Location = new Point(12, 12);
            cmbTipoVeiculos.Name = "cmbTipoVeiculos";
            cmbTipoVeiculos.Size = new Size(300, 33);
            cmbTipoVeiculos.TabIndex = 8;
            cmbTipoVeiculos.SelectedIndexChanged += cmbTipoVeiculos_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 261);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(765, 177);
            dataGridView1.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(cmbTipoVeiculos);
            Controls.Add(btnExcluir);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private TextBox txtAssentosOuEixos;
        private Label lbl1;
        private TextBox txtAno;
        private Label lbl2;
        private Label lbl3;
        private TextBox txtPlaca;
        private Button button1;
        private Button btnExcluir;
        private ComboBox cmbTipoVeiculos;
        private DataGridView dataGridView1;
    }
}
