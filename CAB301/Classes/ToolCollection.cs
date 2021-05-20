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
                new ToolCollection[6]["Jacks", "Air Compressors", "Battery Chargers", "Socket Tools", "Braking", "Drivetrain"], //Automoti
            };*/

        Tool[] collection;
        int count = 0;

        public ToolCollection()
        {
            collection = new Tool[Int32.MaxValue];
        }

        public int Number => count;

        public void add(Tool aTool)
        {
            collection[Number - 1] = aTool;
            count++;
        }

        public void delete(Tool aTool)
        {
            // Array.IndexOf(collection, aTool) will return the index if it's found, or -1 if it's not found
            int index = Array.IndexOf(collection, aTool);

            // for (int i = something; i < collection.Length; i++) <- if we start at -1 we'll get an error because arrays start at 0, if it's not found we shouldn't attempt to loop

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
