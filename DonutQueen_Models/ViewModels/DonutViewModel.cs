using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonutQueen_Models.ViewModels
{
    public class DonutViewModel
    {
        public string SearchQuery { get; set; }

     
        public string Prijs { get; set; }
        public Decimal Prijs2{ get; set; }
        public IEnumerable<Donut> Donuts { get; set; }
        public Donut Donut { get; set; }

    }
}
