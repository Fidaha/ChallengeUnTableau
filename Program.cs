namespace ChallengeUnTableau;

class Program
{
    static void Main(string[] args)
    {
        // Crée trois tableaux qui contiennent le même type de données, deux de même taille, un qui a le double de la taille des deux précédents 
        int[] array1 = new int[5] { 1, 2, 3, 4, 5 };
        int[] array2 = new int[5] { 6, 7, 8, 9, 10 };
        //int[] array3 = new int[10];
        int[] array3 = new int[array1.Length + array2.Length];

        // Met à la suite les deux premiers tableaux dans le plus grand
        array1.CopyTo(array3, 0);
        array2.CopyTo(array3, array1.Length);

        foreach(var i in array3) 
        {
            Console.WriteLine(i);
        }

        
    }
}
