using AutoMapper;

namespace CleanArchitecture.Aplication.AutoMapper
{
    public class AutoMapperConfiguration
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(config =>
            {
                config.AddProfile(new DomainToViewModelProfile());
                config.AddProfile(new ViewModelToDomainProfile());
            });
        }
    }
}
