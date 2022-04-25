using System;

int memSize = 5;
// creating member collection of size memSize
IMemberCollection collection = new MemberCollection(memSize);
Console.WriteLine("new member collection of size: " + memSize.ToString());

// creating new member
IMember James = new Member("James", "Smith", "0406566777", "23456");
IMember Alice = new Member("Alice", "Jones", "940656 777", "f36111");
IMember Frank = new Member("Frank", "Banks", "040f566777", "00000000");
IMember Mary = new Member("Mary", "Jane");

// adding member to collection
collection.Add(Alice);
collection.Add(James);
collection.Add(Frank);
collection.Add(Alice);

collection.Delete(Frank);

collection.Add(Alice);



Console.WriteLine("number of members " + collection.Number.ToString() + ", capacity of " + collection.Capacity.ToString());
Console.WriteLine(collection.ToString());


// searching for a member to collection

Console.WriteLine(collection.Search(James));
Console.WriteLine(collection.Search(Mary));



// deleting member to collection
collection.Delete(Alice);
//collection.Delete(Frank);
Console.WriteLine();


Console.WriteLine("number of members " + collection.Number.ToString() + ", capacity of " + collection.Capacity.ToString());
Console.WriteLine(collection.ToString());

Console.WriteLine();

// Checking phone numbers
Console.WriteLine(IMember.IsValidContactNumber(James.ContactNumber));
Console.WriteLine(IMember.IsValidContactNumber(Frank.ContactNumber));
Console.WriteLine(IMember.IsValidContactNumber(Alice.ContactNumber));

Console.WriteLine();

// Checking pin numbers
Console.WriteLine(IMember.IsValidPin(James.Pin));
Console.WriteLine(IMember.IsValidPin(Frank.Pin));
Console.WriteLine(IMember.IsValidPin(Alice.Pin));