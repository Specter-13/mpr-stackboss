using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StackBoss.Web.Data.Entities
{
    public class RiskEntity
    {
        [Key]
        public int Id { get; set; }
        public string RiskName { get; set; }
        public string RiskCategory { get; set; }
     
    }
}
