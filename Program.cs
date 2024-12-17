using System.Reflection;

namespace InterviewQuestions
{
    internal class Program
    {
        static void Main()
        {
            // TODO - your code here
        }

        /// <summary>
        /// Returns the question input as a list of strings
        /// </summary>
        private static List<string> GetInput()
        {
            List<string> lines = [];

            var assembly = Assembly.GetExecutingAssembly();

            using (var stream = assembly.GetManifestResourceStream("InterviewQuestions.input.txt"))
            {
                if (stream == null)
                {
                    throw new Exception("Error reading input resource");
                }

                using (var reader = new StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                    {
                        lines.Add(reader.ReadLine()!);
                    }
                }
            }

            return lines;
        }
    }
}
