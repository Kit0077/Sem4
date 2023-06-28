int exponentiation (int num1, int num2){
    int result1 = 1;
    for (int i = 1; i <= num2; i++)
    {
    
        result1 = result1 * num1;
        
    }
    return result1;
}
Console.Write("entern a number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("entern a degree: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Число {number1} в степени {number2} равно {exponentiation(number1, number2)}");