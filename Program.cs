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
    total = grade2;
    grade2 = int.Parse(Console.ReadLine());
    if (total < grade2)
    {
        total = grade2;
    }

} 
if (count > 0)
{
    Console.WriteLine($"Средний балл: {(double)sum / count}");
} else
{
    Console.WriteLine("Оценок не было введено");
}

Console.WriteLine(total);


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