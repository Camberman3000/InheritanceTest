using System;
using System.Drawing.Drawing2D;

namespace InheritanceTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        // base class
        class Animal
        {           
            private string breed;// Private - Cannot be accessed directly - must use get/set, below
            public string AnimalBreed { get => breed; set => breed = value; }
        }

        // derived class of Animal 
        class Dog : Animal
        {
            private string name;// Private - Cannot be accessed directly - must use get/set, below
            public string AnimalName { get => name; set => name = value; }
        }

        private void buttonDisplayName_Click(object sender, EventArgs e)
        {             
            Dog labrador = new Dog();// Derived class (Dog inherits from Animal class which means it can get/set AnimalBreed method)

            /* Set values in Dog class */
            labrador.AnimalName = "Ubu";
            labrador.AnimalBreed = "Labrador";

            /* Get values from Dog class */
            tbDogName.Text = labrador.AnimalName;
            tbDogBreed.Text = labrador.AnimalBreed;
        }
    } 
}