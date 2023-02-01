using Practica_MVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Practica_MVVM.ViewModels
{
    internal class AddPersonaCommand : CommandBase
    {
        private ObservableCollection<PersonaModel> _listaPersonas;

        public AddPersonaCommand()
        {

        }

        public AddPersonaCommand(ObservableCollection<PersonaModel> listaPersonas)
        {
            this._listaPersonas = listaPersonas;
        }

        public override void Execute(object parameter)
        {
            //Añadir un registro
            PersonaModel miPersona = new PersonaModel(3, "Manolito" , "Gafotas");
            _listaPersonas.Add(miPersona);
        }
    }
}
