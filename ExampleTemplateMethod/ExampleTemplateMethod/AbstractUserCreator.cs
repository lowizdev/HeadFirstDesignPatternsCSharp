using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleTemplateMethod
{
    public abstract class AbstractUserCreator
    {

        public String createUser(String userData) { //Creating a string, for simplicity

            String user = "";

            user += this.fillUserData(userData);
            user += this.createAccount(userData);

            if (this.typeIsAdmin()){ //A Hook

                user += " - Admin"; 

            }

            return user;

        }

        public abstract String fillUserData(String userData);

        public String createAccount(String userData) {

            return " Account Created as " + userData + ", "; //Simplicity

        }

        public abstract bool typeIsAdmin();

    }
}
