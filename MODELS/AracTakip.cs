using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELS
{
    public class AracTakip
    {
        public int CihazMarkaId { get; set; }
        public string AracTakipId { get; set; }

        public ICollection<AracTakip> CihazdakiAraclar { get; set; }
    }
}
