using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DMP_Project
{
    public class WebSite
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int ClientId { get; set; }

        public int Status { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime LastChanged { get; set; }

        public override string ToString()
        {
            return string.Format("【Id: {0}, Name: {1}, ClientId: {2}, Status: {3}, CreateTime: {4}, LastChanged: {5}】", Id, Name, ClientId, Status, CreateTime.ToString("yyyyMMdd"), LastChanged.ToString("yyyyMMdd"));
        }
    }
}
