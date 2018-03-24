using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace JsonApp
{
    class Class1
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long phoneNumber { get; set; }
        public object array { get; set; }
        static void Main(string[] args)
        {
            List<Class1> cl = new List<Class1>();
            Class1 c = new Class1();
            c.FirstName = "Bal Krishna";
            c.LastName = "Mittal";
            c.phoneNumber = 76757656453;
            c.array = "hazaribagh,jharkhand,825319";
            cl.Add(c);
            c = new Class1();
            c.FirstName = "Nitesh";
            c.LastName = "Bansal";
            c.phoneNumber = 81434424554;
            c.array = "M.P";
            cl.Add(c);
            c = new Class1();
            c.FirstName = "Razi";
            c.LastName = "Ahmed";
            c.phoneNumber = 34424554;
            c.array = "Bihar";
            cl.Add(c);
            c = new Class1();
            c.FirstName = "Yashwant";
            c.LastName = "stud";
            c.phoneNumber = 349786424554;
            c.array = "Karnataka";
            cl.Add(c);
            // string input = JsonConvert.SerializeObject(c);
            FileStream fs = new FileStream("New.json", FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            var s = JsonConvert.SerializeObject(cl);
            sw.Write(s);
            sw.Flush();
            sw.Close();
            string json = File.ReadAllText("New.json");
            dynamic s1 = JsonConvert.DeserializeObject(json);
            int i = 0;
            foreach(object s2 in s1)
            {
                Console.WriteLine(s2);
                i += 1;
            }
            Console.ReadKey();
        }
    }
}
