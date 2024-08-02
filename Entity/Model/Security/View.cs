using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model.Security
{
    public class View
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public string Description { get; set; }
        public string CreateAt { get; set; }
        public string UpdateAt { get; set; }
        public string DeleteAt { get; set; }
        public bool State { get; set; }
        public List<View> ltsViews { get; set; }
    }
}
