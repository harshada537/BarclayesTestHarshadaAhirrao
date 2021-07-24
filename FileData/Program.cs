using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            string outputVersion="";
            int outputSize = 0;
            string firstArgs=args[0].ToString();
            FileDetails filesystem = new FileDetails();

            if (firstArgs == "-v" || firstArgs == "--v" || firstArgs == "/v" || firstArgs == "--version")
            {
                outputVersion = filesystem.Version(args[1].ToString());
                Console.WriteLine(outputVersion);
            }
            else if (firstArgs == "-s" || firstArgs == "--s" || firstArgs == "/s" || firstArgs == "--size")
            {
                outputSize = filesystem.Size(args[1].ToString());
                Console.WriteLine(outputSize);
            }
            else
            {
                Console.WriteLine("Please provide correct argument ");
            }
          
           
        }
    }
}
