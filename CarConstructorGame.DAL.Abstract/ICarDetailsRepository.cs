using CarConstructorGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarConstructorGame.DAL.Abstract
{
    public interface ICarDetailsRepository : IRepository<Detail, int>
    {
        public Task <IEnumerable<Engine>> GetAllEngines();
        public Task<IEnumerable<Accamulator>> GetAllAccamulators();
        public Task<IEnumerable<RimsComplect>> GetAllRimsComplects();
    }
}
