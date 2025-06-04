using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultorioApp
{
    public partial class FormExcusa : Form
    {
        public FormExcusa()
        {
            InitializeComponent();
        }

        private void btnGuardar_excusa_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "PDF Files (*.pdf)|*.pdf",
                FileName = "Excusa_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".pdf"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                {
                    float altoCarta = iTextSharp.text.PageSize.LETTER.Height;
                    float altoMediaCarta = altoCarta / 2;

                    float margenSuperior = 30f;
                    float margenInferior = altoCarta - altoMediaCarta + 71f;
                    float margenIzquierdo = 57f;
                    float margenDerecho = 57f;

                    Document doc = new Document(iTextSharp.text.PageSize.LETTER, margenIzquierdo, margenDerecho, margenSuperior, margenInferior);
                    PdfWriter writer = PdfWriter.GetInstance(doc, stream);
                    writer.PageEvent = new FooterEvent(); // ← Reutilizar si tienes esta clase para el pie de página

                    doc.Open();

                    string rutaFuente = Path.Combine(Application.StartupPath, "Resources", "Fonts", "GreatVibes-Regular.ttf");
                    BaseFont bfCabecera = BaseFont.CreateFont(rutaFuente, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                    var fontCabecera = new iTextSharp.text.Font(bfCabecera, 16f);
                    var fontSubtitulo = FontFactory.GetFont(FontFactory.HELVETICA, 12, iTextSharp.text.Font.BOLD);
                    var fontBody = FontFactory.GetFont(FontFactory.HELVETICA, 11);

                    // Cabecera
                    doc.Add(new Paragraph("Dra. Bertha Patricia Monroy Garibello", fontCabecera)
                    {
                        Alignment = Element.ALIGN_CENTER
                    });

                    doc.Add(new Paragraph("Excusa médica", fontSubtitulo)
                    {
                        Alignment = Element.ALIGN_CENTER,
                        SpacingAfter = 10f
                    });

                    // Tabla con fecha y nombre
                    PdfPTable infoTable = new PdfPTable(2)
                    {
                        WidthPercentage = 100,
                        SpacingAfter = 10f
                    };
                    infoTable.SetWidths(new float[] { 1, 1 });

                    PdfPCell fechaCell = new PdfPCell(new Phrase("Fecha: " + dateTimePicker_excusa.Value.ToShortDateString(), fontBody))
                    {
                        Border = iTextSharp.text.Rectangle.NO_BORDER,
                        HorizontalAlignment = Element.ALIGN_LEFT
                    };
                    PdfPCell pacienteCell = new PdfPCell(new Phrase("Paciente: " + txtNombrePaciente_excusa.Text, fontBody))
                    {
                        Border = iTextSharp.text.Rectangle.NO_BORDER,
                        HorizontalAlignment = Element.ALIGN_RIGHT
                    };

                    infoTable.AddCell(fechaCell);
                    infoTable.AddCell(pacienteCell);
                    doc.Add(infoTable);

                    // Excusa en párrafo
                    Paragraph parrafoExcusa = new Paragraph(txtExcusa.Text, fontBody)
                    {
                        SpacingBefore = 10f,
                        SpacingAfter = 20f,
                        Alignment = Element.ALIGN_JUSTIFIED
                    };
                    doc.Add(parrafoExcusa);

                    doc.Close();
                    MessageBox.Show("PDF guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

    }
}
