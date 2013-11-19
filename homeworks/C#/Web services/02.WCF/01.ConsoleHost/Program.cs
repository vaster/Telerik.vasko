﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.DateTimeServicesLib;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Threading;
using System.Globalization;

namespace _02.ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:8733/Design_Time_Addresses/GetDate/");

            ServiceHost selfHost = new ServiceHost(typeof(DateService), baseAddress);

            try
            {
                selfHost.AddServiceEndpoint(typeof(IDateService), new WSHttpBinding(), "Date Service");
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                selfHost.Description.Behaviors.Add(smb);

                using (selfHost)
                {
                    selfHost.Open();
                    Console.WriteLine("Service is ready\nPress any key  to exit");
                    Console.WriteLine();
                    Console.ReadKey();
                }
            }
            catch (CommunicationException ex)
            {
                Console.WriteLine("An exception occured: {0}", ex.Message);
                selfHost.Abort();
            }
        }
    }
}
