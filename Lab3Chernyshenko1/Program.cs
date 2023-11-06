
double X; 
int N;
Console.Write("Введите вещественное число X: ");
X = double.Parse(Console.ReadLine());
Console.Write("Введите целое число N (> 0): ");
N = int.Parse(Console.ReadLine());
double result = 1.0; 
for (int i = 1; i <= N; i++)
{
    result += Math.Pow(X, i) / i;
}

Console.WriteLine("Результат: " + result);