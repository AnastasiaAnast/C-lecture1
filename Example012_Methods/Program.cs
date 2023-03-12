void Method1()
{
Console.WriteLine("Автор ...");
}

// Это вызов метода - Method1();

// Вид 2: Метод ничего не возвращает, но может принимать какие-то аргументы
void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Method2("Текст сообщения");


void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++; //инкремент (уменьшение на 1 - декремент)
        // если здесь увеличивать count - программа зациклится
    }
}
// Method21(msg: "Текст", count: 4); //увидеть сообщение 4 раза
// Method21(count: 4, msg: "новый текст");

// методы которые что-то возвращают, но ничего не принимают
// в таком методе обязательно(!) указывать тип данных, значение которого мы ожидаем
int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

// Вид4
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4 (10, "r");
Console.WriteLine(res);

// Вывод таблицы умножения на экран
for (int i = 2; i <= 10; i++) // для этого внешнего цикла оператором ИЛИ телом метода
{
    for (int j = 0; j <= 10; j++) // выступает второй цикл
    {
        Console.WriteLine($"{i} x {j} = {i*j}"); // МЕТОД ИНТЕРПОЛЯЦИЯ СТРОК
    }
    Console.WriteLine(); // после того как второй цикл отработает, сделаем переход на новую строку
}

// Программы обработки текста:
// Задача1: 
// Дан текст (будет храниться как отдельная строка). 
// В тексте заменить все 
// пробелы черточками, 
// маленькие буквы «к» заменить на «К», 
// большие «С» заменить на «с».

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
// Если требуется обратиться к какому то конкретному символу строки,
// начинаем позици/ этого символа отсчитывать с нуля
// чтобы получить конкретный сивол - обратимся через [], укажем идентификатор строки
// s [3] // r - 3-й символ строки "qwerty"

// Метод будет принимать строку, старый символ и новый, на который нужно будет заменить. Возвращаться будет строка. Условно 4-й вид методов

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;

//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }

// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);

// алгоритм сортировки методом выбора ИЛИ алгоритм сортировки методом мини-макса ИЛИ методом/выбором максимального

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 }; //для этого алгоритма непринципиально, если будут повторяющиеся элементы

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length -1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
//
//
//
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);