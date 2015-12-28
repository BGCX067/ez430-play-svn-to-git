using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;

namespace ez430_test
{
    class FileWorks
    {
        private TextWriter tw;

        public FileWorks(string path, string ext) {
            int n = 0;
            while (File.Exists(path+n+ext)) {
                n++;
            }
            tw = new StreamWriter(path+n+ext);
        }

        public void saveList(LinkedList<Point> ll) {
            LinkedList<Point>.Enumerator lenum= ll.GetEnumerator();
            int i = 0 ;
            while (i++ < ll.Count) {
                tw.WriteLine("X=" + lenum.Current.X + " Y=" + lenum.Current.Y);
                lenum.MoveNext();                
            }
            tw.Flush();
        }

        public LinkedList<Point> loadList() {
            return null;
        }
    }
}
