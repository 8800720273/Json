using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace JsonApp
{
    public class Person12
    {

        private string ApplicantName;
        private string SSNNo;
        private string CitizenShip1;
        public string ApplicaName1
        {
            get
            {
                return ApplicantName;
            }
            set
            {
                ApplicantName = value;
            }
        }
        public string SSno
        {
            get
            {
                return SSNNo;
            }
            set
            {
                SSNNo = value;
            }
        }
        public string CitizenShip
        {
            get
            {
                return CitizenShip1;
            }
            set
            {
                CitizenShip1 = value;
            }
        }
    }
    class ElementType1
    {
        public static void Write()
        {
            Person12 per = new Person12() { ApplicaName1 = "John kethi", SSno = "UTGDY65577", CitizenShip = "UnitedState" };
            Person12 per1 = new Person12() { ApplicaName1 = "Angelina Marry", SSno = "USIDTY466565", CitizenShip = "GERMANY" };
            Person12 per2 = new Person12() { ApplicaName1 = "Nitesh Bansal", SSno = "UUYLK78876678", CitizenShip = "BARMUDA" };
            Person12 per3 = new Person12() { ApplicaName1 = "Bal Krishna", SSno = "USASSNOC76865", CitizenShip = "U.s.A" };
            Person12[] per12 = new Person12[] { per, per1, per2, per3 };
            FileStream fs = new FileStream("Citezen1.json", FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
            StreamWriter fw = new StreamWriter(fs);
            var s = JsonConvert.SerializeObject(per12);
            fw.Write(s);
            fw.Flush();
            fw.Close();
            fs.Close();
            string str1 = File.ReadAllText("Citezen1.json");

            dynamic str = JsonConvert.DeserializeObject(str1);
            int i = 0;
            foreach (var cus1 in str)
            {
                System.Console.WriteLine("ApplicatName :  " + cus1.ApplicaName1);
                System.Console.WriteLine("Snno         :  " + cus1.SSno);
                System.Console.WriteLine("CitizenShip  :  " + cus1.CitizenShip);
                System.Console.WriteLine("==================================");
                System.Console.WriteLine();


            }

        }
        static void Main(string[] args)
        {
            Write();
            Console.ReadKey();
        }
    }
}
