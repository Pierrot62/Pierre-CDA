using Interface_Carte_dAquisition_PicoDrDAQ;
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
        short handle;
        uint echantillonnage = 500;
        ushort overflow;
        short son;
        short temp;
        short lum;
        int tempsAcquisition=5000; //En ms
        float[] mesureTemperature = new float[20];
        float[] mesureSon = new float[20];
        float[] mesureLumiere = new float[20];


        public MainWindow()
        {

            InitializeComponent();

            Imports.OpenUnit(out handle);
            Imports.Run(handle, echantillonnage, Imports._BLOCK_METHOD.BM_STREAM);
            /* Son */

            System.Windows.Threading.DispatcherTimer Son = new System.Windows.Threading.DispatcherTimer();
            Son.Tick += AcquisitionSon;
            Son.Interval = TimeSpan.FromMilliseconds(tempsAcquisition);
            Son.Start();

            /*Temperature*/

            System.Windows.Threading.DispatcherTimer Temperature = new System.Windows.Threading.DispatcherTimer();
            Temperature.Tick += AcquisitionTemperature;
            Temperature.Interval = TimeSpan.FromMilliseconds(tempsAcquisition);
            Temperature.Start();

            /*Lumiere*/

            System.Windows.Threading.DispatcherTimer Lumiere = new System.Windows.Threading.DispatcherTimer();
            Lumiere.Tick += AcquisitionLumiere;
            Lumiere.Interval = TimeSpan.FromMilliseconds(tempsAcquisition);
            Lumiere.Start();

        }

        public void AcquisitionSon(object sender, EventArgs e)
        {
            Imports.GetSingle(handle, Imports.Inputs.USB_DRDAQ_CHANNEL_MIC_LEVEL, out son, out overflow);
            Trace.WriteLine(Convert.ToString(Convert.ToDouble(son) / 10));
        }

        public void AcquisitionTemperature(object sender, EventArgs e)
        {
            Imports.GetSingle(handle, Imports.Inputs.USB_DRDAQ_CHANNEL_TEMP, out temp, out overflow);
            Trace.WriteLine(Convert.ToString(temp*0.088));  
        }

        public void AcquisitionLumiere(object sender, EventArgs e)
        {
            Imports.GetSingle(handle, Imports.Inputs.USB_DRDAQ_CHANNEL_LIGHT, out lum, out overflow);
            Trace.WriteLine(Convert.ToDouble(lum)/10);
        }
    }
}
