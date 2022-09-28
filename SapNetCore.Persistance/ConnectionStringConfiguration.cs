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
                return "Server=localhost;Database=SapNetCloneV1;User=sa;Password=MyPass@word;";
            }

        }
    }
}
