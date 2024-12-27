namespace _0._2._1_Arrays_Operations
{
    public class Read
    {
        int[] numeros;

        public Read() => numeros = [1,2,3,4,5,6,7,8,9];

        public void ReadArray()
        {
            for (int i = 0; i < numeros.Length; i++) 
                Console.WriteLine(numeros[i]);
        }
         
    }
}
