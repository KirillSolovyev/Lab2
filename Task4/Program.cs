using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task4 {
    class Program {
        static void Main(string[] args) {
            FileInfo newF = new FileInfo(@"C:\Users\Kirill\source\repos\Lab2\Task4\Ya text.txt");
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Kirill\source\repos\Lab2\Task4\Ya Directory");
            if(!dir.Exists) {
                dir.Create();
                FileInfo newNew = new FileInfo(dir.FullName + @"\Ya text2.txt");
                using(FileStream fs = newF.OpenWrite()) {
                    string text = "From the new directory";
                    fs.Write(Encoding.Default.GetBytes(text), 0, Encoding.Default.GetByteCount(text));
                }
                newF.CopyTo(newNew.FullName);
                newF.Delete();
            } else {
                dir.Delete(true);
            }
        }
    }
}
