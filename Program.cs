using System;
using System.Collections.Generic;

// TODO: Step 7: Call the method
GetGuests();

// TODO: Step 6: Create a method to seat the guests at a table






// Step 4: Create a method to return a list (guests)
List<Guest> GetGuests()
{
    // Step 5: Create a list of objects (new Guest)
    List<Guest> guests = new List<Guest>()
    {
    new Guest("Marilyn Monroe", "entertainer", "(1926 - 1962) American actress, singer, model");
  
    new Guest("Abraham Lincoln", "politician", "(1809 - 1865) US President during American civil war");
    
    new Guest("Martin Luther King", "activist", "(1929 - 1968)  American civil rights campaigner");
    
    new Guest("Rosa Parks", "activist", "(1913 - 2005)  American civil rights activist");
    
    new Guest("Peter Sellers", "entertainer", "(1925 - 1980) British actor and comedian");
    
    new Guest("Alan Turing", "computer scientist", "(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world");
    
    new Guest("Admiral Grace Hopper", "computer scientist", "(1906-1992) - developed early compilers: FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds");

    new Guest("Indira Gandhi", "politician", "(1917 - 1984) Prime Minister of India 1966 - 1977");
    }
    return guests;
}



