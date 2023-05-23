using lab12;


//FileInfo f = new FileInfo("C:\\Users\\lkost\\Desktop\\lab12.txt");
//if (f.Exists)
//{
//    string str1 = f.Split('\n');
//    var employees = new List<string> { };
//    Stack<string> people = new Stack<string>(employees);
//    people.Push(str1);
//}
//var employees = new List<string> { "Michael", "Sam", "Denny" };



//using (StreamReader sr = new StreamReader("C:\\Users\\lkost\\Desktop\\lab12.txt"))
//{
//    MyStack<string> people = new MyStack<string>();
//    string line;
//    while ((line = sr.ReadLine()) != null)
//    {
//        people.Push(line);
//        Console.WriteLine(line);
//    }
//    int Index = 0;
//    int Length = 10000;
//    int index = 0;
//    string MinString = "";
//    while (people.Count > 0)
//    {
//        if (people.Pop().Length< Length)
//        {
//            Length = people.Pop().Length;
//            Index = index;
//            MinString = people.Pop();
//        }
//        index++;
//    }
//    Console.WriteLine($"Самая короткая строка: {MinString}, индекс: {Index}, длинa: {Length}");
//}



//Задание 1

//MyStackMinComparator<string, IComparer<string>> stack3 = new MyStackMinComparator<string, IComparer<string>>(Comparer<string>.Create((s1, s2) => s1.Length - s2.Length));
//try
//{
//    using StreamReader sr = new StreamReader("C:\\Users\\lkost\\Desktop\\lab12.txt");
//    string str;
//    while ((str = await sr.ReadLineAsync()) != null)
//    {
//        stack3.Push(str);
//    }
//    Console.WriteLine(stack3);
//    Console.WriteLine(stack3.GetMin + ", " + stack3.GetMin.Length);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.ToString());
//}

//Задание 2

//static string CheckBraces(string s)
//{
//    MyStack<int> stack = new MyStack<int>();

//    for (int i = 0; i < s.Length; i++)
//    {
//        char brace = s[i];
//        if (brace == '(' || brace == '[' || brace == '{')
//            stack.Push(i + 1);
//        else if (brace == ')' || brace == ']' || brace == '}')
//        {
//            if (stack.IsEmpty)
//                return (i + 1).ToString();
//            char left = (char)stack.Pop();
//            if (!((left == '(' && brace == ')') || (left == '[' && brace == ']') || (left == '{' && brace == '}')))
//                return (i + 1).ToString();
//        }
//    }

//    if (stack.IsEmpty)
//        return "YES";
//    else
//        return stack.Pop().ToString();
//}


//string s = "{[]()}";
//Console.WriteLine(CheckBraces(s));
//s = "{([])}";
//Console.WriteLine(CheckBraces(s));
//s = "{[(])}";
//Console.WriteLine(CheckBraces(s));
//s = "({[{[]}]}())";
//Console.WriteLine(CheckBraces(s)); 
//s = "{[]()}";
//Console.WriteLine(CheckBraces(s));
//s = "]";
//Console.WriteLine(CheckBraces(s));