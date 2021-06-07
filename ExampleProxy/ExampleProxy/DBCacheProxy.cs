using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleProxy
{
    class DBCacheProxy : DBInterface
    {

        private DBInterface _proxied = null;

        private List<string> _simpleCache = null;

        private int _countExpire = 2;

        public DBCacheProxy(DBInterface proxied) {

            this._proxied = proxied;

        }

        public List<string> getAll()
        {

            _countExpire -= 1;

            if (this._simpleCache == null || _countExpire <= 0) {
                this._simpleCache = this._proxied.getAll();
                _countExpire = 2;

                Console.WriteLine("IN CACHING PROXY");

            }


            return this._simpleCache;

        }

        public string getSingle()
        {
            return this._proxied.getSingle();
        }
    }
}
