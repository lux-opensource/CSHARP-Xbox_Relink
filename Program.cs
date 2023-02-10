using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Xbox_Relink
{
    internal class Program
      { 
        static void Main()
        { 
            // Timers are used to slow down, so files can download and then run to reduce errors.

            Console.Title = "Github lux-opensource : Xbox Service Relinker.";
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine(" [ ! ] Relinking Xbox Services - Lux-OpenSource Github");

            File.Delete("C:\\Windows\\System32\\drivers\\etc\\hosts");
            /* REASON TO FUNCTION: File.Delete("C:\\Windows\\System32\\drivers\\etc\\hosts"); 
             
                Normally spoofers will cause this issue blocking certain functions from your hosts file such as the 
                lines below. This will prevent your PC from accessing these servers.

                127.0.0.1 xboxlive.com 
                127.0.0.1 user.auth.xboxlive.com 
                127.0.0.1 presence-heartbeat.xboxlive.com 
             
             */


            /* REASON TO FUNCTION: Download Registerys; 

            Spoofers will also remove the required registerys, therefor you can simply use these and it will 
            automatically replace these. With simple downloads and running.

            */

            using (var client = new WebClient())
            {
                client.DownloadFile("https://cdn.discordapp.com/attachments/1031327960415862898/1073712596278050846/xboxgipsvc.dll.reg", "xboxgipsvc.reg");
                client.DownloadFile("https://cdn.discordapp.com/attachments/1031327960415862898/1073712596697489478/XblAuthManager.dll.reg", "XblAuthManager.reg");
                client.DownloadFile("https://cdn.discordapp.com/attachments/1031327960415862898/1073712597200797747/XblGameSave.dll.reg", "aXblGameSave.reg");
                client.DownloadFile("https://cdn.discordapp.com/attachments/1031327960415862898/1073712597586681866/XboxNetApiSvc.dl.reg", "XboxNetApiSvc.reg");
            }



            Process.Start("xboxgipsvc.reg");
            Process.Start("XblAuthManager.reg");
            Process.Start("aXblGameSave.reg");
            Process.Start("XboxNetApiSvc.reg");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("");
            Console.WriteLine(" [ ! ] Relinked Xbox Services. Restart your PC for xbox service to restart.");
            Console.ReadKey();
        }
    }
}
