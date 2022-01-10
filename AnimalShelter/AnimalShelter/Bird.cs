using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    [Serializable]
    public class Bird : Animal
    {
        Size size;
        public Bird(string name, uint age, Gender gender, Size size) : base(name, age, gender)
        {
            this.size = size;
        }

        public Bird(string name, uint age, Gender gender, string description, Size size) : base(name, age, gender, description)
        {
            this.size = size;
        }

        public override bool AvaillableToBeAdopted()
        {
            return true;
        }
        public Size GetSize()
        {
            return this.size;
        }

        public override string ToString()
        {
            return base.ToString() + ", Animal: Bird";
        }
    }
}
