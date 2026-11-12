/*
Name: Gabriela Malaka
Date: 11/12/2026
Assignment: SDC320 LAB PROJECT - WEEK 1
Description: Derived class for business contacts. Demonstrates inheritance.
*/

// DEMONSTRATING INHERITANCE: BusinessContact IS A Contact
public class BusinessContact : Contact
{
    public string CompanyName { get; set; }
    public string JobTitle { get; set; }

    //CONSTRUCTOR FOR INITIALIZING BUSINESS CONTACT OBJECTS
    public BusinessContact(string firstName, string lastName, string email, string phoneNumber, Address contactAddress, string companyName, string jobTitle)
        : base(firstName, lastName, email, phoneNumber, contactAddress)
    {
        CompanyName = companyName;
        JobTitle = jobTitle;
    }
    //METHOD TO DISPLAY BUSINESS CONTACT DETAILS
    public override void DisplayContact()
    {
        base.DisplayContact();
        Console.WriteLine($"Company: {CompanyName}");
        Console.WriteLine($"Job Title: {JobTitle}");
    }
}