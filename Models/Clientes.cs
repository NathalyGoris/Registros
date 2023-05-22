using System.ComponentModel.DataAnnotations;

	public class Clientes
	{
		[Key]
		public int ClienteId { get; set; }

		[Required (ErrorMessage = "El nombre del cliente ingresado es obligatorio")]
		public string? Nombre { get; set;}

		[Required (ErrorMessage = "El teléfono del cliente ingresado es obligatorio")]
		public string? Telefono { get; set; }

		[Required (ErrorMessage = "El celular del cliente ingresado es obligatorio")]
		public string? Celular { get; set; }
		
		[Range(1, int.MaxValue, ErrorMessage = "El valor ingresado en la cantidad debe ser mayor que cero.")]
		public int RNC { get; set; }

		[Required (ErrorMessage = "El email del cliente ingresado es obligatorio")]
		public string?  Email { get; set; }

		[Required (ErrorMessage = "La dirección del cliente ingresado es obligatorio")]	
		public string?  Direccion { get; set; }
	}
