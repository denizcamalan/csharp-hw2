class Ex3
{
    public static void SortVowel()
    {
        string? str = Console.ReadLine();
        char[] charArr;
        int count=0;
        if (!string.IsNullOrEmpty(str))
        {   
            charArr =new char[str.Length];
            foreach (char v in str)
            {
                if (!IsContain(v))
                    continue;
                else
                {
                    charArr[count] = v;
                    count += 1;
                }
            }
            Array.Sort(charArr);
            foreach (var val in charArr)
                Console.Write(val);
        }
    }
    
    static bool IsContain(char letter)
    {
        if (letter == 'a' || letter == 'e' || letter == 'i'  || letter == 'o' || letter == 'u')
            return true;
        else
            return false;
    }
}