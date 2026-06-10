# ✅ To-Do List - Windows Forms Project

## 📖 Overview

A To-Do List application built with **C# Windows Forms** as my own practice project of the **_“Course 14 - C# - Level 1”_** with **Dr. Mohammed Abu-Hadhoud**  👉 [www.programmingadvices.com](https://www.programmingadvices.com).

The application allows users to create, manage, edit, and track tasks while automatically saving data between sessions.

All tasks are stored in a **TXT file**, ensuring that the task list remains available even after closing and reopening the application.

---

## ✨ Features

### 📝 Task Management

* Add new tasks
* Edit existing tasks using the ✏️ edit button
* Delete individual tasks
* Delete all tasks at once
* Mark tasks as completed or incomplete

---

### 📊 Task Tracking

The application keeps track of:

* ✅ Completed tasks
* ⏳ Remaining tasks

This provides a quick overview of overall progress.

---

### ⚡ Bulk Actions

Perform actions on multiple tasks with a single click:

* ✅ Mark all tasks as completed
* ⏳ Mark all tasks as incomplete
* 🗑️ Remove all completed tasks

---

### 💾 Automatic Data Persistence

All tasks are saved to a TXT file.

Users can save manually using the Save button, and tasks are also saved automatically when the application closes.

Automatic saving is implemented using the:

```csharp
Form_Closing
```

event, ensuring that no task changes are lost when exiting the application.

---

## 🛠️ Main Windows Forms Controls Used

* 📋 CheckedListBox
* 🖱️ Button
* 🏷️ Label
* ✏️ PictureBox (Edit, Save Icons)
* 📝 TextBox

---

## 🎯 Learning Objectives

This project was created to practice:

* File handling with TXT files
* Reading and writing persistent data
* Managing collections of tasks
* Implementing CRUD operations (Create, Read, Update, Delete)
* Working with Windows Forms events
* Using the Form Closing event
* Updating the user interface dynamically
* Building productivity applications

---

## 💻 Technologies

* C#
* .NET
* Windows Forms (WinForms)

---

## 🎥 Demo Video

A demonstration video of the project is available on LinkedIn: [View post](https://www.linkedin.com/posts/sami-yahya_programming-csharp-windowsfroms-activity-7470067208724013056-_Fj9?utm_source=share&utm_medium=member_desktop&rcm=ACoAAF-2Zs4BGwYO_o-PgB_jvED7e8bNeuGeNSU)

