int CircuitPower(int voltage, int current) 
{
    return voltage * current;
}

System.Console.WriteLine(CircuitPower(230, 10) == 2300);
System.Console.WriteLine(CircuitPower(110, 3) == 330);
System.Console.WriteLine(CircuitPower(480, 20) == 9600);