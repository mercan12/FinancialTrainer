using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public  class UserEducationRelation
    {
        [Key]
        public int RelationId { get; set; }
        public int UserId { get; set; }
        public int EduId { get; set; }
        public DateTime Date { get; set; }
        public bool RelStatus { get; set; }
        public User User { get; set; }
    }
}
