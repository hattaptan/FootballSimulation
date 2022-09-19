using FootballSimulation.Base.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballSimulation.Entities.Entities
{
    public class Fixture : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("HomeTeamId")]
        public int HomeTeamId { get; set; }
        public Team HomeTeam { get; set; }

        [ForeignKey("OpponentTeamId")]
        public int OpponentTeamId { get; set; }
        public Team OpponentTeam { get; set; }

        [ForeignKey("WeekId")]
        public int WeekId { get; set; }
        public Week Week { get; set; }



    }
}
