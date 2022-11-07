using DataModel.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Resolver.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Configuration
{
    public class CategoryConfiguration
    {
        public CategoryConfiguration(EntityTypeBuilder<Category> entityBuilder)
        {
            entityBuilder.HasKey(u => u.Id);
            entityBuilder.Property(u => u.CategoryName).IsRequired().HasMaxLength(250);
            entityBuilder.Property(u => u.Description).HasMaxLength(1000);

            entityBuilder.HasData
            (
                new Category()
                {
                    Id = "4444da14-84ac-48de-a7da-a4f4ddd28858",
                    CategoryName = "ABARROTES",
                    Description = "Este tipo de recinto comercial ofrece alimentos envasados o de venta al peso, desde panes hasta productos lácteos pasando por conservas. Los abarrotes, en algunos países sudamericanos, se denominan almacenes.",
                    AccountId = "3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new Category()
                {
                    Id = "96e050b3-4f1c-4280-8ce0-1f32b6af87f1",
                    CategoryName = "PRODUCTOS ENLATADOS",
                    Description = "Un alimento enlatado, es por ende, un alimento fresco, incorporado en un recipiente metálico, herméticamente cerrado el cual se somete a un proceso de calentamiento a temperaturas superiores a los 100 °C, para conservarlo, lo más parecido posible, a su estado en forma natural hasta el momento de consumirlo.",
                    AccountId = "3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                }, 
                new Category()
                {
                    Id = "eeb60ffd-ff0d-4367-afc6-e28bef23f1ef",
                    CategoryName = "BEBIDAS ALCOHÓLICAS",
                    Description = "Las bebidas alcohólicas son aquellas bebidas que contienen etanol en su composición. Las bebidas alcohólicas desempeñan un papel social importante en muchas culturas del mundo, debido a su efecto de droga recreativa depresora.",
                    AccountId = "3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new Category()
                {
                    Id = "4af6f8b7-b1a5-4375-8319-079e3d8487fe",
                    CategoryName = "LÁCTEOS",
                    Description = "El grupo de los lácteos (también productos lácteos, lácticos o derivados lácteos) incluye alimentos como la leche y sus derivados procesados. Las plantas industriales que producen estos alimentos pertenecen a la industria láctea y se caracterizan por la manipulación de un producto altamente perecedero, como la leche, que debe vigilarse y analizarse correctamente durante todos los pasos de la cadena de frío hasta su llegada al consumidor.",
                    AccountId = "3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new Category()
                {
                    Id = "e7c4059e-04a1-4f4a-b5c9-b86da231147f",
                    CategoryName = "BOTANAS",
                    Description = "Es un tipo de aperitivo, ese plato que da inicio a una comida y se comparte entre los comensales. Algunas de las botanas más tradicionales generalmente están hechas con una masa de maíz que termina siendo tortillas, totopos, tostadas… y normalmente se acompañan con diferentes salsas.",
                    AccountId = "3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                }, 
                new Category()
                {
                    Id = "f350cdda-f912-4fd3-85c9-f99863ab6c2e",
                    CategoryName = "CONFITERÍA/DULCERIA",
                    Description = "El término repostería es el que se utiliza para denominar al tipo de gastronomía que se basa en la preparación, y decoración de platos dulces tales como pies, tartas, pasteles, galletas, budines, etc.",
                    AccountId = "3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                }, 
                new Category()
                {
                    Id = "c0f96f74-96cf-438a-b89f-0888182b3e75",
                    CategoryName = "HARINAS Y PAN",
                    Description = "Se encuentra todo sobre perfumeria",
                    AccountId = "3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                }, 
                new Category()
                {
                    Id = "b296430c-42de-41f8-8fc2-3f7fadb44218",
                    CategoryName = "FRUTAS Y VERDURAS",
                    Description = "Las frutas y verduras se consideran partes comestibles de las plantas (por ejemplo, estructuras portadoras de semillas, flores, brotes, hojas, tallos, brotes y raíces), ya sean cultivadas o cosechadas en forma silvestre, en estado crudo o en forma mínimamente elaborada.",
                    AccountId = "3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                }, 
                new Category()
                {
                    Id = "087aa814-3f3d-4cfb-83ef-e11256d6ecdb",
                    CategoryName = "BEBIDAS",
                    Description = "Bebida es cualquier líquido que se ingiere. La bebida más consumida es el agua. Otros ejemplos son las bebidas alcohólicas, bebidas gaseosas, infusiones o zumos. En Chile se le llama bebida exclusivamente a las gaseosas.",
                    AccountId = "3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                }, 
                new Category()
                {
                    Id = "13e20bf2-8bff-4201-b3bf-30cf7e2cdb12",
                    CategoryName = "ALIMENTOS PREPARADOS",
                    Description = "Alimento listo para el consumo: alimento que está en forma comestible, sin necesidad de lavado, cocimiento, o preparación adicional por parte del establecimiento de comida o consumidor, y se espera que sea consumido en esa forma.",
                    AccountId = "3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                }, 
                new Category()
                {
                    Id = "07dd4e15-386e-44c7-8f63-801c1dddeb1a",
                    CategoryName = "AUTOMEDICACIÓN",
                    Description = "La automedicación es la utilización de medicamentos por iniciativa propia sin ninguna intervención por parte del médico (ni en el diagnóstico de la enfermedad, ni en la prescripción o supervisión del tratamiento)",
                    AccountId = "3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                }, 
                new Category()
                {
                    Id = "9fc02177-e0ba-42cf-bc95-cd2f7abc4418",
                    CategoryName = "HIGIENE PERSONAL",
                    Description = "La higiene personal es el concepto básico del aseo, de la limpieza y del cuidado del cuerpo humano.",
                    AccountId = "3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                }, 
                new Category()
                {
                    Id = "21fcbb68-3e40-4550-b142-a302fc264a47",
                    CategoryName = "USO DOMÉSTICO",
                    Description = "USO DOMÉSTICO.",
                    AccountId = "3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                }, 
                new Category()
                {
                    Id = "db2ca371-5ba5-49d9-81cf-f04f49a61b0e",
                    CategoryName = "HELADOS",
                    Description = "En su forma más simple, el helado o crema helada es un alimento congelado que por lo general se hace de productos lácteos tales como leche o crema.",
                    AccountId = "3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                }, 
                new Category()
                {
                    Id = "27d5e91e-1229-49cd-964b-cc812a81faeb",
                    CategoryName = "JARCERÍA / PRODUCTOS DE LIMPIEZA",
                    Description = "Jarciería es el término que se refiere a toda aquella mercadería que se denomina comúnmente instrumentos de limpieza. Existe gran variedad de jarciería a la venta ya sea en la típica tienda de autoservicio o bien en compañías especializadas.",
                    AccountId = "3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                }, 
                new Category()
                {
                    Id = "9cb3d8c8-226e-4f1a-b04d-258db3329c75",
                    CategoryName = "OTROS PRODUCTOS",
                    Description = "Que no tiene una categoria especifico",
                    AccountId = "3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                }
            );
            entityBuilder.HasMany(e => e.SubCategories).WithOne(e => e.Category).HasForeignKey(e => e.CategoryId).IsRequired();
        }
    }
}
