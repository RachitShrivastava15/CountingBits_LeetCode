namespace CountingBits
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 2;
            var arr = new int[num+1];
            arr[0] = 0;
            
            for(int i = 1; i<= num; i++)
            {
                if(i%2 == 0)
                {
                    arr[i] = arr[i/2];
                }
                else
                {
                    arr[i] =  arr[i/2]+1;
                }
            }
            
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}