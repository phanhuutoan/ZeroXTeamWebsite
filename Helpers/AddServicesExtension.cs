using Microsoft.Extensions.DependencyInjection;
using ZeroXTeam.Data;
using ZeroXTeam.Services;

namespace ZeroXTeam.Helpers
{
    public static class AddServicesExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {           
            services.AddSingleton<AdminFilterAction>();
            services.AddScoped<AdminRepository>();
            services.AddScoped<InformationRepository>();
            services.AddScoped<PhotoUploadService>();
            services.AddScoped<ProjectRepository>();
            services.AddScoped<MemberRepository>();
            services.AddScoped<ContactRepository>();
            services.AddScoped<BlogRepository>();
            services.AddScoped<RecruitmentRepository>();
            services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);

            return services;
        }
    }
}