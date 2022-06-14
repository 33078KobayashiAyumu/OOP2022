using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            _score = ReadScore (filePath);


            
        }


        //メソッドの概要： 
        private static IEnumerable<Student> ReadScore(string filePath) {
            List<Student> students = new List<Student> ();
            string[] line = File.ReadAllLines (filePath);
            foreach (var lines in line) {
                string[] item = lines.Split (',');
                Student student = new Student {
                    Name = item[0],
                    Subject = item[1],
                    Score = int.Parse (item[2]),
                };
                students.Add (student);
            }
            return students;




            
        }

        //メソッドの概要： 
        public IDictionary<string, int> GetPerStudentScore() {
            var num = new Dictionary<string, int> ();
            foreach (var scores in _score) {
                if (num.ContainsKey (scores.Subject)) {
                    num[scores.Subject] += scores.Score;
                } else {
                    num[scores.Subject] = scores.Score;
                }
            }
            return num;



            
        }
    }
}
