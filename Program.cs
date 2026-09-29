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


