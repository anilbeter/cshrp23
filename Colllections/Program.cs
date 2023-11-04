/*
Exercise 1
a) Declare an Integer-Array which can contain 20 values. Then use a For-Loop to set all those values to random numbers between 1 and 100.
b) Do the same with an Integer-List.
*/

/*
using System.Reflection.Metadata;

Random random = new();
int[] randomNumbers = new int[20];
for (int i = 0; i < randomNumbers.Length; i++)
{
    int randomNum = random.Next(1, 101);
    randomNumbers[i] = randomNum;
    Console.WriteLine(randomNumbers[i]);
}
*/

/*
Exercise 2
a) Declare a String-List and read Text from the console in an Endless-Loop.
Whenever the player enters something add it to the List.

b) When the player enters the string “stop” print every item in the list in the reversed order.
i.e. the player enters:
Bob
Cat
Monkey
Stop

You program should output:
Monkey
Cat
Bob

c) In addition the Program should sort the List and output the sorted list too.
*/
/*
List<string> inputList = new();
while (true)
{
    string input = Console.ReadLine();
    if (input == "stop")
        break;
    else
        inputList.Add(input);
}

Console.WriteLine("Printing in reversed order");
for (int i = inputList.Count - 1; i >= 0; i--)
{
    Console.WriteLine(inputList[i]);
}

Console.WriteLine("Printing in sorted order");
inputList.Sort();
for (int i = 0; i < inputList.Count; i++)
{
    Console.WriteLine(inputList[i]);
}
*/

// 2D Arrays
int[,] integerArray = new int[3, 3];
integerArray[0, 0] = 1;
integerArray[1, 0] = 2;
integerArray[2, 0] = 3;

integerArray[0, 1] = 4;
integerArray[1, 1] = 5;
integerArray[2, 1] = 6;

integerArray[0, 2] = 7;
integerArray[1, 2] = 8;
integerArray[2, 2] = 9;

for (int y = 0; y < 3; y++)
{
    for (int x = 0; x < 3; x++)
    {
        Console.WriteLine(integerArray[x, y]);
    }
}