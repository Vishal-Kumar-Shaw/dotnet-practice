// See https://aka.ms/new-console-template for more information
// DAY 9 = Advanced Polymorphism + virtual / override / new / sealed / base (INTERVIEW MOST ASKED ROUND!)

// Aaj ka goal:
// Tum yeh topic itna solid pakdoge ki interviewer confuse ho jaaye ki 2 saal ka exp ya 5 saal ka exp 🤣

// ⭐ DAY 9 — PART 1: virtual / override (Deep)
// 🧠 virtual → Parent bolta:

// “Beta, tum is method ko change kar sakte ho.”

// public virtual void Speak() { Console.WriteLine("Animal speaks"); }

// 🧠 override → Child bolta:

// “Papa ka method main apne tareeke se likh raha hoon.”

// public override void Speak() { Console.WriteLine("Dog barks"); }


// 👉 This enables runtime polymorphism

// ⭐ DAY 9 — PART 2: new keyword (Method Hiding)

// Yeh sabse zyada students confuse hote hain.

// 🧠 “new” ka purpose?

// Parent method ko hide karna, override nahi karna.

// public new void Speak() { Console.WriteLine("Dog speaks differently"); }


// 💥 Important difference:

// override → runtime pe object ka method chalega
// new → compile time pe reference type decide karega

// Example:

// Animal a = new Dog();
// a.Speak();  // If override → Dog version
//             // If new → Animal version

// ⭐ DAY 9 — PART 3: sealed keyword

// sealed override →
// Child class ka method final.
// Grandchild override nahi kar sakta.

// Why useful?
// Companies use sealed for:

// Security-sensitive methods

// Performance optimization

// Prevent unexpected overriding

// Example:

// public sealed override void Speak() { ... }

// ⭐ DAY 9 — PART 4: base keyword

// Child class se parent method ko call karne ke liye.

// public override void Speak()
// {
//     base.Speak();   // parent method
//     Console.WriteLine("Dog barks");
// }

// ⭐ DAY 9 — PART 5: FULL POLYMORPHISM FLOW

// Example:

// Animal a = new Dog();  
// a.Speak();  


// Reference type = Animal

// Object type = Dog

// If override → Dog version

// If new → Animal version

// INTERVIEW KEY:
// Polymorphism always depends on OBJECT TYPE, not reference type.
Console.WriteLine("Hello, World!");

Employee e1 = new Manager();
Employee e2 = new Developer();
Employee e3 = new Intern();

e1.CalculateBonus();  // Manager bonus
e2.CalculateBonus();  // Developer bonus
e3.CalculateBonus();  // Intern bonus

Intern e4 = new Intern(); 
Employee e5 = new Intern();
e4.CalculateBonus(); // after new keyword in Intern -> Reference type method is called i.e. Intern's
e5.CalculateBonus(); // after new keyword in Intern -> Reference type method is called i.e. Employee's default one


