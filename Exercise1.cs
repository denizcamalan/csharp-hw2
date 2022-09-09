using System.Collections;

public class Ex1
{
    public static void SplitPrimes(int count)
    {
        ArrayList thisPrime = new ArrayList();
        ArrayList nonPrime = new ArrayList();
        int n =0;
        Console.WriteLine("Please enter "+count+" numbers :");
        while(n < count)
        {
            if(int.TryParse(Console.ReadLine(), out int numb) && numb > 0)
                if(IsPrime(numb,out bool result))
                    thisPrime.Add(numb);
                else
                    nonPrime.Add(numb);
            n+=1;
        }
        thisPrime.Sort();
        nonPrime.Sort();
        Console.WriteLine("Prime Numbers :");
        foreach (int val in thisPrime)
            Console.Write(val+" ");
        Console.WriteLine("length and avr"+Avarage(thisPrime));
        Console.WriteLine("non-Prime Numbers :");
        foreach (int val in nonPrime)
            Console.Write(val+" ");
        Console.WriteLine("length and avr"+Avarage(nonPrime));
    }

    static bool IsPrime(int numb, out bool result)
    {
        if (numb == 2 || numb == 3 || (numb%2 != 0 && numb%3 != 0 && numb%5 != 0))
            result = true;
        else
            result = false;
        return result;
    }
    static (int,int) Avarage(ArrayList arr)
    {
        int tot = 0;
        int count = arr.Count;
        foreach (int val in arr)
            tot +=val;
        return (count,tot/count);
    }
}