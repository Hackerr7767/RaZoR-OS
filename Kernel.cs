using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection.Metadata;
using System.Text;
using Cosmos.System.Graphics;
using Sys = Cosmos.System;

namespace RazorOS
{
    public class Kernel : Sys.Kernel
    {

        protected override void BeforeRun()
        {
            Console.WriteLine("Loading Kernel kernel");
            Console.WriteLine("Loading Assembler yasm.exe");
        }

        protected override void Run()
        {
            Console.Write("razor@root:~$  ");

            string com = "";
            com = Console.ReadLine();
            handle(com);
            
        }

        private void handle(string com)
        {
            if(com == null)
            {
                Console.WriteLine("Write a command!");

            }
            if (com == "ver")
            {
                Console.WriteLine("FSE Razor");
                Console.WriteLine("Version 0.0.1-beta");
            }
            if(com == "help")
            {
                Console.WriteLine("HELP - The command you runned right now.");
                Console.WriteLine("VER - Show kernel and system version");
                Console.WriteLine("NULL - error");
            }
            
              
            }
        }

    }

        
