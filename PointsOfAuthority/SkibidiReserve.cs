using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace PointsOfAuthority
{
    public class SkibidiReserve
    {
        public string Name { get; set; } = string.Empty;
        public string StartDate { get; set; } = string.Empty;
        public string EndDate { get; set; } = string.Empty;
        public string PaymentMethod { get; set; } = string.Empty;

        private int _numofothers = 0;
        public string NumOfOthers
        {
            get
            {
                return _numofothers.ToString();
            }
            set 
            { 
                _numofothers = Convert.ToInt32(value);
            }
        }

        public void Save(CheckBox checkbox)
        {
            StreamWriter writer = new StreamWriter("adatok.txt", true);

            if (checkbox.IsChecked ?? true && _numofothers != 0)
            {
                writer.WriteLine(Name + ";" + StartDate + ";" + EndDate + ";" + PaymentMethod + ";" + NumOfOthers);
            }
            else
            {
                writer.WriteLine(Name + ";" + StartDate + ";" + EndDate + ";" + PaymentMethod + ";0");
            }

            writer.Close();
        }
    }
}
