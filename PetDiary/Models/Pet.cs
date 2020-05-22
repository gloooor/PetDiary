using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetDiary.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public bool Desexed { get; set; }
        public bool Insured { get; set; }
        public string Breed { get; set; }
        public string DateOfBirth { get; set; }
        public int OwnerId { get; set; }
        public string StaticPic { get; set; }
        public string FoodPic { get; set; }
        public string ActPic { get; set; }
        public string ProfPic { get; set; }


        public Pet()
        {
            this.Id = 0;
            this.Type = "";
            this.Age = 0;
            this.Name = "";
            this.Sex = "";
            this.Desexed = false;
            this.Insured = false;
            this.Breed = "";
            this.DateOfBirth = "";
            this.OwnerId = 0;
            this.StaticPic = "";
            this.ActPic = "";
            this.FoodPic = "";
            this.ProfPic = ""; 

        }

        public Pet(int Id, string Type, int Age, string Name, string Sex, bool Desexed, bool Insured, string Breed, string DateOfBirth, int OwnerId)
        {
            switch (Type)
            {
                case "Cat": this.StaticPic = "pack://siteoforigin:,,,/images/catstat.gif";
                    this.ActPic = "pack://siteoforigin:,,,/images/catact.gif";
                    this.FoodPic = "pack://siteoforigin:,,,/images/cateat.gif";
                    this.ProfPic = "pack://siteoforigin:,,,/images/catprof.gif"; break;
                case "Dog":
                    this.StaticPic = "pack://siteoforigin:,,,/images/dogstat.gif";
                    this.ActPic = "pack://siteoforigin:,,,/images/dogact.gif";
                    this.FoodPic = "pack://siteoforigin:,,,/images/dogeat.gif";
                    this.ProfPic = "pack://siteoforigin:,,,/images/dogprof.gif"; break;
                case "Hamster":
                    this.StaticPic = "pack://siteoforigin:,,,/images/hamsterstat.gif";
                    this.ActPic = "pack://siteoforigin:,,,/images/hamsteract.gif";
                    this.FoodPic = "pack://siteoforigin:,,,/images/hamstereat.gif";
                    this.ProfPic = "pack://siteoforigin:,,,/images/hamsterprof.gif"; break;
                case "Rabbit":
                    this.StaticPic = "pack://siteoforigin:,,,/images/rabbitstat.gif";
                    this.ActPic = "pack://siteoforigin:,,,/images/rabbitact.gif";
                    this.FoodPic = "pack://siteoforigin:,,,/images/rabbiteat.gif";
                    this.ProfPic = "pack://siteoforigin:,,,/images/rabbitprof.gif"; break;
            }
            this.Id = Id;
            this.Type = Type;
            this.Age = Age;
            this.Name = Name;
            this.Sex = Sex;
            this.Desexed = Desexed;
            this.Insured = Insured;
            this.Breed = Breed;
            this.DateOfBirth = DateOfBirth;
            this.OwnerId = OwnerId;
        }
    }
}
