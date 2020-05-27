using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarConstructorGame.BLL.Abstract
{
    public interface ICarDetailsService
    {
        public Task<IEnumerable<EngineDto>> GetAllEngines();
        public Task<IEnumerable<RimsComplectDto>> GetAllRimsComplects();
        public Task<IEnumerable<AccamulatorDto>> GetAllAccamulators();
    }
}
