using CalculadoraUX.Models;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Input;

namespace CalculadoraUX.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        #region Atributos

        private List<MathOperation> _HistorialOpercaciones { get; set; }
        #endregion

        #region Propiedades
        public List<MathOperation> HistorialOpercaciones { get; set; }

        #endregion


        #region Comandos
        public ICommand NumeroAddedCommand { get { return new RelayCommand<string>(NumeroAdded); } }
        #endregion



        #region Constructor ctor
        public MainPageViewModel()
        {
        }
        #endregion

        

        #region Methodos
        private void NumeroAdded(string digit)
        {

        }
        #endregion



    }
}
