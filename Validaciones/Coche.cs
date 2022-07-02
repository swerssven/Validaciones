using System;
using System.Collections.Generic;
using System.Text;

namespace Validaciones
{
    public class Coche
    {
        private DateTime fechaVenta;
        private String hora;
        private String idEmpleado;
        private String nTelf;
        private String matricula;
        private Decimal valorVenta;

        public Coche(DateTime fechaVenta, String hora, String idEmpleado, String nTelf, String matricula, Decimal valorVenta)
        {
            this.fechaVenta = fechaVenta;
            this.hora = hora;
            this.idEmpleado = idEmpleado;
            this.nTelf = nTelf;
            this.matricula = matricula;
            this.valorVenta = valorVenta;
        }
    }
}
