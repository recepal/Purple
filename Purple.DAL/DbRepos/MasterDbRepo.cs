using Microsoft.EntityFrameworkCore;
using System;

namespace Purple.DAL
{
    public class MasterDbRepo
    {
        private readonly AppContext _ctx;

        public MasterDbRepo()
        {
            _ctx = new AppContext();
        }

        public bool CreateDb()
        {
            bool result;
            try
            {
                _ctx.Database.Migrate();
                result = true;
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }
    }
}
