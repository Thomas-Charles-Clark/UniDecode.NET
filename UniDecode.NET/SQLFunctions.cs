using Microsoft.SqlServer.Server;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Unidecode.NET;

namespace UniDecode.NET
{
    public static class SQLFunctions
    {
        [SqlFunction(DataAccess = DataAccessKind.Read,
            SystemDataAccess = SystemDataAccessKind.Read)]
        [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
        public static string Transliterate(
            string Input)
        {
            return Input.Unidecode();
        }
    }
}
