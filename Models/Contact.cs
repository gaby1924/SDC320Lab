/*
Name: Gabriela Malaka
Date: 11/12/2026
Assignment: SDC320 LAB PROJECT - WEEK 1
Description: Base Contact class containing shared attributes for all 
contact types. Demonstrates composition via the Address property.
*/
//BASE CLASS FOR ALL CONTACT TYPES
public class Contact
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Email { get; set; }
    public string PhoneNumber { get; set; }

    //DEMONSTRATING COMPOSITION: Contact HAS AN Address
    public Address ContactAddress { get; set; }

    //CONSTRUCTOR FOR INITIALIZING CONTACT OBJECTS
    public Contact(string firstName, string lastName, string email, string phoneNumber, Address contactAddress)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        PhoneNumber = phoneNumber;
        ContactAddress = contactAddress;
    }
    //METHOD TO DISPLAY CONTACT DETAILS
    public virtual void DisplayContact()
    {
        Console.WriteLine($"Name: {FirstName} {LastName}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Phone: {PhoneNumber}");
        Console.WriteLine($"Address: {ContactAddress}");
    }
}