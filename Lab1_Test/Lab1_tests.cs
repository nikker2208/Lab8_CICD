namespace Lab1_Test
{
    public class Tests
    {
        [Test]
        public void Sort_Test()
        {
            //arrange
            int[] arr1 = { 1, 7, 6, 20, 10};
            int[] expected = { 1, 6, 7, 10, 20};
            //act
            int[] actual = lab1.BubbleSort(arr1);
            //assert
            Assert.That(actual, Is.EqualTo(expected));

        }
        [Test]
        public void Sort_Test2()
        {
            //arrange
            int[] arr1 = {};
            int[] expected = {};
            //act
            int[] actual = lab1.BubbleSort(arr1);
            //assert
            Assert.That(actual, Is.EqualTo(expected));

        }
        [Test]
        public void IsPalidrom_Test()
        {
            //arrange
            string word = "шабаш";
            bool expected = true;
            //act
            bool actual = lab1.IsPalindrome(word);
            //assert
            Assert.That(actual, Is.EqualTo(expected));

        }
        [Test]
        public void IsPalidrom_Test2()
        {
            //arrange
            string word = "конь";
            bool expected = false;
            //act
            bool actual = lab1.IsPalindrome(word);
            //assert
            Assert.That(actual, Is.EqualTo(expected));

        }
        [Test]
        public void factorial_test()
        {
            //arrange
            int a = 5;
            int expected = 120;
            //act
            int actual = lab1.Factorial(a);
            //assert
            Assert.That(actual, Is.EqualTo(expected));

        }
        [Test]
    
        public void factorial_test2()
        {
            //arrange
            int a = -3;

            
            //act - assert
            Assert.Throws<ArgumentException>(() => lab1.Factorial(a));

        }
        [Test]
        public void fibonachi_test()
        {
            //arrange
            int a = 10;
            int expected = 55;
            //act
            int actual = lab1.Fibonacci(a);
            //assert
            Assert.That(actual, Is.EqualTo(expected));

        }
        [Test]
        public void fibonachi_test2()
        {
            //arrange
            int a = 2;
            int expected = 1;
            //act
            int actual = lab1.Fibonacci(a);
            //assert
            Assert.That(actual, Is.EqualTo(expected));

        }
        [Test]
        public void fibonachi_test3()
        {
            //arrange
            int a = -3;


            //act - assert
            Assert.Throws<ArgumentException>(() => lab1.Fibonacci(a));

        }
        [Test]
        public void pow_test()
        {
            //arrange
            //arrange
            double a = 4.2;
            double b = 2.4;
            double expected = 31.31830843906927d;

            //act
            double actual = lab1.Pow(a, b);

            //assert
            Assert.That(actual, Is.EqualTo(expected));

        }
        [Test]
        public void pow_test2()
        {
            //arrange
            int a = 2;
            int b = 2;
            int expected = 4;

            //act
            int actual = (int)lab1.Pow(a, b);

            //assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void isprimenumber_test()
        {
            //arrange
            int a = 5;
            bool expected = true;

            //act
            bool actual = lab1.IsPrimeNumber(a);

            //assert
            Assert.That(actual, Is.EqualTo(expected));

        }
        [Test]
        public void isprimenumber_test2()
        {
            //arrange
            int a = 0;
            bool expected = false;

            //act
            bool actual = lab1.IsPrimeNumber(a);

            //assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void isprimenumber_test3()
        {
            //arrange
            int a = 6;
            bool expected = false;

            //act
            bool actual = lab1.IsPrimeNumber(a);

            //assert
            Assert.That(actual, Is.EqualTo(expected));
        }

    }
}