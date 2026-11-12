/*
Name: Gabriela Malaka
Date: 11/12/2026
Assignment: SDC320 LAB PROJECT - WEEK 1
Description: Derived class for personal contacts (friends/family). Demonstrates inheritance.
*/

// DEMONSTRATING INHERITANCE: PersonalContact IS A Contact
public class PersonalContact : Contact
{
    public string Relationship { get; set; } //family or friend
    public string Birthday { get; set; } //in the format MM/DD/YYYY

    //CONSTRUCTOR FOR INITIALIZING PERSONAL CONTACT OBJECTS
    public PersonalContact(string firstName, string lastName, string email, string phoneNumber, Address contactAddress, string relationship, string birthday)
        : base(firstName, lastName, email, phoneNumber, contactAddress)
    {
        Relationship = relationship;
        Birthday = birthday;
    }

    //METHOD TO DISPLAY PERSONAL CONTACT DETAILS
    public override void DisplayContact()
    {
        base.DisplayContact();
        Console.WriteLine($"Relationship: {Relationship}");
        Console.WriteLine($"Birthday: {Birthday}");
    }
}