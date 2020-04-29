using MyTemplate.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyTemplate.DAL.Entities
{
    public class PersonType : BaseEntity
    {

        [Required]
        public Guid rowguid { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }
    }
}
