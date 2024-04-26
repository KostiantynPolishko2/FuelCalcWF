using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;
using System.Globalization;
using System.Web;

namespace FuelCalcLibrary.Models
{
    public class FuelCost
    {
        public const int DistancePerConsume = 100;
        public float Distance { get; set; }
        public float Consumption { get; set; }
        public float Price { get; set; }

        public float TotalFuelVolume;
        public float TotalCost;

        public static string[] Message;

        static FuelCost()
        {
            Message = new string[] { "Distance", "Consumption", "Price", "Engine Volume" };
        }
        public FuelCost() { }

        public void FuelCalculation()
        {
            TotalFuelVolume = (float)Math.Round(Distance / DistancePerConsume * Consumption, 2, MidpointRounding.AwayFromZero);
        }

        public void CostCalculation()
        {
            TotalCost = (float)Math.Round(TotalFuelVolume * Price, 1, MidpointRounding.AwayFromZero);
        }
        public static (bool, float) IsValue(in string inputValue)
        {
            float treatValue;

            return (float.TryParse(inputValue, out treatValue), Math.Abs(treatValue));
        }

        public static string GetTxtHundreths(in float volume)
        {
            return volume - (int)volume != 0 ? volume.ToString() : volume.ToString() + ".00";
        }

        public static int GetIntHundredths(in float value)
        {
            return (int)((value - (int)value) * 100);
        }
    }
}
