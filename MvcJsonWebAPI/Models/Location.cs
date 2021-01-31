using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcJsonWebAPI.Models
{
    public class Location
    {
        [Display(Name="城市名稱")]
        public string City { get; set; }
        [Display(Name ="1-12月份溫度資料")]
        public double[] Temperature { get; set; }
    }
}