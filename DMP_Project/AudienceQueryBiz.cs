using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DMP_Project.QueryParameters;

namespace DMP_Project
{
    public class AudienceQueryBiz : IDmpBiz<AudienceParameters, AudienceTagInfo>
    {
        public List<AudienceTagInfo> GetList(AudienceParameters parameters)
        {
            List<AudienceTagInfo> ls = DataGenerator.GetAudienceList().ToList();
            if (parameters.QueryId > 0)
                ls = ls.Where(n => n.Id == parameters.QueryId).ToList();
            if (!string.IsNullOrEmpty(parameters.QueryName))
                ls = ls.Where(n => n.Name.Contains(parameters.QueryName)).ToList();
            if (parameters.Status > 0)
                ls = ls.Where(n => n.Status == parameters.Status).ToList();

            ls = ls.Where(n => n.ExecuteTime.Date >= parameters.ExecuteTime.Date).ToList();

            return ls;
        }
    }
}
