using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Validaciones
{
    public partial class Form1 : Form
    {
        private Coche car1;
        private DateTime fechaConvertida;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (msk_Fecha.Text != "" && msk_Hora.Text != "" && msk_ID.Text != "" && msk_Telf.Text != "" && msk_Matricula.Text !="" && msk_Valor.Text != ""){
                    
                    car1 = new Coche(fechaConvertida, msk_Hora.Text, msk_ID.Text, msk_Telf.Text, msk_Matricula.Text, Convert.ToDecimal(msk_Valor.Text.Replace("€", "")));
                    MessageBox.Show("Venta guardada");
                    msk_Fecha.Text = "";
                    msk_Hora.Text = "";
                    msk_ID.Text = "";
                    msk_Telf.Text = "";
                    msk_Matricula.Text = "";
                    msk_Valor.Text = "";
                }
                else
                {
                    MessageBox.Show("Existen campos vacíos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            msk_Fecha.ValidatingType = typeof(DateTime);
            msk_Hora.ValidatingType = typeof(String);
            msk_ID.ValidatingType = typeof(String);
            msk_Telf.ValidatingType = typeof(String);
            msk_Matricula.ValidatingType = typeof(String);
            msk_Valor.ValidatingType = typeof(decimal);
        }

        private void msk_Fecha_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            //this.msk_Fecha.TextMaskFormat = MaskFormat.IncludePromptAndLiterals; lo comento porque queremos que nos guarde las barras inclinadas en el string.
            CultureInfo cultureinfo = new CultureInfo("es-ES");
            // Si no se consigue el text al formato español no entra en el if.
            if (!DateTime.TryParseExact(msk_Fecha.Text, "dd/MM/yyyy", cultureinfo, DateTimeStyles.None, out fechaConvertida))
            {
                this.errorProvider1.SetError(this.msk_Fecha, "Fecha incorrecta");
                e.Cancel = true;
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void msk_Hora_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            int horas = Int32.Parse(msk_Hora.Text.Split(":")[0]);
            int min = Int32.Parse(msk_Hora.Text.Split(":")[1]);
            if (!e.IsValidInput || horas > 23 || horas < 0 || min > 59 || min < 0)
            {
                this.errorProvider1.SetError(this.msk_Hora, "Hora incorrecta");
                e.Cancel = true;
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void msk_ID_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            this.msk_ID.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (!e.IsValidInput)
            {
                this.errorProvider1.SetError(this.msk_ID, "ID incorrecto");
                e.Cancel = true;
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void msk_Telf_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            this.msk_Telf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (!e.IsValidInput)
            {
                this.errorProvider1.SetError(this.msk_Telf, "Teléfono incorrecto");
                e.Cancel = true;
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void msk_Matricula_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            msk_Matricula.Text = msk_Matricula.Text.ToUpper();
            this.msk_Matricula.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (!e.IsValidInput)
            {
                this.errorProvider1.SetError(this.msk_Matricula, "Matrícula incorrecta");
                e.Cancel = true;
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void msk_Valor_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            this.msk_Valor.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (!e.IsValidInput)
            {
                this.errorProvider1.SetError(this.msk_Valor, "Valor incorrecto");
                e.Cancel = true;
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
