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
    public partial class FormFormula : Form
    {
        public FormFormula()
        {
            InitializeComponent();
        }

        private void lblTexto_cotiza_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarMedicamento_Click(object sender, EventArgs e)
        {
            FormMedicamento formMed = new FormMedicamento();
            if (formMed.ShowDialog() == DialogResult.OK)
            {
                MedicamentoRecetado nuevo = formMed.Medicamento;

                if (!string.IsNullOrWhiteSpace(txtRecetaManual.Text) &&
                    !txtRecetaManual.Text.EndsWith(Environment.NewLine))
                {
                    txtRecetaManual.AppendText(Environment.NewLine);
                }

                txtRecetaManual.AppendText(nuevo.ToString() + Environment.NewLine);
            }
        }

        private void btnGuardar_receta_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "PDF Files (*.pdf)|*.pdf",
                FileName = "Receta_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".pdf"
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
                    writer.PageEvent = new FooterEvent(); // ← Activar el footer global

                    doc.Open();

                    string rutaFuente = Path.Combine(Application.StartupPath, "Resources", "Fonts", "GreatVibes-Regular.ttf");
                    BaseFont bfCabecera = BaseFont.CreateFont(rutaFuente, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                    var fontCabecera = new iTextSharp.text.Font(bfCabecera, 16f);
                    var fontSubtitulo = FontFactory.GetFont(FontFactory.HELVETICA, 12, iTextSharp.text.Font.BOLD);
                    var fontBody = FontFactory.GetFont(FontFactory.HELVETICA, 9);

                    doc.Add(new Paragraph("Dra. Bertha Patricia Monroy Garibello", fontCabecera)
                    {
                        Alignment = Element.ALIGN_CENTER
                    });

                    doc.Add(new Paragraph("Receta médica", fontSubtitulo)
                    {
                        Alignment = Element.ALIGN_CENTER,
                        SpacingAfter = 2f
                    });

                    PdfPTable infoTable = new PdfPTable(2)
                    {
                        WidthPercentage = 100,
                        SpacingAfter = 10f // Más espacio después de datos del paciente
                    };
                    infoTable.SetWidths(new float[] { 1, 1 });

                    PdfPCell fechaCell = new PdfPCell(new Phrase("Fecha: " + dateTimePicker_receta.Value.ToShortDateString(), fontBody))
                    {
                        Border = iTextSharp.text.Rectangle.NO_BORDER,
                        HorizontalAlignment = Element.ALIGN_LEFT
                    };
                    PdfPCell pacienteCell = new PdfPCell(new Phrase("Paciente: " + txtNombrePaciente_receta.Text, fontBody))
                    {
                        Border = iTextSharp.text.Rectangle.NO_BORDER,
                        HorizontalAlignment = Element.ALIGN_RIGHT
                    };

                    infoTable.AddCell(fechaCell);
                    infoTable.AddCell(pacienteCell);
                    doc.Add(infoTable);

                    PdfPTable tablaReceta = new PdfPTable(2)
                    {
                        WidthPercentage = 100
                    };
                    tablaReceta.SetWidths(new float[] { 1, 9 });

                    tablaReceta.AddCell(new PdfPCell(new Phrase("Ítem", fontBody)) { BackgroundColor = BaseColor.LIGHT_GRAY, HorizontalAlignment = Element.ALIGN_CENTER });
                    tablaReceta.AddCell(new PdfPCell(new Phrase("Descripción", fontBody)) { BackgroundColor = BaseColor.LIGHT_GRAY, HorizontalAlignment = Element.ALIGN_CENTER });

                    string[] lineas = txtRecetaManual.Text.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                    int item = 1;
                    foreach (string linea in lineas)
                    {
                        string descripcion = linea.Trim();
                        if (!string.IsNullOrWhiteSpace(descripcion))
                        {
                            tablaReceta.AddCell(new PdfPCell(new Phrase(item.ToString(), fontBody)) { HorizontalAlignment = Element.ALIGN_CENTER });
                            tablaReceta.AddCell(new PdfPCell(new Phrase(descripcion, fontBody)));
                            item++;
                        }
                    }

                    doc.Add(tablaReceta);

                    doc.Close();
                    MessageBox.Show("PDF guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }

    public class FooterEvent : PdfPageEventHelper
    {
        private iTextSharp.text.Font fontFooter = FontFactory.GetFont(FontFactory.HELVETICA, 9);
        public override void OnEndPage(PdfWriter writer, Document document)
        {
            PdfPTable footerTable = new PdfPTable(1);
            footerTable.TotalWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin;
            footerTable.DefaultCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
            footerTable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;

            PdfPCell lineCell = new PdfPCell(new Phrase(" "))
            {
                BorderWidthTop = 1,
                Border = iTextSharp.text.Rectangle.TOP_BORDER,
                BorderColorTop = BaseColor.GRAY,
                PaddingTop = 5,
                BorderWidthBottom = 0,
                BorderWidthLeft = 0,
                BorderWidthRight = 0
            };
            footerTable.AddCell(lineCell);

            PdfPCell footerTextCell = new PdfPCell(new Phrase("Calle 51 No. 23 -34  Cel. 310 864 9410\nBogotá D.C. – Colombia", fontFooter))
            {
                Border = iTextSharp.text.Rectangle.NO_BORDER,
                HorizontalAlignment = Element.ALIGN_CENTER,
                PaddingTop = 5
            };
            footerTable.AddCell(footerTextCell);

            footerTable.WriteSelectedRows(0, -1, document.LeftMargin, document.BottomMargin - 5, writer.DirectContent);
        }
    }
}
