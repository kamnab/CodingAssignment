var list = new List<string>()
{
    "BE","FE","QA","Urgent"
};

Func<string, List<string>> Input = (input) =>
{
    var output = new List<string>();

    list.ForEach(x =>
    {
        if (input.Contains($"[{x}]")) output.Add(x);
    });

    return output;
};

var input = "[BE][FE][Urgent] there is error";
Console.WriteLine(input);
Console.WriteLine($"Receive channels: {string.Join(", ", Input(input))}{Environment.NewLine}");

input = "[BE][QA][HAHA][Urgent] there is error";
Console.WriteLine(input);
Console.WriteLine($"Receive channels: {string.Join(", ", Input(input))}");

Console.ReadLine();
