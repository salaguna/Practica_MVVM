using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_MVVM.Models
{
    internal class ListaPersonas : ViewModels.ViewModelBase
    {
        private PersonaModel _PersonaSeleccionada;
        public PersonaModel PersonaActual { 
            get { return _PersonaSeleccionada; }
            set {
                _PersonaSeleccionada = value;
            } 
        }

        public ObservableCollection<Models.PersonaModel> lstPersonas { get; set; }
    }
}
