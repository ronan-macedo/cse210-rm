Console.WriteLine("Please provide your grade score: ");

var gradeInput = int.TryParse(Console.ReadLine(), out int score);

if (!gradeInput || score > 100 || score < 0)
{
    Console.WriteLine("Your grade score should be less than 100 and higher than 0, or an integer.");
    return;
}

string grade = CalculateGrade(score);

Console.WriteLine($"Your grade is: {grade}");

if (score >= 70)
{
    Console.WriteLine("Congrats! You passed!");
}
else
{
    Console.WriteLine("Sorry, your grade was not enough to pass.");
}

static string CalculateGrade(int score)
{
    if (score < 60)
    {
        return "F";
    }

    var baseGrade = string.Empty;
    var scoreLastDigit = score % 10;

    if (score >= 90)
    {
        baseGrade = scoreLastDigit < 3 ? "A-" : "A";
    }
    else if (score >= 80)
    {
        baseGrade = "B";
    }
    else if (score >= 70)
    {
        baseGrade = "C";
    }
    else if (score >= 60)
    {
        baseGrade = "D";
    }

    if (score >= 90)
    {
        return baseGrade;
    }
    else if (scoreLastDigit >= 7)
    {
        return baseGrade + "+";
    }
    else if (scoreLastDigit < 3)
    {
        return baseGrade + "-";
    }
    else
    {
        return baseGrade;
    }
}