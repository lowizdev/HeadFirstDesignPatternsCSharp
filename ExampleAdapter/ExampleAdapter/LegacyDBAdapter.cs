using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleAdapter
{
    public class LegacyDBAdapter : DBClient
    {

        private LegacyDB _legacyDB = null; 

        public LegacyDBAdapter(LegacyDB legacyDB)
        {
            this._legacyDB = legacyDB;
        }

        public void create()
        {
            Console.WriteLine("Passando pelo adaptador");
            this._legacyDB.create();
        }

        public void delete()
        {
            Console.WriteLine("Passando pelo adaptador");
            this._legacyDB.delete();
        }

        public void update()
        {
            Console.WriteLine("Passando pelo adaptador");
            this._legacyDB.delete();
            Console.WriteLine("Update 'na mao'");
            this._legacyDB.create();
        }
    }
}
