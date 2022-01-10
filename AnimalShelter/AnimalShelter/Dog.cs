using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    [Serializable]
    public class Dog : Animal
    {
        public Dog(string name, uint age, Gender gender) : base(name, age, gender)
        {

        }

        public Dog(string name, uint age, Gender gender, string description) : base(name, age, gender, description)
        {
        }

        public override bool AvaillableToBeAdopted()
        {
            if (base.GetAge() >= 1)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return base.ToString() + ", Animal: Dog";
        }
    }
}
