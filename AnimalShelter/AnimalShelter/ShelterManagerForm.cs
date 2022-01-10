using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;

namespace AnimalShelter
{
    public partial class ShelterManagerForm : Form, ISaveAndLoad
    {
        private ShelterManager shelterManager;
        

        public ShelterManagerForm()
        {
            InitializeComponent();
            shelterManager = new ShelterManager();
            foreach (var a in Enum.GetValues(typeof(Gender)))
            {
                // add all genders in a combo box
                cbGender.Items.Add(a);
                
            }

            foreach (var a in Enum.GetValues(typeof(Size)))
            {
                // add all sizes in a combo box
                cbSize.Items.Add(a);
            }
        }


        public bool SaveFiles(string FileName)
        {
            FileStream fs = null;
            BinaryFormatter bf = null;
            try
            {
                fs = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Write);
                bf = new BinaryFormatter();
                bf.Serialize(fs, shelterManager);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }
        public bool LoadFiles(string FileName)
        {
            FileStream fs = null;
            BinaryFormatter bf = null;
            try
            {
                fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                bf = new BinaryFormatter();
                ShelterManager ShelterFile = (ShelterManager)bf.Deserialize(fs);
                this.shelterManager = ShelterFile;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }

        private void btnDogGui_Click(object sender, EventArgs e)
        {
            AnimalForm.Text = "Dog form";
            labelSize.Visible = false;
            cbSize.Visible = false;
            btnAddDog.Visible = true;
            btnAddCat.Visible = false;
            btnAddBird.Visible = false;
        }

        private void btnCatGUI_Click(object sender, EventArgs e)
        {
            AnimalForm.Text = "Cat form";
            labelSize.Visible = false;
            cbSize.Visible = false;
            btnAddDog.Visible = false;
            btnAddCat.Visible = true;
            btnAddBird.Visible = false;
        }

        private void btnBirdGUI_Click(object sender, EventArgs e)
        {
            AnimalForm.Text = "Bird form";
            labelSize.Visible = true;
            cbSize.Visible = true;
            btnAddDog.Visible = false;
            btnAddCat.Visible = false;
            btnAddBird.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string filename;
            SaveFileDialog sfd = new SaveFileDialog();

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                filename = sfd.FileName;
                if (SaveFiles(filename))
                {
                    MessageBox.Show("The file has been saved successfly.");
                }
                else
                {
                    MessageBox.Show("An error occured while trying to save.");
                }
            }
            else { MessageBox.Show("You chose CANCEL"); }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                string filename;
                OpenFileDialog ofd = new OpenFileDialog();

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    filename = ofd.FileName;
                    if (LoadFiles(filename))
                    {
                        MessageBox.Show("The file has been loaded successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong while loading.");
                    }
                }
                else { MessageBox.Show("You chose CANCEL"); }
            }
            catch (Exception)
            {
                MessageBox.Show("Error - cannot indentify the file.");
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Refresher()
        {
            tbAnimalName.Clear();
            tbAnimalAge.Clear();
            cbGender.Text = "";
            cbSize.Text = "";
            tbDescription.Clear();
        }

        private void btnAddCat_Click(object sender, EventArgs e)
        {
            try
            {
                bool age = Regex.IsMatch(tbAnimalAge.Text, "^[0-9]{1,5}$");
                if (age)
                {
                    Animal cat = null;
                    if (tbDescription.Text != "")
                    {
                        cat = new Cat(tbAnimalName.Text, Convert.ToUInt32(tbAnimalAge.Text),
                            (Gender)cbGender.SelectedItem, tbDescription.Text);
                    }
                    else
                    {
                        cat = new Cat(tbAnimalName.Text, Convert.ToUInt32(tbAnimalAge.Text),
                            (Gender)cbGender.SelectedItem);
                    }
                    if (shelterManager.AddAnimal(cat))
                    {
                        MessageBox.Show($"The cat {cat.GetName()} has been added to the shelter.");
                    }
                    else
                    {
                        MessageBox.Show("Please change animal name since it is already stored in the system.");
                    }
                }
                else
                {
                    MessageBox.Show("Wrong input in age field.");
                }
              
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Please fill in all the informaion required.");
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("Please select the gender or size from the available choices.");
            }
            catch(Exception)
            {
                MessageBox.Show("Something went wrong please try again.");
            }
            finally
            {
                Refresh();
            }
        }

        private void btnAddDog_Click(object sender, EventArgs e)
        {
            try
            {
                bool age = Regex.IsMatch(tbAnimalAge.Text, "^[0-9]{1,5}$");
                if (age)
                {
                    Animal dog = null;
                    if (tbDescription.Text != "")
                    {
                        dog = new Dog(tbAnimalName.Text, Convert.ToUInt32(tbAnimalAge.Text),
                            (Gender)cbGender.SelectedItem, tbDescription.Text);
                    }
                    else
                    {
                        dog = new Dog(tbAnimalName.Text, Convert.ToUInt32(tbAnimalAge.Text),
                            (Gender)cbGender.SelectedItem);
                    }
                    if (shelterManager.AddAnimal(dog))
                    {
                        MessageBox.Show($"The dog {dog.GetName()} has been added to the shelter.");
                    }
                    else
                    {
                        MessageBox.Show("Somethign went wrnog!");
                    }

                }
                else
            {
                MessageBox.Show("Wrong input in age field.");
            }


        }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Please fill in all the informaion required.");
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("Please select the gender or size from the available choices.");
            }
            catch (Exception)
            {
                MessageBox.Show("Please change animal name since it is already stored in the system.");
            }
            finally
            {
                Refresher();
            }
        }

       

        private void btnAddBird_Click(object sender, EventArgs e)
        {
            try
            {
                bool age = Regex.IsMatch(tbAnimalAge.Text, "^[0-9]{1,5}$");
                if (age)
                {
                    Animal bird = null;
                    if (tbDescription.Text != "")
                    {
                        bird = new Bird(tbAnimalName.Text, Convert.ToUInt32(tbAnimalAge.Text),
                            (Gender)cbGender.SelectedItem, tbDescription.Text,
                            (Size)cbSize.SelectedItem);
                    }
                    else
                    {
                        bird = new Bird(tbAnimalName.Text, Convert.ToUInt32(tbAnimalAge.Text),
                            (Gender)cbGender.SelectedItem, (Size)cbSize.SelectedItem);
                    }
                    if (shelterManager.AddAnimal(bird))
                    {
                        MessageBox.Show($"The bird {bird.GetName()} has been added to the shelter.");
                    }
                    else
                    {
                        MessageBox.Show("Please change animal name since it is already stored in the system.");
                    }
                }
                else
                {
                    MessageBox.Show("Wrong input in age field.");
                }

            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Please fill in all the informaion required.");
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("Please select the gender or size from the available choices.");
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong please try again.");
            }
            finally
            {
                Refresher();
            }
        }

        private void btnShowAllAnimals_Click(object sender, EventArgs e)
        {
            lbAnimals.Items.Clear();
            foreach (var a in shelterManager.GetAllAnimals())
            {
                lbAnimals.Items.Add(a);
            }
        }

        private void btnShowAllAvailableAnimals_Click(object sender, EventArgs e)
        {
            lbAnimals.Items.Clear();
            foreach (var a in shelterManager.GetAllAvailableAnimals())
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
                foreach (var a in shelterManager.GetAllAnimals())
                {
                    if (a.GetName() == AnimalName)
                    {
                        animal = a;
                    }
                }
                AnimalDescription animalDescription = new AnimalDescription(animal);
                animalDescription.Show();
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Something went wrong with the data.");
            }
            
        }
        private List<Animal> ChosenAnimals = null;
        private Adoption Adoption = null;
        public void SetChosenAnimals(List<Animal> chosenAnimals)
        {
            ChosenAnimals = chosenAnimals;
            lbChosenAnimals.Items.Clear();
            foreach (var a in ChosenAnimals)
            {
                lbChosenAnimals.Items.Add(a);
            }
        }
        private void btnSelectAnimals_Click(object sender, EventArgs e)
        {
            SelectAnimals selectAnimals = new SelectAnimals(shelterManager.GetAllAvailableAnimals(),this);
            selectAnimals.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                bool Email = Regex.IsMatch(tbEmail.Text, "^[a-zA-Z0-9]{5,50}@[a-zA-Z]{1,10}.(com|net|org)$");
                bool phone = Regex.IsMatch(tbPhone.Text, "^[0-9]{8}$");
                if (Email)
                {
                    if(phone)
                    {
                        Adoption = new Adoption
                           (tbName.Text, tbAddress.Text, tbZipcode.Text, tbCity.Text, tbEmail.Text,
                            tbPhone.Text, DateTime.Now, DateTime.Now,
                            ChosenAnimals);

                        if (Adoption.hasDiscount())
                        {
                            lbDiscount.Text = "Has a discount 10%";
                        }
                        else
                        {
                            lbDiscount.Text = "No discount";
                        }
                        lbTotalFees.Text = Adoption.CalculateFees().ToString();
                        lbDiscount.Visible = true;
                        lbTotalFees.Visible = true;
                        btnAdd.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Error in phone number field, please enter valid phone number.");
                    }
                }
                else
                {
                    MessageBox.Show("Error in email field, please enter valid email.");
                }
              
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Please fill in all the informaion required.");
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("Please select the gender or size from the available choices.");
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong please try again.");
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(shelterManager.AddAdoption(Adoption))
            {
                MessageBox.Show("Adoption has been done!");
                foreach (var a in Adoption.GetAdoptedAnimals())
                {
                    //change animal status.
                    a.AnimalAdopted();
                }
            }
            else
            {
                MessageBox.Show("Something wrong occured while adopting animals.");
            }
        }

        private void lbChosenAnimals_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Animal animal = null;
                int FirstComma = lbChosenAnimals.Text.IndexOf(',');
                string AnimalName = lbChosenAnimals.Text.Substring(0, FirstComma);
                foreach (var a in shelterManager.GetAllAnimals())
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

        private void btnViewAdoptions_Click(object sender, EventArgs e)
        {
            lbHistory.Items.Clear();
            foreach (var a in shelterManager.GetAllAdoptions())
            {
                lbHistory.Items.Add(a);
            }
        }

        private void lbHistory_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Adoption adoption = null;
                int FirstComma = lbHistory.Text.IndexOf(',');
                string CustomerName = lbHistory.Text.Substring(0, FirstComma);
                foreach (var a in shelterManager.GetAllAdoptions())
                {
                    if (a.GetCustomerName() == CustomerName)
                    {
                        adoption = a;
                    }
                }
                AdoptionDescriptionForm adoptionDescription = new AdoptionDescriptionForm(adoption, shelterManager);
                adoptionDescription.Show();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Something went wrong with the data.");
            }
        } 
    }
}
