# 📌 Microsoft Summer Internship ( Contact Manager CLI (C#) )2026  

---

## Project Overview

This project is a **Command-Line Contact Management System** developed in **C#**, designed to replace a legacy phone-book–style contact lookup system.
The application provides **efficient contact retrieval**, **extensible data storage**, and a **clean object-oriented architecture** following **SOLID principles**.
All contact data is stored locally using **JSON**, ensuring simplicity and flexibility.

---

## Problem Statement

The legacy contact lookup system suffers from:
- Slow and inefficient searching
- Rigid, non-extensible data storage
- Blocking operations during data loading

This application addresses these issues by providing a modern, structured, and maintainable solution implemented in **C#**.

---

##  Features

### Contact Management
Users can:
- Add a new contact
- Edit an existing contact
- Delete a contact
- View a specific contact
- List all contacts

Each contact includes:
- **Id** (auto-generated)
- **Name**
- **Phone**
- **Email**
- **Creation Date** (auto-generated, real-time)

---

### Additional Operations
- Search contacts by name, phone, or email
- Filter contacts based on Date of creating contact "Could be extended by OC principle" 
- Save contacts to JSON storage

---
## Applying SOLID Principles and OO design
- OCP for extending versions of services adding new services 
- Coding to an interface
## Application Flow

1. Load stored contacts (if any)
2. Display existing contacts
3. Show Main Menu
4. Execute user-selected operations

---

## Main Menu Options

1. Add Contact  
2. Edit Contact  
3. Delete Contact  
4. View Contact  
5. List Contacts  
6. Search by any keyword referring to name , ID , etc any property og the contact 
7. Filter by Date of creating contact
8. Save to ensure before close wether need that changes or not "that step the user should take care of it"
9. Exit  

---

## 🛠️ Technologies Used

- **Language:** C#
- **Storage:** JSON file
- **Architecture:** Object-Oriented Programming
- **Design Principles:** SOLID

---

## ▶️ How to Run the Application

### Prerequisites
- .NET SDK installed (version 8.0 )
- Any C# IDE

### Steps
1. Clone the repository:
   ```bash
   git clone <https://github.com/fatema123elfiky/Contact-Manager_CLI>
