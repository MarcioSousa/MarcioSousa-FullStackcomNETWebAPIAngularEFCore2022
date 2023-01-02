using Microsoft.AspNetCore.Mvc;
using ProEscolas.Domain;
using ProEscolas.Application.Services;
using System.Threading.Tasks;
using System;
using Microsoft.AspNetCore.Http;

namespace ProEscolas.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunosController : ControllerBase
    {
        private readonly IAlunoService _alunoService;

        public AlunosController(IAlunoService alunoService)
        {
            _alunoService = alunoService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var alunos = await _alunoService.Get();
                if(alunos == null) return NotFound("Nenhum aluno encotrado.");
                return Ok(alunos);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar recuperar alunos. Erro: {ex.Message}");
            }
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById(int Id)
        {
            try
            {
                var aluno = await _alunoService.Get(Id);
                if(aluno == null) return NotFound("Aluno por Id não encotnrado.");
                return Ok(aluno);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar recuperar alunos. Erro: {ex.Message}");
            }
            //return context.Alunos
            //    .FirstOrDefault(aluno => aluno.Id == Id);        
        }
        
        [HttpGet("nome/{nome}")]
        public async Task<IActionResult> GetByNome(string nome)
        {
            try
            {
                var alunos = await _alunoService.Get(nome);
                if(alunos == null) return NotFound("Alunos por nome não encotnrados.");
                return Ok(alunos);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar recuperar alunos. Erro: {ex.Message}");
            }     
        }

        [HttpPost]
        public async Task<IActionResult> Post(Aluno model)
        {
            try
            {
                var aluno = await _alunoService.Add(model);
                if(aluno == null) return BadRequest("Erro ao tentar adicionar aluno.");
                return Ok(aluno);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar adicionar o aluno. Erro: {ex.Message}");
            }     
        }

        [HttpPut("{Id}")]
        public async Task<IActionResult> Put(int id, Aluno model)
        {
            try
            {
                var aluno = await _alunoService.Update(id, model);
                if(aluno == null) return BadRequest("Erro ao tentar adicionar aluno.");
                return Ok(aluno);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar atualizar o aluno. Erro: {ex.Message}");
            }     
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                return await _alunoService.Delete(id) ? 
                            Ok("Deletado") : 
                            BadRequest("Aluno não deletado.");
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar deletar o aluno. Erro: {ex.Message}");
            }     
        }

    }
}