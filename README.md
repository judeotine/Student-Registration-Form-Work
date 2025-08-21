# Student Registration Form (UWP/XAML)
A simple **Student Registration Form** built using **C# (UWP)** and **XAML** as part of a class assignment.  
The form allows users to enter student details, interact with buttons and receive feedback via dialogs.

---

## Features & Screenshots

### Main Form
The main form with five text fields and four buttons.
<img width="1178" height="932" alt="FormView" src="https://github.com/user-attachments/assets/7af17b71-cf02-44bc-8e33-35b38a9caa1b" />

---

### Greet Student
When the **Greet Student** button is clicked, the name is prefixed with "Hello" and a dialog is displayed.
<img width="738" height="521" alt="Greeting" src="https://github.com/user-attachments/assets/1ecc8e76-7512-4f1f-ac78-296d4e74abb0" />

---

### Show Course
Displays the entered course in the textbox and shows a confirmation dialog.
<img width="671" height="529" alt="ShowCourse" src="https://github.com/user-attachments/assets/0821f372-697f-42bc-b707-7d00f8b57187" />

---

### Show Contacts
Shows the student’s email and phone number in the fields and confirms with a dialog.
<img width="1181" height="792" alt="ShowContact" src="https://github.com/user-attachments/assets/cdde687d-31cc-48c6-ac3d-41c10429a2c5" />

---

### Confirm Registration
Summarizes all the student’s information in a final confirmation dialog.
<img width="1192" height="862" alt="ConfirmRegistration" src="https://github.com/user-attachments/assets/77fc59b5-a659-44cb-a3a0-69d50087a78f" />

---

## Code Structure
- **MainPage.xaml** → Defines the layout (TextBoxes, Buttons, Header, Styles).  
- **MainPage.xaml.cs** → Contains the event handlers for button clicks.

---

## Example Usage
1. Enter your name, ID, course, email, and phone.
2. Click **Greet Student** → Name field is updated and a dialog appears.  
3. Click **Show Course** → Course field is updated and a dialog appears.  
4. Click **Show Contacts** → Email and Phone fields are updated and a dialog appears.  
5. Click **Confirm Registration** → A summary dialog appears with all details.  

---

## Requirements
- Windows 10 or later
- Visual Studio (with UWP development tools installed)

---

## How to Run
1. Clone the repository:
   ```bash
   git clone https://github.com/judeotine/student-registration-form-work.git

2. Open the project in **Visual Studio**.  
3. Build and run the project.  

---

## Notes
- This project was developed as a **class assignment**.  
- The app demonstrates the use of:
  - **XAML UI design**  
  - **Event handling in C#**  
  - **Asynchronous dialogs**  
- Input fields are updated with labels using **string concatenation**, as required by the assignment instructions.  

