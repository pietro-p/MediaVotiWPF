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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MediaVoti
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            const int COMPITI = 4;
            if (txtCompito1.Text == "" || txtCompito2.Text == "" || txtCompito3.Text == "" || txtCompito4.Text == "")
            {
                MessageBox.Show("Non sono stati compilati tutti i campi", "Attenzione", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            try
            {
                double compito1 = double.Parse(txtCompito1.Text);
                double compito2 = double.Parse(txtCompito2.Text);
                double compito3 = double.Parse(txtCompito3.Text);
                double compito4 = double.Parse(txtCompito4.Text);
                if (compito1 >= 2 && compito1 <= 10 && compito2 >= 2 && compito2 <= 10 && compito3 >= 2 && compito3 <= 10 && compito4 >= 2 && compito4 <= 10)
                {
                    double somma = compito1 + compito2 + compito3 + compito4;
                    double media = somma / COMPITI;
                    lblMedia.Content = media;
                    double min = Math.Min(compito1,(Math.Min(compito2,(Math.Min(compito3, compito4)))));
                    double max = Math.Max(compito1, (Math.Max(compito2, (Math.Max(compito3, compito4)))));
                    lblMin.Content = min;
                    lblMax.Content = max;
                    double incidenza1 = (compito1 / somma) * 100;
                    double incidenza2 = (compito2 / somma) * 100;
                    double incidenza3 = (compito3 / somma) * 100;
                    double incidenza4 = (compito4 / somma) * 100;
                    lblIncidenza1.Content = incidenza1;
                    lblIncidenza2.Content = incidenza2;
                    lblIncidenza3.Content = incidenza3;
                    lblIncidenza4.Content = incidenza2;
                    if (media >= 6)
                        lblRisposta.Content = "Studente PROMOSSO";
                    else
                        lblRisposta.Content = "Studente BOCCIATO";
                }
                else
                {
                    MessageBox.Show("Inserire un voto da 2 a 10", "Attenzione", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            catch (Exception ex)
            {
                lblRisposta.Content = ex.Message;
            }
        }
    }
}
