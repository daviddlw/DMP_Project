using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DMP_Project
{
    public class AudienceTagInfo
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Status { get; set; }

        public DateTime ExecuteTime { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime LastChanged { get; set; }

        public override string ToString()
        {
            return string.Format("【Id: {0}, Name: {1}, Status: {2}, CreateTime: {3}, LastChanged: {4}, ExecuteTime: {5}】", Id, Name, Status, CreateTime.ToString("yyyyMMdd"), LastChanged.ToString("yyyyMMdd"), ExecuteTime.ToString("yyyyMMdd"));
        }
    }
}
