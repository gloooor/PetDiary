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
        }

        public Pet(int Id, string Type, int Age, string Name, string Sex, bool Desexed, bool Insured, string Breed, string DateOfBirth, int OwnerId)
        {
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
