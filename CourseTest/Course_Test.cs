using Course;
using System;
using System.IO;

namespace CourseTest
{
    [TestClass]
    public class Course_Test
    {
        [TestMethod]
        public void EnterLine_winter_winterreturned()
        {
            string word = "winter";

            Editor mEditor = new Editor();
            using (StringReader stringReader = new StringReader(word))
            {
                Console.SetIn(stringReader);
                mEditor.EnterLine();
            }

            Assert.AreEqual(word, mEditor.Buffer);
        }
        [TestMethod]
        public void Length_winter_6returned()
        {
            string word = "winter";
            int c = 6;

            Editor mEditor = new Editor();
            using (StringReader stringReader = new StringReader(word))
            {
                Console.SetIn(stringReader);
                mEditor.EnterLine();
                mEditor.LengthOfLine();

            }

            Assert.AreEqual(mEditor.Buffer.Length, c);
        }
        [TestMethod]
        public void AddLine_iscoming_winteriscomingreturned()
        {
            string word = "winter";
            string addNew = " is coming";
            string end = "winter is coming";

            Editor mEditor = new Editor();
            using (StringReader stringReader = new StringReader(word + addNew))
            {
                Console.SetIn(stringReader);
                mEditor.AddLine();
            }

            Assert.AreEqual(end, mEditor.Buffer);
        }
        [TestMethod]
        public void LookForLine_w_truereturned()
        {
            string word = "winter";
            bool expected = true;
            string lookFor = "w";

            Editor mEditor = new Editor();
            mEditor.Buffer = word;
            using (StringReader stringReader = new StringReader(lookFor))
            {
                Console.SetIn(stringReader);
                bool real = mEditor.LookForLine();
                Assert.AreEqual(expected, real);
            }
        }
        [TestMethod]
        public void RemoveLine_w_interreturned()
        {
            string word = "winter";
            string r = "w";
            string expected = "inter";

            Editor mEditor = new Editor();
            mEditor.Buffer = word;
            using (StringReader stringReader = new StringReader(r))
            {
                Console.SetIn(stringReader);
                mEditor.RemoveLine();
            }
            Assert.AreEqual(expected, mEditor.Buffer);
        }
        [TestMethod]
        public void ReplaceLine_terandd_windreturned()
        {
            string word = "winter";
            string part = "ter";
            string newPart = "d";
            string expected = "wind";

            Editor mEditor = new Editor();
            mEditor.Buffer = word;
            using (StringReader stringReader = new StringReader(part + "\n" + newPart))
            {
                Console.SetIn(stringReader);
                mEditor.ReplaceLine();
            }

            Assert.AreEqual(expected, mEditor.Buffer);
        }
        [TestMethod]
        public void GetLine_winter_winterreturned()
        {
            string word = "winter";

            Editor mEditor = new Editor();
            mEditor.Buffer = word;
            mEditor.GetLine();

            Assert.AreEqual(word, mEditor.Buffer);
        }
        [TestMethod]
        public void SetBuffer_summer_summerreturned()
        {
            string word = "winter";
            string newWord = "summer";

            Editor mEditor = new Editor();
            mEditor.Buffer = word;
            using (StringReader stringReader = new StringReader(newWord))
            {
                Console.SetIn(stringReader);
                mEditor.SetBuffer();
            }

            Assert.AreEqual (newWord, mEditor.Buffer);
        }
        [TestMethod]
        public void Command_addline_winteriscomingreturned()
        {
            string word = "winter";
            string newLine = " is coming";
            string expected = "winter is coming";
            string command = "add line";

            Editor mEditor = new Editor();
            CommandInterpreter editor = new CommandInterpreter(mEditor);
            editor.Buffer = word;
            using (StringReader stringReader = new StringReader(newLine))
            {
                Console.SetIn(stringReader);
                editor.Command(command);
            }

            Assert.AreEqual(expected, editor.Buffer);
        }
    }
}