using R20240408.AccesoADatos;
using R20240408.EntidadesDeNegocio;

namespace R20240408.LogicaDeNegocio
{
    public class PersonaRBL
    {
        readonly PersonaRDAL _personaRDAL;

        public PersonaRBL(PersonaRDAL personaRDAL)
        {
            _personaRDAL = personaRDAL;
        }
        public async Task<int> Crear(PersonaR personaR)
        {
            return await _personaRDAL.Crear(personaR);
        }
        public async Task<int> Modificar(PersonaR personaR)
        {
            return await _personaRDAL.Modificar(personaR);
        }
        public async Task<int> Eliminar(PersonaR personaR)
        {
            return await _personaRDAL.Eliminar(personaR);
        }
        public async Task<PersonaR> ObtenerPorId(PersonaR personaR)
        {
            return await _personaRDAL.ObtenerPorId(personaR);
        }
        public async Task<List<PersonaR>> ObtenerTodos()
        {
            return await _personaRDAL.ObtenerTodos();
        }
        public async Task<List<PersonaR>> Buscar(PersonaR personaR)
        {
            return await _personaRDAL.Buscar(personaR);
        }
    }
}
