using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECommerceUI
{
    public static class Logger
    {


        static string PacificLogfFile = @"C:\Users\christopher.e\DotNet\PacificLogFile.log";

        public static void WriteToLog(string whatToWrite)
        {
            // Set up the streamwriter as appendable so we don't overwrite anything already there
            System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(PacificLogfFile, true);
            streamWriter.WriteLine(whatToWrite);
            streamWriter.Close();
        }

    }
    
}