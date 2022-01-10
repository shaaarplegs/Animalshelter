using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace AnimalShelter
{
    [Serializable]
    public class ShelterManager 
    {
        private List<Animal> animals;
        private List<Adoption> adoptions;

        public ShelterManager()
        {
            animals = new List<Animal>();
            adoptions = new List<Adoption>();
        }
        private bool uniqueAnimal(Animal animal)
        {
            foreach (var a in animals)
            {
                if (a.GetName() == animal.GetName() && a != animal)
                {
                    return false;
                }
            }
            return true;
        }
        public bool AddAnimal(Animal animal)
        {
            if(uniqueAnimal(animal))
            {
                this.animals.Add(animal);
                return true;
            }
            return false;
        }

        public List<Animal> GetAllAnimals()
        {
            return this.animals;
        }

        public List<Animal> GetAllAvailableAnimals()
        {
            List<Animal> temp = new List<Animal>();
            foreach(var a in GetAllAnimals())
            {
                if(a.AvaillableToBeAdopted() == true && a.GetAdoptionStatus() == AdoptionStatus.NotAdopted)
                {
                    temp.Add(a);
                }
            }
            return temp;
        }

        public bool AddAdoption(Adoption adoption)
        {
            try
            {
                this.adoptions.Add(adoption);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<Adoption> GetAllAdoptions()
        {
            return this.adoptions;
        }

    }
}
