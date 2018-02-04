using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ite.Models
{
    public class State
    {
        [Key]
        public byte StateId { get; set; }
        [Display(Name = "Тип")]
        public string StateText { get; set; }
    }
}