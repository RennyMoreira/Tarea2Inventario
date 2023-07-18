using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2Inventario
{
    public class Proveedores
    {
        private string nombreproveedor;

        public string Nombreproveedor
        {
            get => nombreproveedor;
            set => nombreproveedor = ValidateNombreproveedor(value);
        }
        public override string ToString()
        {
            return $"Nombre Proveedor: {Nombreproveedor}";
        }

        private string ValidateNombreproveedor(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("El Proveedor no puede estar vacío");
                
            }
            return Nombreproveedor;
            
        }
    }
}
