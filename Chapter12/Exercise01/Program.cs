using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Exercise01 {


    public class Employee {
        [XmlElement (ElementName = "id")]
        public int Id { get; set; }
        [XmlElement (ElementName = "name")]
        public string Name { get; set; }
        [XmlElement (ElementName = "hiredate")]
        public DateTime HireDate { get; set; }
        public override string ToString () {
            return string.Format ("[Id={0}, Name={1}, HireDate={2}]",
                                  Id, Name, HireDate);
        }
    }
    [DataContract (Name = "employee2")]
    public class Employee1 {

        public int Id { get; set; }
        [DataMember (Name = "name")]
        public string Name { get; set; }
        [DataMember (Name = "hireDate")]
        public DateTime HireDate { get; set; }

    }


    class Program {
        static void Main (string[] args) {

            Exercise1_1 ("employee.xml");

            //// これは確認用
            //Console.WriteLine (File.ReadAllText ("employee.xml"));
            //Console.WriteLine ();

            Exercise1_2 ("employees.xml");
            Exercise1_3 ("employees.xml");
            //Console.WriteLine ();

            Exercise1_4 ("employees.json");

            //// これは確認用
            //Console.WriteLine (File.ReadAllText ("employees.json"));
        }

        private static void Exercise1_1 (string outfile) {
            var emp = new Employee {

                Id = 123,
                Name = "a",
                HireDate = new DateTime (2022, 2, 22),
            };
            using (var writer = XmlWriter.Create ("employee.xml")) {
                var serializer = new XmlSerializer (emp.GetType ());
                serializer.Serialize (writer, emp);
            }
            Display ("employee.xml");
        }

        private static void Exercise1_2 (string v) {
            var emp = new Employee[] {
               new Employee {
                  Id = 123,
                  Name = "あ",
                  HireDate = new DateTime (2022, 2, 22),
              },
               new Employee {
                  Id = 1234,
                  Name = "ああ",
                  HireDate = new DateTime (2011, 1, 11),
               },
            };
            
            using (var writer = XmlWriter.Create ("employees.xml")) {
                var serializer = new DataContractSerializer (emp.GetType ());
                serializer.WriteObject (writer, emp);
            }
                Display ("employees.xml");
        }

        private static void Exercise1_3 (string v) {
            using (var reader = XmlReader.Create ("employees.xml")) {
                var serializer = new DataContractSerializer (typeof (Employee[]));
                var emp = serializer.ReadObject (reader) as Employee[];
                foreach (var item in emp) {
                    Console.WriteLine ("{0}{1}{2}",item.Name,item.Id,item.HireDate);
                }
            }
        }

        private static void Exercise1_4 (string v) {

            var emp = new Employee1[] {
               new Employee1 {
                  Id = 123,
                  Name = "あ",
                  HireDate = new DateTime (2022, 2, 22),
              },
               new Employee1 {
                  Id = 1234,
                  Name = "ああ",
                  HireDate = new DateTime (2011, 1, 11),
               }
            };

            using (var writer = new FileStream ("employees2.json", FileMode.Create, FileAccess.Write)) {
                var serializer = new DataContractJsonSerializer (emp.GetType (),new DataContractJsonSerializerSettings {
                    DateTimeFormat = new DateTimeFormat("yyyy-MM-dd")
                });
                serializer.WriteObject (writer, emp);
            }
            Display ("employees2.json");
        }
        //XMLファイルの中身表示用
        private static void Display (string filename) {
            var lines = File.ReadLines (filename);
            foreach (var line in lines)
                Console.WriteLine (line);
        }
    }
}
