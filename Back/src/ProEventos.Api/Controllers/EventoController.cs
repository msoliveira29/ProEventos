using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.Api.Models;

namespace ProEventos.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _eventos =  new Evento[] {
            new Evento() {
                Id = 1,
                Tema = "Angular 11 e .NET 5",
                Local = "Belo HOrizonte",
                Lote = "1º Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2),
                ImagemURL = "foto.png",
                Email = "teste@phronesis.com.br",
                Telefone = "(11) 972220163"
            },
            new Evento() {
                Id = 2,
                Tema = "Angular 11 e suas novidades",
                Local = "São Paulo",
                Lote = "2º Lote",
                QtdPessoas = 350,
                DataEvento = DateTime.Now.AddDays(3),
                ImagemURL = "foto2.png",
                Email = "teste2@phronesis.com.br",
                Telefone = "(11) 972220164"
            }
        };

        public EventoController()
        {
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _eventos;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _eventos.Where(x => x.Id.Equals(id));
        }
    }
}