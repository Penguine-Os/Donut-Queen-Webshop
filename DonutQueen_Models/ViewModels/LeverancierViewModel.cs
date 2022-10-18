using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonutQueen_Models.ViewModels
{
    public class LeverancierViewModel
    {
        public List<Leverancier> Leveranciers { get; set; }
        public List<LeverancierDonut> LeverancierDonut { get; set; }
        public Donut Donut { get; set; } = new Donut ();
        public Leverancier Leverancier { get; set; } = new Leverancier();
    }
}
