using FileData.middleware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyTools;

namespace FileData.core
{
    public class FetchFileDetails : IFetchFileDetails
    {
        string version;
        int size;
        FileDetails filesystem;
       public FetchFileDetails()
        {
            filesystem = new FileDetails();
        }
        public string Version(string name)
        {
            
            version=filesystem.Version(name);
            return version;
        }
        public int Size(string name)
        {
            size = filesystem.Size(name);
            return size;

        }
    }
}
