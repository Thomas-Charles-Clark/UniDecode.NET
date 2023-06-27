using Microsoft.SqlServer.Server;

namespace UnicodeTransliteration
{
    public static class SQLFunctions
    {
        [SqlFunction(DataAccess = DataAccessKind.Read,
            SystemDataAccess = SystemDataAccessKind.Read)]
        [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
        public static string Transliterate(
            string Input)
        {
            if (Input == null)
            {
                return null;
            }

            return Decoder.Decode(Input);
        }
    }
}
