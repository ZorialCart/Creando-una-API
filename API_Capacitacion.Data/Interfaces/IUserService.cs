using Api_Capacitacion.Model;
using API_Capacitacion.DTO.User;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace API_Capacitacion.Data.Interfaces
{
    public interface IUserService
    {
        public Task<UserModel?> Create(CreateUserDTO createUserDTO);
        /*Método asíncrono que crea un nuevo usuario.
        Toma un objeto CreateUserDTO como parámetro, que contiene los datos necesarios para crear un nuevo usuario.
        Devuelve un Task que contiene un UserModel?, donde el ? indica que el valor puede ser nulo(es decir, 
        puede no encontrarse un usuario).*/

        public Task<IEnumerable<UserModel>> FindAll();
        /*Método asíncrono que devuelve todos los usuarios en forma de una colección (IEnumerable<UserModel>).
        Este método no recibe parámetros y se utiliza para listar todos los usuarios existentes*/

        public Task<UserModel?> Update(UpdateUserDTO updateUserDTO);
        /*Método asíncrono que actualiza un usuario existente.
        Toma un objeto UpdateUserDTO como parámetro, que contiene los datos del usuario a actualizar.
        Devuelve un Task que contiene un UserModel?, que puede ser nulo si no se encuentra el usuario a actualizar.*/

        public Task<UserModel?> Remove(int userId);
        /*Método asíncrono que elimina un usuario por su ID.
        Recibe un entero (userId) que identifica al usuario a eliminar.
        Devuelve un Task que contiene un UserModel?, que puede ser nulo si no se encuentra el usuario a eliminar.*/
    }
}
