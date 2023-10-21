
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Serialization;
using SwallowApplicationApi.Models;
using System.Text.Json.Serialization.Metadata;

namespace SwallowApplicationApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers().AddNewtonsoftJson((options) => {
                // ���÷����ֶκ�ʵ�����ֶ����ִ�Сд����һ��
                options.SerializerSettings.ContractResolver = new DefaultContractResolver();
                // ���ڸ�ʽ
                options.SerializerSettings.DateFormatString = "yyyy-MM-dd HH:mm:ss";
            });
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<CoreDbContext>(x => x.UseMySQL(builder.Configuration.GetConnectionString("DefaultConnection")));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}