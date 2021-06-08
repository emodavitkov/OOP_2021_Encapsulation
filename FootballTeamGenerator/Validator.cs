using System;

namespace FootballTeamGenerator
{
    public class Validator
    {
        public static void ThrowIfStringIsNUllOrEmpty(string name, string exeptionMsd)
        {

            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException(exeptionMsd);
            }
        }

        
    }
}