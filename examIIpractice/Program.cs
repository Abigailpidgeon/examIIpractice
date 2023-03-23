List<double> examscores = new List<double>();

do
{
    Console.WriteLine("Please Enter your first score");
    double score = Convert.ToDouble(Console.ReadLine());
    examscores.Add(score);

    Console.WriteLine("do you have another score to add yes or no?");  

} while (Console.ReadLine().ToLower()[0] == 'y');

double min = 100;
double max = 0;
double total = 0;

foreach (double score in examscores)
{
    if (score > max)
    {
        max = max + score;
    }
    if (score < min)
    {
        min = score;
    }
    total = total + score;
}

double avg = total / examscores.Count();

Console.WriteLine($"Your minimum score is {min}");
Console.WriteLine($"Your maximum score is {max}");
Console.WriteLine($"Your average score is {avg}");

