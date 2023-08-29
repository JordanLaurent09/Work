﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilesDirectoriesPartTwoProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Определение характеристик жестких дисков
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach(DriveInfo item in drives)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.DriveType);
                if(item.IsReady)
                {
                    Console.WriteLine(item.TotalSize);
                    Console.WriteLine(item.AvailableFreeSpace);
                    Console.WriteLine(item.VolumeLabel);
                }

            }


        }
    }
}