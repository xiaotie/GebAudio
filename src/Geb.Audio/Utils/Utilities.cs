using System;
using System.Collections.Generic;
using System.Text;

namespace Geb.Audio.Utils
{
    public class Utilities
    {
        /// <summary>
        /// Converts class name into readable string
        /// </summary>
        /// <param name="name">input name</param>
        /// <returns>readable class name</returns>
        public static String GetReadable(String name)
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < name.Length; i++)
            {
                char c = name[i];
                if (i == 0)
                {
                    builder.Append(Char.ToUpper(c));
                }
                else if (Char.IsUpper(c) && !Char.IsUpper(name[i - 1]))
                {
                    builder.Append(' ');
                    builder.Append(c);
                }
                else
                {
                    builder.Append(c);
                }
            }
            return builder.ToString();
        }
    }
}
