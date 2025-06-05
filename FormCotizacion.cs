using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ConsultorioApp
{
    public partial class FormCotizacion : Form
    {
        public FormCotizacion()
        {
            InitializeComponent();
            // Desactiva el botón de maximizar
            this.MaximizeBox = false;

            // Evita que el usuario cambie el tamaño de la ventana
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void FormCotizacion_Load(object sender, EventArgs e)
        {
            // Desactiva la fila adicional para agregar nuevas filas manualmente
            dgvProcedimientos.AllowUserToAddRows = false;

            // Evento para asegurar que CellValueChanged se dispare correctamente
            dgvProcedimientos.CurrentCellDirtyStateChanged += (s, ev) =>
            {
                if (dgvProcedimientos.IsCurrentCellDirty)
                {
                    dgvProcedimientos.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
            };

            dgvProcedimientos.CellValueChanged += dgvProcedimientos_CellValueChanged;

            // Para validar entrada numérica solo en la columna ColValor
            dgvProcedimientos.EditingControlShowing += dgvProcedimientos_EditingControlShowing;

            // Para formatear el valor en moneda al terminar edición en ColValor
            dgvProcedimientos.CellEndEdit += dgvProcedimientos_CellEndEdit;

            // Crear 8 filas vacías al cargar
            for (int i = 0; i < 8; i++)
            {
                dgvProcedimientos.Rows.Add();
            }
        }

        // Validar solo números y formato decimal en columna "ColValor"
        private void dgvProcedimientos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb = e.Control as TextBox;
            if (tb == null) return;

            // Quitar siempre el handler anterior para evitar que se acumule o afecte a otras columnas
            tb.KeyPress -= Tb_KeyPress;

            if (dgvProcedimientos.CurrentCell.ColumnIndex == dgvProcedimientos.Columns["ColValor"].Index)
            {
                tb.KeyPress += Tb_KeyPress;
            }
        }

        // Evento para aceptar solo números, tecla de control y punto/coma decimal
        private void Tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir control (backspace), dígitos, y un solo punto o coma decimal
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            TextBox tb = sender as TextBox;
            if ((e.KeyChar == '.' || e.KeyChar == ',') && tb != null)
            {
                // Solo permitir un punto o coma decimal
                if (tb.Text.Contains('.') || tb.Text.Contains(','))
                {
                    e.Handled = true;
                }
            }
        }

        // Al terminar la edición en "ColValor", formatear como moneda
        private void dgvProcedimientos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvProcedimientos.Columns["ColValor"].Index)
            {
                var cell = dgvProcedimientos.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value != null)
                {
                    // Intentar parsear el valor ignorando formato moneda
                    if (decimal.TryParse(cell.Value.ToString(), out decimal valor))
                    {
                        // Formatear valor con símbolo moneda local y 2 decimales
                        cell.Value = valor.ToString("C2");
                        CalcularTotal();
                    }
                    else
                    {
                        cell.Value = ""; // limpiar si no es válido
                        CalcularTotal();
                    }
                }
            }
        }

        // Recalcula total si se cambia el valor
        private void dgvProcedimientos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvProcedimientos.Columns["ColValor"].Index)
            {
                CalcularTotal();
            }
        }

        // Suma los valores de la columna "ColValor"
        private void CalcularTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgvProcedimientos.Rows)
            {
                if (row.IsNewRow) continue;

                if (row.Cells["ColValor"].Value != null)
                {
                    string valorTexto = row.Cells["ColValor"].Value.ToString();

                    // Intentar parsear como moneda usando la cultura local
                    if (decimal.TryParse(valorTexto, System.Globalization.NumberStyles.Currency,
                        System.Globalization.CultureInfo.CurrentCulture, out decimal valor))
                    {
                        total += valor;
                    }
                }
            }

            labelTotal.Text = total.ToString("C2");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "PDF Files (*.pdf)|*.pdf",
                FileName = "Cotizacion_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".pdf"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                using (Document doc = new Document(iTextSharp.text.PageSize.LETTER, 57f, 57f, 30f, iTextSharp.text.PageSize.LETTER.Height / 2 + 71f))
                {
                    PdfWriter writer = PdfWriter.GetInstance(doc, stream);
                    doc.Open();

                    string rutaFuente = Path.Combine(Application.StartupPath, "Resources", "Fonts", "GreatVibes-Regular.ttf");
                    BaseFont bfCabecera = BaseFont.CreateFont(rutaFuente, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                    var fontCabecera = new iTextSharp.text.Font(bfCabecera, 16f);
                    var fontSubtitulo = FontFactory.GetFont(FontFactory.HELVETICA, 12, iTextSharp.text.Font.BOLD);
                    var fontBody = FontFactory.GetFont(FontFactory.HELVETICA, 9);
                    var fontTotal = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11);

                    doc.Add(new Paragraph("Dra. Bertha Patricia Monroy Garibello", fontCabecera)
                    {
                        Alignment = Element.ALIGN_CENTER
                    });
                    doc.Add(new Paragraph("Cotización", fontSubtitulo)
                    {
                        Alignment = Element.ALIGN_CENTER,
                        SpacingAfter = 2f
                    });

                    PdfPTable infoTable = new PdfPTable(2)
                    {
                        WidthPercentage = 100,
                        SpacingAfter = 5f
                    };
                    infoTable.SetWidths(new float[] { 1, 1 });

                    PdfPCell fechaCell = new PdfPCell(new Phrase("Fecha: " + dateTimePicker_coti.Value.ToShortDateString(), fontBody))
                    {
                        Border = iTextSharp.text.Rectangle.NO_BORDER,
                        HorizontalAlignment = Element.ALIGN_LEFT
                    };
                    PdfPCell pacienteCell = new PdfPCell(new Phrase("Paciente: " + txtNombrePaciente_coti.Text, fontBody))
                    {
                        Border = iTextSharp.text.Rectangle.NO_BORDER,
                        HorizontalAlignment = Element.ALIGN_RIGHT
                    };

                    infoTable.AddCell(fechaCell);
                    infoTable.AddCell(pacienteCell);
                    doc.Add(infoTable);

                    if ("Cotizacion" == "Cotizacion")
                    {
                        PdfPTable table = new PdfPTable(3)
                        {
                            WidthPercentage = 100
                        };
                        table.SetWidths(new float[] { 1, 4, 1.5f });

                        table.AddCell(new PdfPCell(new Phrase("Ítem", fontBody)) { BackgroundColor = BaseColor.LIGHT_GRAY, HorizontalAlignment = Element.ALIGN_CENTER });
                        table.AddCell(new PdfPCell(new Phrase("Procedimiento", fontBody)) { BackgroundColor = BaseColor.LIGHT_GRAY, HorizontalAlignment = Element.ALIGN_CENTER });
                        table.AddCell(new PdfPCell(new Phrase("Valor", fontBody)) { BackgroundColor = BaseColor.LIGHT_GRAY, HorizontalAlignment = Element.ALIGN_CENTER });

                        int item = 1;
                        foreach (DataGridViewRow row in dgvProcedimientos.Rows)
                        {
                            if (row.IsNewRow) continue; // evitar fila de nuevo

                            if (item > 8) break;

                            string procedimiento = row.Cells["ColProcedimiento"].Value?.ToString().Trim() ?? "";
                            string valorTexto = row.Cells["ColValor"].Value?.ToString().Trim() ?? "";

                            // Quitar símbolo moneda para parsear decimal
                            valorTexto = valorTexto.Replace("$", "").Replace(" ", "").Replace(".", "").Replace(",", ".");

                            if (!decimal.TryParse(valorTexto, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decimal valor))
                            {
                                valor = 0;
                            }

                            // Saltar filas sin procedimiento ni valor
                            if (string.IsNullOrEmpty(procedimiento) && valor == 0)
                            {
                                continue;
                            }

                            table.AddCell(new PdfPCell(new Phrase(item.ToString(), fontBody)) { HorizontalAlignment = Element.ALIGN_CENTER });
                            table.AddCell(new PdfPCell(new Phrase(procedimiento, fontBody)) { HorizontalAlignment = Element.ALIGN_LEFT });
                            table.AddCell(new PdfPCell(new Phrase(valor.ToString("C0"), fontBody)) { HorizontalAlignment = Element.ALIGN_RIGHT });

                            item++;
                        }
                        doc.Add(table);

                        doc.Add(new Paragraph(labelTotal.Text, fontTotal)
                        {
                            Alignment = Element.ALIGN_RIGHT,
                            SpacingBefore = 8f,
                            SpacingAfter = 6f
                        });

                        Paragraph aviso = new Paragraph("Importante: Cotización válida por 30 días desde la fecha. Sujeta a cambios sin previo aviso.", fontBody)
                        {
                            SpacingAfter = 10f
                        };
                        doc.Add(aviso);
                    }

                    // Línea divisoria
                    PdfPTable linea = new PdfPTable(1)
                    {
                        WidthPercentage = 100,
                        SpacingBefore = 10f,
                        SpacingAfter = 2f
                    };
                    PdfPCell cellLinea = new PdfPCell(new Phrase(" "))
                    {
                        BorderWidthTop = 1,
                        Border = iTextSharp.text.Rectangle.TOP_BORDER,
                        BorderColorTop = BaseColor.GRAY,
                        PaddingTop = 5,
                        BorderWidthBottom = 0,
                        BorderWidthLeft = 0,
                        BorderWidthRight = 0
                    };
                    linea.AddCell(cellLinea);
                    doc.Add(linea);

                    Paragraph footer = new Paragraph("Calle 51 No. 23 -34  Cel. 310 864 9410\nBogotá D.C. – Colombia", fontBody)
                    {
                        Alignment = Element.ALIGN_CENTER
                    };
                    doc.Add(footer);

                    doc.Close();
                }

                MessageBox.Show("PDF guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
