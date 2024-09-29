
class Program
{
    static void Main()
    {
        
        int target = 0;
        Random random = new Random();

        int[] arr = new int[10];

        for (int i = 0; i < arr.Length; i++)
            arr[i] = random.Next(-10, 50);

        foreach (int el in arr)
            System.Console.Write(el + " ");
        System.Console.WriteLine();

        HashSet<int> set = new HashSet<int>();

        while(target < arr.Length)
        {
            System.Console.WriteLine($"Target number: {arr[target]}");

            foreach(var i in arr)
            {
                var x = arr[target] - i;
                if(set.Contains(x))
                {
                    System.Console.WriteLine($"{arr[target]} = {x} + {i}");
                }
                else
                    set.Add(i);
            }
            target++;
        }
    }
}