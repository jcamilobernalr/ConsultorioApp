using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using drawingFont = System.Drawing.Font;
using pdfFont = iTextSharp.text.Font;

namespace ConsultorioApp
{
    public partial class FormDocumento : Form
    {
        private string tipoDocumento;
        private DataGridView dgvProcedimientos;
        private Label lblTotal;

        public FormDocumento(string tipo)
        {
            InitializeComponent();
            tipoDocumento = tipo;
            this.Text = tipo;
            lblTexto.Text = tipo;

            this.Load += FormDocumento_Load;
            btnGuardar.Click += btnGuardar_Click;
        }

        private void FormDocumento_Load(object sender, EventArgs e)
        {
            if (tipoDocumento == "Cotizacion")
            {
                txtTexto.Visible = false;
                AgregarTablaProcedimientos();
                AgregarTotalizador();
            }
        }

        private void AgregarTablaProcedimientos()
        {
            dgvProcedimientos = new DataGridView
            {
                Name = "dgvProcedimientos",
                Location = new Point(50, 160),
                Size = new Size(700, 250),
                ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = true,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                RowCount = 8
            };

            dgvProcedimientos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Procedimiento",
                HeaderText = "Procedimiento",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvProcedimientos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Valor",
                HeaderText = "Valor",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                ValueType = typeof(decimal),
                DefaultCellStyle =
                {
                    Alignment = DataGridViewContentAlignment.MiddleRight,
                    Format = "C0",
                    NullValue = "0"
                }
            });

            dgvProcedimientos.CellValueChanged += DgvProcedimientos_CellValueChanged;
            dgvProcedimientos.EditingControlShowing += DgvProcedimientos_EditingControlShowing;
            dgvProcedimientos.CellValidating += DgvProcedimientos_CellValidating;

            this.Controls.Add(dgvProcedimientos);
            dgvProcedimientos.BringToFront();
        }

        private void DgvProcedimientos_CellValueChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void CalcularTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvProcedimientos.Rows)
            {
                if (row.IsNewRow) continue;

                string valorTexto = row.Cells["Valor"].Value?.ToString() ?? "0";

                if (!decimal.TryParse(valorTexto, out decimal valor))
                {
                    valor = 0;
                }

                total += valor;
            }

            lblTotal.Text = "Total: $" + total.ToString("N0");
        }

        private void AgregarTotalizador()
        {
            lblTotal = new Label
            {
                Name = "lblTotal",
                Location = new Point(50, 420),
                Size = new Size(700, 40),
                Font = new drawingFont("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.DarkBlue,
                Text = "Total: $0"
            };

            this.Controls.Add(lblTotal);
            lblTotal.BringToFront();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "PDF Files (*.pdf)|*.pdf",
                FileName = tipoDocumento + "_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".pdf"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                {
                    float altoCarta = iTextSharp.text.PageSize.LETTER.Height;
                    float altoMediaCarta = altoCarta / 2;

                    float margenSuperior = 30f;  // margen superior reducido
                    float margenInferior = altoCarta - altoMediaCarta + 71f;
                    float margenIzquierdo = 57f;
                    float margenDerecho = 57f;

                    Document doc = new Document(iTextSharp.text.PageSize.LETTER, margenIzquierdo, margenDerecho, margenSuperior, margenInferior);
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
                        SpacingAfter = 2f // menos espacio después del título
                    });

                    PdfPTable infoTable = new PdfPTable(2)
                    {
                        WidthPercentage = 100,
                        SpacingAfter = 5f
                    };
                    infoTable.SetWidths(new float[] { 1, 1 });

                    PdfPCell fechaCell = new PdfPCell(new Phrase("Fecha: " + dateTimePicker1.Value.ToShortDateString(), fontBody))
                    {
                        Border = iTextSharp.text.Rectangle.NO_BORDER,
                        HorizontalAlignment = Element.ALIGN_LEFT
                    };
                    PdfPCell pacienteCell = new PdfPCell(new Phrase("Paciente: " + lblNombrePaciente.Text, fontBody))
                    {
                        Border = iTextSharp.text.Rectangle.NO_BORDER,
                        HorizontalAlignment = Element.ALIGN_RIGHT
                    };

                    infoTable.AddCell(fechaCell);
                    infoTable.AddCell(pacienteCell);
                    doc.Add(infoTable);

                    if (tipoDocumento == "Cotizacion")
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
                            if (item > 8) break;

                            string procedimiento = row.Cells["Procedimiento"].Value?.ToString() ?? "";
                            string valorTexto = row.Cells["Valor"].Value?.ToString() ?? "0";
                            if (!decimal.TryParse(valorTexto, out decimal valor)) valor = 0;

                            table.AddCell(new PdfPCell(new Phrase(item.ToString(), fontBody)) { HorizontalAlignment = Element.ALIGN_CENTER });
                            table.AddCell(new PdfPCell(new Phrase(procedimiento, fontBody)) { HorizontalAlignment = Element.ALIGN_LEFT });
                            table.AddCell(new PdfPCell(new Phrase("$" + valor.ToString("N0"), fontBody)) { HorizontalAlignment = Element.ALIGN_RIGHT });
                            item++;
                        }
                        doc.Add(table);

                        doc.Add(new Paragraph(lblTotal.Text, fontTotal)
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
                    MessageBox.Show("PDF guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void DgvProcedimientos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is TextBox tb)
            {
                tb.KeyPress -= SoloNumeros_KeyPress;
                if (dgvProcedimientos.CurrentCell.ColumnIndex == dgvProcedimientos.Columns["Valor"].Index)
                {
                    tb.KeyPress += SoloNumeros_KeyPress;
                }
            }
        }

        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' && ((sender as TextBox).Text.Contains(",")))
            {
                e.Handled = true;
            }
        }

        private void DgvProcedimientos_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dgvProcedimientos.Columns[e.ColumnIndex].Name == "Valor")
            {
                string texto = e.FormattedValue?.ToString() ?? "";
                if (!decimal.TryParse(texto, out _))
                {
                    MessageBox.Show("Por favor ingresa solo números válidos en la columna 'Valor'.", "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                }
            }
        }

        private void FormDocumento_Load_1(object sender, EventArgs e)
        {

        }
    }
}
