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
            string line = File.ReadAllLines (filePath);





            
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
