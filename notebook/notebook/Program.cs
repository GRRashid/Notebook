using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace notebook
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int count = 0;
            int a = 0;
            Dictionary<int, Notebook> notebooks = new Dictionary<int, Notebook>();

            Console.WriteLine("Привет! Добро пожаловать в блокнот! Введи цифру 1-5:\n" +
                              "1 - Создадим новую запись\n" +
                              "2 - Редактирование сущетсвующей записи\n" +
                              "3 - Удаление созданных записей\n" +
                              "4 - Просмотр созданных учетных записй\n" +
                              "5 - Просмотр всех созданных учетных записей\n" +
                              "6 - Выход");
            while (a != 6)
            {
                a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Console.WriteLine("Введите фамилию:");
                        string surname = Console.ReadLine();
                        Console.WriteLine("Введите имя:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Введите номер телефона:");
                        string number = Console.ReadLine();
                        Console.WriteLine("Введите страну:");
                        string country = Console.ReadLine();
                        Notebook notebook1 = new Notebook(surname, name, number, country);
                        notebooks.Add(count, notebook1);
                        count += 1;

                        Console.WriteLine("Хотите ввести отчество?\n" +
                                          "y - YES\n" +
                                          "n - NO");
                        char answer = char.Parse(Console.ReadLine());
                        while (answer != 'y' || answer != 'n')
                        {
                            if (answer == 'y')
                            {
                                Console.WriteLine("Введите дату отчество:");
                                string lastName = Console.ReadLine();
                                notebook1.SetDate(lastName);
                                break;
                            }
                            else if (answer == 'n')
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Введите корректный ответ:");
                                answer = char.Parse(Console.ReadLine());
                            }
                        }
                        
                        Console.WriteLine("Хотите ввести дату рождения?\n" +
                                          "y - YES\n" +
                                          "n - NO");
                        answer = char.Parse(Console.ReadLine());
                        while (answer != 'y' || answer != 'n')
                        {
                            if (answer == 'y')
                            {
                                Console.WriteLine("Введите дату рождения:");
                                string date = Console.ReadLine();
                                notebook1.SetDate(date);
                                break;
                            }
                            else if (answer == 'n')
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Введите корректный ответ:");
                                answer = char.Parse(Console.ReadLine());
                            }
                        }
                       

                        Console.WriteLine("Хотите ввести организацию?\n" +
                                          "y - YES\n" +
                                          "n - NO");

                        answer = char.Parse(Console.ReadLine());
                        while (answer != 'y' || answer != 'n')
                        {
                            if (answer == 'y')
                            {
                                Console.WriteLine("Введите организацию:");
                                string org = Console.ReadLine();
                                notebook1.SetOrganization(org);
                                break;

                            }
                            else if (answer == 'n')
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Введите корректный ответ:");
                                answer = char.Parse(Console.ReadLine());
                            }
                        }
                        

                        Console.WriteLine("Хотите ввести должность?\n" +
                                          "y - YES\n" +
                                          "n - NO");
                        answer = char.Parse(Console.ReadLine());
                        while (answer != 'y' || answer != 'n')
                        {
                            if (answer == 'y')
                            {
                                Console.WriteLine("Введите должность:");
                                string pos = Console.ReadLine();
                                notebook1.SetPosition(pos);
                                break;

                            }
                            else if (answer == 'n')
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Введите корректный ответ:");
                                answer = char.Parse(Console.ReadLine());
                            }
                        }

                        Console.WriteLine("Хотите ввести прочие заметки??\n" +
                                          "y - YES\n" +
                                          "n - NO");
                        answer = char.Parse(Console.ReadLine());
                        while (answer != 'y' || answer != 'n')
                        {
                            if (answer == 'y')
                            {
                                Console.WriteLine("Введите прочие заметки:");
                                string oth = Console.ReadLine();
                                notebook1.SetPosition(oth);
                                break;
                            }
                            else if (answer == 'n')
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Введите корректный ответ:");
                                answer = char.Parse(Console.ReadLine());
                            }
                        }
                        

                        Console.WriteLine("Если хотиет продолжить работу введите цифру 1-5\n" +
                                          "иначе введите 6");
                        break;
                    case 2:
                        Console.WriteLine("Введите НОМЕР записи, который хотите отредактировать:");
                        foreach (var notebook in notebooks)
                        {
                            string lastName1 = notebook.Value.GetSurName();
                            Console.WriteLine($"Запись №{notebook.Key} с фамилией: {lastName1}");

                        }

                        int numberOfNotebook = int.Parse(Console.ReadLine());
                        
                        Console.WriteLine("Введите номер поля которое хотите изменить:\n" +
                                          "1 - фамилия\n" +
                                          "2 - имя\n" +
                                          "3 - отчество\n" +
                                          "4 - Номер телефона\n" +
                                          "5 - Организация\n" +
                                          "6 - Должность\n" +
                                          "7 - Прочие" +
                                          "8 - Выход");
                        int pole = int.Parse(Console.ReadLine());
                        switch (pole)
                        {
                            case 1:
                                Console.WriteLine("Введите фамилию:");
                                string name1 = Console.ReadLine();
                                notebooks[numberOfNotebook].SetSurName(name1);
                                break;
                            case 2:
                                Console.WriteLine("Введите имя:");
                                string name2 = Console.ReadLine();
                                notebooks[numberOfNotebook].SetName(name2);
                                break;
                            case 3:
                                Console.WriteLine("Введите отчество:");
                                string name3 = Console.ReadLine();
                                notebooks[numberOfNotebook].SetLastName(name3);
                                break;
                            case 4:
                                Console.WriteLine("Введите Номер телефона:");
                                string name4 = Console.ReadLine();
                                notebooks[numberOfNotebook].SetNumber(name4);
                                break;
                            case 5:
                                Console.WriteLine("Введите организацию:");
                                string name5 = Console.ReadLine();
                                notebooks[numberOfNotebook].SetOrganization(name5);
                                break;
                            case 6:
                                Console.WriteLine("Введите Должность:");
                                string name6 = Console.ReadLine();
                                notebooks[numberOfNotebook].SetPosition(name6);
                                break;
                            case 7:
                                Console.WriteLine("Введите прочие:");
                                string name7 = Console.ReadLine();
                                notebooks[numberOfNotebook].SetOthers(name7);
                                break;
                            case 8:
                                break;
                        }
                        Console.WriteLine("Если хотиет продолжить работу введите цифру 1-5\n" +
                                          "иначе введите 6");
                        break;


                    case 3:
                        Console.WriteLine("Введите НОМЕР записи, который хотите удалить:");
                        foreach (var notebook in notebooks)
                        {
                            
                            string lastName1 = notebook.Value.GetSurName();
                            Console.WriteLine($"Запись №{notebook.Key} с фамилией: {lastName1}");

                        }
                        int numberOfNotebookForDelete = int.Parse(Console.ReadLine());
                        notebooks.Remove(numberOfNotebookForDelete);
                        int i = 0;
                        Dictionary<int, Notebook> newNotebooks = new Dictionary<int, Notebook>();
                        foreach (var notebook in notebooks)
                        {
                            newNotebooks.Add(i, notebook.Value);
                            i++;

                        }

                        Dictionary<int, Notebook> oneMoreDictionary = notebooks;
                        notebooks = newNotebooks;
                        newNotebooks = oneMoreDictionary;
                        newNotebooks.Clear();
                        


                        Console.WriteLine("Если хотиет продолжить работу введите цифру 1-5\n" +
                                          "иначе введите 6");
                        break;
                    case 4:
                        Console.WriteLine("Введите НОМЕР записи, который хотите просмотреть:");
                        foreach (var notebook in notebooks)
                        {
                            string lastName1 = notebook.Value.GetSurName();
                            Console.WriteLine($"Запись №{notebook.Key} с фамилией: {lastName1}");

                        }
                        int numberOfNotebookForSee = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Запись №{numberOfNotebookForSee}\n" +
                                          $"Фамилия - {notebooks[numberOfNotebookForSee].GetSurName()} \n" +
                                          $"Имя - {notebooks[numberOfNotebookForSee].GetName()}\n" +
                                          $"Отчесвто - {notebooks[numberOfNotebookForSee].GetLastName()}\n" +
                                          $"Номер телефона - {notebooks[numberOfNotebookForSee].GetPhoneNumber()}\n" +
                                          $"Организация - {notebooks[numberOfNotebookForSee].GetOrg()}\n" +
                                          $"Должность - {notebooks[numberOfNotebookForSee].GetPosition()}\n" +
                                          $"Прочее - {notebooks[numberOfNotebookForSee].GetOther()}");

                        Console.WriteLine("Если хотите продолжить работу введите цифру 1-5\n" +
                                          "иначе введите 6");
                        break;
                    case 5:
                        foreach (var notebook in notebooks)
                        {
                            string lastName1 = notebook.Value.GetSurName();
                            Console.WriteLine($"Запись №{notebook.Key} с фамилией: {lastName1}, именем: {notebook.Value.GetName()} " +
                                              $"и номером телефона: {notebook.Value.GetPhoneNumber()}");

                        }
                        Console.WriteLine("Если хотите продолжить работу введите цифру 1-5\n" +
                                          "иначе введите 6");
                        break;
                    case 6:
                        Console.WriteLine("Всего Доброго!");
                        break;
                }
            }

            



        }
       
    }

}
