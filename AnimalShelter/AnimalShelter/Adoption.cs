using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    [Serializable]
    public class Adoption
    {
        private string customerName;
        private string customerAddress;
        private string customerZipcode;
        private string customerCity;
        private string customerEmail;
        private string customerPhone;
        private DateTime adoptionDate;
        private DateTime adoptionTime;
        private List<Animal> adoptedAnimals;

        public Adoption (string customerName, string customerAddress, string customerZipcode, string customerCity,
            string customerEmail, string customerPhone, DateTime adoptionDate, DateTime adoptionTime, List<Animal> adoptedAnimals)
        {
            this.customerName = customerName;
            this.customerAddress = customerAddress;
            this.customerZipcode = customerZipcode;
            this.customerCity = customerCity;
            this.customerEmail = customerEmail;
            this.customerPhone = customerPhone;
            this.adoptionDate = adoptionDate;
            this.adoptionTime = adoptionTime;
            this.adoptedAnimals = adoptedAnimals;
        }

        public string GetCustomerName()
        {
            return this.customerName;
        }
        public string GetCustomerAddress()
        {
            return this.customerAddress;
        }
        public string GetCustomerZipcode()
        {
            return this.customerZipcode;
        }
        public string GetCustomerCity()
        {
            return this.customerCity;
        }

        public string GetCustomerEmail()
        {
            return this.customerEmail;
        }

        public string GetCustomerPhone()
        {
            return this.customerPhone;
        }

        public DateTime GetAdoptionDate()
        {
            return this.adoptionDate;
        }
        public DateTime GetAdoptionTime()
        {
            return this.adoptionTime;
        }
        public List<Animal> GetAdoptedAnimals()
        {
            return this.adoptedAnimals;
        }
        public bool hasDiscount()
        {
            if(adoptedAnimals.Count() >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double CalculateFees()
        {
            double TotalFees = 0;

            foreach (var a in adoptedAnimals)
            {
                if(a is Dog)
                {
                    TotalFees += 29.95;
                }
                else if(a is Cat)
                {
                   if(a.GetAge() < 10 )
                    {
                        TotalFees += 15.00;
                    }
                    else
                    {
                        TotalFees += 10.00;
                    }
                }
                else if (a is Bird)
                {
                    if(((Bird)a).GetSize() == Size.Small)
                    {
                        TotalFees += 5.50;
                    }
                    else if (((Bird)a).GetSize() == Size.Medium)
                    {
                        TotalFees += 11.00;
                    }
                    else if (((Bird)a).GetSize() == Size.Large)
                    {
                        TotalFees += 16.50;
                    }
                }

            }
            // at this point the total fees has been calculated, so return it with or without discount.
            if (hasDiscount())
            {
                double discount = TotalFees * 0.1;
                return TotalFees - discount;
            }
            else
            {
                return TotalFees;
            }
        }

        public override string ToString()
        {
            return $"{customerName}, {customerEmail}, animals adopted : {adoptedAnimals.Count}";
        }
    }
}
