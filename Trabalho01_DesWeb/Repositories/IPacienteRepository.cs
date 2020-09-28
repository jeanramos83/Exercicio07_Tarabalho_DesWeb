using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trabalho01_DesWeb.Models;

namespace Trabalho01_DesWeb.Repositories
{
    public interface IPacienteRepository
    {
        public IList<DadosPacientes> ListaTodosPacientes();
        public DadosPacientes BuscaPacientePorId(int id);
        public void InserePaciente(DadosPacientes dadosPacientes);
    }
}
