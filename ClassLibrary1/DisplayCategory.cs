using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    enum Category
    {
        E = 20,
        D = 40,
        C = 60,
        B = 80,
        A = 100
    }
    public class DisplayCategory
    {
        public int value;

        public void Start()
        {
            DisplayCategories();
            while (true)
            {
                Console.Write("Enter Value: ");
                value = int.Parse(Console.ReadLine());
                if (value != -1)
                {
                    GetCategory(value);
                    DisplayCategories();
                }

                else
                {
                    break;
                }
                    
            }
        }

        public void DisplayCategories()
        {
            var previous = 0;
            foreach (Category enumValue in (Category[])Enum.GetValues(typeof(Category)))
            {
                Console.WriteLine("Category: " + enumValue + " has the range of " + previous + " - " + ((int)enumValue));
                previous = (int)enumValue + 1;

            }
        }

        public void GetCategory(int value)
        {
            var previous = 0;
            var categoryname = "";
            foreach (Category enumValue in (Category[])Enum.GetValues(typeof(Category)))
            {
                if ((value >= previous) && (value <= ((int)enumValue)))
                {
                    categoryname = enumValue.ToString();
                }
                previous = (int)enumValue + 1;

            }

            Console.WriteLine(categoryname);
        }


    }
}
