using NrcTaskWeb.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TestProjNew.Models
{
    public class Repo : IRepo
    {
        DbConnection dbConnection;

        public Repo(DbConnection db)
        {
            dbConnection = db;
        }

        public bool AddData(DataSample dataSample)
        {
            try
            {
                dbConnection.Information.Add(dataSample);
                dbConnection.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public List<DataSample> GetDataSamples()
        {
            try
            {
                return dbConnection.Information.ToList();
            }
            catch(Exception ex)
            {
                return null;
            }
        }
    }
}
