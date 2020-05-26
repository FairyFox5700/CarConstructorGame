using System.Collections.Generic;
using System.Text;

namespace CarConstructorGame.Entities
{
    public class Car : BaseEntity<int>
    {
        public Car()
        {
            this.Details = new HashSet<Detail>();
        }
        public bool IsMoving { get; set; }
        public double Distance { get; set; }
        public double TotalCost { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public ICollection<Detail> Details { get; set; }

    }
   
}
