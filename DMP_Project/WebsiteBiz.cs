using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DMP_Project.QueryParameters;

namespace DMP_Project
{
    public class WebsiteBiz : IDmpBiz<SiteParameters, WebSite>
    {
        public List<WebSite> GetList(SiteParameters parameters)
        {
            List<WebSite> ls = DataGenerator.GetWebsiteList().ToList();
            if (parameters.ClientId > 0)
                ls = ls.Where(n => n.ClientId == parameters.ClientId).ToList();
            if (parameters.QueryId > 0)
                ls = ls.Where(n => n.Id == parameters.QueryId).ToList();
            if (!string.IsNullOrEmpty(parameters.QueryName))
                ls = ls.Where(n => n.Name.Contains(parameters.QueryName)).ToList();
            if (parameters.Status > 0)
                ls = ls.Where(n => n.Status == parameters.Status).ToList();

            return ls;
        }
    }
}
