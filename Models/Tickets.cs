//TicketId, Fecha, ClienteId, SistemaId, PrioridadId, SolicitadoPor, Asunto, Descripcion
using System.ComponentModel.DataAnnotations;

	public class Tickets
	{
		[Key]
		public int TicketId { get; set; }

		[Required (ErrorMessage = "El campo fecha es obligatorio")]
		public string? Fecha { get; set;}

		[Required (ErrorMessage = "El campo ClienteId obligatorio")]
		public string? ClienteId { get; set; }

		[Required (ErrorMessage = "El istemaId es obligatorio")]
		public string? SistemaId { get; set; }
		
		[Required (ErrorMessage = "Este campo es obligatorio.")]
		public string? SolicitadoPor { get; set; }

		[Required (ErrorMessage = "Este campo es obligatorio.")]
		public string?  Asunto { get; set; }

		[Required (ErrorMessage = "Este campo es obligatorio.")]	
		public string?  Descripcion { get; set; }
	}
