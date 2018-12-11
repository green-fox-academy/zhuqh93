using System;

namespace Frontend.Models
{
    public class Doubling
    {
        public int Received { get; set; }
        public int Result { get; set; }
        public string Error { get; set; }

//        public override bool Equals(object obj)
//        {
//            var doubling = obj as Doubling;
//            return doubling != null &&
//                   Received == doubling.Received &&
//                   Result == doubling.Result;
//        }
//
//        public override int GetHashCode()
//        {
//            return HashCode.Combine(Received, Result);
//        }
    }
}