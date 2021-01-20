using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SuggestiveService.Models.AvailableData
{
    public class PolicyNumber
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string Product { get; set; }

        public string Scheme { get; set; }

        public int CurrentNumber { get; set; }

        public string Prefix { get; set; }

        public string Suffix { get; set; }
      
    }
}
