using System.ComponentModel.DataAnnotations;

namespace ToDo.Models
{
    public class Tarefa
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        public string  End_Completo { get; set; }

        public DateTime EndDate { get; set; }
        public bool Status { get; set; }

    }
}
