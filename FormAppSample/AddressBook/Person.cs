using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook {
    [Serializable]
    public class Person {

        [System.ComponentModel.DisplayName ("なまえ")]
        public string Name { get; set; }
        [System.ComponentModel.DisplayName ("めーるあどれす")]
        public string MailAddress { get; set; }
        [System.ComponentModel.DisplayName ("じゅうしょ")]
        public string Adress { get; set; }
        [System.ComponentModel.DisplayName ("かいしゃ")]
        public string Company { get; set; }
        [System.ComponentModel.DisplayName ("ぐるーぷ")]

        public string Group {
            get {
                string groups = "";
                foreach (GroupType group in listGroup) {
                    groups += "{" + group + "}";
                }
                return groups;
            }
        }

        public List<GroupType> listGroup { get; set; }
        [System.ComponentModel.DisplayName ("とうろくび")]
        public DateTime Registration { get; set; }
        [System.ComponentModel.DisplayName ("しゃしん")]
        public Image Picture { get; set; }

        public enum GroupType {
            家族,
            友人,
            仕事,
            その他,
        }
    }
}
