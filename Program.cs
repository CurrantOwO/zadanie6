using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;

namespace zadanie5
{
    class Student
    {
        private int Id;
        private string FIO;
        private int Group;
        private string Data;
        private int a = 0;
        ArrayList inf = new ArrayList();
        
        public int id
        {
            get { return Id; }
            set { if (value >= 0) Id = value; }
        }
        public int grp
        {
            get { return Group; }
            set { if (value >= 0) Group = value; inf.Add(Group); }
        }
        public string fio
        {
            get { return FIO; }
            set { if (value != "" || value != " ") FIO = value; inf.Add(FIO); }
        }
        public string dat
        {
            get { return Data; }
            set { if (value != "" || value != " ") Data = value; inf.Add(Data); a++;}
        }
        public void Info()//список всех студентов
        {
            int li = 1;
            for (int i = 0; i < inf.Count; i++)
            {
                if (i == 0 || i % 3 == 0) { Console.WriteLine("Студент №" + li); li++; Console.WriteLine("\t" + inf[i]); }
                else { Console.WriteLine("\t" + inf[i]); }
            }
        }
        public void add()//добавляем данные
        {
            string n, d;
            Console.Write("Введите ФИО студента: ");
            n = Convert.ToString(Console.ReadLine());
            Console.Write("Введите номер группы: ");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите дату рождения: ");
            d = Convert.ToString(Console.ReadLine());
            a++;
            id = a;
            fio = n;
            grp = g;
            dat = d;
            Info();
        }
        public void redakt()//изменяем
        {
            string n, d;
            Console.Write("Выберите номер студента: ");
            int nu = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите ФИО студента: ");
            n = Convert.ToString(Console.ReadLine());
            Console.Write("Введите номер группы: ");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите дату рождения: ");
            d = Convert.ToString(Console.ReadLine());
            int du = nu;
            if(nu > 1) { for(int i = 1; i < du; i++) nu = nu + 2; }
            inf[nu-1] = n;
            inf[nu] = d;
            inf[nu+1] = g;
            Info();
        }
        public void Dell()
        {
            Console.Write("Выберите номер студента: ");
            int nu = Convert.ToInt32(Console.ReadLine());
            int du = nu;
            if (nu > 1) { for (int i = 1; i < du; i++) nu = nu + 2; }
            inf.RemoveRange(nu-1, 3);
            a--;
            Info();
        }
        public void Sid()
        {
            Console.Write("Выберите номер студента: ");
            int nu = Convert.ToInt32(Console.ReadLine());
            int du = nu;
            if (nu > 1) { for (int i = 1; i < du; i++) nu = nu + 2; }
            for (int i = nu-1; i < du+2; i++) { Console.WriteLine("\t" + inf[i]); }
        }
        public void Old()
        {
            Console.Write("Выберите номер студента: ");
            int nu = Convert.ToInt32(Console.ReadLine());
            int du = nu;
            if (nu > 1) { for (int i = 1; i < du; i++) nu = nu + 2; }
            string s = inf[nu] + "";
            Console.WriteLine(s);
            s = s.Substring(s.Length - 4);
            int z = Convert.ToInt32(s);
            z = 2020 - z;
            Console.WriteLine("В этом году студенту " + z);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student ak = new Student();
            ak.id = 01;
            ak.fio = "Зябликов Василий Петячкин";
            ak.dat = "12.10.2001";
            ak.grp = 12;
            ak.id = 02;
            ak.fio = "Зяблов Васий Потчкин";
            ak.dat = "12.10.2000";
            ak.grp = 12;
            ak.id = 03;
            ak.fio = "Баулов Валентин Валович";
            ak.dat = "02.12.2002";
            ak.grp = 6;

            Console.WriteLine("Что вы хотите сделать?\n1.Добавить студента\n2.Изменить данные студента\n3.Удалить студента\n4.Инфопмация по id\n5.Возраст по id");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1: { ak.Info(); ak.add(); break; }
                case 2: { ak.Info(); ak.redakt(); break; }
                case 3: { ak.Info(); ak.Dell(); break; } //удоляем
                case 4: { ak.Sid(); break; }
                case 5: { ak.Old(); break; }

            }

        }
    }
}