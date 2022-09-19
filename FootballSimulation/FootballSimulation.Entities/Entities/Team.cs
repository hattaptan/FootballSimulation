using FootballSimulation.Base.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FootballSimulation.Entities.Entities
{
    public class Team : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int  Id { get; set; }

        [StringLength(50)]
        public string TeamName { get; set; }
    }
}
