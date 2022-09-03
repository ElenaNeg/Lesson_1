/*
void Method(int maximum)
{
    int minimum;
    minimum = -maximum;
    while (minimum <= maximum)
    {
        Console.Write(minimum + " ");
        minimum++;
    }
}

int CreateArray(int N)
{
    int[] arrayA = new int[N * 2 + 1];
    for (int i = -N; i <= N; i++)
    {
        arrayA[i + N] = i;
    }
    return arrayA;
}

int Ar(int N) // Задает метод.
{
    int x = -N; //первая цифра -N (задаем цикл)
    while (x <= N) //до тех пор пока x меньше или равен N
    {
        Console.WriteLine(x);  // выводим в консоль "x"
        x++;  //инеремент
    }
    return x;
}

void Numbers(int n)
{
    int length = n + n;
    for (int i = 0; i < length + 1; i++)
    {
        Console.WriteLine(-n + i);
    }
}

string ShowNums(int N)
{
    string NumsShow = "";
    for (int i = -N; i < N; i++)
    {
        NumsShow = NumsShow + i + " ";
    }
    return NumsShow;
}

int af = -5;
int uf = 5;
Console.WriteLine($"{af}....{uf}");

int result = (1 + 2) - (3 + 4)
            / (15 * 16) - (17 + 19)
            / (25 * 26) - (27 + 29)
            / (35 * 36) - (37 + 39)
            ;

if (a > b
    && c > a
    && e > a
    || af == 1
    || c == f
    ^ !(g != h))
{
    Console.WriteLine("vse kruta");
}

bool Metodi(int chislo)
{
    bool resultati = false;
    if (chislo % 2 == 0)
    {
        resultati = true;
    }
    else
    {
        resultati = false;
    }

    if (resultati == false)
    {
        return false;
    }
    else
    {
        return true;
    }
}

void DrawText(string text, int left, int top)
{
    Console.SetCursorPosition(left, top);
    Console.WriteLine(text);
}
DrawText("Intensive C# Demo text", 629, 360);

string caption = "Intensive C# Demo text";
int screenWidthPosition = (Console.WindowWidth - caption.Length) / 2;
int screenHeigthPosition = Console.WindowHeigth / 2;

DrawText(caption, screenWidthPosition, screenHeigthPosition);

DrawText(
    text: screenWidthPosition,
    top: screenHeigthPosition
    );

string label = "";
string address = string.Empty;

// Пример 1
double a = 1, b = -26, c = 120;
var d = b * b - 4 * a * c;
double x1 = (-b + Math.Sqrt(d)) / (2 * a);
double x2 = (-b - Math.Sqrt(d)) / (2 * a);
Console.WriteLine($"x1 = {x1} x2 = {x2}");
// Пример 2
a = 2; b = 1; c = -3;
d = b * b - 4 * a * c;
x1 = (-b + Math.Sqrt(d)) / (2 * a);
x2 = (-b - Math.Sqrt(d)) / (2 * a);
Console.WriteLine($"x1 = {x1} x2 = {x2}");
// Пример 3
a = 1; b = 1; c = -6;
d = b * b - 4 * a * c;
x1 = (-b + Math.Sqrt(d)) / (2 * a);
x2 = (-b - Math.Sqrt(d)) / (2 * a);
Console.WriteLine($"x1 = {x1} x2 = {x2}");

public Roots Solve(double a, double b, double c)
{
    var d = b * b - 4 * a * c;
    double x1 = (-b + Math.Sqrt(d)) / (2 * a);
    double x2 = (-b - Math.Sqrt(d)) / (2 * a);
    return new Roots {X1 =x1, x2 = x2};
}
*/

using System.Linq;

string text = "(1,2) (2,3) (4,5) (6,7)"
                .Replace("(", "")
                .Replace(")", "")
                ;

var data = text.Split(" ")
                .Select(item => item.Split(','))
                .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1])))
                .Where(e => e.x % 2 ==0)
                .Select(point => (point.x *10, point.y))
                .ToArray();

for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]);
}
