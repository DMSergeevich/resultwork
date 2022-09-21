Console.Clear();
 Console.Write("Введите количество строк, которые хотите ввести: ");
            int n = Convert.ToInt32(Console.ReadLine()); // Считываем строку, переводим в число.
            string[] str1 = new string[n]; //Объявляем массив строк длиной n (которую ввёл пользователь)
            string[] str2 = new string[n]; //Объявляем пустой массив
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите строку №{0}:   ", i + 1);
                str1[i] = Console.ReadLine(); //Заполняем его  
                  string s = str1[i];   
                  if (s.Length<=3) 
                  {
                    str2[i] = s;   
                    count++;
                  }             
            }
            Console.Write("Массив из строк длинна которых меньше либо равна 3 символа :", count);
            Console.Write(count);
            for (int i = 0; i < n; i++)
            {               
                Console.WriteLine(str2[i]);                   
            }
            Console.Write("Нажмите [Enter] для выхода...");
            Console.ReadLine();