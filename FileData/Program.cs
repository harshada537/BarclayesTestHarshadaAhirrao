using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;
using System.Configuration;
using FileData.core;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            string outputVersion="";
            int outputSize = 0;
            string firstArgs=args[0].ToString();
            FetchFileDetails fetchdetails = new FetchFileDetails();

            string[] version = ConfigurationManager.AppSettings["vsupportedVersion"].Split(',');
            string[] size = ConfigurationManager.AppSettings["vsupportedSize"].Split(',');

            if (version.Contains(firstArgs))
            {
                outputVersion = fetchdetails.Version(args[1].ToString());
                Console.WriteLine(outputVersion);
            }
            else if (size.Contains(firstArgs))
            {
                outputSize = fetchdetails.Size(args[1].ToString());
                Console.WriteLine(outputSize);
            }
            else
            {
                Console.WriteLine("Please provide correct argument ");
            }
          
           
        }

        
    }
}
