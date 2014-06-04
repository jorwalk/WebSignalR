using System.Collections.Generic;
using WebSignalR.Models;
namespace WebSignalR.dal
{
    public class ColorData
    {
        public static List<ColorModel> TopThree()
        {
            var colorList = new List<ColorModel>();
            //colorModel.Add(new ColorModel { Total = , Red = , Green = , Blue = , Hex = "", Hue = "", Saturation = "", Lightness = "" });
            colorList.Add(new ColorModel { Total = 102, Red = 177, Green = 168, Blue = 159, Hex = "B1A89F", Hue = 30.00000000000000, Saturation = 0.10344827586207, Lightness = 0.65882352941176 });
            colorList.Add(new ColorModel { Total = 100, Red = 175, Green = 166, Blue = 157, Hex = "AFA69D", Hue = 30.00000000000000, Saturation = 0.10112359550562, Lightness = 0.65098039215686 });
            colorList.Add(new ColorModel { Total = 98, Red = 174, Green = 165, Blue = 156, Hex = "AEA59C", Hue = 30.00000000000000, Saturation = 0.10000000000000, Lightness = 0.64705882352941 });
            return colorList;
        }
    }
}