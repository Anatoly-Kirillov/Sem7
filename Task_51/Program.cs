// Задайте двумерный массив.Найдите сумму элементов, 
//находящихся на главной диагонали(с индексами(0,0);(1,1) и т.д.)
void diagonalArrayElementsSumm (int[,] collection2)
{
    int diagonalPosition = 0;
    int Summ = 0; 
    for (diagonalPosition = 0; diagonalPosition < collection2.GetLength(0); diagonalPosition++)
    {
        {
           Summ = Summ + collection2[diagonalPosition, diagonalPosition];
        }   
    }
    Console.WriteLine ($"Сумма диагональных элементов массива равна {Summ}");
}
