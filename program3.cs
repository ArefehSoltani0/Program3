using System;

class Program
{
    static void Main()
    {
        // تعیین اندازهٔ آرایه (می‌توانید مقدار را تغییر دهید)
        const int size = 10;

        // ایجاد آرایه
        int[] numbers = new int[size];

        // ایجاد شیء Random
        Random rand = new Random();

        // مقداردهی تصادفی به عناصر آرایه با استفاده از Next()
        // مثال: اعداد بین 1 تا 100 (کران بالا انحصاری است → 100 شامل نمی‌شود)
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rand.Next(1, 101); // [1, 100]
        }

        // نمایش آرایه
        Console.WriteLine("آرایه با مقادیر تصادفی:");
        Console.WriteLine("[" + string.Join(", ", numbers) + "]");
    }
}