using System;
using System.Data.SQLite;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace PresencaAlunos
{
    public static class Relatorio
    {
        public static void GerarRelatorio(SQLiteDataReader alunosPresentes, string filePath, string aula)
        {
            // Resetar o arquivo se ele já existir
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                Document doc = new Document();
                PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                doc.Open();

                // Adicionar cabeçalho com dia, hora e aula
                var dataHoraAtual = DateTime.Now;
                string cabecalho = $"Relatório de Presença\nData: {dataHoraAtual.ToShortDateString()} " +
                                   $"Hora: {dataHoraAtual.ToShortTimeString()}\nAula: {aula}\n\n";
                var paragrafoCabecalho = new Paragraph(cabecalho, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14));
                paragrafoCabecalho.Alignment = Element.ALIGN_CENTER;
                doc.Add(paragrafoCabecalho);

                // Adicionar uma linha de separação
                var line = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator()));
                doc.Add(line);

                // Adicionar lista de alunos presentes
                var paragrafoAlunos = new Paragraph("\nAlunos Presentes:\n\n", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12));
                doc.Add(paragrafoAlunos);

                while (alunosPresentes.Read())
                {
                    string aluno = alunosPresentes["Nome"].ToString();
                    var paragrafoAluno = new Paragraph(aluno, FontFactory.GetFont(FontFactory.HELVETICA, 12));
                    paragrafoAluno.Alignment = Element.ALIGN_LEFT;
                    doc.Add(paragrafoAluno);
                }

                doc.Close();
                writer.Close();
            }
        }
    }
}
