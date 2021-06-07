using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleProxy
{
    public interface DBInterface
    {

        public String getSingle();

        public List<String> getAll();

    }
}
