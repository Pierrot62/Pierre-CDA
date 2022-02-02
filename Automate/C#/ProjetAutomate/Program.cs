using Interface_Carte_dAquisition_PicoDrDAQ;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetAutomate
{
    public class Program
    {
        

        public static void Main(string[] args)
        {
            //short handle;
            //uint echantillonnage = 500;
            //ushort overflow;
            //short value;
            //short son;
            //List<Double> x = new List<Double>();
            //List<Double> y = new List<Double>();
            //Trace.WriteLine("*********************************************");
            //Imports.OpenUnit(out handle);
            //Imports.Run(handle, echantillonnage, Imports._BLOCK_METHOD.BM_STREAM);
            //// puissance sonore
            //Imports.GetSingle(handle, Imports.Inputs.USB_DRDAQ_CHANNEL_MIC_LEVEL, out value, out overflow);
            //// Forme d'onde
            //Imports.GetSingle(handle, Imports.Inputs.USB_DRDAQ_CHANNEL_MIC_WAVE, out value, out overflow);
            //Trace.WriteLine("*********************************************");
            //Trace.WriteLine(value);
            CreateHostBuilder(args).Build().Run();
            
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
    
     


}
