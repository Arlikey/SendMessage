using System.Threading.Channels;

namespace SendMessage
{
    /*internal class Program
    {
        static void Main(string[] args)
        {
            
            Message message = new Message(SendMessage);
            message.SendMessage("Внимание!", "Спасибо за внимание!");
        }

        public static void SendMessage(string title, string message)
        {
            Console.WriteLine($"Сообщение:\n\tНазвание: {title}\n\tТекст: {message}");
        }

        public class Message
        {
            public delegate void MessageHandler(string title, string message);
            public MessageHandler messageHandler;

            public Message(MessageHandler messageHandler)
            {
                this.messageHandler = messageHandler;
            }

            public void SendMessage(string title, string message)
            {
                messageHandler?.Invoke(title, message);
            }
        }
    }*/

    /*public class AdditionalTask1
    {
        public delegate void Do(ref (int Id, string FullName)[] values);

        enum Actions
        {
            Info = 1,
            FindById,
            EditingById,
            RemovingById,
            ClearScreen,
            Exit = 0
        }
        static void Main(string[] args)
        {
            (int Id, string FullName)[] personal = {
                (1, "John Bobinson"),
                (2, "Oleg Johnson")
            };

            int userChoice = 1;

            Actions actions;

            while (userChoice != 0)
            {
                Console.Write("Выберите действие:\n1. Просмотреть персонал.\n2. Найти по Id.\n3. Редактировать по Id.\n4. Удалить по Id\n5. Очистить консоль\n0. Выход\n-> ");
                userChoice = int.Parse(Console.ReadLine());

                actions = (Actions)userChoice;

                switch (actions)
                {
                    case Actions.Info:
                        TakeAction(ref personal, Info);
                        break;
                    case Actions.FindById:
                        TakeAction(ref personal, FindById);
                        break;
                    case Actions.EditingById:
                        TakeAction(ref personal, EditingById);
                        break;
                    case Actions.RemovingById:
                        TakeAction(ref personal, RemovingById);
                        break;
                    case Actions.ClearScreen:
                        Console.Clear();
                        break;
                    case Actions.Exit:
                        return;
                    default:
                        Console.WriteLine("Введено неверное действие!");
                        break;
                }
            }
        }

        public static void TakeAction(ref (int Id, string FullName)[] values, Do doAction)
        {
            doAction(ref values);
        }

        public static void Info(ref (int Id, string FullName)[] values)
        {
            foreach (var value in values)
            {
                Console.WriteLine(value);
            }
        }

        public static void FindById(ref (int Id, string FullName)[] values)
        {
            Console.Write("Введите Id для поиска: ");
            int seekId = int.Parse(Console.ReadLine());
            foreach (var value in values)
            {
                if (value.Id.Equals(seekId))
                {
                    Console.WriteLine(value);
                }
            }
        }

        public static void EditingById(ref (int Id, string FullName)[] values)
        {
            Console.Write("Введите Id для поиска: ");
            int seekId = int.Parse(Console.ReadLine());
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i].Id.Equals(seekId))
                {
                    Console.Write("Укажите новый Id: ");
                    values[i].Id = int.Parse(Console.ReadLine());
                    Console.Write("Укажите новое ФИО: ");
                    values[i].FullName = Console.ReadLine();
                }
            }
        }

        public static void RemovingById(ref (int Id, string FullName)[] values)
        {
            Console.Write("Введите Id для удаления: ");
            int seekId = int.Parse(Console.ReadLine());

            int count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i].Id.Equals(seekId))
                {
                    count++;
                }
            }

            var newValues = new (int Id, string FullName)[count];

            for (int i = 0, j = 0; i < values.Length; i++)
            {
                if (values[i].Id.Equals(seekId))
                {
                    continue;
                }
                newValues[j++] = values[i];
            }

            values = newValues;
        }
    }*/

    /*public class AdditionalTask2
    {
        static void Main(string[] args)
        {
            Ping ping = new Ping(ConsolePing);
            Pong pong = new Pong(ConsolePong);

            ping.PlayPing();
            pong.PlayPong();
        }

        public static void ConsolePing(string message)
        {
            Console.WriteLine(message);
        }

        public static void ConsolePong(string message) 
        { 
            Console.WriteLine(message); 
        }

        public class Ping
        {
            public delegate void PingHandler(string message);
            public PingHandler Handler;

            public Ping(PingHandler handler) { Handler = handler; }

            public void PlayPing()
            {
                Handler?.Invoke("Ping received Pong");
            }
        }

        public class Pong
        {
            public delegate void PongHandler(string message);
            public PongHandler Handler;

            public Pong(PongHandler handler) { Handler = handler; }

            public void PlayPong()
            {
                Handler?.Invoke("Pong received Ping");
            }
        }
    }*/

    /*public class AdditionalTask3
    {
        public delegate double RadiusOperations(double R);
        static void Main(string[] args)
        {
            RadiusOperations radiusOperations = CircleLength;

            Console.WriteLine($"Circle Length with radius 5: {radiusOperations(5)}");

            radiusOperations += CircleSquare;

            Console.WriteLine($"Circle Square with radius 5: {radiusOperations(5)}");

            radiusOperations += BallVolume;

            Console.WriteLine($"Ball Volume with radius 5: {radiusOperations(5)}");
        }

        public static double CircleLength(double R)
        {
            return 2 * Math.PI * R;
        }

        public static double CircleSquare(double R)
        {
            return Math.PI * Math.Pow(R, 2);
        }

        public static double BallVolume(double R)
        {
            return ((double)4 / 3) * Math.PI * Math.Pow(R, 3);
        }
    }*/

    /*public class AdditionalTask4
    {
        public delegate string StringOperations(string text);
        static void Main(string[] args)
        {
            StringOperations stringOperations = ReplaceSpaces;

            Console.WriteLine(stringOperations("Hello World!"));

            stringOperations += DeleteFirstWord;

            Console.WriteLine(stringOperations("Hello World!"));
        }

        public static string ReplaceSpaces(string text)
        {
            return text.Replace(' ', ',');
        }

        public static string DeleteFirstWord(string text)
        {
            int spaceIndex = text.IndexOf(' ');

            if(spaceIndex != -1)
            {
                return text.Remove(0, spaceIndex);
            }

            return text;
        }
    }*/

    /*public class AdditionalTask5
    {
        public delegate int[] Find(int[,] array);
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nMAX SUM ARRAY\n");

            Find find = FindRowWithMaxSum;

            int[] maxArray = find(new int[,] { { 1, 2, 3 }, { 3, 4, 5 }, { 1, 5, 2 } });

            for (int i = 0; i < maxArray.Length; i++)
            {
                Console.Write(maxArray[i] + " ");
            }

            Console.WriteLine("\n\nMIN SUM ARRAY\n");

            find += FindRowWithMinSum;

            int[] minArray = find(new int[,] { { 1, 2, 3 }, { 3, 4, 5 }, { 1, 5, 2 } });

            for (int i = 0; i < minArray.Length; i++)
            {
                Console.Write(minArray[i] + " ");
            }
        }

        public static int[] FindRowWithMaxSum(int[,] array)
        {
            int rowIndex = 0;
            int max = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                int currentMax = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == 0)
                    {
                        max += array[i, j];
                        continue;
                    };
                    currentMax += array[i, j];
                }
                if (max < currentMax)
                {
                    max = currentMax;
                    rowIndex = i;
                }
            }

            int[] maxRowArray = new int[array.GetLength(1)];

            for (int i = 0; i < array.GetLength(1); i++)
            {
                maxRowArray[i] = array[rowIndex, i];
            }

            return maxRowArray;
        }

        public static int[] FindRowWithMinSum(int[,] array)
        {
            int rowIndex = 0;
            int min = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                int currentMin = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == 0)
                    {
                        min += array[i, j];
                        continue;
                    };
                    currentMin += array[i, j];
                }
                if (min > currentMin)
                {
                    min = currentMin;
                    rowIndex = i;
                }
            }

            int[] minRowArray = new int[array.GetLength(1)];

            for (int i = 0; i < array.GetLength(1); i++)
            {
                minRowArray[i] = array[rowIndex, i];
            }

            return minRowArray;
        }
    }*/
}
