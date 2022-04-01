using System.ComponentModel.DataAnnotations;

namespace BKD_NetCore_SQLServer.Models
{
    public class Credit_Card
    {
        public int id { get; set; }

        [Required]
        public string owner { get; set; }
        [Required]
        public string card { get; set; }
        [Required]
        public string exp { get; set; }
        [Required]
        public string cvv { get; set; }
    }
}
