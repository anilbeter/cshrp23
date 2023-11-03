List<string> stringList = new();

stringList.Add("First entry");
stringList.Add("Second entry");
stringList.Add("Third entry");

Console.WriteLine(stringList[1]);
// Second Entry

// Shorter Way
List<int> ints = new()
{
    23,
    29,
    35,
    74,
    84,
    99
};
for (int i = 0; i < ints.Count; i++)
{
    Console.WriteLine(ints[i]);
    // 23, 29, 35, 74, 84, 99
}