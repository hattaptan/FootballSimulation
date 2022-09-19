using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballSimulation.Entities
{
    public class FootballTeam
    {


        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
         public int TeamId { get; set; }

        [StringLength(50)]
        public string FootballTeamName { get; set; }
         
    }
}
