using AutoMapper;
using Commander.Models;
using Commander.Dtos;

namespace Commander.Profiles
{
    public class CommandsProfile : Profile 
    {
        public CommandsProfile()
        {
            // Source -> Target

            // Reading
            CreateMap<Command, CommandReadDto>();

            // Creating
            CreateMap<CommandCreateDto, Command>();

            // Updaing (PUT)
            CreateMap<CommandUpdateDto, Command>();

            // For PATCH
            CreateMap<Command, CommandUpdateDto>();
        }
    }
}