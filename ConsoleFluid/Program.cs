using System;
using System.IO;
using System.Xml;

using FluidMan;

namespace ConsoleFluid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fluid calculator");

            Console.WriteLine("Checking working directories");

            string parentFolderPath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string rootFolderName = "FluidMan";
            string rootFolderPath = parentFolderPath + "//" + rootFolderName;

            Directory.CreateDirectory(rootFolderPath);

            string confFolderName = "conf";
            string confFolderPath = rootFolderPath + "//" + confFolderName;
            Directory.CreateDirectory(confFolderPath);

            string unitFileName = "units.xml";
            string unitFilePath = confFolderPath + "//" + unitFileName;

            Console.WriteLine("Creating units file as xml...");

            FileStream fileStream = new FileStream(unitFilePath, FileMode.OpenOrCreate);

            FluidMan.Units.Write_UnitTable(fileStream);

            Console.WriteLine("File of system of units created successfully");

            Console.WriteLine("Bye");
        }
    }
}
