﻿using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada kasutajatunnus ja salasõna;
            //kui sisestatud kasutajatunnus on "admin" ja sisestatud salasõna on "admin1234";
            //siis konsoolis kuvatakse "Tere tulemast!";
            //muul juhul konsoolis kuvatakse "Vale kasutajatunnus või salasõna. Proovi uuesti.";
            //kasutal on kokku kolm katset;
            //esimesel, teisel ja kolmandal katsel "Tere tulemast!";
            //kui esimene, teine ja kolmas katse läks valesti "Vale kasutajatunnus või salasõna. Proovi uuesti.! ;

            int i = 0;


            while (i < 3)
            {
                Console.WriteLine("Sisesta kasutajatunnus:");
                string userName = Console.ReadLine();
                Console.WriteLine("Sisesta salasõna:");
                string userPassword = Console.ReadLine();


                if (userName == "admin" && userPassword == "admin1234")
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                else
                {

                    i++;
                    Console.WriteLine("Vale kasutajatunnus või salasõna. Proovi uuesti.");
                    Console.WriteLine($"Sul on jaanud {3 - i} katset.");
                }
            }
        }
    }
}
