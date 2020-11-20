using System;
using System.Text.RegularExpressions;

namespace KeysVault.Globals
{
    public static class Verifier
    {
        public static bool Email(string Email)
        {
            if (Text(Email))
            {
                var EmailRegex = new Regex(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");
                return EmailRegex.IsMatch(Email);
            }
            else return false;
        }

        public static bool Text(string Text)
        {
            if (string.IsNullOrEmpty(Text) || string.IsNullOrWhiteSpace(Text) || Text == string.Empty || Text == " ")
            {
                return false;
            }
            else return true;
        }

        public static bool Id(int id)
        {
            //this need a better implementation. -gul:0301171550
            try
            {
                id = Convert.ToInt32(id);

                if (id > 0)
                    return true;
            }
            catch (Exception)
            {
                return false;
            }

            return false;
        }
    }
}
