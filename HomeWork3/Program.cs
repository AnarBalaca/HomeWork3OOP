using HomeWork3.Enums;
using HomeWork3.Models;

public class Program
{
 
    public static void Main(string[] args)
    {
        EnumCreate.DisplayEnum<DbConnections>(DbConnections.Mongodb);
        EnumCreate.DisplayEnum<Colors>(Colors.Red);
    }

    
}

