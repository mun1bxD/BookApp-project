# Book App Project

## Overview
The **Book App Project** is a web application built using **ASP.NET Core** that allows users to browse and manage a collection of books. The project follows the **MVC (Model-View-Controller)** architecture for better separation of concerns and utilizes **Identity Core** for user authentication (without email verification). Additionally, the project incorporates **Entity Framework Core** for database management, enabling efficient CRUD operations on book records.

## Features
1. **User Authentication**:  
   The application includes authentication functionality using **ASP.NET Core Identity**. Users can register, log in, and manage their accounts. However, email verification is not implemented in this project.

2. **Admin Page with CRUD Operations**:  
   An admin section is available where administrators can:
   - **Create**, **Read**, **Update**, and **Delete** book records.
   This allows for easy management of the book collection.

3. **MVC Architecture**:  
   The project follows the **MVC design pattern**, where:
   - **Models** represent the data (books and users).
   - **Views** are Razor Pages styled with **Tailwind CSS** for a responsive and modern UI.
   - **Controllers** handle requests, manage data flow, and ensure separation of logic.

4. **Entity Framework Core**:  
   **EF Core** is used for data access and management. It provides:
   - Database migration capabilities.
   - Automatic mapping between models and database tables.
   - Efficient querying and data manipulation for the books collection.

5. **Razor Pages for Frontend**:  
   The frontend of the application is built using **Razor Pages**, ensuring smooth interaction and dynamic content rendering. It is styled with **Tailwind CSS**, providing a clean, responsive, and modern design.

## Technologies Used
- **ASP.NET Core**: Web framework for building the application.
- **MVC Pattern**: For structured code and separation of concerns.
- **ASP.NET Core Identity**: For authentication without email verification.
- **Entity Framework Core**: For database interaction and migrations.
- **Razor Pages**: For rendering the frontend UI.
- **Tailwind CSS**: For responsive and customizable frontend design.

---
