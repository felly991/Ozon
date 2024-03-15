


//int number = Convert.ToInt32(Console.ReadLine());
//List<int[]> list = new List<int[]>();
//string line;
//int index = 0;
//bool flag = false;
//while ((line = Console.ReadLine()) != null)
//{
//    if ((line.Count(x => x == '1') == 4
//        && line.Count(x => x == '2') == 3
//        && line.Count(x => x == '3') == 2
//        && line.Count(x => x == '4') == 1))
//    {
//        flag = true;
//    }
//    list.Add(line.Split(' ').Select(int.Parse).ToArray());
//    if (list[index].Sum() == 20 && flag == true)
//    {
//        Console.WriteLine("YES");
//    }
//    else
//    {
//        Console.WriteLine("NO");
//    }
//    index++;
//    flag = false;
//}

// case 2
//int tests = int.Parse(Console.ReadLine());
//List<int[]> list = new List<int[]>();
//string line;
//bool flag = false;
//bool less = false;
//int index = 0;
//while ((line = Console.ReadLine()) != null)
//{
//    list.Add(line.Split(' ').Select(int.Parse).ToArray());
//    if (list[index][1] == 4 || list[index][1] == 6 || list[index][1] == 9 || list[index][1] == 11)
//    {
//        less = true;
//    }
//    if ((list[index][2] % 400 == 0 || (list[index][2] % 4 == 0 && list[index][2] % 100 != 0)) && list[index][1] == 2)
//    {
//        if (list[index][0] <= 29)
//        {
//            Console.WriteLine("yes");
//            flag = true;
//        }
//        if (!flag)
//        {
//            Console.WriteLine("no");
//            flag = true;
//        }
//    }
//    else if (less && list[index][1] != 2 && list[index][0] >= 31)
//    {
//        Console.WriteLine("no");
//    }
//    else if (list[index][1] == 2 && list[index][0] >= 29 && !flag)
//    {
//        Console.WriteLine("no");
//        flag = true;
//    }
//    else if (!flag)
//    {
//        Console.WriteLine("yes");
//    }
//    flag = false;
//    less = false;
//    index++;
//}

// case 3
//bool Check(string line)
//{
//    if (line.Length == 5)
//    {
//        for (int i = 0; i < line.Length; i++)
//        {
//            if (i != 1 && i != 2)
//            {
//                if (!(line[i] >= 'A' && line[i] <= 'Z'))
//                {
//                    return false;
//                }
//            }
//            else
//            {
//                if (!(line[i] >= '0' && line[i] <= '9'))
//                {
//                    return false;
//                }
//            }
//            if (i == line.Length - 1)
//            {
//                return true;
//            }
//        }
//    }
//    else
//    {
//        for (int i = 0; i < line.Length; i++)
//        {
//            if (i != 1)
//            {
//                if (!(line[i] >= 'A' && line[i] <= 'Z'))
//                {
//                    return false;
//                }
//            }
//            else
//            {
//                if (!(line[i] >= '0' && line[i] <= '9'))
//                {
//                    return false;
//                }
//            }
//            if (i == line.Length - 1)
//            {
//                return true;
//            }
//        }
//    }
//    return false;
//}
//string Numbers(string line)
//{
//    string output = "";
//    while (line != "")
//    {
//        if (line.Length >= 4 && Check(line.Substring(0, 4)))
//        {
//            if (line.Length - line.Substring(0, 4).Length < 4 && line.Length - line.Substring(0, 4).Length != 0)
//            {
//                return "-";
//            }
//            output += line.Substring(0, 4) + " ";
//            line = line.Substring(4);
//        }
//        else if (line.Length >= 5 && Check(line.Substring(0, 5)))
//        {
//            output += line.Substring(0, 5) + " ";
//            line = line.Substring(5);
//        }
//        else
//        {
//            return "-";
//        }
//    }
//    return output;
//}
//int number = int.Parse(Console.ReadLine());
//string line;
//while ((line = Console.ReadLine()) != null)
//{
//    Console.WriteLine(Numbers(line));
//}

//case 4
//int tests = int.Parse(Console.ReadLine());
//string line;
//Random rnd = new Random();
//int number = 0;
//while ((line = Console.ReadLine()) != null)
//{
//    if (line != ">=" && line != "<=")
//    {
//        number = int.Parse(line);
//    }
//    int min = 15;
//    int max = 30;
//    bool flag = false;
//    for (int i = 0; i < number; i++)
//    {
//        line = Console.ReadLine();
//        tests = int.Parse(line.Substring(3));
//        if (line.Substring(0, 2) == ">=")
//        {
//            if (min <= max && tests <= max && (max >= min || min - tests < 0) && !flag)
//            {
//                if (min - tests < 0)
//                {
//                    min = tests;
//                }
//                Console.WriteLine(rnd.Next(min, max));
//            }
//            else
//            {
//                Console.WriteLine("-1");
//                flag = true;
//            }
//        }
//        else
//        {
//            if (max >= min && tests >= min && (max - tests > 0 || max >= min) && !flag)
//            {
//                if (tests - max < 0 && max > tests)
//                {
//                    max = tests;
//                }
//                Console.WriteLine(rnd.Next(min, max));
//            }
//            else
//            {
//                Console.WriteLine("-1");
//                flag = true;
//            }
//        }
//    }
//    Console.WriteLine();
//}

//case 5
//string LongestCommonPrefix(string[] strs)
//{
//    string prefix = "";
//    string first = strs[0];
//    for (int i = 1; i < strs.Length; i++)
//    {
//        if (first[i - 1] == strs[i][i - 1])
//        {
//            prefix += first[i - 1];
//            LongestCommonPrefix(strs.ToList().Skip(1).ToArray());
//        }
//    }
//    return prefix;
//}
//string[] strs = { "flower", "flow", "flight" };
//Console.WriteLine(LongestCommonPrefix(strs));

//case 6
//bool IsValid(string s)
//{
//    Stack<char> sign = new Stack<char>();
//    foreach (var item in s.ToCharArray())
//    {
//        if (item == '(')
//        {
//            sign.Push(')');
//        }
//        else if (item == '[')
//        {
//            sign.Push(']');
//        }
//        else if (item == '{')
//        {
//            sign.Push('}');
//        }
//        else if (sign.Count == 0 || sign.Pop() != item)
//        {
//            return false;
//        }
//    }
//    return sign.Count == 0;
//}
//string s = "{()}{[]{}}";
//Console.WriteLine(IsValid(s));
using System.Diagnostics;

/// case 1
int[,] array = new int[3, 5] { { -1, 2, 4, 5, 6 }, { 2, 4, 5, 6, 7 }, { 5, 6, 7, 8, 15 } };
int key1 = 15;
int key2 = -1;
Console.WriteLine(First(key1, array));
Console.WriteLine(First(key2, array));
Console.WriteLine(Second(key1, array));
Console.WriteLine(Second(key2, array));
//Метод обхода за O(n)
bool First(int key, int[,] array)
{
    int i = 0;
    for (int j = array.GetLength(1) - 1; j >= 0; j--)
    {
        if (key > array[i, j] && array.GetLength(0) - 1 != i)
        {
            i++;
            j++;
            continue;
        }
        else if (array[i, j] == key)
        {
            return true;
        }
    }
    return false;
}

//Обход с преобразованием в лист
bool Second(int key, int[,] array)
{
    var result = array.Cast<int>().Select(c => c).ToList();
    return result.Contains(key);
}

