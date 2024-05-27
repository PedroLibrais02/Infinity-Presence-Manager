using System;
using System.Windows.Forms;

namespace PresencaAlunos
{
    public partial class Form1 : Form
    {
        private Database _db;
        private string _session = Guid.NewGuid().ToString();

        public Form1()
        {
            InitializeComponent();
            _db = new Database("alunos.db");
            InicializarAlunos();
        }

        private void InicializarAlunos()
        {
            _db.AddAluno("Pedro Taiette Sato Librais", "codigo123");
            _db.AddAluno("Thiago Henrique do Rego", "codigo456");
            _db.AddAluno("Roberto da Silva Junior", "codigo789");
        }

        private void btnValidarPresenca_Click(object sender, EventArgs e)
        {
            string codigoPresenca = txtCodigoPresenca.Text;
            if (!string.IsNullOrEmpty(codigoPresenca))
            {
                _db.MarcarPresenca(codigoPresenca, _session);
                MessageBox.Show("Presença validada!");
            }
            else
            {
                MessageBox.Show("Por favor, insira um código de presença.");
            }
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            string aula = txtAula.Text;
            string num_aulas = textBox1.Text;

            if (string.IsNullOrEmpty(aula))
            {
                MessageBox.Show("Por favor, insira o nome da aula.");
                return;
            }

            using (var alunosPresentes = _db.GetAlunosPresentes(_session))
            {
                Relatorio.GerarRelatorio(alunosPresentes, "RelatorioPresenca.pdf", aula);
                MessageBox.Show("Relatório gerado!");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _db.Close();
        }
    }
}
