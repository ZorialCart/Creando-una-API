using Api_Capacitacion.Model;
using API_Capacitacion.DTO.Tarea;

namespace API_Capacitacion.Data.Interfaces
{
    public interface ITareaService
    {
        public Task<TareaModel> Create(CreateTareaDTO createTareaDTO); //Crear tareas a partir de un objeto CreateTareaDTO
    }
}
