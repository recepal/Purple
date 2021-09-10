using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purple.Model.Personnel
{
    [Table("personnels", Schema = "per")]
    public class Personnel: EntityBase
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
