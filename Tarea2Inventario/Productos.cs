using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2Inventario
{
    public class Productos
    {
        private double id;
        private string nombreproducto;
        private string categoria;
        public Productos()
        {
            id = 0;
            nombreproducto = string.Empty;
            categoria = string.Empty;
        }

        public Productos(double id, string nombreproducto, string categoria)
        {
            id = ValidateId(id);
            nombreproducto = ValidateNombreproducto(nombreproducto);
            categoria = ValidateCategoria(categoria);
        }

        public double Id
        {
            get => id;
            set => id = ValidateId(value);
        }
        
        public string Nombreproducto
        {
            get => nombreproducto;
            set => nombreproducto = ValidateNombreproducto(value);
        }
        public string Categoría
        {
            get => categoria;
            set => categoria = ValidateCategoria(value);
        }
        public override string ToString()
        {
            return $"Id: {Id,4:0000}/Nombre Producto: {Nombreproducto}/ Categoria:{Categoría}";
        }

        private string ValidateCategoria(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Categoría no puede estar vacía");
            }
            return Categoría;
        }

        private string ValidateNombreproducto(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Producto no puede estar vacío");
            }
            return Nombreproducto;
            
        }

        private double ValidateId(double value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Id Incorrecto");
            }
            return Id;
        }
       
    }
}
