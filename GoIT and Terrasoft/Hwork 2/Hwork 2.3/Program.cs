﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5, y = 12, z = 2;

            int result = (x++ - --y + --x<<z++) * (x + y + z);

            //int result = (y++ + --y );
            //5 - 11 + 5<<2

            Console.WriteLine(result);
            //Получаем результат равный (-76)
            //Как это получилось по этапам: 
            //1. Компилятор выполняет действие в одних и вторых скобках и получаем (x++ - --y + --x<<z++) * 19
            //2. Выполняя действие во вторых скобка компилятор в приоритете инициализирует постфикс получаем (5 - --y + --x << 2)*19
            //3. Следующее действие это операции с префиксными оператарами (5 - 11 + 5<<2), 
            //но как я понял переменная x = 5 в выражении к примеру (х++ + --х) = 10, 
            //т.е. постфикс инкремент + префикс дикремент для одного значения переменной получится не изменное значение переменной"
            //4. (-1<<2)*19 = -4 * 19 = -76
            Console.ReadKey();
        }
    }
}
