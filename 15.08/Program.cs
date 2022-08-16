using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._08
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime date = DateTime.Now; //get и это свойство  
            //Console.WriteLine(date);

            //date = date.AddYears(5); //add это метод 
            //Console.WriteLine(date);

            string fName = "Anton";
            string mName = "Fedotov";

            //Console.WriteLine(fName);
            //Console.WriteLine(mName);
            //Console.ReadLine();

            Console.Write("Введите ФИО: " + " ");
            string username = Console.ReadLine();

            Console.Write("Введите год рождения: " + " ");
            string userAge = Console.ReadLine();

            int currentAge = 2022;
            int userAge_ = Convert.ToInt32(userAge);

            int avalAge = currentAge - userAge_;

            if (avalAge >= 18)
            {
                Console.WriteLine("Приветствую тебя " + username + "!");
            }
            else
            {
                Console.WriteLine("Слишком молод");
            }
        }
    } 
}
