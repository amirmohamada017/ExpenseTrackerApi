# Expense Tracker API

## Overview
This Expense Tracker API is a robust ASP.NET Core application that allows users to manage their expenses efficiently. It provides secure user authentication and full CRUD operations for expense tracking.

## Features
- User registration and authentication using JWT tokens
- Create, read, update, and delete expenses
- Filter expenses by time periods (past week, past month, last 3 months)
- Secure API endpoints
- MySQL database integration

## Technologies Used
- ASP.NET Core 7.0
- Entity Framework Core
- MySQL
- JWT for authentication

## Prerequisites
- .NET 7.0 SDK
- MySQL Server

## Setup Instructions

1. Clone the repository:
   ```
   git clone https://github.com/yourusername/ExpenseTrackerApi.git
   ```

2. Navigate to the project directory:
   ```
   cd ExpenseTrackerApi
   ```

3. Copy `appsettings.sample.json` to `appsettings.json`:
   ```
   cp appsettings.sample.json appsettings.json
   ```

4. Update `appsettings.json` with your MySQL server details and JWT configuration:
    - Replace `YourPasswordHere` with your MySQL password
    - Replace `YourJwtKeyHere` with a strong, randomly generated key (at least 32 characters)

5. Open the project in JetBrains Rider (or your preferred IDE).

6. Restore the NuGet packages.

7. Apply the database migrations:
   ```
   dotnet ef database update
   ```

8. Run the application:
   ```
   dotnet run
   ```

## API Endpoints

### User Management
- POST /api/User/register - Register a new user
- POST /api/User/login - Log in and receive a JWT token

### Expense Management
- GET /api/Expense - Get all expenses (with optional filter)
- POST /api/Expense - Create a new expense
- PUT /api/Expense/{id} - Update an existing expense
- DELETE /api/Expense/{id} - Delete an expense

## Usage
1. Register a new user using the `/api/User/register` endpoint.
2. Log in using the `/api/User/login` endpoint to receive a JWT token.
3. Include the JWT token in the Authorization header as a Bearer token for all requests to `/api/Expense` endpoints.

## Security Considerations
- The `appsettings.json` file is ignored by git to prevent committing sensitive information.
- Use `appsettings.sample.json` as a template for your `appsettings.json` file.
- Keep the JWT secret key confidential and use environment variables in production.
- Use HTTPS in production to ensure secure transmission of data.
- Regularly update dependencies to patch any security vulnerabilities.


## Project Source
This project was completed as part of the project ideas listed on roadmap.sh.
https://roadmap.sh/projects/expense-tracker-api