int[] array={1, 45, 5, 34, 5, 2, 45, 34, 33};
int n = array.Length; 
int index = 0;
int find = 34;
while (index < n )
{
    if (array[index] == find)
   
{
     Console.WriteLine(index);
     break;     
}

    index = index+1;
}

