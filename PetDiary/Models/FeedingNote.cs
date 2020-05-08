using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetDiary
{
    public class FeedingNote
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public bool WetFood { get; set; }
        public bool DryFood { get; set; }
        public bool Meat { get; set; }
        public bool Medicines { get; set; }
        public bool Other { get; set; }
        public int PetId { get; set; }

        public FeedingNote()
        {
            this.Id = 0;
            this.Date = "";
            this.WetFood = false;
            this.DryFood = false;
            this.Meat = false;
            this.Medicines = false;
            this.Other = false;
            this.PetId = 0;
        }
        public FeedingNote(int Id, string Date, bool WetFood, bool DryFood, bool Meat, bool Medicines, bool Other, int PetId)
        {
            this.Id = Id;
            this.Date = Date;
            this.WetFood = WetFood;
            this.DryFood = DryFood;
            this.Meat = Meat;
            this.Medicines = Medicines;
            this.Other = Other;
            this.PetId = PetId;
        }
    }
}
