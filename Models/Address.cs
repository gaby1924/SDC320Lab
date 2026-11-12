/*
Name: Gabriela Malaka
Date: 11/12/2026
Assignment: SDC320 LAB PROJECT - WEEK 1
Description: This file represents a physical address. Used to demonstrate 
composition within the Contact class hierarchy.
*/
//CLASS REPRESENTING A PHYSICAL ADDRESS
public class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }

    //CONSTRUCTOR FOR INITIALIZING ADDRESS OBJECTS
    public Address(string street, string city, string state, string zipCode)
    {
        Street = street;
        City = city;
        State = state;
        ZipCode = zipCode;
    }
    //OVERRIDING ToString METHOD TO DISPLAY ADDRESS DETAILS
    public override string ToString()
    {
        return $"{Street}, {City}, {State} {ZipCode}";
    }
}