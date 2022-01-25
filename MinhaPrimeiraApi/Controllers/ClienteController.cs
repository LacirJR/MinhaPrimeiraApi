using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaPrimeiraApi.Controllers
{

    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly Conexoes.Sql _sql;

        public  ClienteController()
        {
            _sql = new Conexoes.Sql();
        }
        

        //INSERIR CLIENTE NA BD

        [HttpPost("v1/Cliente")]
        public void InserirCliente(Entidades.Cliente cliente)
        {
            _sql.InserirCliente(cliente);
        }
        
        //ATUALIZAR CLIENTE

        [HttpPut ("v1/ClienteAtualizar")]
        public void AtualizarCliente(Entidades.Cliente cliente)
        {
            _sql.AtualizarCliente(cliente);
        }

        // VERIFICAR EXISTENCIA NA BD COM O CPF

        [HttpGet("v1/ClienteVerificar/{cpf}")]
        public bool VerificarExistencia(string cpf)
        {
             return _sql.VerificarExistenciaCliente(cpf);
        }

        // DELETAR DA BD

        [HttpDelete("v1/ClienteDeletar")]
        public void DeletarCliente(Entidades.Cliente cliente)
        {
            _sql.DeletarCliente(cliente);
        }

        // LISTAR CLIENTE

        [HttpGet("v1/ClienteListar")]
        public List<Entidades.Cliente> ListarClientes()
        {
           return _sql.ListarClientes();
        }

        // SELECIONAR CLIENTE

        [HttpGet("v1/ClienteListar/{cpf}")]
        public Entidades.Cliente Selecionar(string cpf)
        {
           return _sql.SelecionarCliente(cpf);
        }

    }
}
