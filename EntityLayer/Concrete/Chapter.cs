using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public  class Chapter
    {
        [Key]
        public int ChapterId { get; set; }
        public int EduId { get; set; }
        public string Description { get; set; }
        public string ChapterHeader { get; set; }
        public Education Education { get; set; }    

    }
}
