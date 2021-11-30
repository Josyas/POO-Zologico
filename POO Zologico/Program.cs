using System;
using System.Collections.Generic;

namespace POO_Zologico {
    class Program {
        static void Main(string[] args) {

            List<AnimalPlus> animais = new List<AnimalPlus>();
            int countCar = 0, countHer = 0;
            Console.WriteLine("Programa que conta quantos animais são carnívoros e herbìveros");
            for (int i = 0; i < 2; i++) {
                AnimalPlus animal = new AnimalPlus();
                Console.Write("Especie: ");
                animal.Especie = Console.ReadLine();
                Console.Write("Peso: ");
                animal.Peso = double.Parse(Console.ReadLine());
                Console.Write("Tipo alimentação: ");
                animal.TipoAlimentacao = Console.ReadLine();

                if (animal.TipoAlimentacao == "Carnivoro") {
                    //carnivoro
                    countCar++;
                }
                else {
                    countHer++;
                }
                animais.Add(animal);
            }
            Console.WriteLine("Total de animais carnivoros: " + countCar);
            Console.WriteLine("Total de animais herbivoros: " + countHer);
            Console.ReadKey();
            Console.WriteLine("teste");
            
        }
    }
}
