using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2Inventario
{
    public class Clientes
    {
        private string nombrecliente;
        private int cedula;

        public string Nombrecliente
        {
            get => nombrecliente;
            set => nombrecliente = ValidateNombrecliente(value);
        }
        public int Cedula
        {
            get => cedula;
            set => cedula = ValidateCedula(value);
        }
        public override string ToString()
        {
            return $"Nombre Cliente: {Nombrecliente}/Cédula:{Cedula, 10:0000000000}";
        }

        private int ValidateCedula(int value)
        {
            if (cedula > 10)
            {
                throw new ArgumentException("Cédula no válida");
            }
            return cedula;
        }

        private string ValidateNombrecliente(string value)
        {
            if(string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("El nombre no puede estar vacío");
            }
            return Nombrecliente;
        }
    }

}
