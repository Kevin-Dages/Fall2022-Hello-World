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
// a + b
// a - b
// a * b
// a / b
// a % b

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
//(a == b); checks if the two variables are the same whch would be used as a bool stating it true or false
//(a != b);  tells if it is not equal


// Comparison
// Used to compare if they are the same or not the same 

// a = 6;
// b = 2;

//(a == b); checks if the two variables are the same whch would be used as a bool stating it true or false
//(a != b);  tells if it is not equal
//(a > b);  says if a is greater than b
///(a >= b); greater than or equal to
//(a < b); smaller than
//(a <= b); smaller than or = two


// Increment

// Parsing
var ParsedValue = Int32.Parse("15"); //Integer 15

Console.WriteLine("Hello, World!");
// variable types
// -String: Words/Text. a string of characters
string variableName = "Something";
var variableNAme2 = "Something2";
// -Int: integers, whole numbers
int a = 0;
int b = 7;
var c = 9;

// -booleans: True or Flase
// Boolean is a data type where the only values are true and false
var isSunny = true;
// Boolean Operators
// We have some specific operators defined between two booleans

// OR Operator || ( | if you want to run both sides)
// The OR operator returns true if the left is true OR the right is true
// true || false --> true
// false || true --> true
// true || true --> false
// false || false --> false

//Var willGoOutside = isSunny || isDavis;

// AND Operator &&
//The AND Op returns true if the left and the right values are true
// Will only go outside if its sunny and not raining two things need to be true
// true && false --> false
// false && true --> false
// true && true --> true
// false && false --> false
var isRaining = true;
var isCold = true;
var willNotDrive = isRaining && isCold; // true && true = true true && false = false

// NOT Operator !
// Returns the opposite of a given boolean value 
// !true --> false
// !false --> true
var willDrive = !willNotDrive;

// Exclusive OR (XOR) ^
// Only returns true when the left or right are true, false when both are true

// Equality -----------

//(a == b); checks if the two variables are the same which would be used as a bool stating it true or false
//(a != b);  tells if it is not equal
// checks to see if the value of instructor is the same as Davis
string Instructor = "Davis";
var isDavis = Instructor == "Davis"; //Davis == Davis ---> True

// Not Equal != check to see if two things are not equal
var isGavin = Instructor != "Davis";

//Comparison 

// a = 6;
// b = 2;

//(a == b); checks if the two variables are the same which would be used as a bool stating it true or false
//(a != b);  tells if it is not equal
//(a > b);  says if a is greater than b
///(a >= b); greater than or equal to
//(a < b); smaller than
//(a <= b); smaller than or = two


//operators 
// addition, subtraction, divison, multiplcation, exponet Math.Pow(); %--> modulo
// cw + tab + tab = Console.WriteLine
var abc = a + b + c;
// To get Class abc to ConCat need to WriteLine it.
Console.WriteLine(a + b);
Console.WriteLine("Total: " + abc);
// String ConCat to add a string with the total of class abc.

//bool one = true
//bool two = false
//bool three = = true 

//(one && !two)
// true && true = true

//(three || (two && three))
// (true || false = true

//!two && (!three && (one ||)) || three
// true 

// one && two & three
// true && false && true = false
Console.WriteLine(true && false && true);

//one || two || three
Console.WriteLine(true || false || true); 

// 1. = true
// 2. = true 
// 3. = false
// 4. = false
// 5. = True