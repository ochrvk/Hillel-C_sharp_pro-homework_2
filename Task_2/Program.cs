/*
 Завдання 2 (ООП)

    Створити базовий клас «Музичний інструмент» і похідні класи: «Скрипка», «Тромбон», «Укулеле», «Віолончель». 

    За допомогою конструктора, встановити назву до кожного музичного інструменту і його характеристики. 

    Реалізуйте для кожного з класів методи:

    ■ Sound — видає звук музичного інструменту (пишемо текстом у консоль); 

    ■ Show — відображає назву музичного інструменту; 

    ■ Desc — відображає опис музичного інструменту; 

    ■ History — відображає історію створення музичного інструменту.

    Додати iнкапсуляцiю до полiв та методiв якщо треба.
*/


using Task_2;

Violin violin = new Violin();


violin.Sound();
Console.WriteLine("-----");
violin.Show();
Console.WriteLine("-----");
violin.Desc();
Console.WriteLine("-----");
violin.History();
Console.WriteLine("-----");


Trombone trombone = new Trombone();


trombone.Sound();
Console.WriteLine("-----");
trombone.Show();
Console.WriteLine("-----");
trombone.Desc();
Console.WriteLine("-----");
trombone.History();
Console.WriteLine("-----");

Ukulele ukulele = new Ukulele();

ukulele.Sound();
Console.WriteLine("-----");
ukulele.Show();
Console.WriteLine("-----");
ukulele.Desc();
Console.WriteLine("-----");
ukulele.History();
Console.WriteLine("-----");



Cello cello = new Cello();

cello.Sound();
Console.WriteLine("-----");
cello.Show();
Console.WriteLine("-----");
cello.Desc();
Console.WriteLine("-----");
cello.History();
Console.WriteLine("-----");

