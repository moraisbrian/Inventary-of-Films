using AutoMapper;
using Inventary.Application.DTOs;
using Inventary.Application.Interfaces;
using Inventary.Domain.Entities;
using Inventary.Domain.Interfaces;

namespace Inventary.Application.Services;

public class FilmeService : IFilmeService
{
    private readonly IFilmeRepository _filmeRepository;
    private readonly IMapper _mapper;
    public FilmeService(IFilmeRepository filmeRepository, IMapper mapper)
    {
        _filmeRepository = filmeRepository;
        _mapper = mapper;
    }

    public async Task Adicionar(FilmeDto filmeDto)
    {
        var filme = _mapper.Map<Filme>(filmeDto);
        await _filmeRepository.Adicionar(filme);
    }

    public async Task Atualizar(FilmeDto filmeDto)
    {
        var filme = _mapper.Map<Filme>(filmeDto);
        await _filmeRepository.Atualizar(filme);
    }

    public async Task Deletar(int id)
    {
        await _filmeRepository.Deletar(id);
    }

    public async Task<IEnumerable<FilmeDto>> Obter()
    {
        var filmes = await _filmeRepository.Obter();
        return _mapper.Map<IEnumerable<FilmeDto>>(filmes);
    }

    public async Task<IEnumerable<FilmeDto>> ObterPorCategoria(string categoria)
    {
        var filmes = await _filmeRepository.ObterPorCategoria(categoria);
        return _mapper.Map<IEnumerable<FilmeDto>>(filmes);
    }

    public async Task<FilmeDto?> ObterPorId(int id)
    {
        var filme = await _filmeRepository.ObterPorId(id);
        return _mapper.Map<FilmeDto>(filme);
    }
}