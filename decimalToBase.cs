/*
Transform a decimal number(base 10) into the given base (b)
*/

string decimal_to_base(int b, int n) {
    string result = "";
    do{

        int mod = n % b;
        n /= b;
        if (mod < 0) 
        { 
            result = mod - b + result;
            n += 1; 
        }
        else{
            result = mod + result;
        }
    }while (n != 0);

    return result;
}

/*
Convert.ToString(number, baseValue));
baseValue - The base of the return value, which must be 2, 8, 10, or 16
https://docs.microsoft.com/en-us/dotnet/csharp/how-to/concatenate-multiple-strings
*/
