using System;
using System.Collections.Generic;
using DAL;
using Model;

namespace Logic
{
    public class Databases
    {
        private MongoHelper _mongoHelper;
        public Databases() { _mongoHelper = MongoHelper.getInstance(); }

        public List<DatabaseModel> Get_All_Databases() => _mongoHelper.getAllDbs();
    }
}
