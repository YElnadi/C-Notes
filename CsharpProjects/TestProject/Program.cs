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
int saleAmount = 1001;
// int discount = saleAmount > 1000? 100: 50;

Console.WriteLine($"Discount: {(saleAmount > 1000? 100: 50)}");

