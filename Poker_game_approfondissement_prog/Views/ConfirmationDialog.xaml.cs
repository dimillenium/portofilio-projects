﻿using System;
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
using System.Windows.Shapes;

namespace Poker_game_approfondissement_prog.Views
{
    public partial class ConfirmationDialog : Window
    {

        public ConfirmationDialog(string qst, string msg, string btn)
        {
            InitializeComponent();
            questionText.Text = qst;
            messageText.Text = msg;
            confirmationBouton.Content = btn;
            DataContext = this;
        }

        private void btn_Continuer_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void btn_Annuler_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
