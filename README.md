# Rolodex & Contact Management Application

## Project Overview
This Rolodex Application is an Object-Oriented Programming (OOP) console application developed in C#. Designed as a modular, extensible contact management system, it allows users to organize various types of
contacts while demonstrating core OOP pillars—specifically **inheritance**, **composition**, and **encapsulation**.

This project is structured for incremental development over a five-week course term, with Phase 1 establishing the foundational data models, user interaction loops, and menu navigation.

---

## Features & Implementation (Phase 1)
- **Interactive Console Menu:** A clean user interface allowing navigation through options like adding, updating, removing, and displaying contacts.
- **Inheritance Structure:** 
  - A robust base class (`Contact`) containing shared attributes across all contact types.
  - Derived child classes (`BusinessContact` and `PersonalContact`) that specialize records for professional and personal relationships.
- **Composition Architecture:** 
  - A dedicated `Address` class embedded directly within the `Contact` class ("has-a" relationship) to eliminate duplicate location logic.
- **Documentation:** Fully documented classes featuring comprehensive header blocks and inline indicators marking inheritance and composition logic.

---

## Project Structure
RolodexApp/
Program.cs - Main entry point and application loop
Menu.cs - User interface and option handling

Models/ - Data Models (OOP Core)
Address.cs - Composition class for physical locations
Contact.cs - Base class for all contact records
BusinessContact.cs - Derived class for professional contacts
PersonalContact.cs - Derived class for personal (family/friends) contacts

Operations/ - Service & Logic Classes (Upcoming Phases)
AddContact.cs - User can add a contact
RemoveContact.cs - User can delete a contact
UpdateContact.cs - User can update an existing contact
DisplayContacts.cs - Displays all contacts alphabetically, by last initial, or by group
