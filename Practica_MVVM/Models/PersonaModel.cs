using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_MVVM.Models
{
    public class PersonaModel 
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public PersonaModel(int id, string nombre, string apellido)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
        }
    }
}
