using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapNetCore.Persistance
{
   public static class ConnectionStringConfiguration
    {
        static public string ConnectionString
        {
            get
            {
                return "Server=TEDESCO420\\SQL2019;Database=SAPNet;User Id=sa;Password=qwerr112358;";
            }

        }
    }
}
