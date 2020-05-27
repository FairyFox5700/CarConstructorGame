using CarConstructorGame.DAL.Abstract;
using CarConstructorGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarConstructorGame.DAL.Implementation.Core
{
    public class CarDetailsRepository : BaseRepository<Detail, int>, ICarDetailsRepository
    {
        private readonly CarGameContext context;

        public CarDetailsRepository(CarGameContext context) : base(context)
        {
            this.context = context;
        }
        //TODO IQueryable
        public Task<IEnumerable<Accamulator>> GetAllAccamulators()
        {
            return context.Accamulators.ToListAsync();
        }

        public Task<IEnumerable<Engine>> GetAllEngines()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<RimsComplect>> GetAllRimsComplects()
        {
            throw new NotImplementedException();
        }
    }
}
