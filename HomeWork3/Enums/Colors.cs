using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3.Enums
{
    public enum Colors : byte
    {
        [Display(Name ="Color Is Blue")]
        Blue,
        [Display(Name = "Color Is Red")]
        Red,
        [Display(Name = "Color Is White")]
        white,
        [Display(Name = "Color Is Green")]
        Green


    }
}
