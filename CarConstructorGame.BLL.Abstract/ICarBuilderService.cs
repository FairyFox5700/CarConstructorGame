using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarConstructorGame.BLL.Abstract
{
    public interface ICarBuilderService
    {
        public Task AddChosedAccamulator(int acamulatorId,int carId);
        public Task AddChosedRimsComplect(int rimsComplectId,int carId);
        public Task AddChosedEngine(int engineId,int carId);
    }
}
