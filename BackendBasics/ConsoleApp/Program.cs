// //Values: Numbers, Boolean, Texts, Dates

// byte age = 112;   //0-255
// short areaOfDistrictInKmSquare = 2435; // camel casing
// int populationOfNepal = 2736765;
// long maassOfEarthInGms = 2378343682769764;

// float height =45.78364636897364872f;
// double weightInKg = 253.76834763753434;
// decimal e = -67.2536437654683683m;


// bool? isActive = true;
// isActive = null;

// char gender = 'F';
// string name = "Punam Thapa";


// DateTime dob = new(2001, 11, 10);


// Console.WriteLine(age);
// Console.WriteLine(name);
// Console.WriteLine(dob);
// Console.WriteLine(isActive);

// // Allow  user to enter their full name and print the name in uppercase

// Console.Write("Your full name:");
// string? fullName = Console.ReadLine();
// string nameInUpper = fullName.ToUpper();
// Console.WriteLine(nameInUpper);




// string firstFriend = "Maria";
// string secondFriend = "Sage";
// var output1 = "My friends" + "are" + firstFriend + "and" +  secondFriend;
// // Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");
// Console.WriteLine(output1);


// var x = 46 % 5;  //Modulo opertor
// var y =2332763;

// if (y % 2 == 0)
// {
//     Console.WriteLine("Y is even");
// }
// else
// {
//         Console.WriteLine("Y is odd");
// }

// var x = 46 % 5;  //Modulo opertor
// var y =2332763;
// {
//     Console.WriteLine($"{y} is even");
// }
// else
// {
//     Console.WriteLine($"{y} is odd");
// }


// var x = 46 % 5;  //Modulo opertor
// var y =2332763;
// var output = y % 2 == 0 ? $"{y} is even" : $"{y} is odd";
// Console.WriteLine(output);


// var r = 23456;
// var divider = 13;

// // Find if r is perfectly divisible by 13

// var result = r % 13 == 0 ? $"{r} is perfectly divisible by 13" : $"{r} is not perfectly divisible by 13";
// Console.WriteLine(result);

// var r = 23456;
// var divider = 13;

// // Find if r is perfectly divisible by 13
// // Output 13 can divide 23456, 34 times. But it's not perfectly divisible by it.
// var quotient = r / divider;
// var result = r % divider == 0 ? $"{divider} can divide {r}, {quotient} times and it's perfectly divisible by it." : 
// $"{divider} can divide {r}, {quotient} times but it's not perfectly divisible by it.";
// Console.WriteLine(result);

// // Looping
// for(int i=1; i<=100; i++)
// {
// Console.Write(i + " ");
// }
// {
//     Console.Write($"{i} ");
// }


// for(int i=1; i<=100; i--)
// {
//     Console.Write($"{i} ");
// }

// for(int i=1; i<=100; i++)
// {
//     if(i % 2 == 0)
//      Console.Write($"{i} ");
// }

// Print all numbers between 1-1000 which are divisible by 5 and 7


// for(int i=1; i<=1000; i++)
// {
//     if(i % 5 == 0 & i % 7 == 0)
//      Console.Write($"{i} ");
// }

// var radius = 2.50;
// var areaOfCircle = Math.PI * radius * radius;
// Console.WriteLine(areaOfCircle);

// int sum = 0;
// for (int i = 1; i<=20; i++)
// {
//     if(i % 3 ==0)
//     {
//         sum += i;
//     }
// }
// Console.WriteLine($"The sum of all integers from 1to 20 that are divisible by is {sum}");

// Room r1 = new Room();  //Room or var
// r1.paintColor = "Green";
// r1.floor = 3;
// r1.heigthFT = 8;
// r1.lengthFt = 15.5;
// r1.widthFt = 12.4;
// r1.DisplayInfo();


// Room r2 = new Room("Blue", 4, 13.5, 10.4, 10);
// r2.DisplayInfo();

// Room r3 = new HotelRoom();
// r3.

Lake l1 = new Lake("Tilicho Lake", "Manang district", 16138, 4, 1, 279, 4.8 );
l1.DisplayDetails();
Glacial l2 = new Glacial("Tsho Rolpa", 1.68, 140, "High", 2.5, "Supports cold-water fish and algae.");
l2.DisplayGlacialFeatures();