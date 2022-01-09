using Purple.Model.Personnel;
using System.Threading.Tasks;

namespace Purple.DAL
{
    public class PersonnelDbRepo
    {
        private readonly AppContext _ctx;

        public PersonnelDbRepo()
        {
            _ctx = new AppContext();
        }

        public async Task<bool> Insert(Personnel personnel)
        {
            _ctx.Personnels.Add(personnel);
            return await _ctx.SaveChangesAsync() > 0;
        }
    }
}
