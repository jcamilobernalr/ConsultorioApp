namespace ConsultorioApp
{
    partial class FormCotizacion
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimePicker_coti = new System.Windows.Forms.DateTimePicker();
            this.lblFecha_coti = new System.Windows.Forms.Label();
            this.txtNombrePaciente_coti = new System.Windows.Forms.TextBox();
            this.lblNombrePaciente_coti = new System.Windows.Forms.Label();
            this.lblTexto_cotiza = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.labelNombreDoctora = new System.Windows.Forms.Label();
            this.dgvProcedimientos = new System.Windows.Forms.DataGridView();
            this.ColProcedimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelTotalCoti = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcedimientos)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker_coti, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFecha_coti, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNombrePaciente_coti, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNombrePaciente_coti, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 65);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(660, 36);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // dateTimePicker_coti
            // 
            this.dateTimePicker_coti.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePicker_coti.Location = new System.Drawing.Point(69, 8);
            this.dateTimePicker_coti.Name = "dateTimePicker_coti";
            this.dateTimePicker_coti.Size = new System.Drawing.Size(192, 20);
            this.dateTimePicker_coti.TabIndex = 1;
            // 
            // lblFecha_coti
            // 
            this.lblFecha_coti.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFecha_coti.AutoSize = true;
            this.lblFecha_coti.Location = new System.Drawing.Point(3, 11);
            this.lblFecha_coti.Name = "lblFecha_coti";
            this.lblFecha_coti.Size = new System.Drawing.Size(37, 13);
            this.lblFecha_coti.TabIndex = 0;
            this.lblFecha_coti.Text = "Fecha";
            // 
            // txtNombrePaciente_coti
            // 
            this.txtNombrePaciente_coti.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNombrePaciente_coti.Location = new System.Drawing.Point(333, 8);
            this.txtNombrePaciente_coti.Name = "txtNombrePaciente_coti";
            this.txtNombrePaciente_coti.Size = new System.Drawing.Size(324, 20);
            this.txtNombrePaciente_coti.TabIndex = 3;
            // 
            // lblNombrePaciente_coti
            // 
            this.lblNombrePaciente_coti.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNombrePaciente_coti.AutoSize = true;
            this.lblNombrePaciente_coti.Location = new System.Drawing.Point(278, 11);
            this.lblNombrePaciente_coti.Name = "lblNombrePaciente_coti";
            this.lblNombrePaciente_coti.Size = new System.Drawing.Size(49, 13);
            this.lblNombrePaciente_coti.TabIndex = 2;
            this.lblNombrePaciente_coti.Text = "Paciente";
            this.lblNombrePaciente_coti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblTexto_cotiza.Text = "Cotización";
            this.lblTexto_cotiza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(256, 310);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(148, 29);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar PDF\t";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // labelNombreDoctora
            // 
            this.labelNombreDoctora.AutoSize = true;
            this.labelNombreDoctora.Font = new System.Drawing.Font("Great Vibes", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreDoctora.Location = new System.Drawing.Point(123, 9);
            this.labelNombreDoctora.Name = "labelNombreDoctora";
            this.labelNombreDoctora.Size = new System.Drawing.Size(429, 53);
            this.labelNombreDoctora.TabIndex = 10;
            this.labelNombreDoctora.Text = "Dra. Bertha Patricia Monroy Garibello";
            this.labelNombreDoctora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvProcedimientos
            // 
            this.dgvProcedimientos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvProcedimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProcedimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcedimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColProcedimiento,
            this.ColValor});
            this.dgvProcedimientos.Location = new System.Drawing.Point(3, 40);
            this.dgvProcedimientos.Name = "dgvProcedimientos";
            this.dgvProcedimientos.Size = new System.Drawing.Size(654, 210);
            this.dgvProcedimientos.TabIndex = 14;
            // 
            // ColProcedimiento
            // 
            this.ColProcedimiento.FillWeight = 149.2386F;
            this.ColProcedimiento.HeaderText = "Procedimiento";
            this.ColProcedimiento.Name = "ColProcedimiento";
            // 
            // ColValor
            // 
            this.ColValor.FillWeight = 50.76142F;
            this.ColValor.HeaderText = "Valor";
            this.ColValor.Name = "ColValor";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnGuardar, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.dgvProcedimientos, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblTexto_cotiza, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 107);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(660, 342);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.labelTotal, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelTotalCoti, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 259);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(654, 45);
            this.tableLayoutPanel3.TabIndex = 15;
            // 
            // labelTotal
            // 
            this.labelTotal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(330, 10);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(21, 24);
            this.labelTotal.TabIndex = 1;
            this.labelTotal.Text = "0";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotalCoti
            // 
            this.labelTotalCoti.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelTotalCoti.AutoSize = true;
            this.labelTotalCoti.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalCoti.Location = new System.Drawing.Point(268, 10);
            this.labelTotalCoti.Name = "labelTotalCoti";
            this.labelTotalCoti.Size = new System.Drawing.Size(56, 24);
            this.labelTotalCoti.TabIndex = 0;
            this.labelTotalCoti.Text = "Total:";
            this.labelTotalCoti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.labelNombreDoctora);
            this.Name = "FormCotizacion";
            this.Text = "Cotizacion";
            this.Load += new System.EventHandler(this.FormCotizacion_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcedimientos)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_coti;
        private System.Windows.Forms.Label lblFecha_coti;
        private System.Windows.Forms.TextBox txtNombrePaciente_coti;
        private System.Windows.Forms.Label lblNombrePaciente_coti;
        private System.Windows.Forms.Label lblTexto_cotiza;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label labelNombreDoctora;
        private System.Windows.Forms.DataGridView dgvProcedimientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProcedimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColValor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label labelTotalCoti;
        private System.Windows.Forms.Label labelTotal;
    }
}