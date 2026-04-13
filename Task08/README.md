# 8. Generic Repository Pattern in C#

## 📌 Overview

This project demonstrates how to implement a **Generic Repository Pattern** in C# using:

* Generics (`T`)
* Interfaces (`IRepository<T>`)
* In-memory data storage

It provides a reusable and scalable way to perform **CRUD (Create, Read, Update, Delete)** operations on different entities like `Student`, `Product`, etc.

---

## 🎯 Objective

* Understand **Generics** for reusable code
* Learn **Interfaces** for abstraction and contracts
* Implement a **Repository Pattern** for clean data handling
* Build a simple **console-based demonstration**

---

## 🧠 Concepts Covered

### 🔹 Generics (`T`)

Allows writing flexible code that works with any data type.

```csharp
public class Repository<T>
```

---

### 🔹 Interfaces

Defines a contract that classes must implement.

```csharp
public interface IRepository<T>
{
    void Add(T item);
    List<T> GetAll();
    T GetById(int id);
    void Update(T item);
    void Delete(int id);
}
```

---

### 🔹 Repository Pattern

A design pattern that abstracts data access logic.

---

## ⚙️ Implementation Details

### 1. Entity Interface

```csharp
public interface IEntity
{
    int Id { get; set; }
}
```

---

### 2. Sample Entity

```csharp
public class Student : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
}
```

---

### 3. Generic Repository

```csharp
public class Repository<T> : IRepository<T> where T : class, IEntity
{
    private List<T> items = new List<T>();

    public void Add(T item) => items.Add(item);

    public List<T> GetAll() => items;

    public T GetById(int id) => items.FirstOrDefault(x => x.Id == id);

    public void Update(T item)
    {
        var existing = GetById(item.Id);
        if (existing != null)
        {
            items.Remove(existing);
            items.Add(item);
        }
    }

    public void Delete(int id)
    {
        var item = GetById(id);
        if (item != null)
        {
            items.Remove(item);
        }
    }
}
```

---

### 4. Usage (Console App)

```csharp
IRepository<Student> repo = new Repository<Student>();

repo.Add(new Student { Id = 1, Name = "Sarvesh" });
repo.Add(new Student { Id = 2, Name = "Akash" });

var students = repo.GetAll();

foreach (var s in students)
{
    Console.WriteLine($"{s.Id} - {s.Name}");
}
```

---

## 🔁 Execution Flow

```text
Create Repository<T>
      ↓
Add Items
      ↓
Retrieve Data
      ↓
Update / Delete
      ↓
Display Output
```

---

## 📤 Sample Output

```text
1 - Sarvesh
2 - Akash
```

---

## 💡 Why Use This Pattern?

### ✅ Reusability

One repository works for multiple entities:

```csharp
Repository<Student>
Repository<Product>
```

---

### ✅ Decoupling

Code depends on interface, not implementation:

```csharp
IRepository<T>
```

---

### ✅ Scalability

Easily switch data source:

* In-memory → Database → API

---

### ✅ Testability

Allows mocking for unit testing.

---

## ⚠️ Notes

* This is an **in-memory implementation** (no database)
* Uses `List<T>` for storage
* Suitable for learning and small-scale applications

---

## 🧠 Key Takeaway

> Generics enable reusable logic, interfaces provide abstraction, and the repository pattern organizes data access cleanly.