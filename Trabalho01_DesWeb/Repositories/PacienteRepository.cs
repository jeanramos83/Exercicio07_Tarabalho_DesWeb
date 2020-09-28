using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trabalho01_DesWeb.Models;
using Trabalho01_DesWeb.Validations;

namespace Trabalho01_DesWeb.Repositories
{
    public class PacienteRepository : IPacienteRepository
    {
        public object ListaPacientes { get; private set; }

        public DadosPacientes BuscaPacientePorId(int id)
        {
            throw new NotImplementedException();
        }

        public void InserePaciente(DadosPacientes dadosPacientes)
        {
            var validator = new PacienteValidator();
            var result = validator.Validate(dadosPacientes);
            if (result.IsValid)
              listaPacientes.Add(ListaTodosPacientes);
            else
                throw new Exception(result.Errors.FirstOrDefault().ToString());
             
        }

        public IList<DadosPacientes> ListaTodosPacientes()
        {
            IList<DadosPacientes> listaPacientes = new List<DadosPacientes>();
            listaPacientes.Add(new DadosPacientes() { id = 1, nome = "Paciente 1" });
            listaPacientes.Add(new DadosPacientes() { id = 2, nome = "Paciente 2" });
            return listaPacientes;
        }
    }
}
