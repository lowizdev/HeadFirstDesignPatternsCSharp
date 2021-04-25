using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleTemplateMethod
{
    public class AdminUserCreator : AbstractUserCreator
    {
        public override string fillUserData(string userData)
        {
            return "User: " + userData + ", administrative privileges, ";
        }

        public override bool typeIsAdmin()
        {
            return true;
        }
    }
}
