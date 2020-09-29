using System;
using System.Collections.Generic;
using System.Text;

namespace Utils
{
    public static class Time
    {
        public static int GetUnix()
        {
            return (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
        }
    }
}
