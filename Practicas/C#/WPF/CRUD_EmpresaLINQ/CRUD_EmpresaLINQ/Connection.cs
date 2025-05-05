using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_EmpresaLINQ
{
    public class Connection
    {
        public string stringConn = ConfigurationManager.ConnectionStrings[0].ConnectionString;
    }
}
