void Method1()
{
    Console.WriteLine("zzzz");
}

//Method1();

void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2(" текст сообщение");

void Method3(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method3(msg: "program", count: 6);

int Method4()
{
    return DateTime.Now.Year;
}
int year = Method4();
//Console.WriteLine(year);

string Method5(int count, string text)
{
    int i = 0;
    string result = string.Empty; // пустая строка
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}


//string res = Method5(10, "qwe");
//Console.WriteLine(res);



// цикл FOR

string Method6(int count, string text)
{
    int i = 0;
    string result = string.Empty; // пустая строка
    for (i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method5(10, "z");
//Console.WriteLine(res);


//таблица умножения

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i}*{j} = {i * j}");
    }
    Console.WriteLine(); // разделяет каждый цикл
}



