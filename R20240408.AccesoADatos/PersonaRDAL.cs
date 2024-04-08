
using Microsoft.EntityFrameworkCore;
using R20240408.EntidadesDeNegocio;

namespace R20240408.AccesoADatos
{
    public class PersonaRDAL
    {
        readonly AppDBContext _appDBContext;
        public PersonaRDAL(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        public async Task<int> Crear(PersonaR personaR)
        {
            _appDBContext.Add(personaR);
            return await _appDBContext.SaveChangesAsync();
        }
        public async Task<int> Modificar(PersonaR personaR)
        {
            var personaRData = await _appDBContext.PersonasR.FirstOrDefaultAsync(s => s.Id == personaR.Id);
            if (personaRData != null)
            {
                personaRData.NombreR = personaR.NombreR;
                personaRData.ApellidoR = personaR.ApellidoR;
                personaRData.FechaNacimientoR = personaR.FechaNacimientoR;
                personaRData.SueldoR = personaR.SueldoR;
                personaRData.EstatusR = personaR.EstatusR;
                personaRData.ComentarioR = personaR.ComentarioR;

                _appDBContext.Update(personaRData);
            }
            return await _appDBContext.SaveChangesAsync();
        }
        public async Task<int> Eliminar(PersonaR personaR)
        {
            var personaRData = await _appDBContext.PersonasR.FirstOrDefaultAsync(s => s.Id == personaR.Id);
            if (personaRData != null)
                _appDBContext.Remove(personaRData);
            return await _appDBContext.SaveChangesAsync();
        }

        public async Task<PersonaR> ObtenerPorId(PersonaR personaR)
        {
            var personaRData = await _appDBContext.PersonasR.FirstOrDefaultAsync(s => s.Id == personaR.Id);
            if (personaRData != null)
                return personaRData;
            else
                return new PersonaR();
        }
        public async Task<List<PersonaR>> ObtenerTodos()
        {
            return await _appDBContext.PersonasR.ToListAsync();
        }
        public async Task<List<PersonaR>> Buscar(PersonaR personaR)
        {

            var query = _appDBContext.PersonasR.AsQueryable();
            if (!string.IsNullOrWhiteSpace(personaR.NombreR))
            {
                query = query.Where(s => s.NombreR.Contains(personaR.NombreR));
            }
            if (!string.IsNullOrWhiteSpace(personaR.ApellidoR))
            {
                query = query.Where(s => s.ApellidoR.Contains(personaR.ApellidoR));
            }
            if (personaR.Take == 0)
                personaR.Take = 10;
            query = query.Take(personaR.Take);
            return await query.ToListAsync();
        }
    }
}
