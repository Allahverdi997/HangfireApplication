using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Hangfire_App.Process
{
    public class WriteFile : IWirteFile
    {
        public void Write(string msg)
        {
            var path = $"{Environment.CurrentDirectory}\\hangFire.txt";

            if (!File.Exists(path))
            {
                using (var stream = File.CreateText(path))
                {
                    stream.WriteLine(msg);
                    stream.Close();
                }
            }
            else
            {
                var stream = File.AppendText(path);
                stream.WriteLine(msg);
                stream.Close();
            }


        }
    }
}
