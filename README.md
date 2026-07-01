# TimeKeepApp

A full-stack web application built for a coding challenge assessment. This project is a specialized Timekeeping Management System that tracks employee attendance through structured clock-in/out transactions. 

The application utilizes **Blazor Server** and **Entity Framework Core** to deliver a responsive UI coupled with robust data persistence.

---

## 🚀 Features

### 👤 Employee Management
* **Full CRUD Operations:** Add, view, update, and delete employee profiles.
* **Data Fields:** Captures essential details including `EmployeeId`, `FirstName`, `LastName`, `Gender`, and `DateHired`.
* **Input Validation:** Strict validation rules implemented across forms to ensure data integrity.

### ⏱️ Timekeeping & Transactions
* **Clock Transactions:** Log precise timekeeping events tied directly to specific employees.
* **Transaction Types:** Enforced validation logic allowing only `IN` and `OUT` statuses.
* **Data Structure:** Records `TimekeepingTransactionId`, `EmployeeId`, `TransactionTypeId`, and `TransactionDateTime`.

---

## 🛠️ Tech Stack

* **Frontend & Backend Framework:** .NET Core / Blazor Server
* **ORM / Database Access:** Entity Framework Core (Code-First / Database-First)
* **Database:** SQL Server (or your preferred DB choice, e.g., SQLite/PostgreSQL)
* **Development IDE:** Visual Studio 2019 / 2022

---

## 📊 Database Schema

The database relies on Entity Framework mapping out a one-to-many relationship structure among three core entities:

1.  **TransactionType:** Defines lookup statuses (`IN`, `OUT`).
2.  **Employee:** Holds master records of employees.
3.  **TimekeepingTransaction:** Bridges employees to their respective transaction types with timestamps.

---

## ⚙️ Getting Started

Follow these steps to run the project locally on your machine.

### Prerequisites
* [.NET Core SDK](https://dotnet.microsoft.com/download) (Compatible with your project target, e.g., .NET Core 3.1 / .NET 5+)
* Visual Studio 2022 or later
* SQL Server Management Studio (SSMS) or LocalDB

### Installation & Setup

1. **Clone the Repository:**
     ```bash
     git clone [https://github.com/niko2901/TimeKeepApp.git](https://github.com/niko2901/TimeKeepApp.git)
     cd TimeKeepApp
   
2. Configure the Database Connection:
   Open appsettings.json and update the connection string to match your local SQL Server instance:
     "ConnectionStrings": {
         "TimeKeepAppContext": "Server=YOUR_SERVER;Database=TimeKeepDb;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true"
     }

3. Apply Database Migrations (If applicable):
   Open the Package Manager Console in Visual Studio and run:
     Update-Database
