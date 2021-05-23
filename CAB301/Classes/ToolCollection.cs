using System;
using System.Linq;

namespace Assignment
{
    public class ToolCollection : iToolCollection
    {
        //private Tool[] collection;
        /*    public ToolCollection[][] Tools = new ToolCollection[9][]
            {
                new ToolCollection[5]["Line Trimmers", "Lawn Mowers", "Hand Tools", "Wheelbarrows", "Garden Power Tools"], //Gardening Tools
                new ToolCollection[6]["Scrapers", "Floor Lasers", "Floor Levelling Tools", "Floor Levelling Materials", "Floor Hand Tools", "Tiling Tools"], //Flooring Tools
                new ToolCollection[5]["Hand Tools", "Electric Fencing", "Steel Fencing Tools", "Power Tools", "Fencing Accessories"], //Fencing Tools
                new ToolCollection[6]["Distance Tools", "Laser Measurer", "Measuring Jugs", "Temperature & Humidity Tools", "Levelling Tools", "Markers"], //Measuring Tools
                new ToolCollection[6]["Draining", "Car Cleaning", "Vacuum", "Pressure Cleaners", "Pool Cleaning", "Floor Cleaning"], //Cleaning Tools
                new ToolCollection[6]["Sanding Tools", "Brushes", "Rollers", "Paint Removal Tools", "Paint Scrapers", "Sprayers"], //Painting Tools
                new ToolCollection[5]["Voltage Tester", "Oscilloscopes", "Thermal Imaging", "Data Test Tool", "Insullation Tester"], //Electric Tools
                new ToolCollection[5]["Test Equipment", "Safety Equipment", "Basic Hand Tools", "Circuit Protection", "Cable Tools"], //Electricity Tools
                new ToolCollection[6]["Jacks", "Air Compressors", "Battery Chargers", "Socket Tools", "Braking", "Drivetrain"], //Automotive Tools
            };*/

        Tool[] collection;
        //= new Tool[9]{ "Gardening Tools", "Flooring Tools", "Fencing Tools", "Measuring Tools", "Cleaning Tools", "Painting Tools", "Electric Tools", "Electricity Tools", "Automotive Tools" };
        
        int count = 0;

        public ToolCollection()
        {
            collection = new Tool[1000000];
        }

        public int Number => count;

        public void add(Tool aTool)
        {
            collection[Number - 1] = aTool;
            count++;
        }

        public void delete(Tool aTool)
        {
            int index = Array.IndexOf(collection, aTool);

            if (index > -1) {

                for (; index < Number; index++)
                {
                    collection[index] = collection[index + 1];
                }
                count--;
            }
            Console.WriteLine("Tool deleted.");
        }

        public bool search(Tool aTool)
        {
            return Array.IndexOf(collection, aTool) > -1;
        }

        public Tool[] toArray()
        {
            throw new NotImplementedException();
        }
    }
}
