using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FSISSystem.ENTITIES
{
    [Table("Player")]
    public class Player
    {
        public int PlayerID { get; set; }
        public string RegionDescription { get; set; }
    }
}
