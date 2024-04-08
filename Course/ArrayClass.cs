using System.Collections;
using System.Runtime.Serialization;

namespace Course
{
    [DataContract]
    [KnownType(typeof(ArrayClass))]
    public class ArrayClass : CommandInterpreter, IEnumerable<string>
    {


        public ArrayClass(Editor editor) : base(editor) { }

        [DataMember]
        string[] commands = { "enter", "copy", "length", "add line", "find line", "del", "replace part", "replace all" };

        public void ListCommands()
        {
            foreach (string com in commands)
            {
                Command(com);
            }
        }

        public IEnumerator<string> GetEnumerator()
        {
            foreach (string command in commands)
            {
                yield return command;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

