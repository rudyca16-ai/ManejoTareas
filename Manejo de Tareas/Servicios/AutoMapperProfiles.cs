using AutoMapper;
using Manejo_de_Tareas.Entidades;
using Manejo_de_Tareas.Models;

namespace Manejo_de_Tareas.Servicios
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Tarea, TareaDTO>()
                .ForMember(dto => dto.PasosTotal, ent => ent.MapFrom(x => x.Pasos.Count()))
                .ForMember(dto => dto.PasosRealizados, ent =>
                        ent.MapFrom(x => x.Pasos.Where(p => p.Realizado).Count()));
        }
    }
}
