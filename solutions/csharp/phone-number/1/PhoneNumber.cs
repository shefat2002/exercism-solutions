public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        string number ="";
        foreach(var digit in phoneNumber){
            if(Char.IsDigit(digit))number += digit;
            
        }
        int len = number.Length;
        if(len < 10 || len > 11){
            throw new ArgumentException();
        }
        else if(len == 11){
            if(number[0] != '1')throw new ArgumentException();
            number = number.Remove(0,1);
        }
        if(number[0] == '1' || number[3] == '1' || number[0] == '0' || number[3] == '0'){
            throw new ArgumentException();
        }
        Console.WriteLine(number);
        return number;
    }
}