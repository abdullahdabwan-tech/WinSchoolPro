# 🎓 School Management System

![GitHub repo size](https://img.shields.io/github/repo-size/abdullahdabwan-tech/SchoolProject)
![GitHub stars](https://img.shields.io/github/stars/abdullahdabwan-tech/SchoolProject)
![GitHub forks](https://img.shields.io/github/forks/abdullahdabwan-tech/SchoolProject)
![GitHub license](https://img.shields.io/github/license/abdullahdabwan-tech/SchoolProject)

A complete **School Management System** to manage students, teachers, administration, finances, and academic results.

---

# 📌 Features

✔ Student Management
✔ Teacher Management
✔ Administrative Staff Management
✔ Student Grades & Results
✔ School Fees Management
✔ Salary Management
✔ Financial Tracking
✔ Reports & Statistics

---

# 🖼 Screenshots

### Main Screen

![Main Screen](pic/mainscreen.png)

### Login Screen

![Main Log](pic/mainlog.png)

### Add Person / Student

![Add Person](pic/add person screen.png)

### Person Details

![Person Screen](pic/personscrenn.png)

### Show List

![Show List Screen](pic/show list screen.png)

### Application Settings

![App Settings](pic/appsettings.png)

### Themes

![Blue Theme](pic/blue theme.png)
![Black Theme](pic/balck theme.png)

### Code Structure / Pattern

![Code Pattern](pic/code pattern.png)

### Architecture Diagram

![Diagram](pic/digram.png)

### Procedures / Workflows

![Procedure](pic/procedure.png)

### Type Architecture

![Type Architecture](pic/tyer arch.png)

> All screenshots are located in the **pic/** folder.

---

# ⚙️ Installation Guide

Follow these steps to run the system locally.

## 1️⃣ Restore the Database

Open **SQL Server Management Studio** and restore the database located in:

```
Database/
```

Make sure the database name is:

```
SchoolDB
```

---

## 2️⃣ Change Database Owner

Run:

```sql
ALTER AUTHORIZATION ON DATABASE::SchoolDB TO sa;
```

---

## 3️⃣ Configure Connection String

Open the project in Visual Studio and update connection string if necessary:

```text
Server=.;Database=SchoolDB;Trusted_Connection=True;
```

---

## 4️⃣ Run the Project

1. Build the solution in Visual Studio
2. Run the application
3. You should see the system running with the main screen

---

# 🛠 Technologies Used

* C#
* .NET
* SQL Server
* HTML / CSS
* JavaScript

---

# 👨‍💻 Author

**Abdullah Dabwan**
GitHub: [abdullahdabwan-tech](https://github.com/abdullahdabwan-tech)
Telegram: @Abdullah_Soft_Dev

---

⭐ Give a star on GitHub if you like the project!
