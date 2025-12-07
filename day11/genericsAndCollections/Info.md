Bhau 😄❤️
Bilkul sahi bola — **TASK ka code main nahi likhunga**,
**par THEORY samjhane ke liye code zaroor likhunga**, warna concept clear kaise hoga.

Samajh gaya 💯
Aage se structure ye hoga:

### ✔ Theory explain → **full clean code examples** (taaki samajh aaye)

### ✔ Task → **sirf guidance, steps, structure**, code **TU likhega**

Perfect?

Chalo ab tumhari baat follow karte hue **Generics ka T** theory code ke saath dubara ultra-clear format me deta hoon 👇🔥

---

# ⭐ **T = Type ka Placeholder (Generics Concept)**

Ye code **THEORY EXPLANATION** ke liye hai (this is allowed).

---

# ⭐ **1️⃣ Generic Class Example (Understanding T)**

```csharp
public class Box<T>
{
    public T Value { get; set; }
}
```

Use:

```csharp
Box<int> intBox = new Box<int>();
intBox.Value = 100;

Box<string> strBox = new Box<string>();
strBox.Value = "Vishal";

Box<Employee> empBox = new Box<Employee>();
empBox.Value = new Employee { Id = 1, Name = "Shaw" };
```

👉 Is code ka meaning:
**Ek hi Box class → alag-alag type hold kar sakti hai.**

---

# ⭐ **2️⃣ Generic Method Example**

```csharp
public T GetFirstItem<T>(List<T> items)
{
    return items[0];
}
```

Use:

```csharp
int firstNum = GetFirstItem<int>(new List<int>{ 1, 2, 3 });
string firstName = GetFirstItem<string>(new List<string>{ "A", "B" });
```

**Ek hi method, multiple types handle kar raha hai.**

---

# ⭐ **3️⃣ Generic Repository Example (Industry Standard)**

```csharp
public class Repository<T>
{
    private List<T> _items = new List<T>();

    public void Add(T item)
    {
        _items.Add(item);
    }

    public IEnumerable<T> GetAll()
    {
        return _items;
    }
}
```

Use:

```csharp
var empRepo = new Repository<Employee>();
empRepo.Add(new Employee { Id = 1, Name = "Vishal" });

var productRepo = new Repository<Product>();
productRepo.Add(new Product { Id = 101, Name = "Laptop" });
```

👉 Ye INDUSTRY me sabse zyada use hota hai.
**T ensures type safety + reusability.**

---

# ⭐ **4️⃣ T is not a keyword**

Tum aise bhi likh sakte ho:

```csharp
public class Box<X>
{
    public X Value { get; set; }
}
```

But conventionally sab **T** likhte hain.

---

# ⭐ **5️⃣ Generic Constraints Example (Advanced)**

```csharp
public class Repository<T> where T : class
{
    public void Add(T item)
    {
        // only reference types allowed
    }
}
```

Another:

```csharp
public class Factory<T> where T : new()
{
    public T Create()
    {
        return new T(); // works only if T has a public parameterless constructor
    }
}
```

---

# ⭐ Ab Tera Day 11 Task (NO CODE FROM MY SIDE)

👉 Sirf **guide lines**, code **TU likhna**.

## **Task: Create a Generic Response<T> class**

### Properties:

* `bool Success`
* `string Message`
* `T Data`

### Usage:

```
Response<int>
Response<string>
Response<Employee>
```

### Steps (Guide Only):

1. Ek public generic class banao: `Response<T>`
2. Usme 3 properties add karo
3. Constructor optional (agar banana ho)
4. Main me:

   * Response<int> ka object banao
   * Response<string> ka object banao
   * Response<Employee> ka object banao

**Bas itna. Code tu likh ke bhejna.**

---

# Bhau, ab bata:

Day 11 ka concept + theory clear ho gaya?
Agar yes, to tu apna Response<T> ka code likh ke bhej — main review karu.
