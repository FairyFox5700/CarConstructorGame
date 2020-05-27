using CarConstructorGame.BLL.Abstract;
using CarConstructorGame.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConstructorGame.BLL.Implementation
{
    public class CarDetailsService : ICarDetailsService
    {
        private readonly IUnitOfWork unitOfWork;

        public CarDetailsService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<AccamulatorDto>> GetAllAccamulators()
        {
            var accamulators = await unitOfWork.CarDetailsRepository.GetAllAccamulators();
            return accamulators.AsQueryable().Select(AccamulatorDto.Projection);
        }

        public Task<IEnumerable<EngineDto>> GetAllEngines()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<RimsComplectDto>> GetAllRimsComplects()
        {
            throw new NotImplementedException();
        }
    }
}
