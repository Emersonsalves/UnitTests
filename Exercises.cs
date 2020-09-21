using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTests
{
    public class Exercises
    {
        // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 1A,
        // então a aplicação deverá retornar todos os números de 1 a 10 de forma crescente
        public int[] Exercise1A()
        {
            var numbers = new int[10];

            for (int counter = 1; counter < 11; counter++)
            {
				numbers[counter - 1] = counter;
            }

            return numbers;
        }

        // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 1b,
        // então a aplicação deverá retornar todos os números de 1 a 10 de forma decrescente
        public int[] Exercise1B()
        {
            int[] numbers = new int[10];
            
            for (int counter = 10; counter > 0; counter--)
            {
                numbers[numbers.Length - counter] = counter;
            }

            return numbers;
        }

        // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 1c,
        // então a aplicação deverá retornar os números de 1 a 10, mas somente os pares
        public int[] Exercise1C()
        {
            var numbers = new int[5];

            for (int counter = 2; counter < 11; counter+=2)
            {
                var index = (counter / 2) - 1;
				numbers[index] = counter;
            }

            return numbers;
        }

        // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 2,
        // então a aplicação deverá retornar a soma dos números inteiros de 1 à 100.   
        public int Exercise02()
        {
            var sum = 0;
            for (int counter = 1; counter <= 100; counter++)
            {
				sum += counter;
            }
            return sum;
        }

        // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 3,
        // então a aplicação deverá retornar todo os números ímpares menores de 200.
         public string Exercise03()
        {
            var odd = new StringBuilder();
            
            for (int i=1; i<=200; i++)
            {
                if (i % 2 != 0)
                {
                 odd.Append(i + ",");
                }
            }

            odd.Remove(odd.Length - 1, 1);
            return odd.ToString();
        }
        // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 4,
        // então a aplicação deverá retornar a méida de idade dos alunos na sala.

        public double Exercise04(List<int>users)
        {
            var sum = 0.0;
            foreach (var item in users)
            {
                sum +=item;
            }
                sum = sum/users.Count;
                return sum;
        }
            
        
    }
}