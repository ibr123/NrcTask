using NrcTaskWeb.Models.DbModels;
using System.Collections.Generic;

namespace TestProjNew.Models
{
    public interface IRepo
    {
        bool AddData(DataSample dataSample);

        List<DataSample> GetDataSamples();        
    }
}
