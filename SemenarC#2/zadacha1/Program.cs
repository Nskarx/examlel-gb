﻿// цикл это повторяющаясяя последовательность действий (for- счетный цикл foreach /while -Условный цикл      do.while  )

//for(int i = 1; i < 10; i++) // либо i = i+i или i+=i
//{
     //Console.WriteLine($"{i + 10} - я всегда прав");
//}

int k = 0;
while(k < 10 || k < 20)  // || -or(или)  &&-end
{
     k += 2;
    if(k == 8)
    {
      break;  //   continue это переход от сюда в начало break; - окончание
    }
    
     Console.WriteLine($"{k} - я всегда прав ");
}