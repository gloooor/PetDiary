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
        public string Color { get; set; }
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
            this.Color = "Red";
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
            switch (Rating)
            {
                case 0: this.Color = "#ffabab"; break;
                case 1:
                case 2: this.Color = "#ffceab"; break;
                case 3: 
                case 4: this.Color = "#ffe9ab"; break;
                case 5:
                case 6: this.Color = "#f9ffab"; break;
                case 7:
                case 8: this.Color = "#e7ffab"; break;
                case 9: this.Color = "#d8ffab"; break;
                case 10: this.Color = "#c1ffab"; break;
            }
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
