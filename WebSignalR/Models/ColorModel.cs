using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSignalR.Models
{
    public class ColorModel
    {
        public int Id { get; set; }
        public int Total { get; set; }
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }
        public string Hex { get; set; }
        public double Hue { get; set; }
        public double Saturation { get; set; }
        public double Lightness { get; set;}
    }
}