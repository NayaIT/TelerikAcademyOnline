namespace EnigmaCat
{
    using System;
    using System.Text;

    public class EnigmaCat
    {
        public static void Main()
        {
            var words = Console.ReadLine().Split(' ');
            foreach (var word in words)
            {
                /// <summary>
                /// Convert number from 17 numeral system to decimal
                /// </summary>
                ulong numberInDecimal = 0;

                for (int i = 0, len = word.Length; i < len; i++)
                {
                    numberInDecimal *= 17;
                    numberInDecimal += (ulong)(word[i] - 'a');
                }

                /// <summary>
                /// Convert number from decimal to 26 numeral system
                /// </summary>
                var stringBuilder = new StringBuilder();

                while (numberInDecimal > 0)
                {
                    stringBuilder.Insert(0, (char)((numberInDecimal % 26) + 'a'));
                    numberInDecimal /= 26;
                }

                Console.Write(stringBuilder.ToString() + " ");
            }
            Console.WriteLine();
        }
    }
}