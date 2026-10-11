int lessonNumber = 5;
int totalLessons = 1;

while (lessonNumber >= totalLessons) {
    Console.WriteLine($"Пара {lessonNumber}");
    lessonNumber--;
}
Console.WriteLine("Пары закончились");


Console.WriteLine("Вводите оценки по одной, для завершения введите -1:");
int grade = int.Parse(Console.ReadLine());
int summ = 0;
while (grade != -1)
{
    Console.WriteLine($"Оценка принята: {grade}");
    grade = int.Parse(Console.ReadLine());
    summ++;
}
Console.WriteLine("Ввод завершён");
Console.WriteLine($"Количество введённых оценок: {summ}");


int sum = 0;
int count = 0;
int total = 0;

Console.WriteLine("Вводите оценки, для завершения введите -1:");
int grade2 = int.Parse(Console.ReadLine());
while (grade2 != -1)
{
    sum += grade2;
    count++;
    if (total < grade2)
    {
        total = grade2;
    }
    grade2 = int.Parse(Console.ReadLine());
    } 
if (count > 0)
{
    Console.WriteLine($"Средний балл: {(double)sum / count}");
    Console.WriteLine($"Наибольшая оценка {total}");

} else
{
    Console.WriteLine("Оценок не было введено");
}


string correctPassword = "qwerty123";
int summ2 = 0;

while (true)
{
    Console.Write("Введите пароль от личного кабинета: ");
    string password = Console.ReadLine();

    if (password == correctPassword)
    {
        Console.WriteLine("Доступ разрешён");
        break;
    }

    Console.WriteLine("Неверный пароль, попробуйте снова");
    summ2++;
}
Console.WriteLine($"Количество неудачных попыток: {summ2}");


string answer;

do
{
    Console.Write("Введите дату посещения (например, 01.09): ");
    string date = Console.ReadLine();
    Console.WriteLine($"Запись добавлена: {date}");

    Console.Write("Добавить еще одну запись? (да/нет): ");
    answer = Console.ReadLine();
} while (answer == "да");

Console.WriteLine("Дневник сохранён");


Console.WriteLine("Вариант А");
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
int number = 1;
while (number != 11)
{
    Console.WriteLine($"{N} * {number} = {N * number}");
    number++;
}


Console.WriteLine("Вариант В");
Console.Write("Количество страниц за день, для завершения введите -1: ");
int page = int.Parse(Console.ReadLine());
int count1 = 0;
while (page != -1)
{
    count1 += page;
    page = int.Parse(Console.ReadLine());
}
Console.WriteLine($"Количество страниц прочитанных за несколько дней {count1}");



Console.Write("Введите свою фамилию: ");
string surname = Console.ReadLine()!.Trim();
if (string.IsNullOrEmpty(surname)) {
Console.WriteLine("Фамилия не введена. Завершение работы.");
return;
}
Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
var assigned = Enumerable.Range(1, 10)
.OrderBy(_ => rnd.Next())
.Take(2)
.OrderBy(x => x)
.ToList();
Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");


Console.WriteLine($"Вариант 1");
Console.Write("Введите число: ");
int number1 = int.Parse(Console.ReadLine());
while (number1 != 0)
{
    Console.WriteLine(number1);
    number1--;
    if (number1 == 0)
    {
        Console.WriteLine("Старт");
    }
}


Console.WriteLine("Вариант 6");
Console.Write("Введите число: ");
int number2 = int.Parse(Console.ReadLine());
int count2 = 0;
while (number2 != 0)
{
    number2 /= 10;
    count2++;
}
Console.WriteLine($"Количество цифр в числе: {count2}");


Console.WriteLine("Дополнительное задание.Банкомат.");
int PinCode = 123;
int count3 = 0;
int total2 = 0;
while (count3 < 3)
{
    Console.Write("Введите PIN-код: ");
    int PIN = int.Parse(Console.ReadLine());

    if (PIN == PinCode)
    {
        Console.WriteLine("Введите сумму для снятия: ");
        int sum1 = int.Parse(Console.ReadLine());
        while (sum1 != 0)
        {
            total2 += sum1;
            sum1 = int.Parse(Console.ReadLine());
        }
        Console.WriteLine($"Итоговая сумма снятия: {total2}");
        break;
    }
    else
    {
        count3++;

    }

}
if (count3 == 3)
{
    Console.WriteLine("Карта заблокирована");
}
