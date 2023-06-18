using System.ComponentModel.DataAnnotations;

	public class TicketsDetalle
	{
		[Key]
		public int Id { get; set; }

		[Required (ErrorMessage = "El campo TicketId es obligatorio")]
		public int TicketId { get; set;}

		[Required (ErrorMessage = "El campo Emisor es obligatorio")]
		public string? Emisor { get; set; }

		[Required (ErrorMessage = "El campo Mensaje es obligatorio")]
		public string? Mensaje { get; set; }
    }