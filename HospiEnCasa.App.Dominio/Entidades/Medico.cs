namespace HospiEnCasa.App.Dominio
{
  
    public class Medico : Persona
    {
        public int Id { get; set; }
        public string Especialidad { get; set; }
        public string RegRethus { get; set; }
        public List<Paciente> ListaPacientes {get; }  = new List<Paciente>();
        public List<Historia> ListaHistorias { get; } = new List<Historia>();
    }
}