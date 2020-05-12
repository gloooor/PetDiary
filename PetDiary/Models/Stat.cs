using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetDiary
{
    public class Stat
    {
        public int PetId { get; set; }
        public DateTime Date { get; set; }
        public int Weight { get; set; }

        public Stat()
        {
            this.PetId = 0;
            this.Date = DateTime.Today;
            this.Weight = 0;
        }

        public Stat(DateTime Date, int Weight, int PetId)
        {
            this.Date = Date;
            this.Weight = Weight;
            this.PetId = PetId;
        }
    }
}
