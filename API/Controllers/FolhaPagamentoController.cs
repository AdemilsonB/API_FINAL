using System;
using System.Linq;
using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
[ApiController]
    [Route("api/folhaPagamento")]
    public class FolhaPagamentoController : ControllerBase 
    {
        private readonly DataContext _context;
        public FolhaPagamentoController(DataContext context)
        {
            _context = context;
        }

        //POST: api/folhaPagamento/create
        [HttpPost]
        [Route("create")]
        public IActionResult Create([FromBody] FolhaPagamento folhaPgto)
        {
           
            FolhaPagamento novaFolhaPgto = _context.FolhasPagamento.FirstOrDefault(f => f.Funcionario == folhaPgto.Funcionario);

            if (novaFolhaPgto != null){
                return BadRequest(new { message = "Este funcionário já possui a folha deste mês!" });
            }

            _context.FolhasPagamento.Add(folhaPgto);
            _context.SaveChanges();
            return Created("", folhaPgto);         
           
            
        }

        //GET: api/folhaPagamento/list
        [HttpGet]
        [Route("list")]
        public IActionResult List() =>
            Ok(_context.FolhasPagamento.Include(f => f.Funcionario).ToList());    


        //GET: api/folhaPagamento/delete/id
        [HttpDelete]
        [Route("delete/{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            FolhaPagamento folhaPagamento = _context.FolhasPagamento.FirstOrDefault(
                folha => folha.Id == id
            );

            _context.FolhasPagamento.Remove(folhaPagamento);
            _context.SaveChanges();
            return Ok(folhaPagamento);
        }    
        
    }
}