start:

int a;
int b;
int c;

char operation;


Console.WriteLine("Введите первое число : ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число : ");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\nВыберите операцию:");
Console.WriteLine("*");
Console.WriteLine("/");
Console.WriteLine("-");
Console.WriteLine("+");
operation = Convert.ToChar(Console.ReadLine());


switch (operation)
{
    case '+':
        c = a + b;
        Console.WriteLine("Ответ " + (a) + " + " + (b) + " = " + (c).ToString());
        goto start;
    case '-':
        c = a - b;
        Console.WriteLine("Ответ " + (a) + " - " + (b) + " = " + (c).ToString());
        goto start;
    case '/':
        c = a / b;
        Console.WriteLine("Ответ " + (a) + " / " + (b) + "=" + (c).ToString());
        goto start;
    case '*':
        c = a * b;
        Console.WriteLine("Ответ " + (a) + " * " + (b) + " = " + (c).ToString());
        goto start;
    default:
        Console.WriteLine("Ошибка оператора ");
        goto start;
}