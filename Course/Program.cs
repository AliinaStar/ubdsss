using System.Runtime.Serialization.Json;

namespace Course
{
    internal class Pogram
    {
        static void Main(string[] args)
        {
            Editor mainEditor = new Editor();

            ArrayClass array = new ArrayClass(mainEditor);

            foreach (string command in array)
            {
                array.Command(command);
            }

            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                writer.WriteLine("Your final result: " + array.GetLine());
            }

            Stream file = new FileStream("courseNew.json", FileMode.Create);
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Container));
            ser.WriteObject(file, array);

            file.Position = 0;
            ArrayClass array1 = (ArrayClass) ser.ReadObject(file);
        }
    }
}