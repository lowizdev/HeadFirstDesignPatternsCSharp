using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleTemplateMethod
{
    public class StandardUserCreator : AbstractUserCreator
    {
        public override string fillUserData(string userData)
        {
            return "User: " + userData + ", standard privileges, ";
        }

        public override bool typeIsAdmin()
        {
            return false;
        }
    }
}
