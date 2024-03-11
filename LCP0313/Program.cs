// MIS 3013 001
// March 13, 2024
// Alexandra Camarena
// 113568154
// Exam 2 Practice 

string menuStr;
menuStr = @"
**********************************
Student Information System Menu
1. Add a new student
2. Show summary
**********************************
";

while (true)
{ 
    Console.WriteLine(menuStr);
    Console.Write("Enter an option: ");
    string userChoiceStr;
    userChoiceStr = Console.ReadLine();

    if (userChoiceStr == "1")
    {
        // collection one student's information
    }
    else if (userChoiceStr == "2")
    {
        // show the summary information
    }
    else
    {
        Console.WriteLine("Thank you and goodbye!");
        break;
    }

}