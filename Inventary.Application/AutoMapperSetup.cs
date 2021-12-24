using AutoMapper;
using Inventary.Application.DTOs;
using Inventary.Domain.Entities;

namespace Inventary.Application;
public class AutoMapperSetup : Profile
{
    public AutoMapperSetup()
    {
        CreateMap<Filme, FilmeDto>();
        CreateMap<FilmeDto, Filme>();
        CreateMap<Filme[], IEnumerable<FilmeDto>>();
        CreateMap<FilmeDto[], IEnumerable<Filme>>();
    }
}
