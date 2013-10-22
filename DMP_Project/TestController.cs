using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DMP_Project.QueryParameters;

namespace DMP_Project
{
    public static class TestController
    {
        public static void GetWebsiteList()
        {
            IDmpBiz<SiteParameters, WebSite> dmpBiz = new WebsiteBiz();
            SiteParameters sp = new SiteParameters() { ClientId = 2 };
            var ls = dmpBiz.GetList(sp);
            foreach (var item in ls)
            {
                Console.WriteLine(item);
            }
        }

        public static void GetAudienceQueryList()
        {
            IDmpBiz<AudienceParameters, AudienceTagInfo> dmpBiz = new AudienceQueryBiz();
            AudienceParameters ap = new AudienceParameters() { QueryId = 3, QueryName = "腾讯人群" };
            var ls = dmpBiz.GetList(ap);
            foreach (var item in ls)
            {
                Console.WriteLine(item);
            }
        }
    }
}
