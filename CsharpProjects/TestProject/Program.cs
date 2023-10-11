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


// int[] numbers = { 4, 8, 15, 16, 23, 42 };
// int total = 0;
// bool found = false;

// foreach (int number in numbers)
// {

//     total += number;

//     if (number == 42)
//         found = true;

// }

// if (found)
// {
//     Console.WriteLine("Set contains 42");

// }

// Console.WriteLine($"Total: {total}");



// int x = 5;
// if(x>0){
//     int y = 6;
// }
//     x=x+y;



/////////////#######################/////////
/// Code challenge - implement the FizzBuzz challenge rules


// for (int i = 1; i < 101; i++)
// {
//     if ((i % 3 == 0) && (i % 5 == 0))
//         Console.WriteLine($"{i} FizzBuzz");
//     else if (i % 3 == 0)
//         Console.WriteLine($"{i} Fizz");

//     else if (i % 5 == 0)
//         Console.WriteLine($"{i} Buzz");

//     else
//         Console.WriteLine($"{i}");


// }



///////###################################/////
///Exercise - Complete a challenge activity using do and while iteration statements///
///
// int hero = 10;
// int monster = 10;
// Random random = new Random();
// do {
//     int attack = random.Next(1, 11);
//     monster -= attack;
//     Console.WriteLine($"Monster was damaged and lost {attack} health and now has {monster} health.");

//     if (monster <= 0) continue;

//     attack = random.Next(1, 11);
//     hero -= attack;
//     Console.WriteLine($"Hero was damaged and lost {attack} health and now has {hero} health.");


// }
// while(hero > 0 && monster>0);
// Console.WriteLine(hero > monster ? "Hero Wins!" : "Monster Wins!");


////////////////Manage user input during this challenge////
// string? readResult;
// Console.WriteLine("Enter a string:");
// do{
//     readResult = Console.ReadLine();
// }while (readResult == null);



// string? readResult;
// bool validEntry = false;

// Console.WriteLine("Enter a string containing at least three characters:");

// do{
//     readResult = Console.ReadLine();
//     if (readResult != null){
//         if (readResult.Length >= 3){
//             validEntry = true;
//         }
//         else{
//             Console.WriteLine("Your input is invalid, please try again.");
//         }
//     }
// } while(validEntry == false);



// int numericValue = 0;
// bool validNumber = false;
// string? readResult;
// Console.WriteLine("Enter a string containing at least three characters:");
// readResult = Console.ReadLine();

// validNumber = int.TryParse(readResult, out numericValue);
// Console.WriteLine($" number is : {numericValue}");



//////COde project 1 - write code that validates integer input
string? readResult;
Console.WriteLine("Please enter a number between 5 and 10.");
int numericValue = 0;
bool validNumber = false;

do
{
    readResult = Console.ReadLine();
    validNumber = int.TryParse(readResult, out numericValue);

    if (validNumber == true)
    {
        if (numericValue >= 5 && numericValue <= 10)
        {
            validNumber = false;
            Console.WriteLine($"Your input value {numericValue} has been Accespted");
            break;
        }
        else
        {
            validNumber = false;
            Console.WriteLine($" you entered {numericValue}, please enter value between 5 and 10");
        }
    }
    else
    {
        
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }

} while (validNumber == false);

