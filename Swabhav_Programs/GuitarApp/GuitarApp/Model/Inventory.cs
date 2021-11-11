using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GuitarApp.Model
{
    class Inventory:Guitar
    {
        private List<Guitar> guitars = new List<Guitar>();
        public Inventory()
        {
         //   guitars = ;
        }
        Guitar guitar = new Guitar();
        public void AddGuitar(int serialNumber, string builder, string model, string topWood,
            string backWood, double price, string type)
        {
            guitar = new Guitar(serialNumber, builder, model, topWood, backWood, price, type);
            guitars.Add(guitar);
        }
        public Guitar GetGuitar(int serialNumber)
        {
            foreach(Guitar i in guitars)
            {
                if (i.SerialNumber == serialNumber)
                    return guitar;
            }
                return null;
        }
        public String SearchGuitar(int serialNumber)
        {
            if(GetGuitar(serialNumber) == null)
            {
                return "Guitar Not found";
            }
            return serialNumber + " is available";
        }
        public string GetPrice
        {
            if
        }
    }
}
