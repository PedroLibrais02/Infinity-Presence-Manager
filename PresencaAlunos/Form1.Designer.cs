namespace PresencaAlunos
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnGerarRelatorio;
        private System.Windows.Forms.Button btnValidarPresenca;
        private System.Windows.Forms.TextBox txtCodigoPresenca;
        private System.Windows.Forms.Label lblCodigoPresenca;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TextBox txtAula;
        private System.Windows.Forms.Label lblAula;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelMain = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            lblAula = new Label();
            txtAula = new TextBox();
            btnGerarRelatorio = new Button();
            btnValidarPresenca = new Button();
            txtCodigoPresenca = new TextBox();
            lblCodigoPresenca = new Label();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Controls.Add(label1);
            panelMain.Controls.Add(textBox1);
            panelMain.Controls.Add(lblAula);
            panelMain.Controls.Add(txtAula);
            panelMain.Controls.Add(btnGerarRelatorio);
            panelMain.Controls.Add(btnValidarPresenca);
            panelMain.Controls.Add(txtCodigoPresenca);
            panelMain.Controls.Add(lblCodigoPresenca);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(10, 10);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(520, 255);
            panelMain.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(334, 34);
            label1.Margin = new Padding(10);
            label1.Name = "label1";
            label1.Size = new Size(45, 19);
            label1.TabIndex = 8;
            label1.Text = "Aulas:";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Font = new Font("Segoe UI", 10F);
            textBox1.Location = new Point(382, 31);
            textBox1.Margin = new Padding(10);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(70, 25);
            textBox1.TabIndex = 7;
            // 
            // lblAula
            // 
            lblAula.Anchor = AnchorStyles.None;
            lblAula.AutoSize = true;
            lblAula.Font = new Font("Segoe UI", 10F);
            lblAula.Location = new Point(38, 34);
            lblAula.Margin = new Padding(10);
            lblAula.Name = "lblAula";
            lblAula.Size = new Size(39, 19);
            lblAula.TabIndex = 6;
            lblAula.Text = "Aula:";
            // 
            // txtAula
            // 
            txtAula.Anchor = AnchorStyles.None;
            txtAula.Font = new Font("Segoe UI", 10F);
            txtAula.Location = new Point(78, 31);
            txtAula.Margin = new Padding(10);
            txtAula.Name = "txtAula";
            txtAula.Size = new Size(250, 25);
            txtAula.TabIndex = 5;
            // 
            // btnGerarRelatorio
            // 
            btnGerarRelatorio.Anchor = AnchorStyles.None;
            btnGerarRelatorio.Font = new Font("Segoe UI", 10F);
            btnGerarRelatorio.Location = new Point(261, 180);
            btnGerarRelatorio.Margin = new Padding(10);
            btnGerarRelatorio.Name = "btnGerarRelatorio";
            btnGerarRelatorio.Size = new Size(191, 30);
            btnGerarRelatorio.TabIndex = 1;
            btnGerarRelatorio.Text = "Gerar Relatório";
            btnGerarRelatorio.UseVisualStyleBackColor = true;
            btnGerarRelatorio.Click += btnGerarRelatorio_Click;
            // 
            // btnValidarPresenca
            // 
            btnValidarPresenca.Anchor = AnchorStyles.None;
            btnValidarPresenca.Font = new Font("Segoe UI", 10F);
            btnValidarPresenca.Location = new Point(38, 180);
            btnValidarPresenca.Margin = new Padding(10);
            btnValidarPresenca.Name = "btnValidarPresenca";
            btnValidarPresenca.Size = new Size(203, 30);
            btnValidarPresenca.TabIndex = 2;
            btnValidarPresenca.Text = "Validar Presença";
            btnValidarPresenca.UseVisualStyleBackColor = true;
            btnValidarPresenca.Click += btnValidarPresenca_Click;
            // 
            // txtCodigoPresenca
            // 
            txtCodigoPresenca.Anchor = AnchorStyles.None;
            txtCodigoPresenca.Font = new Font("Segoe UI", 10F);
            txtCodigoPresenca.Location = new Point(38, 113);
            txtCodigoPresenca.Margin = new Padding(10);
            txtCodigoPresenca.Name = "txtCodigoPresenca";
            txtCodigoPresenca.Size = new Size(414, 25);
            txtCodigoPresenca.TabIndex = 3;
            // 
            // lblCodigoPresenca
            // 
            lblCodigoPresenca.Anchor = AnchorStyles.None;
            lblCodigoPresenca.AutoSize = true;
            lblCodigoPresenca.Font = new Font("Segoe UI", 10F);
            lblCodigoPresenca.Location = new Point(38, 88);
            lblCodigoPresenca.Margin = new Padding(10);
            lblCodigoPresenca.Name = "lblCodigoPresenca";
            lblCodigoPresenca.Size = new Size(133, 19);
            lblCodigoPresenca.TabIndex = 4;
            lblCodigoPresenca.Text = "Código de Presença:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 275);
            Controls.Add(panelMain);
            Name = "Form1";
            Padding = new Padding(10);
            Text = "Presença de Alunos";
            FormClosing += Form1_FormClosing;
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);
        }

        private Label label1;
        private TextBox textBox1;
    }
}
