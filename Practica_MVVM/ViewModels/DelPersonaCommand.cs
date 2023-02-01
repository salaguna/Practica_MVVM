using Practica_MVVM.Models;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace Practica_MVVM.ViewModels
{
    internal class DelPersonaCommand : CommandBase
    {
        private ObservableCollection<PersonaModel> _listaPersonas;
        public DelPersonaCommand(ObservableCollection<PersonaModel> listaPersonas)
        {
            this._listaPersonas = listaPersonas;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }


        public override void Execute(object parameter)
        {
            PersonaModel miPersona = (PersonaModel) parameter;
            MessageBox.Show("Va a eliminar a "+miPersona.Nombre.ToString());
            _listaPersonas.Remove(miPersona);
        }
    }
}