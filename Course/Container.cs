using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    [DataContract]
    [KnownType(typeof(Editor))]
    [KnownType(typeof(CommandInterpreter))]
    [KnownType(typeof(ArrayClass))]
    public class Container
    {
        [DataMember]
        public Editor Editor { get; set; }
        [DataMember]
        public CommandInterpreter CommandInterpreter { get; set; }
        [DataMember]
        public ArrayClass ArrayClass { get; set; }
    }
}
