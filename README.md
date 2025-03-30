# 🎟️ Evently – Modular Monolith Event Management System

**Evently** is a scalable, modular monolith application built with ASP.NET Core that manages events, ticketing, attendance tracking, and user management. The system follows **Domain-Driven Design (DDD)**, **Onion Architecture**, and integrates **asynchronous messaging** to promote clean boundaries and modularity.

---

![Screenshot 2025-03-18 195310](https://github.com/user-attachments/assets/857e1bac-2bbc-470f-922b-913f80e25258)

---


## 📐 Architecture

Evently is structured into independent feature modules:

- **Events Module**: Create and manage event listings and categories.
- **Ticketing Module**: Handle ticket types, orders, payments, discounts, and refunds.
- **Attendance Module**: Track event attendees and attendance stats.
- **Users Module**: Manage user roles, permissions, and identity integration.

Each module owns its **domain**, **data**, and **API surface**, and communicates via:

- **Internal Contracts** for synchronous calls.
- **Message Broker** (e.g. RabbitMQ) for asynchronous communication.

---

## 🧰 Tech Stack

| Layer           | Tech / Tool                            |
|----------------|----------------------------------------|
| Backend         | ASP.NET Core, .NET 8                   |
| Database        | PostgreSQL                             |
| Caching         | Redis                                  |
| Messaging       | RabbitMQ , Mass Transit         |
| Identity        | External Identity Provider (Keycloak) |
| Logging         | Serilog + Seq                          |
| DevOps          | Docker, Docker Compose                 |

---

## 🗃️ Database Design

Each module owns its own schema. Examples:

### Events Module  
- `events`, `ticket_types`, `categories`, `images`

### Ticketing Module  
- `orders`, `order_items`, `discount_codes`, `payments`, `refunds`, `tickets`

### Attendance Module  
- `attendees`, `event_stats`, `attendance tickets`

### Users Module  
- `users`, `roles`, `permissions`

---

## 🚀 Getting Started

### 1. Clone the repository
```bash
git clone https://github.com/Eng-Eslamayman/Evently.git
cd Evently
