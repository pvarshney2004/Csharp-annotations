# Csharp-annotations
This repository is dedicated to understanding and practicing **C# annotations (attributes)**.  
It focuses on how attributes are defined, applied, and accessed using **Reflection**, starting from basic built-in attributes to advanced custom attribute–based designs.

---

## 🌿 Branch: annotations

This branch covers:
- Built-in attributes like `override` and `Obsolete`
- Creating **custom attributes**
- Applying attributes at **method, field, and class level**
- Using **Reflection** to read attribute metadata
- Real-world use cases such as validation, logging, and access control

---

## 📝 Exercises & Practice Problems

### 🔹 Core Exercises

- Use method overriding correctly by creating a parent `Animal` class with a `MakeSound()` method and overriding it in a `Dog` class using `override`.
- Use the `Obsolete` attribute to mark an old method in a `LegacyAPI` class and introduce a new replacement method.
- Create a custom attribute `TaskInfo` with fields like priority and assigned person, apply it to a method, and retrieve its values using Reflection.
- Create and use a repeatable attribute `BugReport` that can be applied multiple times to the same method and retrieve all applied instances.

---

### 🔹 Beginner-Level Custom Attribute Problems

- Create an attribute `ImportantMethod` to mark important methods with an optional importance level and retrieve annotated methods using Reflection.
- Create a `Todo` attribute to mark pending tasks with task description, assigned developer, and priority, and list all pending tasks using Reflection.

---

### 🔹 Intermediate-Level Problems

- Create a `LogExecutionTime` attribute to measure and display the execution time of methods using `Stopwatch`.
- Create a `MaxLength` attribute to enforce maximum length validation on string fields and throw an exception when the constraint is violated.

---

### 🔹 Advanced-Level Problems

- Implement role-based access control using a `RoleAllowed` attribute to restrict method execution based on user roles and deny access for unauthorized roles.

---

## 🎯 Learning Outcomes

- Deep understanding of **C# attributes and annotations**
- Hands-on experience with **Reflection**
- Designing **custom metadata-driven logic**
- Applying attributes for validation, logging, and security
- Writing cleaner and more maintainable C# code

---

## 👤 Author
**Prashant Varshney**  
B.Tech CSE (Data Analytics)  
