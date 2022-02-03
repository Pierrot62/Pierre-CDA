using Interface_Carte_dAquisition_PicoDrDAQ;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Automate
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Boolean AutoScroll = true;

        short handle;
        uint echantillonnage = 500;
        ushort overflow;
        short son;
        short temp;
        short lum;
        int tempsAcquisition=3000; //En ms

        /* SEUILS */
        float seuilHautSon;
        float seuilBasSon;
        float seuilHautTemperature;
        float seuilBasTemperature;
        float seuilHautLumiere;
        float seuilBasLumiere;

        /* PENALITE TEMPS */
        int tempsSon;
        int tempsTemp;


        /* COULEURS */
        List<int> seuilBasCouleur = new List<int>();
        List<int> seuilOKCouleur = new List<int>();
        List<int> seuilHautCouleur = new List<int>();

        /* Arret */
        bool arret = false;

        List<string> mesureTemperature = new List<string>();
        List<string> mesureSon = new List<string>();
        List<string> mesureLumiere = new List<string>();
        List<string> tabDate = new List<string>();
        List<List<string>> tabAnomalies = new List<List<string>>();
        int TailleEnvoi = 2;
        string conString = "Server=localhost;Database=automate;port=3306;UserId=root;password=";
        MySqlConnection con; 

        public MainWindow()
        {

            InitializeComponent();

            //Connexion à la BDD
            con = new MySqlConnection(this.conString);

            RecupCouleur();
            RecupSeuil();

            //Ouverture des acquisitions
            Imports.OpenUnit(out handle);
            Imports.Run(handle, echantillonnage, Imports._BLOCK_METHOD.BM_STREAM);
            /* Acquisition périodique */
            System.Windows.Threading.DispatcherTimer Son = new System.Windows.Threading.DispatcherTimer();
            Son.Tick += Acquisitions;
            Son.Interval = TimeSpan.FromMilliseconds(tempsAcquisition);
            Son.Start();
        }

        public void Acquisitions(object sender, EventArgs e)
        {
            //Création de la date du jour (on le gère ici seulement car les 3 relevées sont simultanée)
            string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            tabDate.Add(date);


            /* Son */
            Imports.GetSingle(handle, Imports.Inputs.USB_DRDAQ_CHANNEL_MIC_LEVEL, out son, out overflow);
            string stringSon = Convert.ToString(Math.Round(Convert.ToDouble(son) / 10,2));
            float floatSon = (float) Math.Round(Convert.ToDouble(son) / 10,2);
            int resultSeuilSon = VerifSeuil(floatSon,"son");

            Log.Text += "Seuil bas temperature :" + seuilBasTemperature
                        + "\nSeuil haut temperature :" + seuilHautTemperature
                        + "\nSeuil bas son :" + seuilBasSon
                        + "\nSeuil haut son :" + seuilHautSon
                        + "\nSeuil bas lumiere :" + seuilBasLumiere
                        + "\nSeuil haut lumiere :" + seuilHautLumiere + "\n\n";

            

            /* Temperature */
            Imports.GetSingle(handle, Imports.Inputs.USB_DRDAQ_CHANNEL_TEMP, out temp, out overflow);
            string stringTemp = Convert.ToString(Math.Round(temp * 0.088,2));
            float floatTemp = (float) Math.Round(temp * 0.088,2);
            int resultSeuilTemp = VerifSeuil(floatTemp, "temp");
            

            /* Lumière */
            Imports.GetSingle(handle, Imports.Inputs.USB_DRDAQ_CHANNEL_LIGHT, out lum, out overflow);
            string stringLum = Convert.ToString(Math.Round(Convert.ToDouble(lum) / 10,2));
            float floatLum = (float) Math.Round(Convert.ToDouble(lum) / 10,2); 
            int resultSeuilLum = VerifSeuil(floatLum, "lum");
           



            if (arret)
            {
                mesureSon.Add("0");
                mesureTemperature.Add("0");
                mesureLumiere.Add("0");
            } else
            {
                mesureSon.Add(stringSon);
                mesureTemperature.Add(stringTemp);
                mesureLumiere.Add(stringLum);
            }
            


            // Gestion des anomalies 
            CheckAnomalies(resultSeuilTemp,"temp",date);
            CheckAnomalies(resultSeuilSon, "son", date);
            CheckAnomalies(resultSeuilLum, "lum", date);



            //On affiche les logs sur la fenetre AVEC LES COULEURS
            Log.Text += date;

            switch (resultSeuilTemp)
            {
                case 1:
                    Log.Inlines.Add(new Run("\nRelevé température : " + stringTemp) { Foreground = new SolidColorBrush(System.Windows.Media.Color.FromRgb((byte)seuilHautCouleur[0], (byte)seuilHautCouleur[1], (byte)seuilHautCouleur[2])) });
                    break;
                case -1:
                    Log.Inlines.Add(new Run("\nRelevé température : " + stringTemp) { Foreground = new SolidColorBrush(System.Windows.Media.Color.FromRgb((byte)seuilBasCouleur[0], (byte)seuilBasCouleur[1], (byte)seuilBasCouleur[2])) });
                    break;
                default:
                    Log.Inlines.Add(new Run("\nRelevé température : " + stringTemp) { Foreground = new SolidColorBrush(System.Windows.Media.Color.FromRgb((byte)seuilOKCouleur[0], (byte)seuilOKCouleur[1], (byte)seuilOKCouleur[2])) });
                    break;
            }
            //Log.Text += "\nRelevé température : " + stringTemp;
            switch (resultSeuilLum)
            {
                case 1:
                    Log.Inlines.Add(new Run("\nRelevé lumière : " + stringLum) { Foreground = new SolidColorBrush(System.Windows.Media.Color.FromRgb((byte)seuilHautCouleur[0], (byte)seuilHautCouleur[1], (byte)seuilHautCouleur[2])) });
                    break;
                case -1:
                    Log.Inlines.Add(new Run("\nRelevé lumière : " + stringLum) { Foreground = new SolidColorBrush(System.Windows.Media.Color.FromRgb((byte)seuilBasCouleur[0], (byte)seuilBasCouleur[1], (byte)seuilBasCouleur[2])) });
                    break;
                default:
                    Log.Inlines.Add(new Run("\nRelevé lumière : " + stringLum) { Foreground = new SolidColorBrush(System.Windows.Media.Color.FromRgb((byte)seuilOKCouleur[0], (byte)seuilOKCouleur[1], (byte)seuilOKCouleur[2])) });
                    break;
            }
            //Log.Text += "\nRelevé lumière : " + stringLum;
                            
            switch (resultSeuilSon)
            {
                case 1:
                    Log.Inlines.Add(new Run("\nRelevé son : " + stringSon + "\n\n") { Foreground = new SolidColorBrush(System.Windows.Media.Color.FromRgb((byte)seuilHautCouleur[0], (byte)seuilHautCouleur[1], (byte)seuilHautCouleur[2])) });
                    break;
                case -1:
                    Log.Inlines.Add(new Run("\nRelevé son : " + stringSon+"\n\n") { Foreground = new SolidColorBrush(System.Windows.Media.Color.FromRgb((byte)seuilBasCouleur[0], (byte)seuilBasCouleur[1], (byte)seuilBasCouleur[2])) });
                    break;
                default:
                    Log.Inlines.Add(new Run("\nRelevé son : " + stringSon+"\n\n") { Foreground = new SolidColorBrush(System.Windows.Media.Color.FromRgb((byte)seuilOKCouleur[0], (byte)seuilOKCouleur[1], (byte)seuilOKCouleur[2])) });
                    break;
            }
            //Log.Text += "\nRelevé son : " + stringSon+"\n\n";
            //Log.Inlines.Add(new Run("text formatting ") { Foreground = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 0, 0)) });
            //On lance l'envoie à la base

            if (mesureSon.Count() == TailleEnvoi)
            {
                EnvoieBase();
            }

            if (resultSeuilSon != 0 || resultSeuilTemp != 0 && !arret)
            {
                Log.Text += "*** PAUSE ***";
                arret = true;
                EnvoieBase();

                // On fait une pause en fonction du temmps d'arret proposé dans le seuil.
                if (resultSeuilSon != 0 && resultSeuilTemp != 0) // Si il ya deux anomalies en même temps
                {
                    if (resultSeuilSon > resultSeuilTemp) // On prend le temps de pause le plus grand
                    {
                        pause(tempsSon * 60000);
                    } else
                    {
                        pause(tempsTemp * 60000);
                    }
                } else // s'il n'y a qu'une anomalie
                {
                    if (resultSeuilSon != 0) // On prends le temps de pause de l'anomalie concernée.
                    {
                        pause(tempsSon * 60000);
                    }
                    else
                    {
                        pause(tempsTemp * 60000);
                    }
                }
            }

        }

        private void EnvoieBase()
        {
           
            int cadence = 0;

            /*Cadence*/
            Random rand = new Random();
            if (!arret)
            {
                cadence = rand.Next(100, 300);
            }

            string requeteCadence = "";
            if (tabDate.Count != 0)
            {
                requeteCadence = "INSERT INTO `afpa_cadences`( `NbProduit`, `DateCadence`) VALUES(" + cadence + ",'" + tabDate[tabDate.Count() - 1] + "')";
            } else
            {
                requeteCadence = "INSERT INTO `afpa_cadences`( `NbProduit`, `DateCadence`) VALUES(" + cadence + ",'" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')";
            }


            MySqlCommand comCad = new MySqlCommand(requeteCadence, con);
            con.Open();
            comCad.ExecuteReader();
            con.Close();

            //Création des requêtes
            string requeteSon = "INSERT INTO `afpa_sons`(`ValeurSon`, `DateSon`) VALUES ";
            string requeteLumiere = "INSERT INTO `afpa_lumieres`(`ValeurLumiere`, `DateLumiere`) VALUES ";
            string requeteTemperature = "INSERT INTO `afpa_temperatures`(`ValeurTemperature`, `DateTemperature`) VALUES ";
            for (int i=0;i< mesureLumiere.Count(); i++)
            {
                requeteSon += "( "+mesureSon[i].Replace(",",".") + " , '"+tabDate[i]+ "') , ";
                requeteLumiere += "( " + mesureLumiere[i].Replace(",", ".") + " , '" + tabDate[i] + "') , ";
                requeteTemperature += "( " + mesureTemperature[i].Replace(",", ".") + " , '" + tabDate[i] + "') , ";
            }
            requeteSon = requeteSon.Substring(0,requeteSon.Length-2);
            requeteLumiere = requeteLumiere.Substring(0, requeteLumiere.Length - 2);
            requeteTemperature = requeteTemperature.Substring(0, requeteTemperature.Length - 2);
            requeteSon += ";";
            requeteLumiere += ";";
            requeteTemperature += ";";

            // creation des requetes anomalies
            string requeteAnomalie = "INSERT INTO `afpa_anomalies`(`DateAnomalie`, `TypeAnomalie`, `NbDeclasses`, `IdErreur`) VALUES ";


            foreach(List<string> anomalie in tabAnomalies)
            {
                if (anomalie[1] == "lumiere")
                {
                // Si la cadence est a 0 soit la production est en pause, on met le nombre de declassé a 0 puisque le rand commence a 1 et cadence = 0; 
                if (cadence == 0)
                {
                    requeteAnomalie += " ( '" + anomalie[0] + "' , '" + anomalie[1] + "' , '0' , '" + anomalie[3] + "') , ";
                } else
                {
                    requeteAnomalie += " ( '" + anomalie[0] + "' , '" + anomalie[1] + "' , '" + rand.Next(1, (cadence / 2)) + "' , '" + anomalie[3] + "') , ";
                }


            } else
                {
                    requeteAnomalie += " ( '" + anomalie[0] + "' , '" + anomalie[1] + "' , '" + anomalie[2] + "' , '" + anomalie[3] + "') , ";
                }
            }
            requeteAnomalie = requeteAnomalie.Substring(0, requeteAnomalie.Length - 2);
            requeteAnomalie += ";";
                


            if (mesureSon.Count != 0)
            { 
                //On crée la requête lié à la connexion, puis on ouvre la connexion à la base de données et on exécute la requêtes avant de fermer la connexion à la BDD pour laisser la place autre requête de se faire
                /*Son*/
                MySqlCommand comSon = new MySqlCommand(requeteSon, con); // Association de la connexion avec la requete

                con.Open(); // Ouverture de la connexion
                comSon.ExecuteReader(); //Envoie de la requête
                con.Close(); // Fermeture de la connexion

                /*Lumiere*/
                MySqlCommand comLum = new MySqlCommand(requeteLumiere, con);
                con.Open();
                comLum.ExecuteReader();
                con.Close();

                /*Temperature*/
                MySqlCommand comTem = new MySqlCommand(requeteTemperature, con);
                con.Open();
                comTem.ExecuteReader();
                con.Close();

                    Log.Text += "\n*******************************" +
                  "\n*         Envoi en Base ...         *" +
                  "\n*******************************\n\n";
            }
            /*Anomalie*/
            if (tabAnomalies.Count() != 0)
            {
                MySqlCommand comAno = new MySqlCommand(requeteAnomalie, con);
                con.Open();
                comAno.ExecuteReader();
                con.Close();
            }

               

          
            //On remet les tableaux de données à zéro
            mesureSon.Clear();
            mesureLumiere.Clear();
            mesureTemperature.Clear();
            tabDate.Clear();
            tabAnomalies.Clear();

        }

        private void ScrollViewer_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            // User scroll event : set or unset auto-scroll mode
            if (e.ExtentHeightChange == 0)
            {   // Content unchanged : user scroll event
                if (ScrollBar.VerticalOffset == ScrollBar.ScrollableHeight)
                {   // Scroll bar is in bottom
                    // Set auto-scroll mode
                    AutoScroll = true;
                }
                else
                {   // Scroll bar isn't in bottom
                    // Unset auto-scroll mode
                    AutoScroll = false;
                }
            }

            // Content scroll event : auto-scroll eventually
            if (AutoScroll && e.ExtentHeightChange != 0)
            {   // Content changed and auto-scroll mode set
                // Autoscroll
                ScrollBar.ScrollToVerticalOffset(ScrollBar.ExtentHeight);
            }
        }

        private void RecupSeuil()
        {
            // récupération des seuils
            string requeteSeuilTemperature = "SELECT * FROM `afpa_seuils` WHERE nature = 1 ORDER BY `DateSeuil` DESC LIMIT 1;";
            string requeteSeuilSon = "SELECT * FROM `afpa_seuils` WHERE nature = 2 ORDER BY `DateSeuil` DESC LIMIT 1;";
            string requeteSeuilLumiere = "SELECT * FROM `afpa_seuils` WHERE nature = 3 ORDER BY `DateSeuil` DESC LIMIT 1;";

            // requete seuil temperature
            MySqlCommand comTemperature = new MySqlCommand(requeteSeuilTemperature, con); // Association de la connexion avec la requete
            con.Open(); // Ouverture de la connexion
            MySqlDataReader reader = comTemperature.ExecuteReader(); //Envoie de la requête
            reader.Read();
            seuilBasTemperature = reader.GetFloat("SeuilBas");
            seuilHautTemperature = reader.GetFloat("SeuilHaut");
            tempsTemp = reader.GetInt32("Temps");
            con.Close(); // Fermeture de la connexion

            // requete seuil son
            MySqlCommand comSon = new MySqlCommand(requeteSeuilSon, con); // Association de la connexion avec la requete
            con.Open(); // Ouverture de la connexion
            reader = comSon.ExecuteReader(); //Envoie de la requête
            reader.Read();
            seuilBasSon = reader.GetFloat("SeuilBas");
            seuilHautSon = reader.GetFloat("SeuilHaut");
            tempsSon = reader.GetInt32("Temps");
            con.Close(); // Fermeture de la connexion

            // requete seuil lumiere
            MySqlCommand comLumiere = new MySqlCommand(requeteSeuilLumiere, con); // Association de la connexion avec la requete
            con.Open(); // Ouverture de la connexion
            reader = comLumiere.ExecuteReader(); //Envoie de la requête
            reader.Read();
            seuilBasLumiere = reader.GetFloat("SeuilBas");
            seuilHautLumiere = reader.GetFloat("SeuilHaut");
            con.Close(); // Fermeture de la connexion

            Log.Text += "Seuil bas temperature :" + seuilBasTemperature
                        +"\nSeuil haut temperature :" + seuilHautTemperature
                        +"\nSeuil bas son :" + seuilBasSon
                        +"\nSeuil haut son :" + seuilHautSon
                        +"\nSeuil bas lumiere :" + seuilBasLumiere
                        +"\nSeuil haut lumiere :" + seuilHautLumiere+ "\n\n";
        }

        private int VerifSeuil(float value,string type)
        {
            switch (type)
            {
                case "temp":
                    if (value < seuilBasTemperature)
                    {
                        return -1;
                    } else if (value > seuilHautTemperature)
                    {
                        return 1;
                    }
                    return 0;
                case "son":
                    if (value < seuilBasSon)
                    {
                        return -1;
                    }
                    else if (value > seuilHautSon)
                    {
                        return 1;
                    }
                    return 0;
                case "lum":
                    if (value < seuilBasLumiere)
                    {
                        return -1;
                    }
                    else if (value > seuilHautLumiere)
                    {
                        return 1;
                    }
                    return 0;
                default:
                    return 99;
            }

        }

        private void CheckAnomalies(int value, string type, string date)
        {
          
            switch (type)
            {
                case "temp":

                    if (value == 1)
                    {
                        tabAnomalies.Add(new List<string> { date, "temperature", "0", "5" });
                    } else if (value == -1)
                    {
                        tabAnomalies.Add(new List<string> { date, "temperature", "0", "6" });
                    }
                    break;
                case "son":
                    if (value == 1)
                    {
                        tabAnomalies.Add(new List<string> { date, "son", "0", "2" });
                    }
                    else if (value == -1)
                    {
                        tabAnomalies.Add(new List<string> { date, "son", "0", "4" });
                    }
                    break;
                case "lum":
                    if (value == 1)
                    {
                        tabAnomalies.Add(new List<string> { date, "lumiere", "0", "1" });
                    }
                    else if (value == -1)
                    {
                        tabAnomalies.Add(new List<string> { date, "lumiere", "0", "3" });
                    }
                    break;
                default:
                    break;
            }

        }

        private void RecupCouleur()
        {
            string requeteCouleur = "SELECT * FROM `afpa_couleurs`";
            // requete seuil temperature
            MySqlCommand comCouleur = new MySqlCommand(requeteCouleur, con); // Association de la connexion avec la requete
            con.Open(); // Ouverture de la connexion
            MySqlDataReader reader = comCouleur.ExecuteReader(); //Envoie de la requête


            reader.Read();
            seuilBasCouleur.Add(reader.GetInt32("Red"));
            seuilBasCouleur.Add(reader.GetInt32("Green"));
            seuilBasCouleur.Add(reader.GetInt32("Blue"));
            reader.Read();
            seuilOKCouleur.Add(reader.GetInt32("Red"));
            seuilOKCouleur.Add(reader.GetInt32("Green"));
            seuilOKCouleur.Add(reader.GetInt32("Blue"));
            reader.Read();
            seuilHautCouleur.Add(reader.GetInt32("Red"));
            seuilHautCouleur.Add(reader.GetInt32("Green"));
            seuilHautCouleur.Add(reader.GetInt32("Blue"));
            con.Close(); // Fermeture de la connexion
        }
        private async void pause(int temps)
        {
            await Task.Delay(temps);
            Log.Text += "FIN PAUSE\n";
        }
    }
   
}
