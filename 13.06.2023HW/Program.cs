using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._06._2023HW
{
    public class Task1
    {
        double BinToDec(string str)
        {
            try
            {
                for (int i = 0; i < str.Length; i++)
                    if (str[i] != 48 || str[i] != 49)
                        throw new Exception("Число введено не в двоичной системе");
                double dec = 0;
                int k = 0;
                for (int i = str.Length - 1; i >= 0; i--)
                {
                    if (str[i] == '1')
                        dec += Math.Pow(2, k);
                    k++;
                }
                return dec;
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            return 0;
        }
        double OctToDec(string str)
        {
            try
            {
                for (int i = 0; i < str.Length; i++)
                    if (str[i] < 48 || str[i] > 55)
                        throw new Exception("Число введено не в двоичной системе");
                double dec = 0;
                int k = 0;
                for (int i = str.Length - 1; i >= 0; i--)
                {
                    if (str[i] == '1')
                        dec += Math.Pow(2, k);
                    if (str[i] == '2')
                        dec += 2 * Math.Pow(2, k);
                    if (str[i] == '3')
                        dec += 3 * Math.Pow(2, k);
                    if (str[i] == '4')
                        dec += 4 * Math.Pow(2, k);
                    if (str[i] == '5')
                        dec += 5 * Math.Pow(2, k);
                    if (str[i] == '6')
                        dec += 6 * Math.Pow(2, k);
                    if (str[i] == '7')
                        dec += 7 * Math.Pow(2, k);
                    k++;
                }
                return dec;
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            return 0;
        }
        double HexToDec(string str)
        {
            try
            {
                for (int i = 0; i < str.Length; i++)
                    if (str[i] < 48 || str[i] > 57 || str[i] != 'a' || str[i] != 'b'
                        || str[i] != 'c' || str[i] != 'd' || str[i] != 'e' || str[i] != 'f')
                        throw new Exception("Число введено не в двоичной системе");
                double dec = 0;
                int k = 0;
                for (int i = str.Length - 1; i >= 0; i--)
                {
                    if (str[i] == '1')
                        dec += Math.Pow(2, k);
                    if (str[i] == '2')
                        dec += 2 * Math.Pow(2, k);
                    if (str[i] == '3')
                        dec += 3 * Math.Pow(2, k);
                    if (str[i] == '4')
                        dec += 4 * Math.Pow(2, k);
                    if (str[i] == '5')
                        dec += 5 * Math.Pow(2, k);
                    if (str[i] == '6')
                        dec += 6 * Math.Pow(2, k);
                    if (str[i] == '7')
                        dec += 7 * Math.Pow(2, k);
                    if (str[i] == '8')
                        dec += 8 * Math.Pow(2, k);
                    if (str[i] == '9')
                        dec += 9 * Math.Pow(2, k);
                    if (str[i] == 'a')
                        dec += 10 * Math.Pow(2, k);
                    if (str[i] == 'b')
                        dec += 11 * Math.Pow(2, k);
                    if (str[i] == 'c')
                        dec += 12 * Math.Pow(2, k);
                    if (str[i] == 'd')
                        dec += 13 * Math.Pow(2, k);
                    if (str[i] == 'e')
                        dec += 14 * Math.Pow(2, k);
                    if (str[i] == 'f')
                        dec += 15 * Math.Pow(2, k);
                    k++;
                }
                return dec;
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            return 0;
        }
        string DecToAll(int dec)
        {
            int sys = 2;
            return Convert.ToString(dec, sys);
        }
        public void Calculator()
        {

            Console.WriteLine("Из какой системы вы хотите перевести \n" +
                "1)Из двоичной\n" +
                "2)Из восьмиричной\n" +
                "3)Из десятичной\n" +
                "4)Из шестнадцатиричной");

            int a = int.Parse(Console.ReadLine());
            while (a < 1 || a > 4)
                a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число для перевода");
            string str = Console.ReadLine();
            Console.WriteLine(BinToDec(str));
        }

    }
    public class Task3
    {
        string _name;
        int _number;
        DateTime _date;

        public Task3(string name, int number, DateTime date)
        {
            _name = name;
            _number = number;
            _date = date;
        }
        public override string ToString()
        {
            return $"Имя -> {_name}\n" +
                $"Номер паспорта -> {_number}" +
                $"Дата выдачи -> {_date}";
        }
    }
    internal class Program
    {
        static void task2()
        {
            string cif = Console.ReadLine().ToLower();
            if (cif != null)
            {
                if (cif == "one") Console.WriteLine("1");
                if (cif == "two") Console.WriteLine("2");
                if (cif == "three") Console.WriteLine("3");
                if (cif == "four") Console.WriteLine("4");
                if (cif == "five") Console.WriteLine("5");
                if (cif == "six") Console.WriteLine("6");
                if (cif == "seven") Console.WriteLine("7");
                if (cif == "eight") Console.WriteLine("8");
                if (cif == "nine") Console.WriteLine("9");
                if (cif == "zero") Console.WriteLine("0");
                else Console.WriteLine("net takoy");
            }
        }
        static void task4()
        {
            string str = Console.ReadLine();
            if (str.Split('<').Length > 1)
            {
                if (int.Parse(str.Split('<')[0]) < int.Parse(str.Split('<')[1]))
                    Console.WriteLine("true");
                else Console.WriteLine("false");
            }
            if (str.Split('>').Length > 1)
            {
                if (int.Parse(str.Split('>')[0]) > int.Parse(str.Split('>')[1]))
                    Console.WriteLine("true");
                else Console.WriteLine("false");
            }

            try
            {
                if (str.Contains('.') || str.Contains(','))
                {
                    throw new Exception("Содержит не целые числа");
                }
            }
            catch
            {

            }
        }
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}
