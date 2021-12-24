using Inventary.Application.DTOs;
using Inventary.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Inventary.Api.Controllers;

[ApiController]
[Authorize]
[Route("api/filmes")]
public class FilmeController : ControllerBase
{
    private readonly IFilmeService _filmeService;
    public FilmeController(IFilmeService filmeService)
    {
        _filmeService = filmeService;
    }

    [HttpGet]
    public async Task<IActionResult> ObterFilmes()
    {
        try
        {
            var filmes = await _filmeService.Obter();
            return Ok(filmes);
        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
    }

    [HttpGet("categoria/{categoria}")]
    public async Task<IActionResult> ObterFilmesPorCategoria(string categoria)
    {
        try
        {
            var filmes = await _filmeService.ObterPorCategoria(categoria);
            return Ok(filmes);
        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> ObterFilmesPorId(int id)
    {
        try
        {
            var filmes = await _filmeService.ObterPorId(id);
            return Ok(filmes);
        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
    }

    [HttpPut]
    public async Task<IActionResult> AtualizarFilme([FromBody] FilmeDto filme)
    {
        try
        {
            await _filmeService.Atualizar(filme);
            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletarFilme(int id)
    {
        try
        {
            await _filmeService.Deletar(id);
            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
    }

    [HttpPost]
    public async Task<IActionResult> Adicionar([FromBody] FilmeDto filmeDto)
    {
        try
        {
            await _filmeService.Adicionar(filmeDto);
            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
    }
}
