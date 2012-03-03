using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KeyPassBusiness
{
    public static class Util
    {
        public static string GetRandomString(int length)
        {
            var output = "";
            var rand = new Random();

            for (int i = 0; i <= length; i++)
            {
                output += (char)(rand.Next(26) + 65);
            }

            return output.ToLower();
        }
    }
}
