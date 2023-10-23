using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class test2
    {
        [Key]
        public int Test2ID { get; set; }
        public string Test2Name { get; set; }
    }
}
