using AutoMapper;
using Purple.Api.Dtos;
using Purple.Model.Personnel;
using System.Linq;

namespace Purple.Service
{
    public partial class PurpleProfile : Profile
    {
        public PurpleProfile()
        {
            CreateMap<PersonnelDto, Personnel>().ReverseMap();
        }
    }

    //public static class PurpleMapper // singleton olması gerekiyor
    //{
    //    public static IMapper Mapper { get; set; }

    //    public static IMapper GetMapper()
    //    {
    //        var config = new AutoMapper.Configuration.MapperConfigurationExpression();
    //        config.AddCollectionMappers();

    //        config.AllowNullCollections = true;

    //        config.AddProfile(new PurpleProfile());

    //        var mcfg = new MapperConfiguration(config);

    //        Mapper = mcfg.CreateMapper();

    //        return Mapper;
    //    }

    //    public static IMappingExpression<TSource, TDestination> IgnoreAllNonExisting<TSource, TDestination>(
    //        this IMappingExpression<TSource, TDestination> expression)
    //    {
    //        var sourceType = typeof(TSource);
    //        var destinationType = typeof(TDestination);
    //        var existingMaps = Mapper.ConfigurationProvider.GetAllTypeMaps().First(x => x.SourceType.Equals(sourceType) && x.DestinationType.Equals(destinationType));
    //        foreach (var property in existingMaps.GetUnmappedPropertyNames())
    //        {
    //            expression.ForMember(property, opt => opt.Ignore());
    //        }
    //        return expression;
    //    }
    //}
}
