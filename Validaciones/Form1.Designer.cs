
namespace Validaciones
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.msk_Fecha = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.lbl_Valor = new System.Windows.Forms.Label();
            this.lbl_Matricula = new System.Windows.Forms.Label();
            this.lbl_Telf = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_HoraVenta = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.msk_Valor = new System.Windows.Forms.MaskedTextBox();
            this.msk_Matricula = new System.Windows.Forms.MaskedTextBox();
            this.msk_Telf = new System.Windows.Forms.MaskedTextBox();
            this.msk_ID = new System.Windows.Forms.MaskedTextBox();
            this.msk_Hora = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // msk_Fecha
            // 
            this.msk_Fecha.Location = new System.Drawing.Point(3, 11);
            this.msk_Fecha.Mask = "00/00/0000";
            this.msk_Fecha.Name = "msk_Fecha";
            this.msk_Fecha.Size = new System.Drawing.Size(100, 23);
            this.msk_Fecha.TabIndex = 0;
            this.msk_Fecha.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.msk_Fecha_TypeValidationCompleted);
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Location = new System.Drawing.Point(28, 14);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(41, 15);
            this.lbl_Fecha.TabIndex = 1;
            this.lbl_Fecha.Text = "Fecha:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Location = new System.Drawing.Point(13, 13);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_Guardar);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_Valor);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_Matricula);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_Telf);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_ID);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_HoraVenta);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_Fecha);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btn_Salir);
            this.splitContainer1.Panel2.Controls.Add(this.msk_Valor);
            this.splitContainer1.Panel2.Controls.Add(this.msk_Matricula);
            this.splitContainer1.Panel2.Controls.Add(this.msk_Telf);
            this.splitContainer1.Panel2.Controls.Add(this.msk_ID);
            this.splitContainer1.Panel2.Controls.Add(this.msk_Hora);
            this.splitContainer1.Panel2.Controls.Add(this.msk_Fecha);
            this.splitContainer1.Size = new System.Drawing.Size(306, 377);
            this.splitContainer1.SplitterDistance = 158;
            this.splitContainer1.TabIndex = 2;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(81, 199);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_Guardar.TabIndex = 7;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // lbl_Valor
            // 
            this.lbl_Valor.AutoSize = true;
            this.lbl_Valor.Location = new System.Drawing.Point(28, 159);
            this.lbl_Valor.Name = "lbl_Valor";
            this.lbl_Valor.Size = new System.Drawing.Size(96, 15);
            this.lbl_Valor.TabIndex = 6;
            this.lbl_Valor.Text = "Valor de la venta:";
            // 
            // lbl_Matricula
            // 
            this.lbl_Matricula.AutoSize = true;
            this.lbl_Matricula.Location = new System.Drawing.Point(28, 130);
            this.lbl_Matricula.Name = "lbl_Matricula";
            this.lbl_Matricula.Size = new System.Drawing.Size(95, 15);
            this.lbl_Matricula.TabIndex = 5;
            this.lbl_Matricula.Text = "Matricula coche:";
            // 
            // lbl_Telf
            // 
            this.lbl_Telf.AutoSize = true;
            this.lbl_Telf.Location = new System.Drawing.Point(28, 101);
            this.lbl_Telf.Name = "lbl_Telf";
            this.lbl_Telf.Size = new System.Drawing.Size(128, 15);
            this.lbl_Telf.TabIndex = 4;
            this.lbl_Telf.Text = "Nº Telefono empleado:";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(28, 72);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(77, 15);
            this.lbl_ID.TabIndex = 3;
            this.lbl_ID.Text = "ID Empleado:";
            // 
            // lbl_HoraVenta
            // 
            this.lbl_HoraVenta.AutoSize = true;
            this.lbl_HoraVenta.Location = new System.Drawing.Point(28, 43);
            this.lbl_HoraVenta.Name = "lbl_HoraVenta";
            this.lbl_HoraVenta.Size = new System.Drawing.Size(84, 15);
            this.lbl_HoraVenta.TabIndex = 2;
            this.lbl_HoraVenta.Text = "Hora de venta:";
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(14, 199);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 8;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // msk_Valor
            // 
            this.msk_Valor.Location = new System.Drawing.Point(3, 156);
            this.msk_Valor.Mask = "999999,99€";
            this.msk_Valor.Name = "msk_Valor";
            this.msk_Valor.Size = new System.Drawing.Size(100, 23);
            this.msk_Valor.TabIndex = 5;
            this.msk_Valor.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.msk_Valor_TypeValidationCompleted);
            // 
            // msk_Matricula
            // 
            this.msk_Matricula.Location = new System.Drawing.Point(3, 127);
            this.msk_Matricula.Mask = "0000LLL";
            this.msk_Matricula.Name = "msk_Matricula";
            this.msk_Matricula.Size = new System.Drawing.Size(100, 23);
            this.msk_Matricula.TabIndex = 4;
            this.msk_Matricula.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.msk_Matricula_TypeValidationCompleted);
            // 
            // msk_Telf
            // 
            this.msk_Telf.Location = new System.Drawing.Point(3, 98);
            this.msk_Telf.Mask = "000-000-000";
            this.msk_Telf.Name = "msk_Telf";
            this.msk_Telf.Size = new System.Drawing.Size(100, 23);
            this.msk_Telf.TabIndex = 3;
            this.msk_Telf.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.msk_Telf_TypeValidationCompleted);
            // 
            // msk_ID
            // 
            this.msk_ID.Location = new System.Drawing.Point(3, 69);
            this.msk_ID.Mask = "V-0000000";
            this.msk_ID.Name = "msk_ID";
            this.msk_ID.Size = new System.Drawing.Size(100, 23);
            this.msk_ID.TabIndex = 2;
            this.msk_ID.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.msk_ID_TypeValidationCompleted);
            // 
            // msk_Hora
            // 
            this.msk_Hora.Location = new System.Drawing.Point(3, 40);
            this.msk_Hora.Mask = "00:00";
            this.msk_Hora.Name = "msk_Hora";
            this.msk_Hora.Size = new System.Drawing.Size(100, 23);
            this.msk_Hora.TabIndex = 1;
            this.msk_Hora.ValidatingType = typeof(System.DateTime);
            this.msk_Hora.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.msk_Hora_TypeValidationCompleted);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 272);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Venta coche";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox msk_Fecha;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lbl_Valor;
        private System.Windows.Forms.Label lbl_Matricula;
        private System.Windows.Forms.Label lbl_Telf;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_HoraVenta;
        private System.Windows.Forms.MaskedTextBox msk_Valor;
        private System.Windows.Forms.MaskedTextBox msk_Matricula;
        private System.Windows.Forms.MaskedTextBox msk_Telf;
        private System.Windows.Forms.MaskedTextBox msk_ID;
        private System.Windows.Forms.MaskedTextBox msk_Hora;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

