using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixtureProject.Models
{
    public class Fixture
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 2)]
        [Required]
        public string SerialNo { get; set; }

        public string FixtureName { get; set; }

        [DefaultValue(0)]
        public Int32? UseCount { get; set; }
        public Int32? CycleCount { get; set; }
        public Int32? CeilingCount { get; set; }
        public DateTime? InvestmentDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }

        [DefaultValue(0)]
        public bool? Status { get; set; }

    }
}
