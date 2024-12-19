Console.WriteLine("Трехзначные числа с уникальными цифрами:");

for (int hundreds = 1; hundreds <= 9; hundreds++)
{
    for (int tens = 0; tens <= 9; tens++)
    {
        if (tens != hundreds)
        {
            for (int units = 0; units <= 9; units++)
            {
                if (units != hundreds && units != tens)
                {
                    Console.WriteLine($"{hundreds}{tens}{units}");
                }
            }
        }
    }
}