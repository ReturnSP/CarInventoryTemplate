using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarInventory
{
    public partial class Form1 : Form
    {
        List<Car> carInventory = new List<Car>();

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string year = yearInput.Text;
            string make = makeInput.Text;
            string colour = colourInput.Text;
            string mileage = mileageInput.Text;

            Car newCar = new Car("2001", "Honda", "White", "12000");
            Car newCar2 = new Car("2002", "Toyota", "Red", "1000");

            outputLabel.Text = newCar.year + newCar.make + "\n";
            outputLabel.Text = newCar2.year + newCar2.colour;

            outputLabel.Text = "";

            DisplayCars();
            //foreach (Car car in carInventory)
            //{
            //    outputLabel.Text = $"{car.year} {car.year} {car.make} {car.colour} {car.mileage}\n";
            //}
        }

        private void DisplayCars()
        {
            for (int i = 0; i < carInventory.Count; i++)
            {
                outputLabel.Text = $"{carInventory[i].year} {carInventory[i].year} {carInventory[i].make} {carInventory[i].colour} {carInventory[i].mileage}\n";
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            string make = makeInput.Text;

            foreach(Car car in carInventory)
            {
                if (car.make == make)
                {
                    carInventory.Remove(car);
                    break; //break out of the foreach loop
                }
            }
            outputLabel.Text = "";
            DisplayCars();
        }
    }
}
