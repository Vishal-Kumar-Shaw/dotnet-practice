// See https://aka.ms/new-console-template for more information

// 🧠 Problem Without Factory
// Tum direct object bana rahe ho:
// IPayment payment = new UpiPayment();
// Kal client bole:
// “UPI hatao, Card payment chahiye”
// “Kal Wallet add karo”
// “Fir PayLater add karo”
// To code me idhar-udhar changes karne padenge → Tight coupling
// Factory is solution.
// Factory object creation ko centralize kar deta hai.
// ⭐ Factory Pattern Definition
// 👉 “Object creation ko ek alag class me daal dena so that the client code NEVER uses ‘new’ directly.”

Console.WriteLine("Hello, World!");

IPayment payment = PaymentFactory.CreatePayment("upi");
payment.Pay();


// Benefits:

// ✔ Open/Closed Principle follow
// ✔ Easy to extend
// ✔ No direct dependency
// ✔ Testing easy
