using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iOSEventosDemo
{
    public class Validation
    {
        public enum ValitationType { User, Password, Code }

        public static bool ValidateInput(string text, ValitationType validationType)
        {
            var validUserChars = "abcdefghijklmnopqrstuwxyz1234567890_";
            var validPasswordChars = "abcdefghijklmnopqrstuwxyz1234567890!@#$%&*()?<>";
            var validCodeChars = "1234567890";
            bool result = false;
            switch (validationType)
            {

                case ValitationType.User:
                    result = text.ToLower().All(c => validUserChars.Contains(c));
                    break;
                case ValitationType.Password:
                    result = text.ToLower().All(c => validPasswordChars.Contains(c));
                    break;
                case ValitationType.Code:
                    result = text.ToLower().All(c => validCodeChars.Contains(c));
                    break;

            }

            return result;
        }
    }
}
