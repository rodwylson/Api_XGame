using System;

namespace XGame.Domain.Extension
{
    public static class StringExtension
    {
        public static string ConvertMD5(this string passaWord)
        {
            var senha = new Guid();
            return senha.ToString(); ;
        }
    }
}
