using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

    [XmlRoot ("novelist")]
    [DataContract(Name = "novelist")]
    public class Novelist {
        [XmlElement (ElementName = "name")]
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [XmlElement (ElementName = "birth")]
        [DataMember(Name = "birth")]
        public DateTime Birth { get; set; }

        [XmlArray("masterpieces")]
        [XmlArrayItem("title",typeof(string))]
        [DataMember(Name = "masterpieces")]
        public string[] Masterpieces { get; set; }
    public override string ToString () {
        return string.Format ("[name={0}, birth={1}, masterpieces={2}]",
                              Name, Birth, Masterpieces);
    }
}
