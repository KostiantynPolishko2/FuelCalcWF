using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CmdDbMSSQL.Models;

namespace CmdDbMSSQL.Controllers
{
    public class DbController : db_aa7fda_edmond171195001Context
    {
        public DbController() : base() { }

        public bool isConnection() => Database.CanConnect();

        public (bool, string) isSaveChanges()
        {
            try
            {
                this.SaveChanges();
                return (true, string.Empty);
            }
            catch (SystemException sysEx)
            {
                return (false, sysEx.Message);
            }
        }
    }
}
