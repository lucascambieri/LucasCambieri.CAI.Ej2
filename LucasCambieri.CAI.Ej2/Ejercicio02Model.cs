using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasCambieri.CAI.Ej2
{
    internal class Ejercicio02Model
    {
        public string[] Marcas { get; } = new string[] { "Ford ", "Fiat", "Chevrolet", "Audi" };

        public string NombreUsuario { get; } = "lcambieri";

        public string NombreReal { get; } = "Lucas Cambieri";

        public string Modelo { get; set; }
        public string Año { get; set; }
        public string Precio { get; set; }
        public string Marca { get; set; }

        public DateTime Fecha { get; } = DateTime.Now;


        public string Validar()
        {
            //Precio es decimal
            if (string.IsNullOrEmpty(Precio))
            {
                return "El precio no puede estar vacío.";
            }

            if (!decimal.TryParse(Precio, out decimal precio))
            {
                return "El precio ingresado no es un valor númerico válido.";
            }

            if (precio <= 0)
            {
                return "El precio debe ser mayor a 0.";
            }

            if (string.IsNullOrEmpty(Modelo))
            {
                return "El modelo no puede estar vacío.";
            }

            if (Modelo.Length > 30)
            {
                return "El modelo no puede tener más de 30 caracteres.";
            }

            if(string.IsNullOrEmpty(Año))
            {
                return "El año no puede estar vacío.";
            }

            if (!int.TryParse(Año, out int año))
            {
                return "El año debe ser un valor númerico entero.";
            }

            if(año < 2000 || año > 2021)
            {
                return "El año debe ser entre 2000 y 2021";
            }

            
            return "ok";
        }
    }
}
