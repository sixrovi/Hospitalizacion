namespace HospiEnCasa.App.Dominio
{
 
    public class Historia
    {
        public int Id { get; set; }

        public string Identificador { get; set; }
        public string Diagnostico { get; set; }
        public string Entorno { get; set; }
        public int PacienteId {get; set; }
        public Paciente Paciente {get; set; }
        public int MedicoId {get; set; }
        public Medico Medico {get; set; }
        public List<SignoVital> ListaSignosVitales {get; }  = new List<SignoVital>();
        public List<SugerenciaCuidado> ListaSugerencias {get; }  = new List<SugerenciaCuidado>();
    }
}