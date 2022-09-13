namespace HospiEnCasa.App.Dominio
{
  
    public class Paciente : Persona
    {
        public int Id { get; set; }
        public string Direccion { get; set; }
        public string Coordenadas { get; set; }
        public string Ciudad { get; set; }
        public string FechaNacimiento { get; set; }
        public int AuxiliarHospitalId {get; set; }
        public  AuxiliarHospital AuxiliarHospital {get; set; }
        public int MedicoId {get; set; }
        public Medico Medico {get; set; }
        public int EnfermeroId {get; set; }
        public Enfermera Enfermero {get; set; }
        public List<Historia> ListaHistorias {get; }  = new List<Historia>();
        public List<FamiliarDesignado> ListaFamiliar {get; }  = new List<FamiliarDesignado>();
    }
}