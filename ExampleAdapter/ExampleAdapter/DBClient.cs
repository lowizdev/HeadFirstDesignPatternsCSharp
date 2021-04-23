using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleAdapter
{
    public interface DBClient
    {

        public void create();

        public void update();

        public void delete();

    }
}
