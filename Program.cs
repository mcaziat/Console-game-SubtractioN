using System;

namespace Home_3_Game
{
    class Program
    {      
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать \n\"ИГРА НА ВЫЧЕТАНИЕ\"");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine(" Правила игры: " +
                              "\n Система загадывает число от 12 до 120. Или же вы задаете его в ручную в зависимости от версии игры" +
                              "\n Игроки по очереди выбирают число от одного до четырёх. Или же из выбранного диапазона" +
                              "\n После каждого хода число игрока вычитается из числа Системы" +
                              "\n Если после хода игрока число Системы равняется нулю, то походивший игрок оказывается победителем.");
            Console.ReadKey();

            Console.Clear();

            #region Игра №1 только на двоих с реваншом
            ////КОД ДЛЯ ИГРЫ НА ДВОИХ//
            //Console.Write("Игрок №1 введите свое имя: ");
            //string Player1 = Console.ReadLine();
            //Console.WriteLine($"Приятно познакомиться {Player1} ");


            //Console.Write("Игрок №2 введите свое имя: ");
            //string Player2 = Console.ReadLine();
            //Console.WriteLine($"Приятно познакомиться {Player2} ");

            //Console.ReadKey();
            //Console.Clear();

            //Random rand = new Random();
            //int userTry;
            //bool game = true; 


            //while (game)
            //{
            //    int gameNumber = rand.Next(12, 121); // - диапазон чисел системы от 12 до 120
            //    Console.WriteLine($"Система выбрало число : {gameNumber}");

            //    while (gameNumber != 0)
            //    {
            //        //ВВОД ИГРОВЫХ ДАННЫХ ПЕРВЫМ ИГРОКОМ
            //        Console.WriteLine($"Сейчас ход игрока {Player1} . Выберите число от 1 до 4 ");
            //        userTry = Convert.ToInt32(Console.ReadLine());

            //        //ЦИКЛ НА ЗАДАННЫЙ ДИАПАЗОН ЧИСЕЛ
            //        while (userTry <= 0 || userTry > 4)
            //        {
            //            Console.WriteLine("Вы ввели недопустимое число, помни от 1 до 4, еще раз:");
            //            userTry = Convert.ToInt32(Console.ReadLine());
            //        }
            //        gameNumber = gameNumber - userTry;
            //        Console.WriteLine($"До конца игры остало {gameNumber}");

            //        if (gameNumber <= 0)
            //        {
            //            Console.WriteLine($"Поздравляю {Player1}, Вы победили");
            //            break;
            //        }
            //        //ВВОД ИГРОВЫХ ДАННЫХ ВТОРЫМ ИГРОКОМ
            //        Console.WriteLine($"Сейчас ход игрока {Player2} . Выберите число от 1 до 4 ");
            //        userTry = Convert.ToInt32(Console.ReadLine());

            //        //ЦИКЛ НА ЗАДАННЫЙ ДИАПАЗОН ЧИСЕЛ
            //        while (userTry <= 0 || userTry > 4)
            //        {
            //            Console.WriteLine("Вы ввели недопустимое число, помни от 1 до 4, еще раз:");
            //            userTry = Convert.ToInt32(Console.ReadLine());
            //        }
            //        gameNumber = gameNumber - userTry;
            //        Console.WriteLine($"До конца игры остало {gameNumber}");

            //        if (gameNumber <= 0)
            //        {
            //            Console.WriteLine($"Поздравляю {Player2}, Вы победили");
            //            break;
            //        }
            //    }
            //    if (gameNumber <= 0)
            //    {
            //        Console.WriteLine("Игра окончена, спасибо за участие");
            //    }

            //    //ДЛЯ ПОВТОРНОГО ЗАПУСК ИГРЫ
            //    Console.WriteLine("Хотите взять реванш и начать занового? 0 - да ; 1 - нет");
            //    int select = Convert.ToInt32(Console.ReadLine());

            //    if (select == 0)
            //    {
            //        game = true;
            //    }
            //    else 
            //    {
            //        game = false;
            //    }
            //}
            #endregion

            #region Игра №2 на двоих или с компьютером + реванш + ручной userTry + ручной gameNumber
            //string solo = "Игрок";
            //string gamer0 = "Бот"; // для компьютера
            //string gamer1 = ""; // игрок 1
            //string gamer2 = ""; // игрок 2
            //string currentGamer = ""; //текущий игрок
            //int flag = 0; // счетчик для игрока
            //int userTry = 0; // ход игрока
            //int select;
            //bool game = true;
            //Random rand = new Random(); // рандомное число для компьютера

            //while (game)
            //{
            //    Console.WriteLine("Вы планируете играть с другом или вам нужен соперник? 0 - вдвоем с другом, 1 - компьютер");
            //    int gameMode = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Ввидите ваше 'Игровое число': ");
            //    int gameNumber = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Установите уровень сложности выбрав минимальный шаг хода - ");
            //    int minStep = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Установите уровень сложности выбрав максимальный шаг хода - ");
            //    int maxStep = int.Parse(Console.ReadLine());

            //    if (gameMode == 0) //режим игры с другом
            //    {
            //        Console.WriteLine("Игрок №1, назовите свое имя: ");
            //        gamer1 = Console.ReadLine();
            //        Console.WriteLine($"Приятно познакомиться, {gamer1}");

            //        Console.WriteLine("Игрок №2, назовите свое имя: ");
            //        gamer2 = Console.ReadLine();
            //        Console.WriteLine($"Приятно познакомиться, {gamer2}");

            //        Console.ReadKey();
            //        Console.Clear();

            //        Console.WriteLine($"Ваше игровое число - {gameNumber}");

            //        Console.ReadKey();
            //        Console.Clear();

            //        while (gameNumber != 0) // цикл для ходов игроков
            //        {
            //            switch (flag) //оператор для очередности хода
            //            {
            //                case 0:
            //                    currentGamer = gamer1;
            //                    break;
            //                case 1:
            //                    currentGamer = gamer2;
            //                    break;
            //            }
            //            Console.WriteLine($"Сейчас ходит {currentGamer}, выберите число: ");
            //            userTry = int.Parse(Console.ReadLine());

            //            while (userTry <= minStep || userTry > maxStep)
            //            {
            //                Console.WriteLine($"Вы ввели недопустимое число, помни от {minStep} до {maxStep}, еще раз:");
            //                userTry = int.Parse(Console.ReadLine());
            //            }

            //            Console.WriteLine($"{currentGamer} сделал ход - {userTry}");

            //            gameNumber -= userTry;

            //            if (gameNumber <= 0)
            //            {
            //                Console.WriteLine($"Конец игры, поздравляю {currentGamer}, Вы победили!!!");
            //                break;
            //            }

            //            flag++;
            //            if (flag > 1) flag = 0; //счетчик игрока зацикленный

            //        }

            //        if (gameNumber <= 0)
            //        {
            //            Console.WriteLine("Игра окончена, спасибо за участие");
            //        }

            //        Console.ReadKey();
            //        Console.Clear();

            //        Console.WriteLine("Хотите взять реванш и начать занового? 0 - да ; 1 - нет");
            //        select = Convert.ToInt32(Console.ReadLine());

            //        if (select == 0)
            //        {
            //            game = true;
            //        }
            //        else
            //        {
            //            game = false;
            //        }
            //    }

            //    if (gameMode == 1)  // режим игры с ботом
            //    {

            //        Console.WriteLine($"Ваше игровое число - {gameNumber}");

            //        while (gameNumber != 0) //цикл на игру
            //        {
            //            switch (flag) // кейс на имена 
            //            {
            //                case 0:
            //                    currentGamer = gamer0;
            //                    break;
            //                case 1:
            //                    currentGamer = solo;
            //                    break;
            //            }

            //            Console.WriteLine($"Сейчас ходит {currentGamer}");
            //            if (flag == 0) // оператор 
            //            {
            //                userTry = rand.Next(minStep, maxStep);
            //                Console.WriteLine($"Прекрасно, {currentGamer} сделал ход - {userTry}");
            //                gameNumber -= userTry;
            //            }
            //            else
            //            {
            //                userTry = int.Parse(Console.ReadLine());
            //                while (userTry <= minStep || userTry > maxStep)
            //                {
            //                    Console.WriteLine($"Вы ввели недопустимое число, помни от {minStep} до {maxStep}, еще раз:");
            //                    userTry = int.Parse(Console.ReadLine());
            //                }
            //                gameNumber -= userTry;
            //            }

            //            flag++;
            //            if (flag > 1) flag = 0;

            //            if (gameNumber <= 0)
            //            {
            //                Console.WriteLine($"Конец игры, поздравляю победил : {currentGamer}!!!");
            //                break;
            //            }

            //        }

            //    }
            //    if (gameNumber <= 0)
            //    {
            //        Console.WriteLine("Игра окончена, спасибо за участие");
            //    }

            //    Console.ReadKey();
            //    Console.Clear();

            //    Console.WriteLine("Хотите взять реванш и начать занового? 0 - да ; 1 - нет");
            //    select = Convert.ToInt32(Console.ReadLine());

            //    if (select == 0)
            //    {
            //        game = true;
            //    }
            //    else
            //    {
            //        game = false;
            //    }
            //}
            #endregion

            #region Игра №3 Тоже что и вторая версия, только короче
            string gamer0 = "Бот"; // компьютер
            string gamer1 = ""; // игрок 1
            string gamer2 = ""; // игрок 2
            string currentGamer = ""; //текущий игрок
            int flag = 0; // счетчик для игрока     
            int userTry; // ход игрока
            int select;
            bool game = true;
            Random rand = new Random(); // рандомное число для компьютера

            while(game)
            {
                Console.WriteLine("Прошу Вас выбрать режим игры: 0 - вдвоем с другом, 1 - я против Бота");
                int gameMode = int.Parse(Console.ReadLine());

                if (gameMode == 0)
                {
                    Console.WriteLine("Игрок №1, назовите свое имя: ");
                    gamer1 = Console.ReadLine();
                    Console.WriteLine($"Приятно познакомиться, {gamer1}");

                    Console.WriteLine("Игрок №2, назовите свое имя: ");
                    gamer2 = Console.ReadLine();
                    Console.WriteLine($"Приятно познакомиться, {gamer2}");

                    flag = 1;
                    
                }
                else if (gameMode == 1)
                {
                    Console.WriteLine("Ну, с Ботом так с Ботом ... удачи :D");

                    flag = 0;
                    
                }

                Console.WriteLine("Ввидите ваше 'Игровое число': ");
                int gameNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Установите уровень сложности выбрав минимальный шаг хода - ");
                int minStep = int.Parse(Console.ReadLine());

                Console.WriteLine("Установите уровень сложности выбрав максимальный шаг хода - ");
                int maxStep = int.Parse(Console.ReadLine());

                while (gameNumber != 0)
                {
                    switch (flag)
                    {
                        case 0:
                            currentGamer = gamer0;
                            break;
                        case 1:
                            currentGamer = gamer1;
                            break;
                        case 2:
                            currentGamer = gamer2;
                            break;
                    }
                    Console.WriteLine($"Сейчас ходит Игрок {currentGamer}");

                    if (flag == 0) // оператор 
                    {
                        userTry = rand.Next(minStep, maxStep);
                        Console.WriteLine($"Прекрасно, {currentGamer} сделал ход - {userTry}");
                        gameNumber -= userTry;
                    }
                    else if (flag == 1 | flag == 2)
                    {
                        userTry = int.Parse(Console.ReadLine());
                        while (userTry <= minStep || userTry > maxStep)
                        {
                            Console.WriteLine($"Вы ввели недопустимое число, помни от {minStep} до {maxStep}, еще раз:");
                            userTry = int.Parse(Console.ReadLine());
                        }
                        gameNumber -= userTry;
                    }

                    flag++;
                    if(gameMode == 1)
                    {
                        if (flag > 1) flag = 0;
                    }
                    else if (gameMode == 0)
                    { 
                        if (flag > 2) flag = 1; 
                    }                                           

                }
                if (gameNumber <= 0)
                {
                    Console.WriteLine("Игра окончена, спасибо за участие");
                }

                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Хотите взять реванш и начать занового? 0 - да ; 1 - нет");
                select = Convert.ToInt32(Console.ReadLine());

                if (select == 0)
                {
                    game = true;
                }
                else
                {
                    game = false;
                }
            }
            #endregion



        }

    }
}
