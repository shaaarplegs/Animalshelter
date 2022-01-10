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
    public partial class AnimalDescription : Form
    {
        
        public AnimalDescription(Animal animal)
        {
            InitializeComponent();
            lbName.Text = animal.GetName();
            lbAge.Text = animal.GetAge().ToString();
            lbGender.Text = animal.GetGender().ToString();
            if(animal is Dog)
            {
                lbType.Text = "Dog";
            }
            else if (animal is Cat)
            {
                lbType.Text = "Cat";
            }
            if(animal is Bird)
            {
                lbSize.Visible = true;
                lbSize.Text = ((Bird)animal).GetSize().ToString();
                lbType.Text = "Bird";
            }
            lbDescription.Text = animal.GetDescription();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
