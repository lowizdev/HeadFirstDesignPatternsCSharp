using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleProxy
{
    public class FakeDBAccess : DBInterface
    {
        public List<string> getAll()
        {

            string[] arr = { "My single item", "My other item" };

            List<string> response = new List<string>(arr);

            return response;
        }

        public string getSingle()
        {
            
            return "My single item";
        }
    }
}
