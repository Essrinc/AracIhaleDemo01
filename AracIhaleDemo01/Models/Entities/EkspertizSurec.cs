using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AracIhaleDemo01.Models.Entities
{
    public class EkspertizSurec:Base
    {
        public int EkspertizSurecID { get; set; }

        public EkspertizStatu EkspertizStatu { get; set; }
        public int EkspertizStatuID { get; set; }

    }
}
