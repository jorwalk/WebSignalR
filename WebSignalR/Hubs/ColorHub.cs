using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Web.Script.Serialization;
using System.Web.UI.WebControls;
using Microsoft.AspNet.SignalR;
using Newtonsoft.Json;
using WebSignalR.Models;

namespace WebSignalR.Hubs
{
    public class ColorHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }

        public void Increment(int count)
        {
            Clients.All.incrementCounter(count+10);
        }

        public void TopThree()
        {
            var colorList = new List<ColorModel>
            {
                new ColorModel
                {
                    Total = 100,
                    Red = 175,
                    Green = 166,
                    Blue = 157,
                    Hex = "79654D",
                    Hue = 30.00000000000000,
                    Saturation = 0.10112359550562,
                    Lightness = 0.65098039215686
                },
                new ColorModel
                {
                    Total = 98,
                    Red = 174,
                    Green = 165,
                    Blue = 156,
                    Hex = "AEA59C",
                    Hue = 30.00000000000000,
                    Saturation = 0.10000000000000,
                    Lightness = 0.64705882352941
                },
                new ColorModel
                {
                    Total = 55,
                    Red = 187,
                    Green = 168,
                    Blue = 159,
                    Hex = "B5ACA3",
                    Hue = 30.00000000000000,
                    Saturation = 0.10344827586207,
                    Lightness = 0.65882352941176
                }
            };
   
            foreach (var color in colorList)
            {
                Clients.All.addColorToPage(color.Hex);
            }
        }
    }
}