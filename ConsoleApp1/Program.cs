﻿using ConsoleApp1;
using System;

class Program
{
    static void Main()
    {
        
        Ihlican strom = new Ihlican(5,7);
        Console.WriteLine("Objem ihlicnanu: " + strom.objem);
        Baobap strom1 = new Baobap(5,7);
        Console.WriteLine("Objem Baobapu: " + strom1.objem);
        Listnaty strom2 = new Listnaty(5,7);
        Console.WriteLine("Objem Listnateho: " + strom1.objem);

        Console.ReadKey();
    }
}