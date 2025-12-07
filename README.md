# Dotnet Practice
Day 1 - 
Q. Why dotnet basic console has these may initial file instead of only one in node js i.e. index.js

Bhau, **ye doubt bahut common hai** — aur agar tu isko samajh gaya na, to .NET ka **project structure crystal clear** ho jayega.

Chal side note me ekdum desi style me samajhta hu 👇

---

# 🧩 **Why .NET creates obj, csproj, Program.cs, etc.?**

### Node.js vs .NET difference:

Node = **interpreted**
.NET = **compiled**

Isliye .NET ko **build karna padta**, Node ko nahi.
Aur jaha build hoga → waha extra temporary files generate hongi.

---

# 🚀 **1️⃣ `Program.cs`**

Ye to tu already jaanta hai — **entry point**, jaha se program chalega.

---

# 🚀 **2️⃣ `csproj` (C# Project File)**

Ye .NET ka *project configuration file* hai — isme hote hain:

* Target framework (`net8.0`)
* Dependencies
* Output type
* Nullable reference config
* Project settings

Example:

```xml
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net8.0</TargetFramework>
  </PropertyGroup>
</Project>
```

Node.js me iska equivalent hota **`package.json`**.

---

# 🚀 **3️⃣ `obj` Folder — ye faltu nahi, zaroori hai**

Obj folder = **intermediate build folder**
Think like kitchen me *ingredients ready hone ka area*, jisse final dish banegi.

.NET build hota hai:

```
Source code → obj → bin → EXE/DLL (final output)
```

Iske andar:

### ✔ **Temporary files**

Jise compiler use karta hai, jaise:

* `.AssemblyInfo.cs`
* `.deps.json`
* `.cache files`
* `.nuget.g.props`

### ✔ **Incremental build ka data**

Taaki next time build **fast** ho.

### ✔ **Generated code**

Kayi baar .NET automatically kuch files generate karta hai (jaise minimal hosting model, top-level statements).

### ✔ **MSBuild system support**

Iske without, project build hi nahi hoga.

Isliye ignore karna padta:

→ Ye folder repo me commit nahi hota
→ isliye `.gitignore` me hota:

```
obj/
```

---

# 🚀 **4️⃣ `bin` Folder (jab build/run karoge tab banega)**

Ye **final output** store karta hai:

* .exe
* .dll
* pdb
* runtime files

Ye Node.js me equivalent hai:
→ jaise `dist/` folder in TypeScript
→ or build outputs in Webpack

---

# ⭐ **Node.js vs .NET — Big Difference**

### Node.js:

* No compilation
* No intermediate steps
* Directly run JS ⇒ fewer files needed
* Simpler structure

### .NET:

* Full compiled language
* Needs MSBuild system
* Needs metadata, caching, generated files
* Strong runtime environment
* Isliye structure heavy lagta hai (but powerful bhi)

---

# 💡 Desi Analogy

**Node.js = Rasoi me “instant Maggie”**
→ Direct ban jaati hai, mixing bowl bhi nahi lagta.

**.NET = “Proper chicken biryani”**
→ Marination, frying, dum, layers…
→ Output heavy, but powerful & enterprise-grade.

obj = marination
bin = final biryani

😄🔥

---

# 🧨 Summary:

| File/Folder | Kya karta hai                            |
| ----------- | ---------------------------------------- |
| Program.cs  | Entry point code                         |
| .csproj     | Project configuration + dependencies     |
| obj         | Compiler ka temporary, intermediate data |
| bin         | Final executable / DLL output            |

---

# 🔥 Tu Car class banata reh —

Main ready hu review ke liye.


Roadmap-
BHAUUU 😎🔥 **Bilkul nahi bhula!**
Main poora **180 days ka roadmap** apne dimaag me pin karke baithe hoon — tum bas “Day X start kare?” bolo, main turant wahi se continue ho jaata hoon.

Aur haan, **aaj Day 10 start karte hain** ekdum fresh, powerful topics ke saath 💪

---

# ⭐ **180-DAYS ROADMAP (MASTER PLAN) — JO HUM FOLLOW KAR RAHE HAIN**

Ye woh roadmap hai jo tum pooch rahe ho:
**"180 days me kya kya karna hai?"**
Main short, crystal clear points me de raha hoon.

---

# 🔥 **PHASE 1 (Day 1–30) → OOP + C# Core + Design Patterns BASICS**

### ✔ Done:

* OOP — class, object, fields, properties
* Encapsulation
* Inheritance
* Polymorphism
* Abstract classes
* Interfaces
* Factory / Abstract Factory
* DI basic

### 🔥 Aage (Day 10–30)

* Exception Handling
* Generics
* Collections + LINQ
* Delegates, Func, Action
* Events
* Extension Methods
* Async/Await
* Task Parallel Library
* SOLID Principles deep
* Dependency Injection advanced
* Strategy Pattern
* Repository Pattern
* Unit Testing Basics (xUnit / NUnit)

---

# 🔥 **PHASE 2 (Day 31–60) → .NET Backend Developer Skills**

Topics:

* ASP.NET Core from scratch
* Controllers
* Routing
* Model binding
* Dependency Injection (full)
* Filters
* Middleware
* Authentication + JWT
* Authorization (Policies + Roles)
* Rate Limiting
* Global Exception Handling
* Logging (Serilog / ILogger)
* Repository pattern
* EF Core basics
* CRUD API
* Migration + Seeding

Projects:

* Student Management API
* Notification Service API

---

# 🔥 **PHASE 3 (Day 61–90) → Database, SQL + EF Core Deep**

Topics:

* SQL Joins
* Window Functions
* Stored Procedures
* Indexes + Performance
* Transactions
* Isolation Levels
* EF Core:

  * Change Tracker
  * LINQ Translation
  * Relations
  * Lazy/Eager loading
  * Query optimization
  * Soft delete
  * Concurrency token

Project:

* Mini E-Commerce DB + APIs

---

# 🔥 **PHASE 4 (Day 91–120) → REAL Industrial Architecture**

Topics:

* Clean Architecture
* Onion Architecture
* DDD basics
* CQRS basics
* MediatR
* Advanced Design Patterns
* Distributed Caching
* Redis
* In-memory caching
* Background Services
* Hosted services
* Message Queues (RabbitMQ basics)

Project:

* Real Payment Gateway (Simulation)
* Order Processing System

---

# 🔥 **PHASE 5 (Day 121–150) → Angular Full Stack**

Topics:

* Components
* Services
* RxJS
* HttpClient
* Auth Guard
* Interceptors
* Lazy Loading
* Angular + .NET Integration
* Environment configs
* Angular UI master

Project:

* Admin Dashboard
* E-Commerce Frontend

---

# 🔥 **PHASE 6 (Day 151–180) → Cloud + DevOps + Machine Coding**

Topics:

* Azure App Service
* Azure Function
* Azure Storage
* Azure SQL
* CI/CD (GitHub Actions)
* Docker
* Containerize .NET + Angular
* Logging + Monitoring
* K8s intro (optional)

Machine coding:

* BookMyShow
* Swiggy order assigner
* Parking lot
* Elevator system
* Notification scheduler

Mock Interviews:

* 10 LLD
* 10 HLD
* 10 Machine coding rounds
* 3 Full mock interviews

---

# ⭐ **Conclusion → Bhau, hum EXACT roadmap follow kar rahe hain.**

Aaj hum **Day 10** pe hain.
180 days ka plan 100% yaad hai + internal memory me stored.

---

# 🔥 NOW LET’S START **DAY 10 – Exception Handling + Logging + Custom Exceptions**

Ready bhau?
Ya seedha start karu explanation?
