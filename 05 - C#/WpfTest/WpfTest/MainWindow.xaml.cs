using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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


namespace WpfTest
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        char[] op = new char[4] { '+', '-', 'x', '/' };

        //Affichage de la valeur du bouton dans l'ecrant d'affichage
        private void BtnNumerique_Click(object sender, RoutedEventArgs e)
        {
            Tbx_affichage.Text += ((Button)sender).Content;
        }

        private void BtnVirgule_Click(object sender, RoutedEventArgs e)
        {
            int posOp = 0;
            if (Tbx_affichage.Text == "")
            {
                BtnNumerique_Click(sender, e);
            }
            foreach (char unOp in Tbx_affichage.Text)
            {
                if (Array.Exists(op, x => x == unOp))
                {
                    posOp = Tbx_affichage.Text.IndexOf(unOp);
                }
            }
            if (posOp == -1)
            {
                if (Tbx_affichage.Text.IndexOf(",") == -1)
                {
                    BtnNumerique_Click(sender, e);
                }
            }
            else
            {
                if (Tbx_affichage.Text[Tbx_affichage.Text.Length - 1] != '+' && Tbx_affichage.Text[Tbx_affichage.Text.Length - 1] != '-' && Tbx_affichage.Text[Tbx_affichage.Text.Length - 1] != 'x' && Tbx_affichage.Text[Tbx_affichage.Text.Length - 1] != '%')
                {
                    string reste = Tbx_affichage.Text.Substring(posOp);
                    if (reste.IndexOf(',') == -1)
                    {
                        BtnNumerique_Click(sender, e);
                    }
                }
            }
        }

        //Remise a 0 de l'affichage
        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            Tbx_affichage.Text = "";
        }

        private void BtnOperateur_Click(object sender, RoutedEventArgs e)
        {
            bool autorisation = true;
            foreach (char unOp in Tbx_affichage.Text)
            {
                if (Array.Exists(op, x => x == unOp))
                {
                    autorisation = false;
                }
            }
            if (Tbx_affichage.Text != "" && autorisation)
            {
                Tbx_affichage.Text += ((Button)sender).Content;
            }
        }

        private void BtnResult_Click(object sender, RoutedEventArgs e)
        {
            char operateur = ' ';
            string[] nb = new string[2] {" "," "};
            double resultat = 0;
                foreach (char unOp in Tbx_affichage.Text)
                {
                    if (Array.Exists(op, x => x == unOp))
                    {
                        operateur = Tbx_affichage.Text[Tbx_affichage.Text.IndexOf(unOp)];
                        nb = Tbx_affichage.Text.Split(operateur);
                    }
                }

            switch (operateur)
            {
                case '+':
                    resultat = double.Parse(nb[0]) + double.Parse(nb[1]);
                    break;
                case '-':
                    resultat = double.Parse(nb[0]) - double.Parse(nb[1]);
                    break;
                case 'x':
                    resultat = double.Parse(nb[0]) * double.Parse(nb[1]);
                    break;
                case '/':
                    if (double.Parse(nb[0]) != 0 && double.Parse(nb[1]) != 0)
                    {
                        resultat = double.Parse(nb[0]) / double.Parse(nb[1]);
                    }
                    else
                    {
                        resultat = 0;
                    }
                    break;
                default:
                    resultat = double.Parse(Tbx_affichage.Text);
                    break;
            }
            Tbx_affichage.Text = resultat + "";
        }

        private void BtnSupp_Click(object sender, RoutedEventArgs e)
        {
            if (Tbx_affichage.Text != "")
            {
                Tbx_affichage.Text = Tbx_affichage.Text.Substring(0, Tbx_affichage.Text.Length-1);
            }
        }
    }
}
