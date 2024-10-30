namespace Api_Capacitacion.Model
{
    public class UserModel
    {
        public int idUsuario { get; set; }
        public string? nombres { get; set; }
        public string? usuario { get; set; }
        public string? contrasena { get; set; }
        public List<TareaModel> Tareas { get; set; } = [];
    }
}
