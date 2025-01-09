using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

/*
//Пример окна с полем ввода 

using Microsoft.VisualBasic;

class InputDialogDemo
{
    static void Main()
    {
// Текстовая переменная: 
        string name;
// Отображение окна с полем ввода: 
        name = Interaction.InputBox(
            "Как Вас зовут?", // Текст над полем ввода 
            "Давайте познакомимся ... " // Название окна 
        );
// Еще одна текстовая переменная: 
        string txt = "Очень приятно, " + name + "!";
// Окно с сообщением: 
        MessageBox.Show(txt, "Знaкoмcтвo состоялось");
    }
}
*/

// Пример считывания чисел
/*
using Microsoft.VisualBasic;

class Enteringinteger
{
    static void Main()
    {
// Текстовые переменные: 
        string res, txt;
// Целочисленные переменные: 
        int year = 2024, age, born;
// Отображение окна с полем ввода: 
        res = Interaction.InputBox("B каком году Вы родились?", "Год рождения");
// Преобразование текста в число: 
        born = Int32.Parse(res);
// Вычисление возраста: 
        age = year - born;
        txt = "Тогда Вам " + age + " лет";
// Окно с сообщением: 
        MessageBox.Show(txt, "Boзpacт");
    }
}
*/

// Задачи для тренировки
/*Напишите программу, в которой пользователь вводит сначала имя,
    а затем фамилию. Программа выводит сообщение с информацией
    об имени и фамилии пользователя. Предложите версию программы,
    в которой ввод и вывод текста осуществляется с помощью диалоговых
окон. Также предложите консольную версию программы. */
/*
class Lesson1
{
    static void Main()
    {
        string name1, name2;
        name1 = Interaction.InputBox(
            "Введите ваше имя",
            "Знакомство");

        name2 = Interaction.InputBox(
            "Введите вашу фамилию",
            "Знакомство");

        string txt = "Очень приятно, " + name1 + " " + name2 + "!";
        MessageBox.Show(txt, "Знакомство состоялось");
    }
}

*/

/*Напишите программу, в которой пользователь вводит имя и возраст.
    Программа отображает сообщение об имени и возрасте пользователя.
    Предложите консольную версию программы и версию, в которой данные вводятся и выводятся с помощью диалоговых окон.
    */
/*class Lesson2
{
    static void Main()
    {
        string txt, res, name;

        name = Interaction.InputBox(
            "Введите ФИО",
            "Знакомство");

        int year = 2024, age, born;

        res = Interaction.InputBox("В каком году вы родились?", "Год рождения");
        born = int.Parse(res);
        age = year - born;
        txt = "" + name + " вам " + age + "лет";

        MessageBox.Show(txt, "Знакомство");
    }
}
*/