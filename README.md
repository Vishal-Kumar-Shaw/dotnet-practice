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
