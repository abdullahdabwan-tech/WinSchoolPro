# 🎓 School Management System

![GitHub repo size](https://img.shields.io/github/repo-size/abdullahdabwan-tech/SchoolProject)
![GitHub stars](https://img.shields.io/github/stars/abdullahdabwan-tech/SchoolProject)
![GitHub forks](https://img.shields.io/github/forks/abdullahdabwan-tech/SchoolProject)
![GitHub license](https://img.shields.io/github/license/abdullahdabwan-tech/SchoolProject)

A complete **School Management System** designed to manage all school departments including students, teachers, administration, finances, and academic results.

This system helps schools automate administrative tasks and organize data efficiently.

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
some screen shuts

## add person screen 

![Dashboard](pic/addpersonscreen.png)

## settings screen

![settings](pic/appsettings.png)



## Black Theme

![settings](pic/blacktheme.png)



All images are located inside:

pic/

---

# 📂 Project Structure

SchoolProject
│
├── Database → SQL Server Database backup
├── pic → Project screenshots
├── SchoolProject → Main source code
└── README.md

---

# ⚙️ Installation Guide

Follow these steps to run the system locally.

## 1️⃣ Restore the Database

Open **SQL Server Management Studio**

Restore the database located in:

Database/

After restoring, make sure the database name is:

SchoolDB

---

## 2️⃣ Change Database Owner

Run the following SQL command:

```sql
ALTER AUTHORIZATION ON DATABASE::SchoolDB TO sa;
```

Or change the owner manually from database properties.

---

## 3️⃣ Configure Connection String

Open the project and update the connection string if necessary.

Example:

```
Server=.;Database=SchoolDB;Trusted_Connection=True;
```

---

## 4️⃣ Run the Project

1. Open the solution using **Visual Studio**
2. Build the project
3. Run the application

---

# 🛠 Technologies Used

* C#
* .NET
* SQL Server
* HTML
* CSS
* JavaScript

---

# 🎥 Demo GIF

You can add a demo GIF here later to show how the system works.

Example:

![Demo](pic/demo.gif)

---

# 👨‍💻 Author

Abdullah Dabwan

GitHub
https://github.com/abdullahdabwan-tech

Telegram
@Abdullah_Soft_Dev

---

⭐ If you like this project, give it a star on GitHub.
