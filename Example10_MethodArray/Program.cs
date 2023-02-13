int[] array = {1,12,31,4,18,15,16,17,18};

// Lentch - команда, которая запрашивает длинну массива (кол-во элементов)
int n = array.Length;
int find = 18;
int index = 0;

while (index < n)
{
   if (array[index] == find)
   {
       Console.WriteLine(index); 
       break; // прерывание цикла, в случае обнаружения элемента равного find
   } 
   // index = index + 1;
   index++; 
}
