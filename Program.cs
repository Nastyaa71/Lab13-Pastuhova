PrintHeader();
PrintHeader();
Console.WriteLine("Основная часть программы");
PrintFooter();
void PrintHeader()
{
    Console.WriteLine("^_^");
    Console.WriteLine("Лабораторная работа №13");
    Console.WriteLine("0_0");
}
void PrintFooter()
{
    Console.WriteLine(">_<");
    Console.WriteLine("    Конец программы");
    Console.WriteLine("X_X");
    Console.WriteLine("Тринадцатое октября две тысячи двадцать шестой год");
}

void PrintStudentCard(string name, int age, string number)
{
    Console.WriteLine($"Студент: {name}, возраст: {age}, номер группы: {number}");
}
PrintStudentCard("Егор", 18, "252");
PrintStudentCard("Валерия", 17, "251");