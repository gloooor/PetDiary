using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetDiary
{
    public class ActivityNote
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Location { get; set; }
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }
        public int PetId { get; set; }

        public ActivityNote()
        {
            this.Id = 0;
            this.Date = "";
            this.Location = "";
            this.Hours = 0;
            this.Minutes = 0;
            this.Comment = "";
            this.Rating = 0;
            this.PetId = 0;
        }

        public ActivityNote(int Id, string Date, string Location, int Hours, int Minutes, string Comment, int Rating, int PetId)
        {
            this.Id = Id;
            this.Date = Date;
            this.Location = Location;
            this.Hours = Hours;
            this.Minutes = Minutes;
            this.Comment = Comment;
            this.Rating = Rating;
            this.PetId = PetId;
        }
    }
}
