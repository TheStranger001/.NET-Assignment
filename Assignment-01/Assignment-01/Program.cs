using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question7 q = new Question7();
            q.fun();
        }
    }
    class Question1
    {
        public void fun()
        {
            // Q1.Write a C# program to calculate the total price of items in a shopping cart. The cart contains 5 items with different prices. Include a 10% discount if the total price exceeds Rs. 3000.
            int[] shoppingCart = { 1000, 2000, 3000, 4000, 5000 };
            double totalPrice = 0;
            for (int i = 0; i < shoppingCart.Length; i++)
            {
                if (shoppingCart[i] > 3000)
                {
                    totalPrice += (shoppingCart[i] * 0.1);
                }
                else
                {
                    totalPrice += shoppingCart[i];
                }
            }
            Console.WriteLine(totalPrice);
        }
    }
    class Question2
    {
        public void fun()
        {
            // Q2.Develop a C# application that allows the user to input a temperature in Celsius and convert it to Fahrenheit. If the input temperature is below 0°C, display a warning message about freezing temperatures.
            Console.Write("Enter temperature in Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit}°F");
            if (celsius < 0)
            {
                Console.WriteLine("Warning: The temperature is below freezing point!");
            }
        }
    }
    class Question3
    {
        public void fun()
        {
            // Q3.Create a C# program that simulates a simple ATM. It should allow users to check their balance, deposit money, and withdraw money. Ensure that the program checks for sufficient funds before allowing a withdrawal.
            double balance = 1000.00;
            while (true)
            {
                Console.WriteLine("Simple ATM Menu");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Exit");
                Console.Write("Select an option (1-4): ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"Your current balance is: ${balance}");
                        break;
                    case 2:
                        Console.Write("Enter the amount to deposit: $");
                        double depositAmount = Convert.ToDouble(Console.ReadLine());
                        if (depositAmount > 0)
                        {
                            balance += depositAmount;
                            Console.WriteLine($"Deposited ${depositAmount}. New balance: ${balance}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid deposit amount.");
                        }
                        break;
                    case 3:
                        Console.Write("Enter the amount to withdraw: $");
                        double withdrawAmount = Convert.ToDouble(Console.ReadLine());
                        if (withdrawAmount > 0)
                        {
                            if (withdrawAmount <= balance)
                            {
                                balance -= withdrawAmount;
                                Console.WriteLine($"Withdrew ${withdrawAmount}. New balance: ${balance}");
                            }
                            else
                            {
                                Console.WriteLine("Insufficient funds. Withdrawal denied.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid withdrawal amount.");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Exiting ATM. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please select 1-4.");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
    class Question4
    {
        public void fun()
        {
            int[] marks = new int[5];
            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write($"Enter the marks for subject {i + 1}: ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
            double average = CalculateAverage(marks);
            char grade = DetermineGrade(average);
            Console.WriteLine($"\nYour average marks are: {average}");
            Console.WriteLine($"Your grade is: {grade}");
        }
        static double CalculateAverage(int[] marks)
        {
            int total = 0;
            foreach (int mark in marks)
            {
                total += mark;
            }
            return (double)total / marks.Length;
        }
        static char DetermineGrade(double average)
        {
            if (average >= 90)
            {
                return 'A';
            }
            else if (average >= 80)
            {
                return 'B';
            }
            else if (average >= 70)
            {
                return 'C';
            }
            else if (average >= 60)
            {
                return 'D';
            }
            else
            {
                return 'F';
            }
        }
    }
    class Question5
    {
        public void fun()
        {
            Console.Write("Enter a password: ");
            string password = Console.ReadLine();
            if (ValidatePassword(password))
            {
                Console.WriteLine("Password is valid.");
            }
            else
            {
                Console.WriteLine("Password is invalid. It must be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, and one number.");
            }
            Console.ReadLine(); // To prevent the console application from closing immediately after running
        }
        static bool ValidatePassword(string password)
        {
            if (password.Length < 8)
                return false;
            if (!password.Any(char.IsUpper))
                return false;
            if (!password.Any(char.IsLower))
                return false;
            if (!password.Any(char.IsDigit))
                return false;
            return true;
        }
    }
    class Question6
    {
        public void fun()
        {
            Console.Write("Enter the distance traveled (in kilometers): ");
            double distance = Convert.ToDouble(Console.ReadLine());
            Console.Write("Did the ride occur after 10 PM? (yes/no): ");
            string nightRide = Console.ReadLine().ToLower();
            double fare = CalculateFare(distance, nightRide == "yes");
            Console.WriteLine($"The total fare for the ride is: Rs. {fare}");
            Console.ReadLine(); // Prevents the console from closing immediately
        }
        static double CalculateFare(double distance, bool isNightRide)
        {
            double baseFare = 20.0; // Flat rate for the first 2 kilometers
            double additionalFareRate = 10.0; // Per kilometer rate after the first 2 kilometers
            double nightSurchargeRate = 1.5; // 50% surcharge for night rides
            double fare = baseFare;
            if (distance > 2)
            {
                fare += (distance - 2) * additionalFareRate;
            }
            if (isNightRide)
            {
                fare *= nightSurchargeRate;
            }
            return fare;
        }
    }
    class Question7
    {
        public void fun()
        {
            bool[] attendance = new bool[5];
            for (int i = 0; i < attendance.Length; i++)
            {
                Console.Write($"Was the student present on day {i + 1}? (yes/no): ");
                string input = Console.ReadLine().ToLower();
                attendance[i] = input == "yes";
            }
            int totalDaysAttended = CalculateAttendance(attendance);
            bool hasPerfectAttendance = totalDaysAttended == attendance.Length;
            Console.WriteLine($"\nTotal days attended: {totalDaysAttended}");
            Console.WriteLine(hasPerfectAttendance ? "The student has perfect attendance." : "The student does not have perfect attendance.");
            Console.ReadLine(); // Prevents the console from closing immediately
        }
        static int CalculateAttendance(bool[] attendance)
        {
            int totalDays = 0;
            foreach (bool attended in attendance)
            {
                if (attended)
                {
                    totalDays++;
                }
            }
            return totalDays;
        }
    }

    class Question8
    {
        public void fun()
        {
            // Q8. An individual tracks their expenses for each month in a year. 
            // Calculate the total expenses for the year and identify the month with the highest and lowest expenses.

            double[] monthlyExpenses = new double[12];
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            // Input monthly expenses
            for (int i = 0; i < monthlyExpenses.Length; i++)
            {
                Console.Write($"Enter expenses for {months[i]}: ");
                monthlyExpenses[i] = Convert.ToDouble(Console.ReadLine());
            }

            // Calculate total expenses
            double totalExpenses = 0;
            foreach (double expense in monthlyExpenses)
            {
                totalExpenses += expense;
            }

            // Find month with highest and lowest expenses
            double maxExpense = monthlyExpenses[0];
            double minExpense = monthlyExpenses[0];
            int maxExpenseMonth = 0;
            int minExpenseMonth = 0;

            for (int i = 1; i < monthlyExpenses.Length; i++)
            {
                if (monthlyExpenses[i] > maxExpense)
                {
                    maxExpense = monthlyExpenses[i];
                    maxExpenseMonth = i;
                }

                if (monthlyExpenses[i] < minExpense)
                {
                    minExpense = monthlyExpenses[i];
                    minExpenseMonth = i;
                }
            }

            // Display results
            Console.WriteLine($"\nTotal expenses for the year: Rs. {totalExpenses}");
            Console.WriteLine($"Highest expenses were in {months[maxExpenseMonth]}: Rs. {maxExpense}");
            Console.WriteLine($"Lowest expenses were in {months[minExpenseMonth]}: Rs. {minExpense}");

            Console.ReadLine(); // Prevents the console from closing immediately
        }
    }


    // Question 9 Implement a shopping cart system where a user can add items, remove items, and view the total price. Assume each item has a name and a price
    class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Item(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }

    class ShoppingCart
    {
        private List<Item> items;

        public ShoppingCart()
        {
            items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            items.Add(item);
            Console.WriteLine($"{item.Name} added to the cart.");
        }

        public void RemoveItem(string itemName)
        {
            Item itemToRemove = items.Find(item => item.Name.Equals(itemName, StringComparison.OrdinalIgnoreCase));
            if (itemToRemove != null)
            {
                items.Remove(itemToRemove);
                Console.WriteLine($"{itemToRemove.Name} removed from the cart.");
            }
            else
            {
                Console.WriteLine($"{itemName} not found in the cart.");
            }
        }

        public void ViewCart()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("Your cart is empty.");
                return;
            }

            Console.WriteLine("\nItems in your cart:");
            foreach (Item item in items)
            {
                Console.WriteLine($"{item.Name}: Rs. {item.Price}");
            }

            double totalPrice = CalculateTotalPrice();
            Console.WriteLine($"\nTotal price: Rs. {totalPrice}");
        }

        private double CalculateTotalPrice()
        {
            double total = 0;
            foreach (Item item in items)
            {
                total += item.Price;
            }
            return total;
        }
    }

    class Question9
    {
        public void fun()
        {
            ShoppingCart cart = new ShoppingCart();

            while (true)
            {
                Console.WriteLine("\nShopping Cart Menu:");
                Console.WriteLine("1. Add Item");
                Console.WriteLine("2. Remove Item");
                Console.WriteLine("3. View Cart");
                Console.WriteLine("4. Exit");
                Console.Write("Select an option (1-4): ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the item name: ");
                        string itemName = Console.ReadLine();
                        Console.Write("Enter the item price: ");
                        double itemPrice = Convert.ToDouble(Console.ReadLine());
                        cart.AddItem(new Item(itemName, itemPrice));
                        break;

                    case 2:
                        Console.Write("Enter the name of the item to remove: ");
                        string removeItemName = Console.ReadLine();
                        cart.RemoveItem(removeItemName);
                        break;

                    case 3:
                        cart.ViewCart();
                        break;

                    case 4:
                        Console.WriteLine("Exiting the shopping cart. Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid option. Please select 1-4.");
                        break;
                }
            }
        }
    }

    // 10.Create a program that calculates the monthly salary of an employee based on their hourly wage and the number of hours worked in a week. Consider that there are 4 weeks in a month.
    class Question10
    {
        public void fun()
        {
            Console.Write("Enter the hourly wage: Rs. ");
            double hourlyWage = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the number of hours worked in a week: ");
            double hoursWorkedPerWeek = Convert.ToDouble(Console.ReadLine());

            double monthlySalary = CalculateMonthlySalary(hourlyWage, hoursWorkedPerWeek);

            Console.WriteLine($"\nThe monthly salary is: Rs. {monthlySalary}");
        }

        static double CalculateMonthlySalary(double hourlyWage, double hoursWorkedPerWeek)
        {
            const int weeksInMonth = 4;
            double weeklySalary = hourlyWage * hoursWorkedPerWeek;
            return weeklySalary * weeksInMonth;
        }
    }
}