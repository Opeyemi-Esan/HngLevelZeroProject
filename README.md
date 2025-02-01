# Public API with .NET Core

## Description
This project is a simple public API built using .NET Core. The API provides data retrieval via GET endpoints and follows a clean structure within the controller.

## Features
- .NET Core Web API
- Simple GET endpoints
- Swagger API documentation

## Technologies Used
- .NET Core
- Swagger for API documentation

## Setup Instructions

### **Prerequisites**
Ensure you have the following installed:
- [.NET SDK](https://dotnet.microsoft.com/en-us/download)
- [Postman](https://www.postman.com/) (optional, for testing)
- [Git](https://git-scm.com/)

### **Steps to Run Locally**
1. Clone the repository:
   git clone https://github.com/Opeyemi-Esan/hng-level-zero-project.git
   cd hng-level-zero-project

2. Restore dependencies:
   Copy code
   dotnet restore

3. Run The API:
   dotnet run

4. Access the API documentation via Swagger:
   https://localhost:7045/api/info



API Documentation

   Base URL
   http://localhost:5000/api

Endpoint
   Get All Items
   Endpoint: GET /api/items
   Response:
   [
     {
       "id": 1,
       "email": "tolulopejossyp@gmail.com",
       "current_time": "2025-01-30720:30:00Z",
       “github_url”: “https://github.com/Opeyemi-Esan/hng-level-zero-project/tree/main”
     }
   ]
   

Links to Developer Hiring Page
   https://hng.tech/hire/csharp-developers


License
   This project is licensed under the MIT License.





