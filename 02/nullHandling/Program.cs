#nullable enable
using System;

// To add OmniSharp, Ctrl + Shift + P, and select OmniSharp and Project

namespace nullHandling
{

    class Address {
        public string? Building;
        public string Street = string.Empty;
        public string City = string.Empty;
        public string Region = string.Empty;
    }

    class Program
    {
        static void Main(string[] args)
        {
            int thisCannotBeNull = 4;
            // thisCannotBeNull = null; // compile error

            int? thisCouldBeNull = null;
            Console.WriteLine(thisCouldBeNull);
            Console.WriteLine(thisCouldBeNull.GetValueOrDefault());

            thisCouldBeNull = 7;
            Console.WriteLine(thisCouldBeNull);
            Console.WriteLine(thisCouldBeNull.GetValueOrDefault());

            var address = new Address();
            address.Building = null;
            address.Street = null;
            address.City = null;
            address.Region = null;
            Console.WriteLine(address);
        }
    }
}
