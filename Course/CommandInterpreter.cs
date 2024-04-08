using System.Runtime.Serialization;

namespace Course
{
    [DataContract]
    public class CommandInterpreter : Editor
    {
        public CommandInterpreter(Editor editor) : base(editor) { }

        public override void DisplayInfo()
        {
            Console.WriteLine("______________");
        }

        public void Command(string command)
        {

            switch (command)
            {
                case "display": DisplayInfo(); break;

                case "copy":
                    Console.WriteLine("Command copy");
                    Editor clonedEditor = new Editor(this);
                    Console.WriteLine("Copy operation executed.");
                    DisplayInfo();
                    break;

                case "length":
                    Console.WriteLine("Command length");
                    LengthOfLine();
                    DisplayInfo();
                    break;

                case "add line":
                    Console.WriteLine("Command add line");
                    AddLine();
                    Console.WriteLine(GetLine());
                    DisplayInfo();
                    break;

                case "find line":
                    Console.WriteLine("Command find line");
                    Console.WriteLine(LookForLine());
                    DisplayInfo();
                    break;

                case "del":
                    Console.WriteLine("Command del");
                    RemoveLine();
                    Console.WriteLine(GetLine());
                    DisplayInfo();
                    break;

                case "replace part":
                    Console.WriteLine("Command replace part");
                    ReplaceLine();
                    Console.WriteLine(GetLine());
                    DisplayInfo();
                    break;

                case "replace all":
                    Console.WriteLine("Command replace all");
                    SetBuffer();
                    Console.WriteLine(GetLine());
                    DisplayInfo();
                    break;

                case "enter": EnterLine(); break;

                default: Console.WriteLine("Unknown command"); break;
            }
        }
    }
}
