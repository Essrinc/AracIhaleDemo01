using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AracIhaleDemo01.Models.Entities
{
    public class Tramer:Base
    {
        public int TramerID { get; set; }
        public string TramerTutari { get; set; }
        public string TramerAciklama { get; set; }

        public TramerCesit TramerCesit { get; set; }
        public int TramerCesitID { get; set; }
    }
}
