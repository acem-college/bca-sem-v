using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterQuality.Domain.Entities
{
    public class Bagmati
    {
        [Key]
        public string Parameters {  get; set; }
        public string pH { get; set; }
        public string DO { get; set; }
        public string BOD {  get; set; }
        public string COD { get; set; }
        public string TDS {  get; set; }
        public string EC { get; set; }
        public string NH3_N { get; set; }
        public string N03_N { get; set; }
        public string N02_N { get; set;}
        public string TOC { get; set;}
        public string TH { get; set;}
        public string Mg { get; set;}
        public string Fe { get; set;}
        public string TC { get; set;}
        public string E_coli { get; set;}

    }
}
