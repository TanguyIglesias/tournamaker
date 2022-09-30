using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Claims;
using tournamaker.Areas.Identity.Data;

namespace tournamaker.Models
{
    public class Tournoi
    {
        [Key]
        public int TournamentId { get; set; }

        public tournamakerUser Id { get; set; }

        [Display(Name="Tournament Name")]
        public string nom_tournoi { get; set; }

        [Display(Name = "Number of Players")]
        public string nombre_participant { get; set; }
        public string? list_participant_huitieme { get; set; }
        public string? score_huitieme { get; set; }
        public string? list_participant_quart { get; set; }
        public string? score_quart { get; set; }
        public string? list_participant_demi { get; set; }
        public string? score_demi { get; set; }
        public string? list_participant_final { get; set; }
        public string? score_final { get; set; }
    }
}
