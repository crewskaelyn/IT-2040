bool anotherCalc = true;

Console.WriteLine("Please enter your full name:");
string firstLastName = Console.ReadLine();

Console.WriteLine("---------GRADE CONVERTER PROGRAM----------");
Console.WriteLine($"Welcome {firstLastName}!");
Console.WriteLine();

while (anotherCalc) {
    Console.WriteLine("Enter the number of grades you need to convert: ");
    int gradeAmount = 0;
    try {
        gradeAmount = int.Parse(Console.ReadLine());
    } catch (FormatException) {
        Console.WriteLine("Please enter a numerical value.");
        continue;
    }
    Console.WriteLine();
    List<double> grades = getNumberGrade(gradeAmount);
    Console.WriteLine();
    Console.WriteLine("Grade List");
    Console.WriteLine("-------------");
    foreach (double grade in grades) {
        string letterGrade = convertGrade(grade);
        Console.WriteLine($"{grade} ==> {letterGrade}");
    }
    Console.WriteLine();
    Console.WriteLine("Grade Statistics");
    Console.WriteLine("-------------------");
    Console.WriteLine($"Number of grades: {gradeAmount}");
    double a = 0;
    foreach (double n in grades) {
        a += n;
    }
    double average = a / gradeAmount;
    Console.WriteLine($"Average Grade: {Math.Round(average,2)} ==> {convertGrade(average)}");

    Console.WriteLine("Would you like to convert more grades? (Y/N)");
    string more = Console.ReadLine().ToUpper();
    if (more == "N") {
        anotherCalc = false;
    }
}

static List<double> getNumberGrade(int gradeAmount) {
    List<double> grades = new List<double>();
    for (int i =0; i < gradeAmount; i++) {
        Console.WriteLine("Enter score to be converted: ");
        try {
            grades.Add(double.Parse(Console.ReadLine()));
        } catch (FormatException Exception) {
            Console.WriteLine("Please enter a numerical value.");
            i--;
        }
        Console.WriteLine();
    }
    return grades;
}

static string convertGrade(double grade) {
    if (grade >= 90) {
        return "A";
    } else if (grade >= 80) {
        return "B";
    } else if (grade >= 70) {
        return "C";
    } else if (grade >=60) {
        return "D";
    } else {
        return "F";
    }
}


//references:
//
//https://www.geeksforgeeks.org/c-sharp-math-round-method-set-1/
//https://www.c-sharpcorner.com/article/c-sharp-list/
//https://www.w3schools.com/cs/cs_foreach_loop.php
