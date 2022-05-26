using Datamodel = studentportalapi.DataModel;
using studentportalapi.DomainModel;
using AutoMapper;

namespace studentportalapi.Profiles
{
    public class Automapperprofiles : Profile
    {
        public Automapperprofiles()
        {
            CreateMap<Datamodel.Student, Student>().ReverseMap();


            CreateMap<Datamodel.Gender, Gender>().ReverseMap();

            CreateMap<Datamodel.Address, Address>().ReverseMap();

        }

    }
}
