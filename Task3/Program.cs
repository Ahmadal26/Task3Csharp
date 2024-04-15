// See https://aka.ms/new-console-template for more information
// C# LINQ
// Task 1
int[] numbers = { 1, 2, 3, 4, 5 }; 
var evenNumbers = numbers.Where(i=>i%2==0);
foreach (var number in evenNumbers)
{
    Console.WriteLine(number);
}

// Task 2
double[] grades = { 90.1, 80.6, 65.9, 70.8, 88.8 };
var avrageGrades = grades.Average();



    Console.Write(avrageGrades);

 //Bonus
var storeGradesByOrder = grades.OrderBy(x => x);

foreach (int grade in storeGradesByOrder)
{
    Console.WriteLine(grade);
}


// C# Functions
// Task 1 

 void Greet(string name)
{
    Console.WriteLine($"Hello {name}");
}
Greet("Ahmad");

Console.WriteLine($"first function (original)  {TwoMethods.calculateVolume(2.0, 50.9, 90.1)}");
Console.WriteLine($"Second function  {TwoMethods.calculateVolume(2.0, 50.9, 90.1, 4.0)}");

// Task 2 
class TwoMethods
{
    public static double calculateVolume(double length, double width, double height)
    {
        return width * height * length;
    }

    public static double calculateVolume(double length,double width , double height ,double somethingNew)
    {
        return length * width * height*somethingNew ;
    }
    
}

