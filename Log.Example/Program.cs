﻿using System;

namespace SoftCube.Log.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Logger.Trace("Hello World!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}