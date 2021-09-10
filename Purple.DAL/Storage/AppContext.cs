using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purple.DAL
{
    public partial class AppContext : DbContext
    {
        private readonly string _cnnStr = "User ID=postgres; Password=deva; Host=localhost; Port=5442; Database=RecDb; Pooling=false; Timeout=300; CommandTimeout=180;";
        //dotnet-ef migrations add Initials --startup-project ..\Purple.Service  // yan çizgiye dikkat et
        public AppContext()
        {

        }

        public AppContext(string cnnStr) // dışarıdan connection
        {
            _cnnStr = cnnStr;
        }

        public AppContext(DbContextOptions<AppContext> options) : base(options) // DbContext options alıyor, çok fazla instancelı çalışldığından
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_cnnStr);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
