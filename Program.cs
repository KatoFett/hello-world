namespace Hello_World
{
    internal class Program
    {
        const int HELLO_LENGTH = 5;
        const int WORLD_LENGTH = 5;

        static void Main(string[] args)
        {
            string hello = GetHello();
            string world = GetWorld();
            string helloWorld = HelloWorldBuilder.Build(hello, world);

            Console.WriteLine(helloWorld);
        }

        /// <summary>
        /// Helper to concatenate the two halves of Hello World.
        /// </summary>
        static class HelloWorldBuilder
        {
            /// <summary>
            /// Builds Hello World.
            /// </summary>
            /// <param name="hello">Hello</param>
            /// <param name="world">World</param>
            /// <returns>Hello World</returns>
            internal static string Build(string hello, string world)
            {
                string result = string.Empty;

                // First word
                for (int i = 0; i < HELLO_LENGTH; i++)
                {
                    result += hello[i];
                }

                // Space
                result += ' ';

                // Second word
                for (int i = 0; i < WORLD_LENGTH; i++)
                {
                    result += world[i];
                }

                return result;
            }
        }

        /// <summary>
        /// Builds the world Hello.
        /// </summary>
        static string GetHello()
        {
            int a = 72;     // H
            int b = 101;    // e
            int c = 108;    // l
            int d = 108;    // l
            int e = 111;    // o

            int[] chars = new int[HELLO_LENGTH] { a, b, c, d, e };
            string firstHalf = String.Empty;

            // Convert to characters and append.
            for (int i = 0; i < HELLO_LENGTH; i++)
            {
                firstHalf += (char)chars[i];
            }

            return firstHalf;
        }

        /// <summary>
        /// Builds the word World.
        /// </summary>
        static string GetWorld()
        {
            int g = 87;     // W
            int h = 111;    // o
            int i = 114;    // r
            int j = 108;    // l
            int k = 100;    // d

            int[] chars = new int[WORLD_LENGTH] { g, h, i, j, k };
            string secondHalf = String.Empty;

            // Convert to characters and append.
            for (int x = 0; x < WORLD_LENGTH; x++)
            {
                secondHalf += (char)chars[x];
            }

            return secondHalf;
        }
    }
}