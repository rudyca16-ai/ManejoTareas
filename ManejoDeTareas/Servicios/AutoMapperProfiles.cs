using AutoMapper;
using ManejoDeTareas.Entidades;
using ManejoDeTareas.Models;

namespace ManejoDeTareas.Servicios
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
