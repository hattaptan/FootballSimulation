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
    public class Match : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("FixtureId")]
        public int FixtureId { get; set; }
        public Fixture Fixture { get; set; }

     
        
        public int ConcededGoal { get; set; }
      
        public int ScoredGoal { get; set; }
      
        public int Score { get; set; }
    }
}
