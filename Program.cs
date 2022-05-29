using System;
using System.Collections.Generic;

namespace DinnerParty
{
    class Program
    {
        static void Main(string[] args)
        {
            Table guests = new Table();

            guests.tables.Add(new Guest("Marilyn Monroe", "entertainer", "(1926 - 1962) American actress, singer, model"));
            guests.tables.Add(new Guest("Abraham Lincoln", "politician", "(1809 - 1865) US President during American civil war"));
            guests.tables.Add(new Guest("Martin Luther King", "activist", "(1929 - 1968)  American civil rights campaigner"));
            guests.tables.Add(new Guest("Rosa Parks", "activist", "(1913 - 2005)  American civil rights activist"));
            guests.tables.Add(new Guest("Peter Sellers", "entertainer", "(1925 - 1980) British actor and comedian"));
            guests.tables.Add(new Guest("Alan Turing", "computer scientist", "(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world"));
            guests.tables.Add(new Guest("Admiral Grace Hopper", "computer scientist", "(1906-1992) - developed early compilers: FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds"));
            guests.tables.Add(new Guest("Indira Gandhi", "politician", "(1917 - 1984) Prime Minister of India 1966 - 1977"));

            Table tableA = new Table();
            Table tableB = new Table();


            foreach (Guest singleGuest in guests.tables)
            {
                Console.WriteLine($"{singleGuest.Name} ({singleGuest.Occupation}) - {singleGuest.Bio}");
            }










        }
    }
}