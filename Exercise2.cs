public class Ex2
{

    public static void RigthLeftAvarage(int count)
    {
        int[] arr = new int[count];
        int n =0;
        int result1 = 0;
        int result2 = 0;
        Console.WriteLine("Please enter "+count+" numbers :");
        while(n < count)
        {
            if(int.TryParse(Console.ReadLine(), out int numb) && numb > 0)
                arr[n] = numb;
            n+=1;
        }
        Array.Sort(arr);
        for (int i=0 ; i<count; i++)
        {
            if (i == 0 || i == 1 || i == 2)
                result1 += arr[i];
            else if (i == count-3|| i == count-2|| i == count-1)
                result2 += arr[i];
        }

        Console.WriteLine("First 3 element avarage is: "+(result1)/3);
        Console.WriteLine("Last 3 element avarage is: "+result2/3);
        Console.WriteLine("Total 2 of them: "+(result2/3+result1/3));
    }
    
}