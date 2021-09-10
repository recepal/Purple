using Microsoft.EntityFrameworkCore;
using Purple.Model.Personnel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purple.DAL
{
    public partial class AppContext
    {
        public DbSet<Personnel> Personnels { get; set; } // veri tabanı tablosunun kendisi
    }
}
