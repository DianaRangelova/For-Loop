char letter1 = char.Parse(Console.ReadLine());
char letter2 = char.Parse(Console.ReadLine());

for (char i = letter1; i <= letter2; i++)
{
    Console.Write(i + " ");
    // Ако е Console.WriteLine(i + " "); ще се изписва вертикално. 
    // Console.Write(i + " "); изписва командата хоризонтално.
}


