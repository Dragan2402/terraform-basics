# 🌐 Terraform Infrastructure – Upskilling Assignment

This repository contains my solution for a team upskilling session focused on **Terraform** and **multi-cloud infrastructure management**. The project demonstrates how to provision and deploy a simple full-stack application using Terraform on both **AWS** and **Azure**.

---

## 🧩 Project Overview

- **Client:** A [SvelteKit](https://kit.svelte.dev/) application for recording and displaying temperature readings.
- **API:** A [.NET](https://dotnet.microsoft.com/) backend service that handles client requests and persists data.
- **Database:** A managed **PostgreSQL** database instance.
- **Infrastructure:** Provisioned entirely using **Terraform**, with cloud-agnostic support for AWS and Azure.

---

## 🎯 Objectives

- Showcase core Terraform concepts and practices
- Build infrastructure that is cloud-provider agnostic
- Explore how Terraform enables portability, repeatability, and scalability
- Serve as a foundation for discussion in a live upskilling session

---

## 🔑 Terraform Concepts Demonstrated

- Providers (AWS, Azure)
- Resources (compute, database, networking)
- Input variables & outputs
- Modules for clean and reusable infrastructure
- Workspaces and environment separation
- Multi-cloud compatibility

---

## 📁 Structure

> The specific folder and file structure is left open to allow for personal interpretation and implementation.

You are encouraged to:

- Organize infrastructure code clearly
- Parameterize cloud-specific values
- Use modules where applicable

---

## 🧠 Learning Goals

This project supports an interactive learning session where developers will:

- Compare different implementation approaches
- Share learnings and pain points
- Deepen their understanding of Terraform workflows
- Discuss real-world scenarios of IaC in a team environment

---

## 🚀 Project Startup

Follow the steps below to get both the API and client running locally in your development environment.

### 🛠️ .NET API

#### 🔧 Configuration

1. Create a file named `appsettings.Development.json` in the API project root (if not already present).
2. Add your PostgreSQL connection string:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Port=5432;Database=your_db;Username=your_user;Password=your_password"
  }
}
```
