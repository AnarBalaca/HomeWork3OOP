using HomeWork3.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3.Models
{
    public static class EnumCreate
    {
        
        public static void DisplayEnum<T>(T @enum)
        {
            var enumType = @enum?.GetType();
            var member = enumType?.GetMember(@enum.ToString()).First();
            var memberatribute = member?.GetCustomAttribute<DisplayAttribute>();
            var display = memberatribute?.GetName();

            //Console.WriteLine($"TYPE \n{enumType}\n\n" +
            //    $"MEMBER \n{member}\n\n" +
            //    $"MEMBERATRIBUTE \n{memberatribute}\n\n" +
            //    $"DISPLAY\n{display}\n\n");

            Console.WriteLine($"Enum Display: {display}");

        }
    } 
}
