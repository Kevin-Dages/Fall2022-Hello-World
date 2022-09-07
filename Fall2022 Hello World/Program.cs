Console.WriteLine("Hello, World!");


// Variables and Objects
//Variable Declaration ex: var Instructor;
// variable is stating we have a variable and giving it associated name
//If you are just doinf variable declaration, you must state the variable type

// varibleType variableName;
string Instructor;

// Variable Assignment
// Variable assignment is giving a variable a value (of the right type) for us to use later

//varibleName = value;
Instructor = "Gavin";
// Variable reassignment 
Instructor = "Davis";

// All together now!
// if we use var c# with know age is a interger  based on the value after the = sign

// var/variableType variableName = value;
int Age = 24;
Console.WriteLine(Age);

//integers are -2b-2b they are whole numbers as well

// int for whole , float for decimals, char is for any vaild characters e,r,t,etc..

// Operators
//Performs some kind of basic operation/Action  on some values
// ex: 5 + 13 = 18

// Assignment Operator
// Single = Use this to assign the value of a variable

//Arithmetic
// addition/String ConCatination: +
var studentCount = 5 + 13;
Console.WriteLine(studentCount);
// subtraction -
// Multiplitcation *
// Divison /
var averageClassSize = studentCount / 3; // 18/3 = 6 //to add a decimal add "f" after integer to make it a decimal
Console.WriteLine(averageClassSize);
// Exponentition ^
// Modulo %
// -- returns the remainder after / by a particular number
var time = 13 % 12; //time has a value of 1 here 
Console.WriteLine(time);

// Equality

// Comparison

// Increment

// Parsing
var ParsedValue = Int32.Parse("15"); //Integer 15
