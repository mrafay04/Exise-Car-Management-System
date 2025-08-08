
🛂 Project Title: Excise and Taxation Car Verification System

🎯 Objective:
To develop a desktop-based system where the public can verify vehicle ownership and details, and the admin can manage vehicle records securely using C# and SQL Server.

🧠 Problem Statement:
Manual vehicle verification is time-consuming, error-prone, and not easily accessible to the public. There is a need for a centralized digital system that allows:
- Admins to add/manage vehicle information.
- Public users to verify vehicle details by entering a registration number.

💻 Tools & Technologies Used:
- C# (Windows Forms) – Frontend development  
- SQL Server – Backend database  
- Visual Studio – IDE for development  
- ADO.NET – Database connectivity

🔐 System Users:
1. Admin
- Login securely.
- Add new vehicle records.
- Manage vehicle data.

2. Public User
-  login required.
- Enter a vehicle number and verify vehicle details.

📦 Core Modules:
1. Login Module (Admin Only)
- Username-password login form.

2. Add Vehicle Module (Admin)
- Fields: Owner Name, CNIC, Vehicle Number, Vehicle Type, Model Year, Engine Number, Chassis Number, Color.
- Inserts data into the database.

3. Public Vehicle Verification Module
- Enter vehicle number
- Shows result in DataGridView
- Displays message if not found

4. Logout Functionality
- For both admin and public users.

🧱 Database Design

Table: Vehicle
| Field Name      | Data Type    | Description               |
|------------------|--------------|---------------------------|
| VehicleID        | INT (PK)     | Auto-increment ID         |
| OwnerName        | VARCHAR(100) | Name of vehicle owner     |
| CNIC             | VARCHAR(20)  | CNIC of the owner         |
| VehicleNumber    | VARCHAR(20)  | Registration number       |
| VehicleType      | VARCHAR(50)  | Car/Bike/Truck etc.       |
| ModelYear        | VARCHAR(10)  | Model year                |
| EngineNumber     | VARCHAR(50)  | Engine number             |
| ChassisNumber    | VARCHAR(50)  | Chassis number            |
| Color            | VARCHAR(20)  | Vehicle color             |

🔄 Workflow Overview:

Public User → PublicForm.cs
              ↳ Enters Vehicle Number
              ↳ SQL Query → Vehicle Table
                 ↳ If found → Show in DataGridView
                 ↳ Else → Show “Not Found”

Admin → LoginForm.cs
        ↳ On success → AddVehicleForm
        ↳ Adds Vehicle to DB

🧪 Testing & Validation
- Tested valid/invalid vehicle numbers.
- Verified SQL insertions.
- Handled null inputs and exceptions.

📈 Project Outcomes
- Centralized digital vehicle record.
- Public access to verification.
- Easy admin data entry.
- Improved reliability and speed.

🧾 Future Enhancements
- Export to PDF or Print
- Upload vehicle photo
- Search by CNIC or Chassis Number
- Online SMS/API verification
- Password encryption for admin


