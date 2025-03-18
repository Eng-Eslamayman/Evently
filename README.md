# Evently

## Overview
Evently is a modular monolith project designed to manage event-related operations, including ticketing, attendance tracking, and user authentication. It is structured into different modules that handle event creation, ticket sales, user roles, and event attendance.

![image](https://github.com/user-attachments/assets/f533af85-8c54-4215-b310-8d1946a1f096)

## Agenda

### 00 - Introduction
- Overview of the project, objectives, and expectations.

### 01 - Modular Monoliths: Introduction
- Explanation of modular monolith architecture and how it differs from other approaches.

### 02 - Defining Module Boundaries
- Tools and techniques for identifying clear module boundaries.

### 03 - Module Cross-Cutting Concerns
- Handling concerns like logging, security, and shared services across modules.

### 04 - Module Communication
- Understanding synchronous and asynchronous communication in a modular system.

### 05 - Authentication & Authorization
- Implementation of external identity providers, token-based authentication, and Role-Based Access Control (RBAC).

## Architecture Overview
Evently is divided into three main modules:

### 1. **Events Module**
   - Manages event creation and categorization.
   - Supports ticket types and image storage.

### 2. **Ticketing Module**
   - Handles ticket purchases, orders, and payment processing.
   - Manages discount codes, refunds, and customer interactions.

### 3. **Attendance Module**
   - Tracks event attendees and ticket validation.
   - Monitors event statistics.

## Installation & Setup
To set up the project, follow these steps:

1. **Clone the repository:**
   ```bash
   git clone https://github.com/yourusername/evently.git
   cd evently
