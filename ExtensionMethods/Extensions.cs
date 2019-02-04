﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class Extensions
    {

        public static int ToInt(this String val)
        {
            try
            {
                return Convert.ToInt32(val);
            }
            catch (Exception ex)

            {
                return -1;
            }
        }

        public static int ToInt1(String val)
        {
            try
            {
                return Convert.ToInt32(val);
            }
            catch (Exception ex)

            {
                return -1;
            }
        }

        public static string Left(this string val, int digits = 1)//this -> do jakiej klasy chcemy się odniesc (klasy string)
        { 
            return val.Substring(0, digits);
        }

        public static void Log (this string text)
        {
            try
            {
                string directory = "D:/Loggs";

                File.AppendAllText(Path.Combine(directory, "Info.txt"),
                    $"{Environment.NewLine} Data: {DateTime.Now.ToShortDateString()} Informacja: {text}");
            }
            catch (DirectoryNotFoundException dnfe)
            {
                //LogError(dnfe.Message);
            }
            catch (Exception)
            {
              //  LogError("Coś sie zepsuło");
            }
        }


    }
}
