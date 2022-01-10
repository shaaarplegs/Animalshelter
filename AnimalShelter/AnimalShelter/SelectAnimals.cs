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
    public partial class SelectAnimals : Form
    {
        ShelterManagerForm caller;
        List<Animal> availableAnimals;
        public SelectAnimals(List<Animal> availableAnimals, ShelterManagerForm caller)
        {
            InitializeComponent();
            //initialize available animals from the shelter 
            this.availableAnimals = availableAnimals;
            foreach (var a in availableAnimals)
            {
                lbAvailableAnimals.Items.Add(a.GetName()+","+a.GetAge() + " years old.");
            }
            //initialize object who called this form. 
            this.caller = caller;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
                if (lbSelectedAnimals.Items.Count < 3)
                {
                    lbSelectedAnimals.Items.Add(lbAvailableAnimals.Text);
                    lbAvailableAnimals.Items.Remove(lbAvailableAnimals.SelectedItem);
                }
                else
                {
                    MessageBox.Show("Max animals 3");
                }
            btnSortOnDescending.Enabled = false;
        }

        private void btnRemoveChoice_Click(object sender, EventArgs e)
        {
            if (lbSelectedAnimals.Items.Count == 0)
            {
                btnSortOnDescending.Enabled = true;
            }
                lbAvailableAnimals.Items.Add(lbSelectedAnimals.Text);
                lbSelectedAnimals.Items.Remove(lbSelectedAnimals.SelectedItem);
            
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbSelectedAnimals.Items.Count == 0)
                {
                    MessageBox.Show("you have to select animal(s).");
                }
                else
                {
                    caller.SetChosenAnimals(GetChosenAnimals());
                    this.Close();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Something went wrong !");
            }
            
        }

        private void lbAvailableAnimals_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Animal animal = null;
                int FirstComma = lbAvailableAnimals.Text.IndexOf(',');
                string AnimalName = lbAvailableAnimals.Text.Substring(0, FirstComma);
                foreach (var a in availableAnimals)
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

        private void btnSortOnDescending_Click(object sender, EventArgs e)
        {
            try
            {
                availableAnimals.Sort();
                lbAvailableAnimals.Items.Clear();
                foreach (var a in availableAnimals)
                {
                    lbAvailableAnimals.Items.Add(a.GetName() + "," + a.GetAge() + " years old.");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("something went wrong witht the sorting function.");
            }
            
        }
        private List<string> GetAnimalNames()
        {
            int FirstComma;
            List<string> temp = new List<string>();
           for (int i =0; i < lbSelectedAnimals.Items.Count; i++)
            {
                FirstComma = lbSelectedAnimals.Items[i].ToString().IndexOf(",");
                temp.Add(lbSelectedAnimals.Items[i].ToString().Substring(0,FirstComma));
            }
            return temp;
        }
        private Animal GetAnimal(String AnimalName)
        {
            foreach (var a in availableAnimals)
            {
                if(a.GetName() == AnimalName)
                {
                    return a;
                }
            }
            return null;
        }
        public List<Animal> GetChosenAnimals()
        {
            
            List<Animal> temp = new List<Animal>();
            for (int i = 0; i < lbSelectedAnimals.Items.Count; i++)
            {
                Animal animal = GetAnimal(GetAnimalNames()[i]);
                temp.Add(animal);
            }
            return temp;
        }

        private void lbSelectedAnimals_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Animal animal = null;
                int FirstComma = lbSelectedAnimals.Text.IndexOf(',');
                string AnimalName = lbSelectedAnimals.Text.Substring(0, FirstComma);
                foreach (var a in availableAnimals)
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
    }
}
