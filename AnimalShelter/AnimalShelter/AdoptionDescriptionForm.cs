using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalShelter
{
    public partial class AdoptionDescriptionForm : Form
    {
        ShelterManager caller;
        public AdoptionDescriptionForm(Adoption adoption, ShelterManager caller)
        {
            InitializeComponent();
            lbAnimals.Items.Clear();
            lbName.Text = adoption.GetCustomerName();
            lbAddress.Text = adoption.GetCustomerAddress();
            lbZipCode.Text = adoption.GetCustomerZipcode();
            lbCity.Text = adoption.GetCustomerCity();
            lbEmail.Text = adoption.GetCustomerEmail();
            lbPhone.Text = adoption.GetCustomerPhone();
            lbDate.Text = adoption.GetAdoptionDate().ToString("dd/MM/mmmm");
            lbTime.Text = adoption.GetAdoptionTime().ToString("HH:mm");
            this.caller = caller;
            foreach (var a in adoption.GetAdoptedAnimals())
            {
                lbAnimals.Items.Add(a);
            }
        }

        private void lbAnimals_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Animal animal = null;
                int FirstComma = lbAnimals.Text.IndexOf(',');
                string AnimalName = lbAnimals.Text.Substring(0, FirstComma);
                foreach (var a in caller.GetAllAnimals())
                {
                    if (a.GetName() == AnimalName)
                    {
                        animal = a;
                    }
                }
                AnimalDescription animalDescription = new AnimalDescription(animal);
                animalDescription.Show();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Something went wrong with the data.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
