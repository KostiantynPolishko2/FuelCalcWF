using CmdDbMSSQL.Models;

namespace CmdDbMSSQL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start Cmd Db MSSQL!");

            db_aa7fda_edmond171195001Context db = new db_aa7fda_edmond171195001Context();
            List<Auto_db> autos = db.Auto_dbs.ToList();

            foreach (Auto_db auto_db in autos)
            {

                Console.WriteLine(auto_db);
            }
        }
    }
}