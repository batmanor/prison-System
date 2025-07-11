# Prison Management System

## Overview

The **Prison Management System** is a desktop application built using C# and WinForms, designed to facilitate the digital management of prison operations, including user management, guard assignments, prisoner records, and privilege control. The system integrates with an Oracle database via the `Oracle.ManagedDataAccess.Core` package.

---

## Features

* Role-based user management (Create/Delete Users)
* Prisoner information tracking
* Guard and job assignment modules
* Privileges and access control configuration
* Multiple interactive forms for UI navigation
* Oracle Database connectivity with core data manipulation

---

## Technologies Used

* **C# / .NET Framework** (WinForms)
* **Oracle Database**
* **Oracle.ManagedDataAccess.Core (v23.8.0)**
* **UML Diagrams & Gantt Chart** for modeling and planning

---

## Project Structure

```
prisonSystem.sln                --> Visual Studio solution file
|-- prisonSystem/               --> Main application project
|   |-- *.cs / *.Designer.cs    --> Source and UI logic
|   |-- Resources/              --> Image assets
|   |-- bin/ & obj/             --> Build and intermediate files
|   |-- App.config              --> Configuration for Oracle connection
|   |-- packages.config         --> NuGet dependencies
|
|-- ModelingProject1/           --> UML and modeling project
|-- the Database/               --> SQL scripts for database setup
|-- project management/         --> ERD, Gantt chart, use-case diagrams
|-- packages/                   --> Oracle Managed Data Access binaries
```

---

## Setup Instructions

1. **Database Setup**

   * Execute `the Database/database.sql` in your Oracle environment to set up required tables and data.

2. **Configure App.config**

   * Update Oracle connection string in `App.config` under the `prisonSystem` project to match your database credentials and server.

3. **Build the Project**

   * Open `prisonSystem.sln` using Visual Studio.
   * Restore NuGet packages (`Oracle.ManagedDataAccess.Core`).
   * Build and run the solution.

4. **Usage**

   * Launch the application to access the main interface.
   * Navigate between prisoner, guard, job, and privilege forms.

---

## Screenshots & Documentation

![Use Case Diagram](project%20management/use-case-diagram.jpg)  
![Entity Relational Diagram](project%20management/Entity%20Relational%20Diagram.jpg)

---

## License

This project is for educational use only. No license is currently assigned.

---

## Authors

* Mohammed Alhariri — IT Student, Seiyun University

---

## Notes

* Ensure Oracle DB is running before launching the application.
* Admin privileges may be required for certain operations.

---
