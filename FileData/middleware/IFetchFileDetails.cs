using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileData.middleware
{
    public interface IFetchFileDetails
    {
        string Version(string name);
        int Size(string name);
    }
}
