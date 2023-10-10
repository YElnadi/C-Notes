// declare new array of strings that can hold three elements 
/*string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
//fraudulentOrderIDs[3] = "D000"; */

/* string[] fraudulentOrderIDs = { "A123", "B456", "C789"};

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";
Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process. "); */

// Looping using foreach

// string[] names = {"Rowena", "Robin", "Bao" };

// foreach(string name in names){
//     Console.WriteLine(name);
// }

// int[] inventory = {200, 450, 700, 175, 250};
// int sum = 0;
// int bin = 0;
// foreach(int items in inventory){
//     bin++;
//     sum += items;
//     Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");

// }

// Console.WriteLine($"We have {sum} items in inventory.");





//#################################//
//Exercise - Complete a challenge activity for nested iteration and selection statements

// string[] fraudulentOrderIDs = { "B123", "C234"," A345"," C15", "B177", "G3003", "C235", "B179"};

// foreach(string order in fraudulentOrderIDs){
//     if(order.StartsWith("B")){
//         Console.WriteLine(order);
//     }
// }


//###########################//
//Exercise - Create effective code comments

// string firstName = "Bob";
// int widgetsPurchased = 7;

// // Testing a change to the message.
// // int widgetsSold = 7;
// // Console.WriteLine($"{firstName} sold {widgetsSold} widgets.");
// Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");


////############################////
//Use boolen method that returens  a Boolen

// string pangram = "The quick brown fox jumps over the lazy dog.";
// Console.WriteLine(pangram.Contains("fox"));
// Console.WriteLine(pangram.Contains("cow"));

///##################///
/////Exercise - Implement the conditional operator////
// int saleAmount = 1001;
// // int discount = saleAmount > 1000? 100: 50;

// Console.WriteLine($"Discount: {(saleAmount > 1000? 100: 50)}");

/////////##################///////
///Code challenge: write code to display the result of a coin flip/////
// Random coin = new Random();
// // int flip = coin.Next(0, 2);
// Console.WriteLine((coin.Next(0, 2) == 0)? "Heads":"Tails");



/////////////#########################////////////////
///Exercise - Complete a challenge activity using Boolean expressions/////



// string permission = "Admin|Manager";
// int level = 55;

// if (permission.Contains("Admin"))
// {
//     if (level > 55)
//     {
//         Console.WriteLine("Welcome, Super Admin User.");
//     }
//     else
//     {
//         Console.WriteLine("Welcome, Admin User");
//     }
// }
// else if (permission.Contains("Manager"))
// {
//     if (level >= 20)
//     {
//         Console.WriteLine("Contact an Admin for access.");
//     }
//     else
//     {
//         Console.WriteLine("You do not have sufficient privileges.");
//     }
// }
// else
// {
//     Console.WriteLine("You do not have sufficient privileges.");
// }







///########################////
// bool flag = true;
// int value = 0;

// if (flag)
// {
//     value = 10;
//     Console.WriteLine("Inside of code block: " + value);
// }
// Console.WriteLine("Outside of code block: " + value);


// int x = 5;
// if (x > 0)
// {
//     int y = 6;
//     x = x + y;

// }
// Console.WriteLine("first integer: "+ x); //11


int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found = false;

foreach (int number in numbers)
{

    total += number;

    if (number == 42)
        found = true;

}

if (found)
{
    Console.WriteLine("Set contains 42");

}

Console.WriteLine($"Total: {total}");