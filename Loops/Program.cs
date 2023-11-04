Random rng = new Random();
int score = 0;
int dice1 = 0;
while (dice1 != 1)
{
    dice1 = rng.Next(1, 7);
    score += dice1;
    Console.WriteLine("You rolled a " + dice1 + ". Current score: " + score);

}
Console.WriteLine("You rolled 1! Final score: " + score + "!");