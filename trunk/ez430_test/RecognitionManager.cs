using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace ez430_test
{
    class RecognitionManager
    {
        private Dictionary<string, List<sbyte>> patterns;


        /*
         * Constructor
         */
        public RecognitionManager()
        {
            //patterns = new Dictionary<string, List<sbyte>>();
        }


        /*
         * Returns keys of pattern Dictionary
         */
        public Dictionary<string, List<sbyte>>.KeyCollection getPatternsNames()
        {
            return patterns != null ? patterns.Keys : null;
        }


        /*
         * Loads patterns from specified directory
         */
        public void load(string path)
        {
            DirectoryInfo di = new DirectoryInfo(path);
            XmlSerializer s = new XmlSerializer(typeof(List<sbyte>));
            FileStream fs;

            patterns = new Dictionary<string, List<sbyte>>();

            foreach (FileInfo fi in di.GetFiles("*.xml"))
            {
                fs = new FileStream(path + "\\" + fi.Name, FileMode.Open);
                List<sbyte> deser = (List<sbyte>)s.Deserialize(fs);
                patterns.Add(fi.Name, deser);
                fs.Close();
            }
        }


        /*
         * Compare 'data' with loaded pattern. 
         * 
         * Returns: 
         * percent of similarity
         *  or
         * -1 if patternName not found in patterns
         */
        public int compare(LinkedList<sbyte> data, string patternName)
        {
            /*
             * Version 1.0: Mean-square estimate
             */
            double sum = 0;

            for (int i = 0; i < data.Count; i++) {
                sum += (data.ElementAt(i) - patterns[patternName].ElementAt(i)) ^ 2;
            }

            sum /= data.Count;
            sum = Math.Sqrt(sum);

            //UInt64 tmp = (UInt64)(sum*10);
            return (int)((UInt64)(sum * 10)); //There is a bug, while counting ABS value during cast.
            //return sum;
        }
    }
}
