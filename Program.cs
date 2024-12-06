using System;

namespace LabWork
{
    // Даний проект є шаблоном для виконання лабораторних робіт
    // з курсу "Об'єктно-орієнтоване програмування та патерни проектування"
    // Необхідно змінювати і дописувати код лише в цьому проекті
    // Відео-інструкції щодо роботи з github можна переглянути 
    // за посиланням https://www.youtube.com/@ViktorZhukovskyy/videos 


    // Базовий клас
    internal class Human
    {
        public string FirstName;

        public string LastName;

        public string MiddleName;

        public int BirthDay;

        public int BirthMonth;

        public int BirthYear;

        public virtual void InputData()
        {
            Console.Write("Введіть ім'я: ");
            FirstName = Console.ReadLine();
            Console.Write("Введіть прізвище: ");
            LastName = Console.ReadLine();
            Console.Write("Введіть по-батькові: ");
            MiddleName = Console.ReadLine();
            Console.Write("Введіть день народження: ");
            BirthDay = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть місяць народження: ");
            BirthMonth = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть рік народження: ");
            BirthYear = Convert.ToInt32(Console.ReadLine());
        }

        public virtual void CalculateAge()
        {
            DateTime currentDate = DateTime.Now;
            int age = currentDate.Year - BirthYear;
            if (currentDate.Month < BirthMonth || (currentDate.Month == BirthMonth && currentDate.Day < BirthDay))
            {
                age--;
            }
            Console.WriteLine($"Вік людини: {age} років");
        }

        public virtual void CountLetterOccurrences()
        {
            Console.Write("Введіть літеру для пошуку в прізвищі: ");
            char letter = Console.ReadKey().KeyChar;
            Console.WriteLine();
            int count = 0;
            string lastName = LastName;
            foreach (char c in lastName)
            {
                if (char.ToLower(c) == char.ToLower(letter))
                {
                    count++;
                }
            }
            Console.WriteLine($"Кількість входжень літери '{letter}' у прізвищі: {count}");
        }
    }



}
