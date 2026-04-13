# 9. Reflection & Custom Attributes in C#

## 📌 Overview

This project demonstrates how to use **Reflection** and **Custom Attributes** in C# to dynamically discover and execute methods at runtime.

Instead of manually calling methods, the application automatically scans the assembly, identifies methods marked with a custom attribute, and executes them.

---

## 🎯 Objective

- Learn how to define and use **custom attributes**
- Understand how **reflection** works in C#
- Build a system that dynamically executes methods based on metadata

---

## 🧠 Concepts Covered

### 🔹 Custom Attributes

Custom attributes allow you to attach metadata to code elements such as methods.

Example:

```csharp
[Runnable]
public void Task1() { }
```

---

### 🔹 Reflection

Reflection enables inspection of:

- Classes
- Methods
- Attributes

at runtime.

---

### 🔹 Dynamic Invocation

Methods are executed dynamically using:

```csharp
method.Invoke(instance, null);
```

---

## ⚙️ How It Works

1. Define a custom attribute:

   ```csharp
   class RunnableAttribute : Attribute { }
   ```

2. Decorate methods:

   ```csharp
   [Runnable]
   public void Task1() { }
   ```

3. Use reflection to:
   - Scan all classes
   - Find methods with `[Runnable]`
   - Create instances dynamically
   - Invoke methods

---

## 🔁 Execution Flow

```
Scan Assembly
   ↓
Find Classes
   ↓
Find Methods
   ↓
Filter [Runnable]
   ↓
Create Instance
   ↓
Invoke Method
```

---

## 📤 Sample Output

```
Running: Task1
Task1 executed
Running: Task2
Task2 executed
```

---

## 💡 Use Cases

- 🧪 Test frameworks (like NUnit / xUnit)
- 🌐 Web frameworks (routing via attributes)
- 🔌 Plugin systems
- 🛠️ Automation tools

---

## ⚠️ Notes

- Reflection is slower than direct method calls
- Requires parameterless constructors for dynamic instantiation
- May produce warnings when using .NET trimming (safe for learning)

---

## 🧠 Key Takeaway

> Custom attributes mark methods, and reflection dynamically discovers and executes them, enabling flexible and extensible systems.

---
