public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string? operation)
    {
        int ans =0;
        if(operation == "")
            throw new ArgumentException();
        else if(operation == null)
            throw new ArgumentNullException();
        else if(operation == "+") ans = operand1+ operand2;
        else if(operation == "*") ans = operand1* operand2;
        else if(operation == "/"){
            if(operand2 == 0)
                return "Division by zero is not allowed.";
            ans = operand1 / operand2;
        }
        else
            throw new ArgumentOutOfRangeException();
        return $"{operand1} {operation} {operand2} = {ans}";
    }
}
