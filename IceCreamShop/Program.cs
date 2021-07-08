using System;
using System.Collections.Generic;

namespace IceCreamShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Case menu = new Case();
            List<Flavor> availableFlavors = menu.Flavors;
            List<Cone> availableCones = menu.Cones;

            // TODO: Use a Comparer class to sort the 'flavors' array alphabetically by the 'name'
            //  field.
            foreach (Flavor flavor in availableFlavors)
            {
                Console.WriteLine(flavor.Name);
            }
            FlavorComparer comparer = new FlavorComparer();
            //availableFlavors.Sort(comparer);


            // TODO: Use a Comparator class to sort the 'cones' array in increasing order by the 'cost'
            //  field.
            //foreach (Cone cone in availableCones)
            //{
            //    Console.WriteLine($"{cone.Name}: ${cone.Cost}");
            //}
            //availableCones.Sort(new ConeComparer());

            // TODO: Print the 'flavors' and 'cones' lists (in a clear manner) to verify the sorting.
            //Console.WriteLine("\n<-----SORTED FLAVORS----->\n");

            //foreach (Flavor flavor in availableFlavors)
            //{
            //    Console.WriteLine(flavor.Name);
            //}
            //Console.WriteLine("\n<-----SORTED CONES----->\n");

            //foreach (Cone cone in availableCones)
            //{
            //    Console.WriteLine($"{cone.Name}: ${cone.Cost}");
            //}

            Console.WriteLine("\n<-----SORTED BY ALLERGENS----->\n");
            availableFlavors.Sort(comparer);
            foreach (Flavor flavor in availableFlavors)
            {
                Console.WriteLine(flavor.Name);
            }


            Console.ReadLine();
        }
    }
}
