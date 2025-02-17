﻿using ATM;
using ATMInterface.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ATMInterface.Views
{
    /// <summary>
    /// Логика взаимодействия для CheckBalanceView.xaml
    /// </summary>
    public partial class CheckBalanceView : UserControl
    {

        private CheckBalanceViewModel _viewmodel;
        public CheckBalanceView(Action goToMain, eATM atm)
        {
            InitializeComponent();
            DataContext = _viewmodel = new CheckBalanceViewModel(goToMain, atm);
        }
    }
}
