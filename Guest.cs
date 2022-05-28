using System;

namespace DinnerParty
{
    // Step 1: create a class (Guest)
    public class Guest
    {
        // Step 2:Create a constructor for the properties of the class
        public string Name { get; set; }
        public string Occupation { get; set; }
        public string Bio { get; set; }

        //  Step 3: Create a constructor to make a new guest object
        public Guest(string name, string occupation, string bio)
        {
            Name = name;
            Occupation = occupation;
            Bio = bio;
        }
    }
}