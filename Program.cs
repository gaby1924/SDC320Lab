/*
Name: Gabriela Malaka
Date: 11/12/2026
Assignment: SDC320 LAB PROJECT
Description: this is the main program file for the Rolodex/Contact
Management application. This file contains the main program logic
for adding, updating, removing, and displaying contacts.*/
/*-------------------------------
DISPLAY MENU AND GET USER CHOICE
-------------------------------*/
Menu menu = new Menu();

bool running = true;
while (running)
{
    menu.DisplayMenu();
    int choice = menu.GetUserChoice();
    switch (choice)
    { //SWITCH CASE START, PLACEHOLDERS FOR MENU FUNCTIONALITY
        case 1:
            Console.WriteLine("You selected to add a new contact.");
            break;
        case 2:
            Console.WriteLine("You selected to remove an existing contact.");
            break;
        case 3:
            Console.WriteLine("You selected to update an existing contact.");
            break;
        case 4:
            Console.WriteLine("You selected to display contacts.");
            break;
        case 5:
            Console.WriteLine("Exiting the application.");
            running = false; //STOP THE LOOP AND EXIT THE APPLICATION
            break;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    } //SWITCH CASE END
}