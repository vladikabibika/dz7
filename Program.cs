namespace lesson6.c_
{


    }
    internal class Program
    {
    interface ICalc
    {
        int Less(int valueToCompare);
        int Greater(int valueToCompare);
    }
    class Array : ICalc
    {
        private int[] numbers;   

   
        public Array(int[] numbers)
        {
            this.numbers = numbers;
        }

      
        public int Less(int valueToCompare)
        {
            int count = 0;
            foreach (int num in numbers)
            {
                if (num < valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }

        
        public int Greater(int valueToCompare)
        {
            int count = 0;
            foreach (int num in numbers)
            {
                if (num > valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }
    }
    static void Main(string[] args)
    {
        // Створіть інтерфейс ICalc.
        // У ньому має бути два методи:
        // int Less(int valueToCompare) — повертає кількість
        // значень менших, ніж valueToCompare;
        // int Greater(int valueToCompare) — повертає кількість
        // значень більших, ніж valueToCompare.
        // Клас, створений раніше в практичному завданні Array,
        // має імплементувати інтерфейс ICalc.
        // Метод Less —  повертає кількість елементів масиву
        // менших, ніж valueToCompare.
        // Метод Greater — повертає кількість елементів масиву
        // більших, ніж valueToCompare.
        // Напишіть код для тестування отриманої
        // функціональності.
        int[] nums = { 1, 5, 8, 3, 10 };
        Array arr = new Array(nums);

        Console.WriteLine("Количество чисел меньших за 5: " + arr.Less(5));
        Console.WriteLine("Количество чисел больших за 5: " + arr.Greater(5));
        


    }
    
}
