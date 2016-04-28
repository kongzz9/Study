using System;
using System.Data;

namespace Test1
{
    public class odp : IDisposable       
    {
        public odp()
        {

        }


        public void Dispose()
        {
            
        }


        private void ConnectDB()
        {

        }

        private void Disconnect()
        {

        }

        public DataTable ExecuteQuery(string Query)
        {
            DataTable dt = new DataTable();

            using (IDbConnection conn )
            {
                
            }
            

            return dt;
        }
    }
}