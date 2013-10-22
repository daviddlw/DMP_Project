using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DMP_Project
{
    public static class DataGenerator
    {
        public static IEnumerable<WebSite> GetWebsiteList()
        {
            return new List<WebSite>()
            {
                new WebSite(){ Id = 1, Name="网易", Status=1, ClientId=1, CreateTime = DateTime.Now, LastChanged=DateTime.Now },
                new WebSite(){ Id = 2, Name="乐视", Status=1, ClientId=1, CreateTime = DateTime.Now, LastChanged=DateTime.Now },
                new WebSite(){ Id = 3, Name="腾讯", Status=2, ClientId=1, CreateTime = DateTime.Now, LastChanged=DateTime.Now },
                new WebSite(){ Id = 4, Name="新浪", Status=2, ClientId=1, CreateTime = DateTime.Now, LastChanged=DateTime.Now },
                new WebSite(){ Id = 5, Name="搜狐", Status=3, ClientId=1, CreateTime = DateTime.Now, LastChanged=DateTime.Now },
                new WebSite(){ Id = 6, Name="搜狗", Status=3, ClientId=2, CreateTime = DateTime.Now.AddDays(-5), LastChanged=DateTime.Now.AddDays(-5) },
                new WebSite(){ Id = 7, Name="随视传媒", Status=4, ClientId=2, CreateTime = DateTime.Now.AddDays(-5), LastChanged=DateTime.Now.AddDays(-5) },
                new WebSite(){ Id = 8, Name="百度", Status=4, ClientId=2, CreateTime = DateTime.Now.AddDays(-5), LastChanged=DateTime.Now.AddDays(-5) },
                new WebSite(){ Id = 9, Name="谷歌", Status=5, ClientId=2, CreateTime = DateTime.Now.AddDays(-5), LastChanged=DateTime.Now.AddDays(-5) },
                new WebSite(){ Id = 10, Name="微软", Status=5, ClientId=2, CreateTime = DateTime.Now.AddDays(-5), LastChanged=DateTime.Now.AddDays(-5) },
            };
        }

        public static IEnumerable<AudienceTagInfo> GetAudienceList()
        {
            return new List<AudienceTagInfo>()
            {
                new AudienceTagInfo(){ Id = 1, Name="网易人群", Status=1, ExecuteTime=DateTime.Now,  CreateTime = DateTime.Now, LastChanged=DateTime.Now },
                new AudienceTagInfo(){ Id = 2, Name="乐视人群", Status=1, ExecuteTime=DateTime.Now, CreateTime = DateTime.Now, LastChanged=DateTime.Now },
                new AudienceTagInfo(){ Id = 3, Name="腾讯人群", Status=2,ExecuteTime=DateTime.Now,  CreateTime = DateTime.Now, LastChanged=DateTime.Now },
                new AudienceTagInfo(){ Id = 4, Name="新浪人群", Status=2,ExecuteTime=DateTime.Now,  CreateTime = DateTime.Now, LastChanged=DateTime.Now },
                new AudienceTagInfo(){ Id = 5, Name="搜狐人群", Status=3, ExecuteTime=DateTime.Now, CreateTime = DateTime.Now, LastChanged=DateTime.Now },
                new AudienceTagInfo(){ Id = 6, Name="搜狗人群", Status=3,ExecuteTime=DateTime.Now.AddDays(-5),  CreateTime = DateTime.Now.AddDays(-5), LastChanged=DateTime.Now.AddDays(-5) },
                new AudienceTagInfo(){ Id = 7, Name="随视传媒人群", Status=4, ExecuteTime=DateTime.Now.AddDays(-5), CreateTime = DateTime.Now.AddDays(-5), LastChanged=DateTime.Now.AddDays(-5) },
                new AudienceTagInfo(){ Id = 8, Name="百度人群", Status=4,ExecuteTime=DateTime.Now.AddDays(-5),  CreateTime = DateTime.Now.AddDays(-5), LastChanged=DateTime.Now.AddDays(-5) },
                new AudienceTagInfo(){ Id = 9, Name="谷歌人群", Status=5, ExecuteTime=DateTime.Now.AddDays(-5), CreateTime = DateTime.Now.AddDays(-5), LastChanged=DateTime.Now.AddDays(-5) },
                new AudienceTagInfo(){ Id = 10, Name="微软人群", Status=5, ExecuteTime=DateTime.Now.AddDays(-5), CreateTime = DateTime.Now.AddDays(-5), LastChanged=DateTime.Now.AddDays(-5) },
            };
        }
    }
}
