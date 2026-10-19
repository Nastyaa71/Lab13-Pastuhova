// PrintHeader();
// PrintHeader();
// Console.WriteLine("Основная часть программы");
// PrintFooter();
// void PrintHeader()
// {
//     Console.WriteLine("^_^");
//     Console.WriteLine("Лабораторная работа №13");
//     Console.WriteLine("0_0");
// }
// void PrintFooter()
// {
//     Console.WriteLine(">_<");
//     Console.WriteLine("    Конец программы");
//     Console.WriteLine("X_X");
//     Console.WriteLine("Тринадцатое октября две тысячи двадцать шестой год");
// }

// void PrintStudentCard(string name, int age, string number)
// {
//     Console.WriteLine($"Студент: {name}, возраст: {age}, номер группы: {number}");
// }
// PrintStudentCard("Егор", 18, "252");
// PrintStudentCard("Валерия", 17, "251");




// double CalculateScholarship(double baseAmount, double bonusPercent)
// {
//     return baseAmount + baseAmount * bonusPercent / 100;
// }
// bool IsEligibleForBonus(double averageGrade)
// {
//     return averageGrade >= 4.5;
// }
// if (IsEligibleForBonus(4.7))
// {
// Console.WriteLine(CalculateScholarship(2000,15));
// }
// else
// {
// Console.WriteLine(CalculateScholarship(2000, 0));
// }


double CalculateAverageGrade(int[] grades)
{
    int sum = 0;
    foreach (int grade in grades)
    {
        sum += grade;
    }
    return (double)sum / grades.Length;
}
int CountFives(int[] grades)
{
    int count = 0;
    foreach(int grade in grades)
    {
        if (grade == 5)
        {
            count++;
        }
    }
    return count;
}
int[] grades = {4,5,3,5,4};
double average = CalculateAverageGrade(grades);
int fives = CountFives(grades);
Console.WriteLine("Средний балл: " + average);
Console.WriteLine("Количество пятерок: " + fives);


// void PrintPerson(string name, int age)
// {
//     Console.WriteLine($"Человек: {name}, возраст: {age}");
// }
// PrintPerson("Настя", 17);
// PrintPerson("Даша", 18);


// Console.WriteLine("Здравствуйте");
// PrintDivider();
// Console.WriteLine("Добрый день");
// PrintDivider();
// Console.WriteLine("Добрый вечер");
// PrintDivider();
// Console.WriteLine("До свидания");
// PrintDivider();
// static void PrintDivider()
// {
//     Console.WriteLine("-------------");
// }

// Console.WriteLine("Введите свою фамилию");
// string surname = Console.ReadLine()!.Trim();

// if (string.IsNullOrEmpty(surname))
// {
//     Console.WriteLine("Фамилия не введена. Завершение работы.");
//     return;
// }

// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);

// var assigned = Enumerable.Range(1,10)
//     .OrderBy(_ => rnd.Next())
//     .Take(2)
//     .OrderBy(x => x)
//     .ToList();

// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");


// Console.WriteLine("Привет");
// PrintDivider();
// Console.WriteLine("Как дела?");
// PrintDivider();
// Console.WriteLine("Пока");
// PrintDivider();
// static void PrintSeparator()
// {
//     Console.WriteLine("-------------");
// }


// Console.WriteLine(IsPositive(6));
// Console.WriteLine(IsPositive(-6));
// Console.WriteLine(IsPositive(0));
// static bool IsPositive(int number)
// {
//     return number>0;
// }