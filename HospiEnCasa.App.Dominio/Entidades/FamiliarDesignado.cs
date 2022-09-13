namespace HospiEnCasa.App.Dominio
{
        /// <summary>Class <c>Familiar</c>
  
    public class FamiliarDesignado : Persona
    {
        public int Id { get; set; }
        public string Parentesco { get; set; }
        public string Email { get; set; }
        public int? PacienteId {get; set; }
        public Paciente Paciente {get; set; }
    }
}