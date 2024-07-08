using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Education
    {
        [Key]
        public int EduId { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public string Level { get; set; }
        public List <Chapter> Chapters { get; set; }
    }
}
