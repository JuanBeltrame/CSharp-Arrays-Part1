namespace ClassLibrary1
{
    public class Class1
    {
        public static void TraverseAndReadArray(int[] nums)
        {
            Console.Write($"The Elements are: ");
            for (int i = 0; i < nums.Length; i++)
                Console.Write($" {nums[i]} ");
        }

        public static void TraverseAndWriteArray(int[] nums, int[] valuesToWrite)
        {
            Console.Write($"Se escribieron en el array los siguientes valores: ");
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = valuesToWrite[i];
                Console.Write($" {nums[i]} ");
            }

        }
    }
}
