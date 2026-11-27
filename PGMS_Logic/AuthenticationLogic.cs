using System;
using System.Collections.Generic;
using System.Text;

namespace PGMS_Logic
{
    public class AuthenticationLogic
    {
        // Placeholder key moved here from the console Program.cs.
        // Fine for a demo; a real system would never hardcode this.
        private const string AdminKey = "lShDSJ73rD";

        public bool IsAdminKeyCorrect(string userInput)
        {
            if (string.IsNullOrWhiteSpace(userInput))
                return false;

            return string.Equals(userInput.Trim(), AdminKey, StringComparison.Ordinal);
        }
    }
}