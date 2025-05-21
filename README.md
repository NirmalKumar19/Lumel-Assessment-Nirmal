# Sales Analysis API (In-Memory EF Core)

## Overview

This is a minimal ASP.NET Core Web API project demonstrating:

- Use of **Entity Framework Core In-Memory** database for data storage
- Loading and parsing sales data from CSV lines into normalized entities (Customers, Products, Orders, OrderItems)
- Calculating total revenue within a date range
- Refreshing data on-demand by reloading CSV input

---

## Prerequisites

- [.NET 7.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) or higher installed
- C# 11 (included with .NET 7)
- Any HTTP client tool (e.g., [Postman](https://www.postman.com/), [curl](https://curl.se/))

---

## Setup Instructions

1. Clone or download the project to your local machine.

2. Open a terminal or command prompt in the project root folder (where the `.csproj` file resides).

3. Restore dependencies and build the project:

   ```bash
   dotnet restore
   dotnet build
