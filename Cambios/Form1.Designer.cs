namespace Cambios
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
            label1 = new Label();
            txtValor = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cmbOrigem = new ComboBox();
            cmbDestino = new ComboBox();
            btnConverter = new Button();
            lblResultado = new Label();
            lblStatus = new Label();
            progressBar1 = new ProgressBar();
            btnTroca = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(76, 78);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
            label1.TabIndex = 0;
            label1.Text = "Valor:";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(137, 76);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(472, 23);
            txtValor.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(76, 150);
            label2.Name = "label2";
            label2.Size = new Size(149, 21);
            label2.TabIndex = 0;
            label2.Text = "Moeda de origem:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(76, 194);
            label3.Name = "label3";
            label3.Size = new Size(151, 21);
            label3.TabIndex = 0;
            label3.Text = "Moeda de destino:";
            // 
            // cmbOrigem
            // 
            cmbOrigem.FormattingEnabled = true;
            cmbOrigem.Location = new Point(242, 148);
            cmbOrigem.Name = "cmbOrigem";
            cmbOrigem.Size = new Size(367, 23);
            cmbOrigem.TabIndex = 2;
            // 
            // cmbDestino
            // 
            cmbDestino.FormattingEnabled = true;
            cmbDestino.Location = new Point(242, 192);
            cmbDestino.Name = "cmbDestino";
            cmbDestino.Size = new Size(367, 23);
            cmbDestino.TabIndex = 2;
            // 
            // btnConverter
            // 
            btnConverter.Enabled = false;
            btnConverter.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConverter.Location = new Point(680, 76);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(155, 55);
            btnConverter.TabIndex = 3;
            btnConverter.Text = "Converter";
            btnConverter.UseVisualStyleBackColor = true;
            btnConverter.Click += btnConverter_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(253, 238);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(356, 21);
            lblResultado.TabIndex = 4;
            lblResultado.Text = "Escolha um valor, moeda de origem e destino";
            lblResultado.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(76, 390);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(57, 21);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "Status";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(617, 388);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(218, 23);
            progressBar1.TabIndex = 6;
            // 
            // btnTroca
            // 
            btnTroca.Enabled = false;
            btnTroca.Image = Properties.Resources.change;
            btnTroca.Location = new Point(719, 148);
            btnTroca.Name = "btnTroca";
            btnTroca.Size = new Size(75, 67);
            btnTroca.TabIndex = 7;
            btnTroca.UseVisualStyleBackColor = true;
            btnTroca.Click += btnTroca_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 450);
            Controls.Add(btnTroca);
            Controls.Add(progressBar1);
            Controls.Add(lblStatus);
            Controls.Add(lblResultado);
            Controls.Add(btnConverter);
            Controls.Add(cmbDestino);
            Controls.Add(cmbOrigem);
            Controls.Add(txtValor);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Câmbios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtValor;
        private Label label2;
        private Label label3;
        private ComboBox cmbOrigem;
        private ComboBox cmbDestino;
        private Button btnConverter;
        private Label lblResultado;
        private Label lblStatus;
        private ProgressBar progressBar1;
        private Button btnTroca;
    }
}
