using System;
namespace DZ4
{
	public class Number
	{

		public void isNumber(int[] arr)
		{
            int number;
            List<int> list = new List<int>(arr);
            Console.Write("Введите число: ");
            string word = Console.ReadLine();
            if (int.TryParse(word, out int result))
            {
                number = result;
                FindNumbers(number, list);
            }
            else
            {
                isNumber(arr);
            }
        }


        public void FindNumbers(int num, List<int> list)
        {
            //{ 7, 5, 1, 3, 2, 5, 8, 2, 4, 5, 6, 9, 0, 12, 65, 7, 23 };
            int count = 0;
            while (list.Count>2)
            {
                int x = list[0];
                list.RemoveAt(0);
                for (int i = 0; i < list.Count; i++)
                {
                    if (list.Contains(num-(x + list[i]))
                        && list.IndexOf(list[i]) != list.IndexOf(num - (x + list[i])))
                    {
                        Console.WriteLine($"{num} = {x} + {list[i]} + {num - (x + list[i])}");
                        count++;
                    }
                }

            }
            if(count ==0)
            {
                Console.WriteLine("Не найдено");
            }
            Console.ReadKey();

        }
    }
}

