int countOfNumbersToSum = int.Parse(Console.ReadLine());

double sum = 0;

for (int i = 1; i <= countOfNumbersToSum; i++)
{
    double nNumber = double.Parse(Console.ReadLine());
    sum += nNumber;
}
Console.WriteLine(sum); 