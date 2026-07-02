# LeaveManagement.Backend

[![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?style=flat-square&logo=dotnet)](https://dotnet.microsoft.com/)
[![License](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE)

A robust backend service for efficient leave (vacation) management, built with modern software architecture principles.

## 📋 Overview

LeaveManagement.Backend is the server-side component of the LeaveManagement system. It provides a comprehensive solution for organizations to manage employee vacation requests, approvals, and tracking. The project serves as an excellent reference implementation of enterprise-level software architecture patterns.

## ✨ Features

- **Employee Management**: Maintain comprehensive employee profiles and records
- **Vacation Requests**: Create, update, and track leave requests
- **Approval Workflow**: Multi-level approval process for vacation requests
- **Leave Period Transfers**: Transfer and manage leave periods between employees
- **Documentation**: Store and manage vacation-related documents
- **Reporting**: Generate leave balances and history reports

## 🛠 Technology Stack

- **Framework**: ASP.NET Core (.NET 10.0)
- **Architecture**: Domain-Driven Design (DDD) with Clean Architecture
- **ORM**: Entity Framework Core
- **Messaging**: Apache Kafka
- **Containerization**: Docker & Docker Compose
- **Database**: SQL Server
- **Authentication**: JWT Bearer Tokens

## 🏗 Architecture

The project follows Clean Architecture principles with Domain-Driven Design patterns, ensuring:
- Separation of concerns
- Domain-centric business logic
- Testability and maintainability
- Independence from external frameworks

### Project Structure

src/
├── LeaveManagement.Domain/ # Enterprise business rules
├── LeaveManagement.Application/ # Application business rules
├── LeaveManagement.Infrastructure/# External concerns (DB, messaging)
└── LeaveManagement.API/ # Web API controllers and middleware

## 🚀 Getting Started

### Prerequisites

- [.NET 10.0 SDK](https://dotnet.microsoft.com/download)
- [Docker](https://www.docker.com/products/docker-desktop)
- [Docker Compose](https://docs.docker.com/compose/install/)

### Installation

1. Clone the repository:
```bash
  git clone https://github.com/AndreyPinchukDeveloper/LeaveManagement.Backend.git
  cd LeaveManagement.Backend
```
2. Start the infrastructure services:
```bash
  docker-compose up -d
```
3. Run database migrations:
```bash
  dotnet ef database update --project src/LeaveManagement.Infrastructure
```
4. Run the application:
```bash
  dotnet run --project src/LeaveManagement.API
```

Contributions are welcome! Please feel free to submit a Pull Request.



