using System;

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

        public int Number => throw new NotImplementedException();

        public void add(Tool aTool)
        {
            Console.WriteLine("Works");
        }

        public void delete(Tool aTool)
        {
            Console.WriteLine("You've deleted tool: ");
        }

        public bool search(Tool aTool)
        {
            throw new NotImplementedException();
        }

        public Tool[] toArray()
        {
            throw new NotImplementedException();
        }
    }
}
