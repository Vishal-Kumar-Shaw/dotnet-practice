// See https://aka.ms/new-console-template for more information
// # ⭐ **DAY 10 — PART 1: Exception Handling BASICS (Interview + Real Use)**

// ## 🧠 Exception kya hota hai?

// Runtime error jo program ko crash kar sakta hai.

// Examples:

// * Divide by zero
// * Null reference
// * Index out of range
// * File not found
// * Network failure

// 🎯 **Goal**: Application should NOT crash → gracefully handle errors.

// ---

// # ⭐ **1️⃣ try–catch basic syntax**

// ```csharp
// try
// {
//     int result = 10 / 0;
// }
// catch(Exception ex)
// {
//     Console.WriteLine(ex.Message);
// }
// ```

// ---

// # ⭐ **2️⃣ Multiple catch blocks**

// ```csharp
// try
// {
//     int[] arr = new int[2];
//     Console.WriteLine(arr[5]);
// }
// catch(IndexOutOfRangeException ex)
// {
//     Console.WriteLine("Array index wrong!");
// }
// catch(Exception ex)
// {
//     Console.WriteLine("General error: " + ex.Message);
// }
// ```

// ---

// # ⭐ **3️⃣ finally block (ALWAYS executes)**

// ```csharp
// finally
// {
//     Console.WriteLine("Cleanup here...");
// }
// ```

// Use-case:

// * Close DB connection
// * Close file
// * Dispose resources

// ---

// # ⭐ **DAY 10 — PART 2: THROW keyword**

// ### Re-throw exception:

// ```csharp
// catch(Exception)
// {
//     throw;
// }
// ```

// ---

// # ⭐ **DAY 10 — PART 3: Custom Exceptions (Real Industry Feature)**

// Why custom exception?

// ✔ Better readability
// ✔ Business logic specific errors
// ✔ Logging clarity
// ✔ Clean API responses

// Example:

// ```csharp
// public class InsufficientBalanceException : Exception
// {
//     public InsufficientBalanceException(string message)
//         : base(message) {}
// }
// ```

// Use:

// ```csharp
// if(balance < amount)
//     throw new InsufficientBalanceException("Balance too low for withdrawal");
// ```

// ---

// # ⭐ **DAY 10 — PART 4: Exception + Logging (ILogger)**

// Every exception MUST be logged.

// Example using console logger:

// ```csharp
// catch(Exception ex)
// {
//     _logger.LogError(ex, "Error while processing payment");
// }
// ```

// Serilog example:

// ```csharp
// Log.Error(ex, "Something bad happened");
// ```

// ---

// # ⭐ **DAY 10 — PART 5: REAL PROJECT EXCEPTION LAYER**

// In ASP.NET Core projects:

// ### ✔ Global Exception Handler

// ### ✔ Middleware

// ### ✔ Logging pipeline

// ### ✔ Custom error response

// Example (simple):

// ```csharp
// app.UseExceptionHandler(errorApp =>
// {
//     errorApp.Run(async context =>
//     {
//         context.Response.StatusCode = 500;
//         await context.Response.WriteAsync("Something went wrong");
//     });
// });
// ```

// ---

// # ⭐ **DAY 10 — PART 6: Best Practices (COMPANY LEVEL)**

// 1️⃣ Don’t use empty catch

// ```csharp
// catch {}
// ```

// ❌ Completely bad

// 2️⃣ Always catch **specific exception first**, then general.

// 3️⃣ Never do:

// ```csharp
// catch(Exception ex)
// {
//     throw ex;  // loses stack trace ❌
// }
// ```

// Correct:

// ```csharp
// throw;  // preserves stack trace ✔
// ```

// 4️⃣ Don’t use try-catch everywhere. Only where needed.

// 5️⃣ Logging mandatory.

// ---

// # ⭐ **DAY 10 — PART 7: REAL TASK (PROFESSIONAL)**

// Build a **Bank Withdrawal System** with proper exception handling.

// ## ✔ Classes Required

// ### 1️⃣ Custom Exceptions:

// ```csharp
// public class InsufficientFundsException : Exception
// {
//     public InsufficientFundsException(string msg) : base(msg) {}
// }

// public class InvalidAmountException : Exception
// {
//     public InvalidAmountException(string msg) : base(msg) {}
// }
// ```

// ---

// ### 2️⃣ BankAccount class:

// Properties:

// * Name
// * Balance

// Method:

// ```csharp
// public void Withdraw(decimal amount)
// {
//     if(amount <= 0)
//         throw new InvalidAmountException("Amount must be positive");

//     if(amount > Balance)
//         throw new InsufficientFundsException("Balance not enough");

//     Balance -= amount;
//     Console.WriteLine($"Withdraw successful. New Balance = {Balance}");
// }
// ```

// ---

// ### 3️⃣ Main method:

// ```csharp
// BankAccount acc = new BankAccount("Vishal", 5000);

// try 
// {
//     acc.Withdraw(7000);   // will trigger custom exception
// }
// catch(InvalidAmountException ex)
// {
//     Console.WriteLine("Invalid amount: " + ex.Message);
// }
// catch(InsufficientFundsException ex)
// {
//     Console.WriteLine("Insufficient funds: " + ex.Message);
// }
// catch(Exception ex)
// {
//     Console.WriteLine("Unknown error: " + ex.Message);
// }
// finally
// {
//     Console.WriteLine("Transaction complete");
// }
// ```

// ---

// # ⭐ **DAY 10 SHORT QUESTIONS (Answer These After Task)**

// 1️⃣ throw vs throw ex difference?
// 2️⃣ Why custom exceptions?
// 3️⃣ What is finally used for?
// 4️⃣ Why should we avoid empty catch?
// 5️⃣ What is global exception handler?

// ---

// # 🔥 BHAU — AB TERA KAAM:

// ✔ BankAccount system ka full implementation likho
// ✔ try–catch–finally use karo
// ✔ Custom exceptions add karo
// ✔ Short questions ke answers do

// Main review karke senior-level version bana dunga.

// Chalu kare?

Console.WriteLine("Hello, World!");

BankAccount b1 = new BankAccount("Vishal", 5000);
try{
    b1.Withdraw(6000);
}
catch(InvalidAmountException ex)
{
    Console.WriteLine("Invalid Amount", ex);
}
catch(InsufficientFundsException ex)
{
    Console.WriteLine("Insufficient funds", ex);
}
catch(Exception ex)
{
    Console.WriteLine("Unknown error : "+ex);
}
finally
{
    Console.WriteLine("Transaction completed");
}


try{
    b1.Withdraw(-6000);
}
catch(InvalidAmountException ex)
{
    Console.WriteLine("Invalid Amount", ex);
}
catch(InsufficientFundsException ex)
{
    Console.WriteLine("Insufficient funds", ex);
}
catch(Exception ex)
{
    Console.WriteLine("Unknown error : "+ex);
}
finally
{
    Console.WriteLine("Transaction completed");
}
