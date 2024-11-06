# Project Workshop 3 – CPRG 200 C#.NET

## Course Information

**Course Name:** Rapid Application Development for OOSD 
**Course Code:** CPRG-200-A  
**Instructor:** Samuel Sofela  
**Project Due Date:** 12-16-2024  
**Group:** 3

## Table of Contents
- [Project Title](#project-title)
- [Project Description](#project-description)
- [Project Objectives](#project-objectives)
- [Functionality](#functionality)
- [Database Tables](#database-tables)
- [Installation](#installation)
- [Usage](#usage)

## Project Title
Travel Experts Data Management System

## Project Description
This project is developed as part of the CPRG 200 C#.NET course and aims to create a prototype application for Travel Experts employees. The application provides a graphical interface for managing data in the TravelExperts SQL Server database. It allows for viewing, adding, editing, and deleting data in essential tables, enabling employees to efficiently administer travel-related information.

## Project Objectives
The main goal of this application is to enable Travel Experts employees to maintain the following data:
- Travel Packages
- Products
- Product Suppliers
- Suppliers
- Agents
- Agencies

The project also includes creating an administrative user who can perform CRUD (Create, Read, Update, Delete) operations on agents and agencies, as well as on travel packages. The interface is designed to be user-friendly, providing intuitive navigation for managing data.

## Functionality
- **CRUD Operations**: The application enables users to perform CRUD operations on travel packages, products, suppliers, agents, and agencies.
- **Data Validation**: Before creating a package, the application ensures data integrity by validating the following:
  - **Agency Commission** cannot exceed the Base Price.
  - **Package End Date** must be later than the Start Date.
  - **Package Name** and **Description** cannot be null.
- **Search and Filter**: The application incorporates search functionality, allowing users to filter displayed data for easy access and management.

## Database Tables
The following tables from the TravelExperts database are used:
1. **Packages**
2. **Products**
3. **Products_suppliers**
4. **Suppliers**
5. **Packages_products_suppliers**
6. **Agents**
7. **Agencies**

Note: While building the application, minor improvements were made to the database structure to facilitate programming. These changes adhere to normalization principles to maintain database integrity.

## Installation
To run this application, ensure that:
1. **SQL Server** is installed and configured with the TravelExperts database.
2. **Visual Studio** or another compatible C#.NET development environment is set up.
3. The TravelExperts database is connected to the application.

## Usage
- Run the application through your C#.NET environment.
- Log in with admin credentials to access all CRUD functionalities.
- Use the search filters to narrow down data views for packages, agents, and products.
- Follow validation prompts to ensure data accuracy.
