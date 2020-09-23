using System.Collections.Generic;
using Xunit;
using System.Linq;

namespace UnitTests
{
    public class ExercisesTest
    {
        [Fact]
        public void should_return_an_array_from_1_to_10()
        {
            // BDD - Behavior Driven Design
            // Dado, Quando, Deve

            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 1,
            // então a aplicação deverá retornar todos os número de 1 a 10

            // Dado / Setup
            var exercises = new Exercises();

            // Quando / Ação
            var result = exercises.Exercise1A();

            // Deve / Asserções
            var expectedOutput = new int[10]
            {
                1,2,3,4,5,6,7,8,9,10
            };

            for (int i = 0; i < expectedOutput.Length; i++)
            {
                Assert.Equal(expectedOutput[i], result[i]);
            }
            
        }

        [Fact]
        public void should_return_an_array_from_10_to_1()
        {
            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 1b,
            // então a aplicação deverá retornar todos os números de 1 a 10 de forma decrescente

            // Dado / Setup
            var exercises = new Exercises();

            // Quando / Ação
            int[] returnedValues = exercises.Exercise1B();

            // Deve / Asserções
            var expectedOutput = new int[10]
            {
                10,9,8,7,6,5,4,3,2,1
            };

            for (int i = 0; i < expectedOutput.Length; i++)
            {
                Assert.Equal(expectedOutput[i], returnedValues[i]);
            }
        }
        
        [Fact]
        public void should_return_an_array_from_1_to_10_but_only_even()
        {
            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 1c,
            // então a aplicação deverá retornar os números de 1 a 10, mas somente os pares

            // Dado / Setup
            var exercises = new Exercises();

            // Quando / Ação
            int[] returnedValues = exercises.Exercise1C();

            // Deve / Asserções
            var expectedOutput = new int[5]
            {
                2,4,6,8,10
            };

            Assert.Equal(5, returnedValues.Length);

            for (int i = 0; i < expectedOutput.Length; i++)
            {
                Assert.Equal(expectedOutput[i], returnedValues[i]);
            }
        }

        [Fact]
        public void should_return_a_sum_of_an_int_from_1_to_100_()
        {
            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 2,
            // A somatória deve retornar a soma dos números inteiros de 1 a 100 sendo o valor total de 5050.            

            // Dado / Setup
            var exercises = new Exercises();

            // Quando / Ação
            var returnedValues = exercises.Exercise02();

            // Deve / Asserções
            Assert.Equal(5050, returnedValues);

        }

        [Fact]
        public void should_return_odd_numbers_from_1_to_200()
        {
            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 3,
            // Devera retornar todos os números ímpares menores que 200            

            // Dado / Setup
            var exercises = new Exercises();

            // Quando / Ação
            var odd = "1,3,5,7,9,11,13,15,17,19,21,23,25,27,29,31,33,35,37,39,41,43,45,47,49,51,53,55,57,59,61,63,65,67,69,71,73,75,77,79,81,83,85,87,89,91,93,95,97,99,101,103,105,107,109,111,113,115,117,119,121,123,125,127,129,131,133,135,137,139,141,143,145,147,149,151,153,155,157,159,161,163,165,167,169,171,173,175,177,179,181,183,185,187,189,191,193,195,197,199";
            var result = exercises.Exercise03();

            // Deve / Asserções
            Assert.Equal(odd, result);
        }

        [Theory]
        [InlineData(new int[2]{18,22},20)]
        [InlineData(new int[5]{18,22,33,36,41},30)]

        public void Should_return_average(int[] users, double expected)
        {
            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 4,
            // então a aplicação deverá retornar a média de idade dos alunos na sala.
                
            var exercises = new Exercises();
                
            //Quando / Ação
            var returnedValue = exercises.Exercise04(users.ToList());
                
            // Deve / Asserções
            Assert.Equal(expected, returnedValue);
        }

        [Theory]
        [InlineData(new double[5]{45, 23, 14, 35, 18}, 60)]
        [InlineData(new double[8]{45, 23, 14, 35, 18, 89, 25, 32}, 62.5)]
        public void should_return_percentage_of_ages_between_18_and_35(double[] ages, double expected)
        {
            var exercises = new Exercises();

            double result = exercises.Exercise05(ages.ToList());

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(4, 23, 2.50, 4197.5)]
        public void should_return_4197_dot_5(double cigDay, double years, double price, double expected)
        {
            var exercises = new Exercises();

            var result = exercises.Exercise07(cigDay, years, price);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(6, new int[10]{6, 12, 18, 24, 30, 36, 42, 48, 54, 60})]
        [InlineData(5, new int[10]{5, 10, 15, 20, 25, 30, 35, 40, 45, 50})]
        public void should_return_the_input_multiplied_by_1_to_10(int number, int[] expectedResult)
        {
            // Dado / Setup
            var exercises = new Exercises();
            
            // Quando / Ação
            var result = exercises.Exercise17(number);

            // Deve / Asserções
            Assert.Equal(result, expectedResult);
        }


    }
}
