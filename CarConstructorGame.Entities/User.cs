using System.Collections.Generic;
using static CarConstructorGame.Entities.Enums.Enums;

namespace CarConstructorGame.Entities
{
    public class User : BaseEntity<int>
    {
        public double MoneySum { get; set; }
        public string UserName { get; set; }
        public GameRating GameRating { get; set; }
        public ICollection<Car> Cars { get; set; }
        public Age Age { get; set; }
    }
}
