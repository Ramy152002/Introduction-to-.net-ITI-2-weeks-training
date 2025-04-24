using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_3
{
    //internal class Vehicle
    //{
    //    private string color;
    //    public void SetColor(string color)
    //    {
    //        if (color.ToUpper() == "YELLOW")
    //        {
    //            Console.WriteLine("Yellow is not allowed color");
    //        }
    //      else   this.color = color;
    //    }
    //    public string GetColor()
    //    {
    //        if (color != null)
    //            return this.color;
    //        else return string.Empty;
    //    }
    //}

    public abstract class Vehicle
    {
        //Constructor Overloading 
        //constructor snippet: ctor
        public Vehicle()
        {
            
        }
       public abstract string TellAbout();
        public Vehicle(string mdl,string clr,float len , float wdt , float hgt)
        {
            Model = mdl;
            color = clr;
            Length = len;
            Width = wdt;
            Height = hgt;

        }
 


        //properties 
        //1. full properties (code snippet: propfull)
        private string color; //camel case 

        public string Color // Pascal case 
        {
            get
            {
                if (string.IsNullOrWhiteSpace(color)) return string.Empty;
                else return color.ToUpper(); ;
            }
            set
            {
                if (value.ToUpper() == "YELLOW")
                    Console.WriteLine("Yellow is not allowed color");
                else
                    color = value;
            }
        }

      

        public string Model { get; set; }
        public float Length { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }

        public virtual string ShowSpecification()
        {
           return 
                $"{nameof(Model)}\t\t:{Model}" +
                $"\n{nameof(Length)}\t\t:{Length}" +
                $"\n{nameof(Width)}\t\t:{Width}" +
                $"\n{nameof(Height)}\t\t:{Height}"
                ;
        }
        
        public virtual string ShowSpecification(string type)
        {
            if (type.ToUpper() == "FULL")
            {

                return 
                    $"{nameof(Model)}\t:{Model}" +
                    $"\n{nameof(color)}\t:{color}" +
                    $"\n{nameof(Length)}\t:{Length}" +
                    $"\n{nameof(Width)}\t:{Width}" +
                    $"\n{nameof(Height)}\t:{Height}" +
                    $"\nDate\t:{DateTime.Now.ToShortDateString()}" +
                    $"\nTime\t:{DateAndTime.Now.ToShortTimeString()}";
        
            
            }
            else
            {
                return$"{color} {Model}";
            }
        }

    }





}
