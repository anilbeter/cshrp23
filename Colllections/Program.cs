/*
Exercise 1
a) Declare an Integer-Array which can contain 20 values. Then use a For-Loop to set all those values to random numbers between 1 and 100.
b) Do the same with an Integer-List.
*/

using System.Reflection.Metadata;

Random random = new();
int[] randomNumbers = new int[20];
for (int i = 0; i < randomNumbers.Length; i++)
{
    int randomNum = random.Next(1, 101);
    randomNumbers[i] = randomNum;
    Console.WriteLine(randomNumbers[i]);
}

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
List<string> stringList = new();
string stopKey = Console.ReadLine();
while (stopKey != "stop")
{
    stringList.Add(stopKey);
    stopKey = Console.ReadLine();
}
