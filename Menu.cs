/*
Name: Gabriela Malaka
Date: 11/12/2026
Assignment: SDC320 LAB PROJECT
Description: This file contains the code for displaying the menu
of the Rolodex/Contact Management application. The menu consists of several
options for the user to select from:
1. Add a new contact
2. Remove an existing contact
3. Update an existing contact
4. Display contacts (all contacts alphabetically, by last name initial, or by group)
5. Exit the application
*/
public class Menu
{
    public void DisplayMenu()
    {
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("SDC320 LAB PROJECT - WEEK 1");
        Console.WriteLine("Rolodex Application by Gabriela Malaka");
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("\nWelcome to the Rolodex Application");
        Console.WriteLine("Please select an option from the menu:");
        Console.WriteLine("1. Add a new contact");
        Console.WriteLine("2. Remove an existing contact");
        Console.WriteLine("3. Update an existing contact");
        Console.WriteLine("4. Display contacts");
        Console.WriteLine("5. Exit");
    }
    public int GetUserChoice()
    {
        Console.Write("Enter your choice: ");
        return Convert.ToInt32((Console.ReadLine()));
    }
}