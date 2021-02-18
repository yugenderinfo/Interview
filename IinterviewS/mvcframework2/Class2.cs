using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcframework2
{
    public class TestUtilitys
    {
        #region Instance
        string _name;
        private TestUtilitys(string name)
        {
            // Execute in every request
            _name = name;
        }
        private static string sqlConnection;
        public string SqlConnetionFactory
        {
            get { return sqlConnection; }
        }
        private static TestUtilitys _instance;
        public static TestUtilitys Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TestUtilitys(name);
                sqlConnection = name;
                return _instance;
            }
        }

        #endregion Instance
        
       
    }
}