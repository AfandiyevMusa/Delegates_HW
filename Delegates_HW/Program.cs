using System;
using System.Collections.Generic;
using System.Linq;
using Delegates_HW.Models;

namespace Delegates_HW
{
    class Program
    {
        ////Predicate'in evezleyicisi
        //public delegate bool CheckNums(int sum);

        ////Action'in evezleyicisi
        //public delegate void ChangeString(string str);

        ////Func'in evezleyicisi
        //public delegate int StringLength(string str);

        public static void Main(string[] args)
        {
            #region Nullable
            //int? a = null;
            //Console.WriteLine(a);
            #endregion

            #region First AND Second Way
            //int[] arr = { 1, 2, 3, 4, 5, 6 };

            //Console.WriteLine(Sum(CheckOddNum, arr));
            //Console.WriteLine(Sum(CheckEvenNum, arr));
            //Console.WriteLine(Sum(CheckGreaterThanFour, arr));

            //------------------------------------------------------------------------------

            //List<int> nums = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //var result = nums.FindAll(m => m > 4);
            //Console.WriteLine(result.Count);
            #endregion

            #region Predicate
            //List<int> ints = new List<int> { 1, 2, 3, 21, 42 };
            //Console.WriteLine(SumOfNums(CheckCondition,ints));

            //Console.WriteLine(ints.FindAll(m => m % 3 == 0 && m % 7 == 0).Sum(m=>m));
            #endregion

            #region The part without Action
            //CheckString(StringToLower, "MUSA");
            //CheckString(StringToUpper, "musa");

            //ChangeString func = new ChangeString(StringToLower);
            //ChangeString func = StringToLower;
            //func.Invoke("MUSA");

            //ChangeString func2 = StringToLower;
            //func2 += StringToUpper;
            //func2.Invoke("Musa");

            //Action<string> action = StringToLower;
            //action("Musa");
            //action.Invoke("Musa");
            #endregion

            #region Action_Part2
            //CheckNum(CalculatePower, 2, 3);

            //Action<int, int> action2 = CalculatePower;
            //action2.Invoke(2, 3);
            //action2(2, 3);
            #endregion

            #region Func_Part 1 AND 2
            //Console.WriteLine(ShowStrLength(GetStringLength, "Musa"));

            //Func<string, int> func4 = GetStringLength;
            //Console.WriteLine(func4("Musa"));
            #endregion

            #region Func_Part3
            //Console.WriteLine(CheckNum(CalculateFactorial, 5));

            //Func<int, int> func6 = CalculateFactorial;
            //func6.Invoke(5);
            //func6(5);
            #endregion

            #region Task_2
            //List<Person> people = new List<Person>();

            //people.Add(new Person { Name = "Elchin", Surname = "Muradov", Address = "Neftchiler", Salary = 2500 });
            //people.Add(new Person { Name = "Anar", Surname = "Ekberov", Address = "Genclik", Salary = 5000 });
            //people.Add(new Person { Name = "Remzi", Surname = "Aliyev", Address = "Xalqlar", Salary = 1500 });
            //people.Add(new Person { Name = "Farid", Surname = "Ahmadli", Address = "Yasamal", Salary = 3000 });
            //people.Add(new Person { Name = "Cavad", Surname = "Heyderov", Address = "Nerimanov", Salary = 1000 });

            //InfoOfPeople(CheckCondition, people);
            #endregion

            #region Task_3
            //List<Book> books = new List<Book>();

            //books.Add(new Book { BookName = "Book1", Author = "Nizami" });
            //books.Add(new Book { BookName = "Book2", Author = "Anar" });
            //books.Add(new Book { BookName = "Book3", Author = "Nizami" });
            //books.Add(new Book { BookName = "Book4", Author = "Elchin" });
            //books.Add(new Book { BookName = "Book5", Author = "Nizami" });

            //Console.WriteLine(CheckTheSumOfBooks(CheckAuthor, books));

            #endregion

            #region Task_4

            //List<Employee> employees = new List<Employee>();

            //employees.Add(new Employee { FullName = "Elchin Muradov", Age = 50 });
            //employees.Add(new Employee { FullName = "Anar Ekberov", Age = 30 });
            //employees.Add(new Employee { FullName = "Farid Ahmadli", Age = 24 });

            //Console.WriteLine(CheckTheAverageOfAge(CheckAge, employees));
            #endregion

        }

        #region First Way
        //public static bool CheckOddNum(int num)
        //{
        //    return num % 2 != 0;
        //}

        //public static bool CheckEvenNum(int num)
        //{
        //    return num % 2 == 0;
        //}

        //public static bool CheckGreaterThanFour(int num)
        //{
        //    return num > 4;
        //}

        //public static int Sum(CheckNums func, int[] arr)
        //{
        //    int sum = 0;

        //    foreach (var item in arr)
        //    {
        //        if(func(item))
        //        {
        //            sum += item;
        //        }
        //    }
        //    return sum;
        //}

        #endregion

        #region Second Way

        //public static bool CheckOddNum(int num)
        //{
        //    return num % 2 != 0;
        //}

        //public static bool CheckEvenNum(int num)
        //{
        //    return num % 2 == 0;
        //}

        //public static bool CheckGreaterThanFour(int num)
        //{
        //    return num > 4;
        //}

        //public static int Sum(Predicate<int> func, int[] arr)
        //{
        //    int sum = 0;

        //    foreach (var item in arr)
        //    {
        //        if (func(item))
        //        {
        //            sum += item;
        //        }
        //    }
        //    return sum;
        //}
        #endregion

        #region Predicate
        //public static bool CheckCondition(int number)
        //{
        //    return number % 3 == 0 && number % 7 == 0;
        //}

        //public static int SumOfNums(Predicate<int> predicate, List<int> numbers)
        //{
        //    int sum = 0;

        //    foreach (var item in numbers)
        //    {
        //        if (predicate(item))
        //        {
        //            sum += item;
        //        }
        //    }
        //    return sum;
        //}
        #endregion

        #region Action_Part1
        //public static void StringToLower(string str)
        //{
        //    Console.WriteLine(str.ToLower());
        //}

        //public static void StringToUpper(string str)
        //{
        //    Console.WriteLine(str.ToUpper());
        //}

        //public static void CheckString(Action<string> changeFunc, string str)
        //{
        //    changeFunc(str);
        //}
        #endregion

        #region Action_Part2
        //public static void CalculatePower(int num1, int num2)
        //{
        //    Console.WriteLine(Math.Pow(num1, num2));
        //}

        //public static void CheckNum(Action<int, int> func, int num1, int num2)
        //{
        //    func(num1, num2);
        //}
        #endregion

        #region Func_Part1
        //public static int GetStringLength(string str)
        //{
        //    return str.Length;
        //}

        //public static int ShowStrLength(StringLength func3, string str)
        //{
        //    return func3(str);
        //}
        #endregion

        #region Func_Part2
        //public static int GetStringLength(string str)
        //{
        //    return str.Length;
        //}

        //public static int ShowStrLength(Func<string, int> func3, string str)
        //{
        //    return func3(str);
        //}
        #endregion

        #region Func_Part3
        //public static int CalculateFactorial(int num)
        //{
        //    int sum = 1;
        //    for (int i = 1; i <= num; i++)
        //    {
        //        sum *= i;
        //    }
        //    return sum;
        //}

        //public static int CheckNum(Func<int, int> func5, int num)
        //{
        //    return func5(num);
        //}
        #endregion

        #region Task_2
        //public static bool CheckCondition(Person person)
        //{
        //    return person.Salary >= 1000;
        //}

        //public static void InfoOfPeople(Predicate<Person> func, List<Person> people)
        //{
        //    foreach (var eachPerson in people)
        //    {
        //        if (func(eachPerson))
        //            Console.WriteLine($"{eachPerson.Name} + {eachPerson.Surname} + {eachPerson.Address}");
        //    }
        //}
        #endregion

        #region Task_3

        //public static bool CheckAuthor(Book book)
        //{
        //    return book.Author == "Nizami";
        //}

        //public static int CheckTheSumOfBooks(Predicate<Book> func, List<Book> books)
        //{
        //    int count = 0;
        //    foreach (var eachBook in books)
        //    {
        //        if (func(eachBook))
        //        {
        //            count++;
        //        }
        //    }
        //    return count;
        //}
        #endregion

        #region Task_4

        //public static bool CheckAge(Employee employee)
        //{
        //    return employee.Age >= 20 && employee.Age <= 40;
        //}

        //public static double CheckTheAverageOfAge(Predicate<Employee> func, List<Employee> employees)
        //{
        //    int avr = 0;
        //    int sum = 0;
        //    int count = 0;

        //    foreach (var eachEmployee in employees)
        //    {
        //        if (func(eachEmployee))
        //        {
        //            count++;
        //            sum += eachEmployee.Age;
        //        }
        //    }
        //    return sum / count;
        //}

        #endregion
    }
}