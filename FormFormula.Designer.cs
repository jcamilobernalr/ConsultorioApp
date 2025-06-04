namespace ConsultorioApp
{
    partial class FormFormula
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnGuardar_receta = new System.Windows.Forms.Button();
            this.lblTexto_cotiza = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimePicker_receta = new System.Windows.Forms.DateTimePicker();
            this.lblFecha_receta = new System.Windows.Forms.Label();
            this.txtNombrePaciente_receta = new System.Windows.Forms.TextBox();
            this.lblNombrePaciente_receta = new System.Windows.Forms.Label();
            this.labelNombreDoctora_receta = new System.Windows.Forms.Label();
            this.txtRecetaManual = new System.Windows.Forms.TextBox();
            this.btnAgregarMedicamento = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnGuardar_receta, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblTexto_cotiza, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtRecetaManual, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnAgregarMedicamento, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 108);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(660, 342);
            this.tableLayoutPanel2.TabIndex = 18;
            // 
            // btnGuardar_receta
            // 
            this.btnGuardar_receta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar_receta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar_receta.Location = new System.Drawing.Point(256, 310);
            this.btnGuardar_receta.Name = "btnGuardar_receta";
            this.btnGuardar_receta.Size = new System.Drawing.Size(148, 29);
            this.btnGuardar_receta.TabIndex = 12;
            this.btnGuardar_receta.Text = "Guardar PDF\t";
            this.btnGuardar_receta.UseVisualStyleBackColor = true;
            this.btnGuardar_receta.Click += new System.EventHandler(this.btnGuardar_receta_Click);
            // 
            // lblTexto_cotiza
            // 
            this.lblTexto_cotiza.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTexto_cotiza.AutoSize = true;
            this.lblTexto_cotiza.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto_cotiza.Location = new System.Drawing.Point(3, 0);
            this.lblTexto_cotiza.Name = "lblTexto_cotiza";
            this.lblTexto_cotiza.Size = new System.Drawing.Size(654, 34);
            this.lblTexto_cotiza.TabIndex = 9;
            this.lblTexto_cotiza.Text = "Receta";
            this.lblTexto_cotiza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTexto_cotiza.Click += new System.EventHandler(this.lblTexto_cotiza_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker_receta, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFecha_receta, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNombrePaciente_receta, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNombrePaciente_receta, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 66);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(660, 36);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // dateTimePicker_receta
            // 
            this.dateTimePicker_receta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePicker_receta.Location = new System.Drawing.Point(69, 8);
            this.dateTimePicker_receta.Name = "dateTimePicker_receta";
            this.dateTimePicker_receta.Size = new System.Drawing.Size(192, 20);
            this.dateTimePicker_receta.TabIndex = 1;
            // 
            // lblFecha_receta
            // 
            this.lblFecha_receta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFecha_receta.AutoSize = true;
            this.lblFecha_receta.Location = new System.Drawing.Point(3, 11);
            this.lblFecha_receta.Name = "lblFecha_receta";
            this.lblFecha_receta.Size = new System.Drawing.Size(37, 13);
            this.lblFecha_receta.TabIndex = 0;
            this.lblFecha_receta.Text = "Fecha";
            // 
            // txtNombrePaciente_receta
            // 
            this.txtNombrePaciente_receta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNombrePaciente_receta.Location = new System.Drawing.Point(333, 8);
            this.txtNombrePaciente_receta.Name = "txtNombrePaciente_receta";
            this.txtNombrePaciente_receta.Size = new System.Drawing.Size(324, 20);
            this.txtNombrePaciente_receta.TabIndex = 3;
            // 
            // lblNombrePaciente_receta
            // 
            this.lblNombrePaciente_receta.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNombrePaciente_receta.AutoSize = true;
            this.lblNombrePaciente_receta.Location = new System.Drawing.Point(278, 11);
            this.lblNombrePaciente_receta.Name = "lblNombrePaciente_receta";
            this.lblNombrePaciente_receta.Size = new System.Drawing.Size(49, 13);
            this.lblNombrePaciente_receta.TabIndex = 2;
            this.lblNombrePaciente_receta.Text = "Paciente";
            this.lblNombrePaciente_receta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNombreDoctora_receta
            // 
            this.labelNombreDoctora_receta.AutoSize = true;
            this.labelNombreDoctora_receta.Font = new System.Drawing.Font("Great Vibes", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreDoctora_receta.Location = new System.Drawing.Point(123, 10);
            this.labelNombreDoctora_receta.Name = "labelNombreDoctora_receta";
            this.labelNombreDoctora_receta.Size = new System.Drawing.Size(429, 53);
            this.labelNombreDoctora_receta.TabIndex = 16;
            this.labelNombreDoctora_receta.Text = "Dra. Bertha Patricia Monroy Garibello";
            this.labelNombreDoctora_receta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRecetaManual
            // 
            this.txtRecetaManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecetaManual.Location = new System.Drawing.Point(3, 71);
            this.txtRecetaManual.Multiline = true;
            this.txtRecetaManual.Name = "txtRecetaManual";
            this.txtRecetaManual.Size = new System.Drawing.Size(654, 233);
            this.txtRecetaManual.TabIndex = 16;
            // 
            // btnAgregarMedicamento
            // 
            this.btnAgregarMedicamento.Location = new System.Drawing.Point(3, 37);
            this.btnAgregarMedicamento.Name = "btnAgregarMedicamento";
            this.btnAgregarMedicamento.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarMedicamento.TabIndex = 17;
            this.btnAgregarMedicamento.Text = "Agregar Medicamento";
            this.btnAgregarMedicamento.UseVisualStyleBackColor = true;
            this.btnAgregarMedicamento.Click += new System.EventHandler(this.btnAgregarMedicamento_Click);
            // 
            // FormFormula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.labelNombreDoctora_receta);
            this.Name = "FormFormula";
            this.Text = "FormFormula";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnGuardar_receta;
        private System.Windows.Forms.Label lblTexto_cotiza;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_receta;
        private System.Windows.Forms.Label lblFecha_receta;
        private System.Windows.Forms.TextBox txtNombrePaciente_receta;
        private System.Windows.Forms.Label lblNombrePaciente_receta;
        private System.Windows.Forms.Label labelNombreDoctora_receta;
        private System.Windows.Forms.TextBox txtRecetaManual;
        private System.Windows.Forms.Button btnAgregarMedicamento;
    }
}