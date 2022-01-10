using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    [Serializable]
    public abstract class Animal : IComparable<Animal>
    {
        protected string name;
        protected uint age;
        protected Gender gender;
        protected string description;
        protected AdoptionStatus AdoptionStatus;

        public Animal(string name, uint age, Gender gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            // by default the new animal is not adopted.
            AdoptionStatus = AdoptionStatus.NotAdopted;
        }
        public Animal(string name, uint age, Gender gender, string description)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.description = description;
            AdoptionStatus = AdoptionStatus.NotAdopted;
        }
        public string GetName()
        {
            return this.name;
        }
        public Gender GetGender()
        {
            return this.gender;
        }
        public uint GetAge()
        {
            return this.age;
        }
        public string GetDescription()
        {
            return this.description;
        }
        public AdoptionStatus GetAdoptionStatus()
        {
            return this.AdoptionStatus;
        }

        public abstract bool AvaillableToBeAdopted();

        //after the customer adopts an animal their adoptionstatus should be changed to adopted.
        public void AnimalAdopted()
        {
            this.AdoptionStatus = AdoptionStatus.Adopted;
        }

        public override string ToString()
        {
          return $"{name}, {AdoptionStatus}";
        }
        public int CompareTo(Animal other) // Desc
        {
            if (other.GetAge() > this.age) return 1;
            else if (other.GetAge() < this.age) return -1;
            else return 0;
        }
    }
}
