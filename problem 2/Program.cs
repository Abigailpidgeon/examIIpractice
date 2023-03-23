List<string> homestates = new List<string>();

do
{
    Console.WriteLine("please enter a state you have lived in.");
    string state = Console.ReadLine();
    homestates.Add(state);

    Console.WriteLine("Do you have another state to add yes or no?");

} while (Console.ReadLine().ToLower()[0] == 'y');

Console.WriteLine($"You have lived in {homestates.Count()} states.");

double max = 0;

foreach (string state in homestates)
{
    if (state.Length > max)
    {
        max = state.Length;
    }
}

foreach (string state in homestates)
{
    if (state.Length == max)
    {
        Console.WriteLine($"{state.ToUpper()}-{state[0]}{state[1]}");
    }
}