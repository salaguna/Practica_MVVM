using Practica_MVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Practica_MVVM.ViewModels
{
    internal class appViewModel : ViewModelBase
    {
        private string _texto;
        private PersonaModel _PersonaActual;
        public PersonaModel PersonaActual
        {
            get { return _PersonaActual; }
            set
            {
                _PersonaActual = value;
                OnPropertyChanged(nameof(PersonaActual));
            }
        }
        public string Texto
        {
            get { return _texto; }
            set { _texto = value;
                OnPropertyChanged(nameof(Texto));
            }
        }
        private ObservableCollection<Models.PersonaModel> _listaPersonasModel = new ObservableCollection<Models.PersonaModel>();
        public ObservableCollection<Models.PersonaModel> ListaPersonas => _listaPersonasModel;


        private ICommand btnAddPersona;
        public ICommand AddPersonaCommand
        {
            get
            {
                if (btnAddPersona == null) btnAddPersona = new AddPersonaCommand(ListaPersonas);
                return btnAddPersona;
            }
            set{ btnAddPersona = value; }
        }

        private ICommand btnDelPersona;
        public ICommand DelPersonaCommand
        {
            get {
                if (btnDelPersona == null) btnDelPersona = new DelPersonaCommand(ListaPersonas);
                return btnDelPersona;
            }
            set { btnDelPersona = value; }
        }

        public appViewModel()
        {
            //Inicializar la lista con un par de elementos
            PersonaModel miPersona = new PersonaModel(1, "Mickey", "Mouse");
            ListaPersonas.Add(miPersona);
            miPersona = new PersonaModel(2, "Harry", "Potters");
            ListaPersonas.Add(miPersona);
        }
    }
}
