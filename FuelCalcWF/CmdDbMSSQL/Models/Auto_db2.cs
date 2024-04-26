using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmdDbMSSQL.Models
{
    public partial class Auto_db
    {
        public override string ToString() => $"{mark} | {model} | {engine_power} | {fuel_consumption}";
    }
}
