int[] favNums = new int[4];

int changeNum = 23;
for(int i = 0; i < favNums.Length; i++)
{
    favNums[i] = changeNum;
    changeNum += 4;
    Console.WriteLine(changeNum); // 27, 31, 35, 39
}

Console.WriteLine(favNums[0]); // 23

// Shorter declaration of Arrays
int[] enemyHp = new int[] { 10, 25, 45, 70, 100 };
Console.WriteLine(enemyHp[0]); // 10