namespace ConsultorioApp
{
    partial class FormExcusa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExcusa));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnGuardar_excusa = new System.Windows.Forms.Button();
            this.lblTexto_excusa = new System.Windows.Forms.Label();
            this.txtExcusa = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimePicker_excusa = new System.Windows.Forms.DateTimePicker();
            this.lblFecha__excusa = new System.Windows.Forms.Label();
            this.txtNombrePaciente_excusa = new System.Windows.Forms.TextBox();
            this.lblNombrePaciente_excusa = new System.Windows.Forms.Label();
            this.labelNombreDoctora_excusa = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnGuardar_excusa, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblTexto_excusa, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtExcusa, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 108);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(660, 342);
            this.tableLayoutPanel2.TabIndex = 21;
            // 
            // btnGuardar_excusa
            // 
            this.btnGuardar_excusa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar_excusa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar_excusa.Location = new System.Drawing.Point(256, 310);
            this.btnGuardar_excusa.Name = "btnGuardar_excusa";
            this.btnGuardar_excusa.Size = new System.Drawing.Size(148, 29);
            this.btnGuardar_excusa.TabIndex = 12;
            this.btnGuardar_excusa.Text = "Guardar PDF\t";
            this.btnGuardar_excusa.UseVisualStyleBackColor = true;
            this.btnGuardar_excusa.Click += new System.EventHandler(this.btnGuardar_excusa_Click);
            // 
            // lblTexto_excusa
            // 
            this.lblTexto_excusa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTexto_excusa.AutoSize = true;
            this.lblTexto_excusa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto_excusa.Location = new System.Drawing.Point(3, 0);
            this.lblTexto_excusa.Name = "lblTexto_excusa";
            this.lblTexto_excusa.Size = new System.Drawing.Size(654, 34);
            this.lblTexto_excusa.TabIndex = 9;
            this.lblTexto_excusa.Text = "Excusa";
            this.lblTexto_excusa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtExcusa
            // 
            this.txtExcusa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExcusa.Location = new System.Drawing.Point(3, 37);
            this.txtExcusa.Multiline = true;
            this.txtExcusa.Name = "txtExcusa";
            this.txtExcusa.Size = new System.Drawing.Size(654, 267);
            this.txtExcusa.TabIndex = 16;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker_excusa, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFecha__excusa, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNombrePaciente_excusa, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNombrePaciente_excusa, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 66);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(660, 36);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // dateTimePicker_excusa
            // 
            this.dateTimePicker_excusa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePicker_excusa.Location = new System.Drawing.Point(69, 8);
            this.dateTimePicker_excusa.Name = "dateTimePicker_excusa";
            this.dateTimePicker_excusa.Size = new System.Drawing.Size(192, 20);
            this.dateTimePicker_excusa.TabIndex = 1;
            // 
            // lblFecha__excusa
            // 
            this.lblFecha__excusa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFecha__excusa.AutoSize = true;
            this.lblFecha__excusa.Location = new System.Drawing.Point(3, 11);
            this.lblFecha__excusa.Name = "lblFecha__excusa";
            this.lblFecha__excusa.Size = new System.Drawing.Size(37, 13);
            this.lblFecha__excusa.TabIndex = 0;
            this.lblFecha__excusa.Text = "Fecha";
            // 
            // txtNombrePaciente_excusa
            // 
            this.txtNombrePaciente_excusa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNombrePaciente_excusa.Location = new System.Drawing.Point(333, 8);
            this.txtNombrePaciente_excusa.Name = "txtNombrePaciente_excusa";
            this.txtNombrePaciente_excusa.Size = new System.Drawing.Size(324, 20);
            this.txtNombrePaciente_excusa.TabIndex = 3;
            // 
            // lblNombrePaciente_excusa
            // 
            this.lblNombrePaciente_excusa.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNombrePaciente_excusa.AutoSize = true;
            this.lblNombrePaciente_excusa.Location = new System.Drawing.Point(278, 11);
            this.lblNombrePaciente_excusa.Name = "lblNombrePaciente_excusa";
            this.lblNombrePaciente_excusa.Size = new System.Drawing.Size(49, 13);
            this.lblNombrePaciente_excusa.TabIndex = 2;
            this.lblNombrePaciente_excusa.Text = "Paciente";
            this.lblNombrePaciente_excusa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNombreDoctora_excusa
            // 
            this.labelNombreDoctora_excusa.AutoSize = true;
            this.labelNombreDoctora_excusa.Font = new System.Drawing.Font("Great Vibes", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreDoctora_excusa.Location = new System.Drawing.Point(123, 10);
            this.labelNombreDoctora_excusa.Name = "labelNombreDoctora_excusa";
            this.labelNombreDoctora_excusa.Size = new System.Drawing.Size(429, 53);
            this.labelNombreDoctora_excusa.TabIndex = 19;
            this.labelNombreDoctora_excusa.Text = "Dra. Bertha Patricia Monroy Garibello";
            this.labelNombreDoctora_excusa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormExcusa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.labelNombreDoctora_excusa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormExcusa";
            this.Text = "Excusa";
            this.Load += new System.EventHandler(this.FormExcusa_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnGuardar_excusa;
        private System.Windows.Forms.Label lblTexto_excusa;
        private System.Windows.Forms.TextBox txtExcusa;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_excusa;
        private System.Windows.Forms.Label lblFecha__excusa;
        private System.Windows.Forms.TextBox txtNombrePaciente_excusa;
        private System.Windows.Forms.Label lblNombrePaciente_excusa;
        private System.Windows.Forms.Label labelNombreDoctora_excusa;
    }
}