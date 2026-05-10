# Library Management API

Simple CRUD API for managing books using ASP.NET Core, Entity Framework Core, and SQL Server.

## Prerequisites

- .NET 8 SDK
- SQL Server (LocalDB works for local development)

## Configuration

Update the connection string in `LibraryManagement.API/appsettings.json` or
`LibraryManagement.API/appsettings.Development.json`:

- `ConnectionStrings:DefaultConnection`

## Run locally

From the `LibraryManagement.API` directory:

- Apply migrations (optional if the database is already created):
  - `dotnet ef database update`
- Start the API:
  - `dotnet run`

Swagger UI is available at `/swagger` in Development.

## API Endpoints

- GET `/api/book` — list all books
- GET `/api/book/{id}` — get a book by id
- POST `/api/book` — create a new book
- PUT `/api/book/{id}` — update a book
- DELETE `/api/book/{id}` — delete a book
