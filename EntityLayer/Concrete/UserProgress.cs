using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class UserProgress
    {
        [Key]
        public int ProgressId { get; set; }
        public int UserId { get; set; }
        public int ChapterId { get; set; }
        public bool Status {  get; set; }
        public User User { get; set; }

    }
}
