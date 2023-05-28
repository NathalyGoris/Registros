using System.ComponentModel.DataAnnotations;

public class Prioridades
    {
        [Key]
        public int PrioridadId { get; set; }

        [Required (ErrorMessage = "El codigo de la prioridad es obligatorio")]
        public string? Codigo { get; set; }
    }