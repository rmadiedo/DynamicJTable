using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicJTable
{
    public class djtField
    {
        public string Name { get; set; }
        public bool ColumnResizable { get; set; }
        public bool Create { get; set; }
        public bool Edit { get; set; }
        public string DefaultValue { get; set; }
        public string DependsOn { get; set; }
        public string Display { get; set; }
        public string Title { get; set; }
    }
}
