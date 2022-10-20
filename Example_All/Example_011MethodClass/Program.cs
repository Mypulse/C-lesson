// Первый тип (без аргументов) ------------------------------------------------------------------
/*
void Method1()
{
    Console.WriteLine("Автор ...");
}

Method1();
*/
//Второй тип метода (ни чего не возвращает, но может принимать аргументы)------------------------
/*
void Method2(string msg)
{
    Console.WriteLine(msg);
}

Method2("Текст сообщения");
*/

// увеличение счета на 1 называется инкриментом, а уменьшение на еденицу называется декриментом.

//Пример с методом, который принимает сразу несколько аргументов---------------------------------
/*
void Method2(string msg, int count)
{
    int i = 0;
    while ( i < count )
    {
        Console.WriteLine(msg);
        i++;
    }
}

//Method2(msg:"Текст", 4); или другой вывод
Method2(count: 4, msg: "Новый текст");
*/
//Третий вид метода (что-то возвращают, но ни чего не принимают)--------------------------------
/*
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);
*/
// 4 группа методов .Самая главная, которая что-то принимает и что-то возвращает. 

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while ( i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10,"z");
Console.WriteLine(res);