using DataModel.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Resolver.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Configuration
{
    public class SubCategoryConfiguration
    {
        public SubCategoryConfiguration(EntityTypeBuilder<SubCategory> entityBuilder)
        {
            entityBuilder.HasKey(u => u.Id);
            entityBuilder.Property(u => u.SubCategoryName).IsRequired().HasMaxLength(250);
            entityBuilder.Property(u => u.Description).HasMaxLength(1000);

            entityBuilder.HasData
            (
            #region Sub cateegoory ABARROTES
                new SubCategory()
                {
                    Id = "81806b92-46ce-4177-bcad-3c572857aec5",
                    CategoryId = "4444da14-84ac-48de-a7da-a4f4ddd28858",
                    SubCategoryName = "Aceite comestibles",
                    Description = "Aceite comestibles",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "c4a81f89-6f44-4c1c-bfd6-adf1f0a312e3",
                    CategoryId = "4444da14-84ac-48de-a7da-a4f4ddd28858",
                    SubCategoryName = "Aderezos",
                    Description = "Aderezos",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "51858237-ae9b-4731-88c2-f19a2d344c3c",
                    CategoryId = "4444da14-84ac-48de-a7da-a4f4ddd28858",
                    SubCategoryName = "Crema para café",
                    Description = "Crema para café",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "dc85f186-d18b-4a8b-a504-698fda19a9b6",
                    CategoryId = "4444da14-84ac-48de-a7da-a4f4ddd28858",
                    SubCategoryName = "Pure de tomate",
                    Description = "Pure de tomate",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "9a15a184-1821-4b06-9b6d-8624e62f42fb",
                    CategoryId = "4444da14-84ac-48de-a7da-a4f4ddd28858",
                    SubCategoryName = "Alimento para bebe",
                    Description = "Alimento para bebe",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "a4d3cc0d-8e39-460c-a02d-18fc2dced014",
                    CategoryId = "4444da14-84ac-48de-a7da-a4f4ddd28858",
                    SubCategoryName = "Alimento para mascotas",
                    Description = "Alimento para mascotas",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "6c9aa2b5-8cef-4621-b526-d94b08c17e46",
                    CategoryId = "4444da14-84ac-48de-a7da-a4f4ddd28858",
                    SubCategoryName = "Avena",
                    Description = "Avena",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "fd74c75f-db36-4101-bcd4-9b5d672f2c5a",
                    CategoryId = "4444da14-84ac-48de-a7da-a4f4ddd28858",
                    SubCategoryName = "Azúcar",
                    Description = "Azúcar",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "84990688-e3f9-45af-8f22-03c77262c614",
                    CategoryId = "4444da14-84ac-48de-a7da-a4f4ddd28858",
                    SubCategoryName = "Cereales",
                    Description = "Cereales",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "b21274b8-1f85-4034-aa24-f47ae1f46d00",
                    CategoryId = "4444da14-84ac-48de-a7da-a4f4ddd28858",
                    SubCategoryName = "Especias",
                    Description = "Especias",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "77c79cbb-b53e-40aa-aa80-043d4f221bec",
                    CategoryId = "4444da14-84ac-48de-a7da-a4f4ddd28858",
                    SubCategoryName = "Harina",
                    Description = "Harina",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "e5eab8bf-d214-4bb2-a42a-e73d6c8890d8",
                    CategoryId = "4444da14-84ac-48de-a7da-a4f4ddd28858",
                    SubCategoryName = "Sal",
                    Description = "Sal",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "995a74e1-98b5-4489-977d-f84113df2bc1",
                    CategoryId = "4444da14-84ac-48de-a7da-a4f4ddd28858",
                    SubCategoryName = "Sopas en sobre",
                    Description = "Sopas en sobre",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "1579c57f-cf33-4645-bfcc-4d09f92a70a3",
                    CategoryId = "4444da14-84ac-48de-a7da-a4f4ddd28858",
                    SubCategoryName = "Catsup",
                    Description = "Catsup",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "24a73edb-d737-42fa-a380-b2fdddd9ef44",
                    CategoryId = "4444da14-84ac-48de-a7da-a4f4ddd28858",
                    SubCategoryName = "Mayonesa",
                    Description = "Mayonesa",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "1a3985b7-65b2-4fc3-bf00-7d5764bd59f2",
                    CategoryId = "4444da14-84ac-48de-a7da-a4f4ddd28858",
                    SubCategoryName = "Mermelada",
                    Description = "Mermelada",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "208b7941-a0a1-47bb-8b6c-5108c0f4cc2b",
                    CategoryId = "4444da14-84ac-48de-a7da-a4f4ddd28858",
                    SubCategoryName = "Miel",
                    Description = "Miel",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "005dc5af-61c1-4b54-9266-03407ca75d10",
                    CategoryId = "4444da14-84ac-48de-a7da-a4f4ddd28858",
                    SubCategoryName = "Te",
                    Description = "Te",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "84bb56bb-c36d-4117-a4cf-e768990761eb",
                    CategoryId = "4444da14-84ac-48de-a7da-a4f4ddd28858",
                    SubCategoryName = "Vinagre",
                    Description = "Vinagre",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "524bbae4-38ca-4f9b-9603-aebcd65ecf84",
                    CategoryId = "4444da14-84ac-48de-a7da-a4f4ddd28858",
                    SubCategoryName = "Huevo",
                    Description = "Huevo",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "7fc35ef8-08f5-4504-b578-012b873574d9",
                    CategoryId = "4444da14-84ac-48de-a7da-a4f4ddd28858",
                    SubCategoryName = "Pastas",
                    Description = "Pastas",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
            #endregion

            #region Sub category PRODUCTOS ENLATADOS
                new SubCategory()
                {
                    Id  = "82fe357c-af4b-436b-b648-983a6092aa65",
                    CategoryId = "96e050b3-4f1c-4280-8ce0-1f32b6af87f1",
                    SubCategoryName = "Aceitunas",
                    Description = "Aceitunas",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "41e9e143-03db-4b0f-a51b-6b9160d357fc",
                    CategoryId = "96e050b3-4f1c-4280-8ce0-1f32b6af87f1",
                    SubCategoryName = "Champiñones enteros/rebanados",
                    Description = "Champiñones enteros/rebanados",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "90bb3117-ea6e-4868-9fc3-7504f685c03e",
                    CategoryId = "96e050b3-4f1c-4280-8ce0-1f32b6af87f1",
                    SubCategoryName = "Chícharo con zanahoria",
                    Description = "Chícharo con zanahoria",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "13722a31-d37e-4c44-9226-fef2dd6ab09e",
                    CategoryId = "96e050b3-4f1c-4280-8ce0-1f32b6af87f1",
                    SubCategoryName = "Chícharos enlatados",
                    Description = "Chícharos enlatados",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "07735a2d-1e10-404d-8ae4-28c05bab0e6b",
                    CategoryId = "96e050b3-4f1c-4280-8ce0-1f32b6af87f1",
                    SubCategoryName = "Frijoles enlatados",
                    Description = "Frijoles enlatados",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "a8f90356-989c-47a5-a6f6-ab338f283018",
                    CategoryId = "96e050b3-4f1c-4280-8ce0-1f32b6af87f1",
                    SubCategoryName = "Frutas en almíbar",
                    Description = "Frutas en almíbar",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "42496afc-b727-48cb-ae26-eb20c859bba7",
                    CategoryId = "96e050b3-4f1c-4280-8ce0-1f32b6af87f1",
                    SubCategoryName = "Sardinas",
                    Description = "Sardinas",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "9d6c9083-6b73-45c9-a61b-28800cfc5d0a",
                    CategoryId = "96e050b3-4f1c-4280-8ce0-1f32b6af87f1",
                    SubCategoryName = "Atún en agua/aceite",
                    Description = "Atún en agua/aceite",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "e3a46fc4-de62-41cc-8a11-305cbbf77ebb",
                    CategoryId = "96e050b3-4f1c-4280-8ce0-1f32b6af87f1",
                    SubCategoryName = "Chiles enlatados",
                    Description = "Chiles enlatados",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "1bc53107-6800-4b35-b4f3-c3363fb89a19",
                    CategoryId = "96e050b3-4f1c-4280-8ce0-1f32b6af87f1",
                    SubCategoryName = "Chiles envasados",
                    Description = "Chiles envasados",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "2cd8ebea-b8e5-408e-b098-4a6f635bc6bd",
                    CategoryId = "96e050b3-4f1c-4280-8ce0-1f32b6af87f1",
                    SubCategoryName = "Ensaladas enlatadas",
                    Description = "Ensaladas enlatadas",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "c3165ffb-7ad1-4730-8b00-a335edac1cc5",
                    CategoryId = "96e050b3-4f1c-4280-8ce0-1f32b6af87f1",
                    SubCategoryName = "Granos de elote enlatados",
                    Description = "Granos de elote enlatados",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "9c8dde52-8d6c-4b7c-9651-fef58287be61",
                    CategoryId = "96e050b3-4f1c-4280-8ce0-1f32b6af87f1",
                    SubCategoryName = "Sopa en lata",
                    Description = "Sopa en lata",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "25202d3f-46e2-4706-aa39-f1100063aeca",
                    CategoryId = "96e050b3-4f1c-4280-8ce0-1f32b6af87f1",
                    SubCategoryName = "Vegetales en conserva",
                    Description = "Vegetales en conserva",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
            #endregion

            #region Sub category BEBIDAS ALCOHÓLICAS
              new SubCategory()
              {
                  Id = "30c5ec35-19f7-4d52-aaa1-cfcf21987603",
                  CategoryId = "eeb60ffd-ff0d-4367-afc6-e28bef23f1ef",
                  SubCategoryName = "Bebidas preparadas",
                  Description = "Bebidas preparadas",
                  CreatedDate = DateTime.Now,
                  state = (Int32)StateEnum.Activeted
              },
              new SubCategory()
              {
                  Id = "6ad37caa-6ee5-4f73-ab41-ea2be3d77828",
                  CategoryId = "eeb60ffd-ff0d-4367-afc6-e28bef23f1ef",
                  SubCategoryName = "Cerveza",
                  Description = "Cerveza",
                  CreatedDate = DateTime.Now,
                  state = (Int32)StateEnum.Activeted
              },
              new SubCategory()
              {
                  Id = "cf17f4d4-cfc1-4c06-9f6a-6eac5062ede9",
                  CategoryId = "eeb60ffd-ff0d-4367-afc6-e28bef23f1ef",
                  SubCategoryName = "Anís",
                  Description = "Anís",
                  CreatedDate = DateTime.Now,
                  state = (Int32)StateEnum.Activeted
              },
              new SubCategory()
              {
                  Id = "7027f120-3478-4896-81cf-21bcff739315",
                  CategoryId = "eeb60ffd-ff0d-4367-afc6-e28bef23f1ef",
                  SubCategoryName = "Brandy",
                  Description = "Brandy",
                  CreatedDate = DateTime.Now,
                  state = (Int32)StateEnum.Activeted
              },
              new SubCategory()
              {
                  Id = "55136ca5-1c33-4e44-9e4d-34a06c6086f8",
                  CategoryId = "eeb60ffd-ff0d-4367-afc6-e28bef23f1ef",
                  SubCategoryName = "Ginebra",
                  Description = "Ginebra.",
                  CreatedDate = DateTime.Now,
                  state = (Int32)StateEnum.Activeted
              },
              new SubCategory()
              {
                  Id = "dd56fb2d-90d1-404d-bf33-3a2163a6fc20",
                  CategoryId = "eeb60ffd-ff0d-4367-afc6-e28bef23f1ef",
                  SubCategoryName = "Cordiales",
                  Description = "Cordiales",
                  CreatedDate = DateTime.Now,
                  state = (Int32)StateEnum.Activeted
              },
              new SubCategory()
              {
                  Id = "1a27fb1d-7b20-41a2-9c53-43e5afa27698",
                  CategoryId = "eeb60ffd-ff0d-4367-afc6-e28bef23f1ef",
                  SubCategoryName = "Mezcal",
                  Description = "Mezcal",
                  CreatedDate = DateTime.Now,
                  state = (Int32)StateEnum.Activeted
              },
              new SubCategory()
              {
                  Id = "247700b0-7887-45b1-b670-4e97c0b90b44",
                  CategoryId = "eeb60ffd-ff0d-4367-afc6-e28bef23f1ef",
                  SubCategoryName = "Jerez",
                  Description = "Jerez",
                  CreatedDate = DateTime.Now,
                  state = (Int32)StateEnum.Activeted
              },
              new SubCategory()
              {
                  Id = "bca46483-d119-4a9a-a72b-676d761ebb6a",
                  CategoryId = "eeb60ffd-ff0d-4367-afc6-e28bef23f1ef",
                  SubCategoryName = "Ron",
                  Description = "Ron",
                  CreatedDate = DateTime.Now,
                  state = (Int32)StateEnum.Activeted
              },
              new SubCategory()
              {
                  Id = "dd2d472b-252b-4963-a802-6e615657df04",
                  CategoryId = "eeb60ffd-ff0d-4367-afc6-e28bef23f1ef",
                  SubCategoryName = "Tequila",
                  Description = "Tequila",
                  CreatedDate = DateTime.Now,
                  state = (Int32)StateEnum.Activeted
              },
              new SubCategory()
              {
                  Id = "a5b8701d-c62c-476e-b22f-e666def4152a",
                  CategoryId = "eeb60ffd-ff0d-4367-afc6-e28bef23f1ef",
                  SubCategoryName = "Sidra",
                  Description = "Sidra",
                  CreatedDate = DateTime.Now,
                  state = (Int32)StateEnum.Activeted
              },
              new SubCategory()
              {
                  Id = "def25cbf-86db-4ae4-ae45-7a63a8d71c6c",
                  CategoryId = "eeb60ffd-ff0d-4367-afc6-e28bef23f1ef",
                  SubCategoryName = "Whiskey",
                  Description = "Whiskey",
                  CreatedDate = DateTime.Now,
                  state = (Int32)StateEnum.Activeted
              },
              new SubCategory()
              {
                  Id = "fef25062-8fc1-4006-8514-e234bfa63a05",
                  CategoryId = "eeb60ffd-ff0d-4367-afc6-e28bef23f1ef",
                  SubCategoryName = "Vodka",
                  Description = "Vodka",
                  CreatedDate = DateTime.Now,
                  state = (Int32)StateEnum.Activeted
              },
            #endregion

            #region Sub category LÁCTEOS
                new SubCategory()
                {
                    Id = "c7b90037-1c6d-4ad4-8397-5f04014ba97f",
                    CategoryId = "4af6f8b7-b1a5-4375-8319-079e3d8487fe",
                    SubCategoryName = "Leche condensada",
                    Description = "Se encuentra todo sobre perfumeria",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "1d5721d3-a787-4b8d-9d6f-ffb5d5262b21",
                    CategoryId = "4af6f8b7-b1a5-4375-8319-079e3d8487fe",
                    SubCategoryName = "Leche deslactosada",
                    Description = "Leche en polvo",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "6f9c9a1a-7ea6-40a2-9a50-feaa658493c7",
                    CategoryId = "4af6f8b7-b1a5-4375-8319-079e3d8487fe",
                    SubCategoryName = "Leche evaporada",
                    Description = "Leche evaporada",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "0c64e944-3a0b-49f4-a323-6edccc48ba35",
                    CategoryId = "4af6f8b7-b1a5-4375-8319-079e3d8487fe",
                    SubCategoryName = "Leche light",
                    Description = "Leche light",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "d75240b2-f901-46af-80be-fcb9a7bd174b",
                    CategoryId = "4af6f8b7-b1a5-4375-8319-079e3d8487fe",
                    SubCategoryName = "Leche pasteurizada",
                    Description = "Leche pasteurizada",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "6d2eac00-615c-4802-8706-ed8f3b339e26",
                    CategoryId = "4af6f8b7-b1a5-4375-8319-079e3d8487fe",
                    SubCategoryName = "Leche saborizada",
                    Description = "Leche saborizada",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "3e237426-d168-4f88-bdd5-44236546870a",
                    CategoryId = "4af6f8b7-b1a5-4375-8319-079e3d8487fe",
                    SubCategoryName = "Leche semidescremada",
                    Description = "Leche semidescremada",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "62664ce7-b8a0-4531-bfb9-932595f7d7a4",
                    CategoryId = "4af6f8b7-b1a5-4375-8319-079e3d8487fe",
                    SubCategoryName = "Crema",
                    Description = "Crema",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "ad74e8ce-c6cf-4f0d-a7c3-0b86a5690808",
                    CategoryId = "4af6f8b7-b1a5-4375-8319-079e3d8487fe",
                    SubCategoryName = "Yoghurt",
                    Description = "Yoghurt",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "35532f1d-0adf-460a-ad91-63e270f7a4db",
                    CategoryId = "4af6f8b7-b1a5-4375-8319-079e3d8487fe",
                    SubCategoryName = "Mantequilla",
                    Description = "Mantequilla",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "410e6eda-1fb4-4ced-84d2-3542b87ada40",
                    CategoryId = "4af6f8b7-b1a5-4375-8319-079e3d8487fe",
                    SubCategoryName = "Margarina",
                    Description = "Margarina",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "3861c055-4277-4c56-8114-5f2c1b898f5c",
                    CategoryId = "4af6f8b7-b1a5-4375-8319-079e3d8487fe",
                    SubCategoryName = "Media crema",
                    Description = "Media crema",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "b0848172-c1be-469b-b874-5143c420a137",
                    CategoryId = "4af6f8b7-b1a5-4375-8319-079e3d8487fe",
                    SubCategoryName = "Queso",
                    Description = "Queso",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
            #endregion,

            #region Sub category BOTANAS 
                new SubCategory()
                {
                    Id = "6399abe6-056a-425c-a41e-371e7f135bce",
                    CategoryId = "e7c4059e-04a1-4f4a-b5c9-b86da231147f",
                    SubCategoryName = "Papas",
                    Description = "Papas",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "e28f8d28-5cb6-4f56-918e-c822a0060452",
                    CategoryId = "e7c4059e-04a1-4f4a-b5c9-b86da231147f",
                    SubCategoryName = "Palomitas",
                    Description = "Palomitas",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "46c73d3e-d21b-4914-87a9-ebac432901e7",
                    CategoryId = "e7c4059e-04a1-4f4a-b5c9-b86da231147f",
                    SubCategoryName = "Frituras de maíz",
                    Description = "Frituras de maíz",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "5c19e99c-2b96-49cc-a968-7e5d270b1201",
                    CategoryId = "e7c4059e-04a1-4f4a-b5c9-b86da231147f",
                    SubCategoryName = "Cacahuates",
                    Description = "Cacahuates",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "bc0083b3-7fce-4fb2-92df-9d6be798366a",
                    CategoryId = "e7c4059e-04a1-4f4a-b5c9-b86da231147f",
                    SubCategoryName = "Botanas saladas",
                    Description = "Botanas saladas",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "82305cb1-de65-4b90-8734-87c5a768e7b3",
                    CategoryId = "e7c4059e-04a1-4f4a-b5c9-b86da231147f",
                    SubCategoryName = "Barras alimenticias",
                    Description = "Barras alimenticias",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "0e59c12d-d29f-4667-a3af-c1060d16ae94",
                    CategoryId = "e7c4059e-04a1-4f4a-b5c9-b86da231147f",
                    SubCategoryName = "Nueces y semillas",
                    Description = "Nueces y semillas",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
            #endregion

            #region Sub category CONFITERÍA/DULCERIA
                new SubCategory()
                {
                    Id = "0be5b0f7-62f6-4411-b540-82b51abc865a",
                    CategoryId = "f350cdda-f912-4fd3-85c9-f99863ab6c2e",
                    SubCategoryName = "Caramelos",
                    Description = "Caramelos",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "dbcc02e0-7b1e-406e-b3e0-a0f333b0062e",
                    CategoryId = "f350cdda-f912-4fd3-85c9-f99863ab6c2e",
                    SubCategoryName = "Dulces enchilados",
                    Description = "Dulces enchilados",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "8bac1ef3-473c-41a7-95a3-209fbea0c9b7",
                    CategoryId = "f350cdda-f912-4fd3-85c9-f99863ab6c2e",
                    SubCategoryName = "Chocolate de mesa",
                    Description = "Chocolate de mesa",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "a93bf77b-505b-46f8-8442-795bd47d83b2",
                    CategoryId = "f350cdda-f912-4fd3-85c9-f99863ab6c2e",
                    SubCategoryName = "Chocolate en polvo",
                    Description = "Chocolate en polvo",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "52cd0e99-22b0-4e17-ba9f-ad448b3b8766",
                    CategoryId = "f350cdda-f912-4fd3-85c9-f99863ab6c2e",
                    SubCategoryName = "Chocolates",
                    Description = "Chocolates",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "dca0c0d8-69a7-451c-bbe3-db4e4237daaf",
                    CategoryId = "f350cdda-f912-4fd3-85c9-f99863ab6c2e",
                    SubCategoryName = "Gomas de mascar",
                    Description = "Gomas de mascar",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "a37d971a-c292-4b59-8883-04362047cb2f",
                    CategoryId = "f350cdda-f912-4fd3-85c9-f99863ab6c2e",
                    SubCategoryName = "Mazapán",
                    Description = "Mazapán",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "eb4ed592-7499-4ea3-9c4d-aea95c4a86b1",
                    CategoryId = "f350cdda-f912-4fd3-85c9-f99863ab6c2e",
                    SubCategoryName = "Malvaviscos",
                    Description = "Malvaviscos",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "0c71411a-1acc-44ce-b5ba-c2bb01fac508",
                    CategoryId = "f350cdda-f912-4fd3-85c9-f99863ab6c2e",
                    SubCategoryName = "Pulpa de tamarindo",
                    Description = "Pulpa de tamarindo",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "c8cb23d4-2d87-41ec-a592-9535d366f9db",
                    CategoryId = "f350cdda-f912-4fd3-85c9-f99863ab6c2e",
                    SubCategoryName = "Pastillas de dulce",
                    Description = "Pastillas de dulce",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    Id = "95dc66d1-1de1-46de-a588-a5080f197aae",
                    CategoryId = "f350cdda-f912-4fd3-85c9-f99863ab6c2e",
                    SubCategoryName = "Paletas de dulce",
                    Description = "Paletas de dulce",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
            #endregion

            #region Sub category HARINAS Y PAN 
                new SubCategory()
                {
                    CategoryId = "c0f96f74-96cf-438a-b89f-0888182b3e75",
                    SubCategoryName = "Tortillas de harina/maíz",
                    Description = "Tortillas de harina/maíz",
                    Id = "9cdba6b6-d54a-467c-ae55-baa752ec67c7",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "c0f96f74-96cf-438a-b89f-0888182b3e75",
                    SubCategoryName = "Galletas dulces",
                    Description = "Galletas dulces",
                    Id = "4ba4eaad-c72c-4bf4-8715-2d1d58f1901b",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "c0f96f74-96cf-438a-b89f-0888182b3e75",
                    SubCategoryName = "Galletas saladas",
                    Description = "Galletas saladas",
                    Id = "d571e083-40cd-41db-8448-f55d4cc16780",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "c0f96f74-96cf-438a-b89f-0888182b3e75",
                    SubCategoryName = "Pastelillos",
                    Description = "Pastelillos",
                    Id = "86775899-0796-4ede-b76f-b2fb4b30aced",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "c0f96f74-96cf-438a-b89f-0888182b3e75",
                    SubCategoryName = "Pan de caja",
                    Description = "Pan de caja",
                    Id = "bd91bd5a-4f03-48d5-ab41-ff3900b3b566",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "c0f96f74-96cf-438a-b89f-0888182b3e75",
                    SubCategoryName = "Pan dulce",
                    Description = "Pan dulce",
                    Id = "1faacaec-d09a-4fb5-ab7f-3ca55c754ccd",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "c0f96f74-96cf-438a-b89f-0888182b3e75",
                    SubCategoryName = "Pan molido",
                    Description = "Pan molido",
                    Id = "f467869a-bbb7-4647-bb04-82e7bfd07eb5",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "c0f96f74-96cf-438a-b89f-0888182b3e75",
                    SubCategoryName = "Pan tostado",
                    Description = "Pan tostado",
                    Id = "c346edb2-02df-4453-9ba6-a8c718d671bd",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
            #endregion

            #region Sub category FRUTAS Y VERDURAS
                new SubCategory()
                {
                    CategoryId = "b296430c-42de-41f8-8fc2-3f7fadb44218",
                    SubCategoryName = "Aguacates",
                    Description = "Aguacates",
                    Id = "4b799d8f-ee08-4e8e-930e-ab8403392c4b",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "b296430c-42de-41f8-8fc2-3f7fadb44218",
                    SubCategoryName = "Ajos",
                    Description = "Ajos",
                    Id = "a39c1fd6-2a60-4b29-8ba9-3e263406caf2",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "b296430c-42de-41f8-8fc2-3f7fadb44218",
                    SubCategoryName = "Cebollas",
                    Description = "Cebollas",
                    Id = "bb789c84-5913-4a64-984b-20ad85a99de1",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "b296430c-42de-41f8-8fc2-3f7fadb44218",
                    SubCategoryName = "Chiles",
                    Description = "Chiles",
                    Id = "6cf0328c-d542-43be-baed-72af19417433",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "b296430c-42de-41f8-8fc2-3f7fadb44218",
                    SubCategoryName = "Cilantro/Perejil",
                    Description = "Cilantro/Perejil",
                    Id = "ce775a23-82b1-4cdf-9736-a378cdb88c8c",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "b296430c-42de-41f8-8fc2-3f7fadb44218",
                    SubCategoryName = "Jitomate",
                    Description = "Jitomate",
                    Id = "a64360a1-d91a-4405-9996-56ef3a89e32c",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "b296430c-42de-41f8-8fc2-3f7fadb44218",
                    SubCategoryName = "Papas",
                    Description = "Papas",
                    Id = "63efd264-3e31-480b-b86c-27c500705826",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "b296430c-42de-41f8-8fc2-3f7fadb44218",
                    SubCategoryName = "Limones",
                    Description = "Limones",
                    Id = "5656e6aa-f9cb-4add-99cb-a9f2696480a0",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "b296430c-42de-41f8-8fc2-3f7fadb44218",
                    SubCategoryName = "Manzanas",
                    Description = "Manzanas",
                    Id = "20db2648-207a-474b-a97d-d53451152de3",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "b296430c-42de-41f8-8fc2-3f7fadb44218",
                    SubCategoryName = "Naranjas",
                    Description = "Naranjas",
                    Id = "5df74c33-8b66-4999-a511-6aecc01faa33",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "b296430c-42de-41f8-8fc2-3f7fadb44218",
                    SubCategoryName = "Plátanos",
                    Description = "Plátanos",
                    Id = "8f762c3f-368d-412b-bd04-3090847b30ea",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
            #endregion

            #region Sub category BEBIDAS
                new SubCategory()
                {
                    CategoryId = "087aa814-3f3d-4cfb-83ef-e11256d6ecdb",
                    SubCategoryName = "Agua mineral",
                    Description = "Agua mineral",
                    Id = "d8fa7bc2-e8b5-44c4-b4ee-79f0db884832",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "087aa814-3f3d-4cfb-83ef-e11256d6ecdb",
                    SubCategoryName = "Agua natural",
                    Description = "Agua natural",
                    Id = "a1746970-5277-4100-87fb-27843e3e7572",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "087aa814-3f3d-4cfb-83ef-e11256d6ecdb",
                    SubCategoryName = "Agua saborizada",
                    Description = "Agua saborizada",
                    Id = "6d5403fe-eb3b-4e6a-b66f-5584d61c75d5",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "087aa814-3f3d-4cfb-83ef-e11256d6ecdb",
                    SubCategoryName = "Jarabes",
                    Description = "Jarabes",
                    Id = "b94e325c-2fa5-4c2e-ae97-66c53f7f23b1",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "087aa814-3f3d-4cfb-83ef-e11256d6ecdb",
                    SubCategoryName = "Jugos/Néctares",
                    Description = "Jugos/Néctares",
                    Id = "530edb0d-938c-4ae4-869a-567bf6bb529c",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "087aa814-3f3d-4cfb-83ef-e11256d6ecdb",
                    SubCategoryName = "Naranjadas",
                    Description = "Naranjadas",
                    Id = "7b3bdb7e-f9d4-4bfc-ab00-ad75b1e32185",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "087aa814-3f3d-4cfb-83ef-e11256d6ecdb",
                    SubCategoryName = "Bebidas de soya",
                    Description = "Bebidas de soya",
                    Id = "f586c0df-265a-46d3-9f7d-1219f269c2d6",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "087aa814-3f3d-4cfb-83ef-e11256d6ecdb",
                    SubCategoryName = "Bebidas en polvo",
                    Description = "Bebidas en polvo",
                    Id = "7002138f-f7fb-4a43-a880-060188703c09",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "087aa814-3f3d-4cfb-83ef-e11256d6ecdb",
                    SubCategoryName = "Bebidas infantiles",
                    Description = "Bebidas infantiles",
                    Id = "74bd441c-c526-4aa8-9948-467be87158e6",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "087aa814-3f3d-4cfb-83ef-e11256d6ecdb",
                    SubCategoryName = "Bebidas isotónicas",
                    Description = "Bebidas isotónicas",
                    Id = "25bb2d73-56d5-4479-bce5-a63aa1ca63d6",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "087aa814-3f3d-4cfb-83ef-e11256d6ecdb",
                    SubCategoryName = "Energetizantes",
                    Description = "Energetizantes",
                    Id = "c5ebff6a-ea3a-426c-a06c-38cfdf3fcc31",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "087aa814-3f3d-4cfb-83ef-e11256d6ecdb",
                    SubCategoryName = "Isotónicos",
                    Description = "Isotónicos",
                    Id = "09e77b14-a1c5-4094-8ae2-5af32ab26d5d",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "087aa814-3f3d-4cfb-83ef-e11256d6ecdb",
                    SubCategoryName = "Refrescos",
                    Description = "Refrescos",
                    Id = "fa7b0ef7-a5b5-48a8-80dd-bdbb51b3827a",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
            #endregion

            #region Sub category ALIMENTOS PREPARADOS 
                new SubCategory()
                {
                    CategoryId = "13e20bf2-8bff-4201-b3bf-30cf7e2cdb12",
                    SubCategoryName = "Pastas listas para comer",
                    Description = "Pastas listas para comer",
                    Id = "e06b976c-4745-4368-a615-3d011811589e",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "13e20bf2-8bff-4201-b3bf-30cf7e2cdb12",
                    SubCategoryName = "Sopas en vaso",
                    Description = "Sopas en vaso",
                    Id = "1174d492-edd1-4f9c-b7cf-ce8a6f68abc3",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "13e20bf2-8bff-4201-b3bf-30cf7e2cdb12",
                    SubCategoryName = "Carnes y Embutidos",
                    Description = "Carnes y Embutidos",
                    Id = "8a195233-1a00-4dbf-a41d-3c4c0d18b574",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "13e20bf2-8bff-4201-b3bf-30cf7e2cdb12",
                    SubCategoryName = "Salchicha",
                    Description = "Salchicha",
                    Id = "6557a6d3-5317-44c2-98fd-333064c87b13",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "13e20bf2-8bff-4201-b3bf-30cf7e2cdb12",
                    SubCategoryName = "Mortadela",
                    Description = "Mortadela",
                    Id = "77e2ee32-b9fc-4600-b28b-1ec5b0190e7d",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "13e20bf2-8bff-4201-b3bf-30cf7e2cdb12",
                    SubCategoryName = "Tocino",
                    Description = "Tocino",
                    Id = "a055a422-56d0-4852-ac24-5a5925002c35",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "13e20bf2-8bff-4201-b3bf-30cf7e2cdb12",
                    SubCategoryName = "Jamón",
                    Description = "Jamón",
                    Id = "a93e6d6a-fe84-4977-88f9-9eb5dac3c7e4",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "13e20bf2-8bff-4201-b3bf-30cf7e2cdb12",
                    SubCategoryName = "Manteca",
                    Description = "Manteca",
                    Id = "14348004-c92e-45b9-8cd4-c82060d3f291",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "13e20bf2-8bff-4201-b3bf-30cf7e2cdb12",
                    SubCategoryName = "Chorizo",
                    Description = "Chorizo",
                    Id = "e5bc3319-2a58-4df3-89bd-17edc123cc0a",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "13e20bf2-8bff-4201-b3bf-30cf7e2cdb12",
                    SubCategoryName = "Carne de puerco/res/pollo",
                    Description = "Carne de puerco/res/pollo",
                    Id = "88cfed2e-4469-4d95-8f08-252ce4f74e8f",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
            #endregion

            #region Sub category AUTOMEDICACIÓN
                new SubCategory()
                {
                    CategoryId = "07dd4e15-386e-44c7-8f63-801c1dddeb1a",
                    SubCategoryName = "Suero",
                    Description = "Suero",
                    Id = "ee9c7eb3-842a-4671-a046-96facfb2bcb6",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "07dd4e15-386e-44c7-8f63-801c1dddeb1a",
                    SubCategoryName = "Agua oxigenada",
                    Description = "Agua oxigenada",
                    Id = "19fe7044-5f20-4720-9bf3-9214b1d9fbef",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "07dd4e15-386e-44c7-8f63-801c1dddeb1a",
                    SubCategoryName = "Preservativos",
                    Description = "Preservativos",
                    Id = "8ac143dd-a639-4bad-9243-5706bf358ae1",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "07dd4e15-386e-44c7-8f63-801c1dddeb1a",
                    SubCategoryName = "Alcohol",
                    Description = "Alcohol",
                    Id = "ad774f0a-e895-47c4-8b7e-9593c5d37f8e",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "07dd4e15-386e-44c7-8f63-801c1dddeb1a",
                    SubCategoryName = "Gasas",
                    Description = "Gasas",
                    Id = "fefb0f12-c610-44ba-a425-b58344af0a3c",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "07dd4e15-386e-44c7-8f63-801c1dddeb1a",
                    SubCategoryName = "Analgésicos",
                    Description = "Analgésicos",
                    Id = "9f8fff37-92e9-465b-ae5d-8940ae1e1cd3",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "07dd4e15-386e-44c7-8f63-801c1dddeb1a",
                    SubCategoryName = "Antigripales",
                    Description = "Antigripales",
                    Id = "198c65d6-cb58-4d3f-be56-f1bc93fc0277",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "07dd4e15-386e-44c7-8f63-801c1dddeb1a",
                    SubCategoryName = "Antiácidos",
                    Description = "Antiácidos",
                    Id = "0d2d3a77-64c7-4fb3-aee0-366d262d3ce3",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
            #endregion

            #region Sub category HIGIENE PERSONAL
                new SubCategory()
                {
                    CategoryId = "9fc02177-e0ba-42cf-bc95-cd2f7abc4418",
                    SubCategoryName = "HIGIENE PERSONAL",
                    Description = "Se encuentra todo sobre perfumeria",
                    Id = "ed6b2c4a-bcf3-4d0b-8e98-83ddd98653b6",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "9fc02177-e0ba-42cf-bc95-cd2f7abc4418",
                    SubCategoryName = "HIGIENE PERSONAL",
                    Description = "Se encuentra todo sobre perfumeria",
                    Id = "65ade45e-c4b5-4b7d-9d71-2cfae455fe31",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "9fc02177-e0ba-42cf-bc95-cd2f7abc4418",
                    SubCategoryName = "HIGIENE PERSONAL",
                    Description = "Se encuentra todo sobre perfumeria",
                    Id = "c7296d61-4b18-46e9-8e26-7a809e636cb8",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "9fc02177-e0ba-42cf-bc95-cd2f7abc4418",
                    SubCategoryName = "HIGIENE PERSONAL",
                    Description = "Se encuentra todo sobre perfumeria",
                    Id = "b3ae5bf6-5836-4e90-9c69-637afde26bd7",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "9fc02177-e0ba-42cf-bc95-cd2f7abc4418",
                    SubCategoryName = "HIGIENE PERSONAL",
                    Description = "Se encuentra todo sobre perfumeria",
                    Id = "8efb933d-b689-4110-8cff-4a4e20f46104",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "9fc02177-e0ba-42cf-bc95-cd2f7abc4418",
                    SubCategoryName = "HIGIENE PERSONAL",
                    Description = "Se encuentra todo sobre perfumeria",
                    Id = "c31961f5-e6ab-4f1f-a398-04ff4c7c2368",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "9fc02177-e0ba-42cf-bc95-cd2f7abc4418",
                    SubCategoryName = "HIGIENE PERSONAL",
                    Description = "Se encuentra todo sobre perfumeria",
                    Id = "10db0819-5466-420d-acca-5ecaa864ec0a",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "9fc02177-e0ba-42cf-bc95-cd2f7abc4418",
                    SubCategoryName = "HIGIENE PERSONAL",
                    Description = "Se encuentra todo sobre perfumeria",
                    Id = "4d85744f-add3-4f9e-88c8-2c34ab4f815a",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "9fc02177-e0ba-42cf-bc95-cd2f7abc4418",
                    SubCategoryName = "HIGIENE PERSONAL",
                    Description = "Se encuentra todo sobre perfumeria",
                    Id = "9ba0b0c7-d09a-42e5-920d-fac472cfdad9",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "9fc02177-e0ba-42cf-bc95-cd2f7abc4418",
                    SubCategoryName = "HIGIENE PERSONAL",
                    Description = "Se encuentra todo sobre perfumeria",
                    Id = "933336aa-5883-46b4-b6af-3f5c89b5b973",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "9fc02177-e0ba-42cf-bc95-cd2f7abc4418",
                    SubCategoryName = "HIGIENE PERSONAL",
                    Description = "Se encuentra todo sobre perfumeria",
                    Id = "8aee87a6-643f-4197-abe7-ee9956cfe636",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "9fc02177-e0ba-42cf-bc95-cd2f7abc4418",
                    SubCategoryName = "HIGIENE PERSONAL",
                    Description = "Se encuentra todo sobre perfumeria",
                    Id = "796cfb96-7b0d-4558-a4a9-08a9fed29071",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "9fc02177-e0ba-42cf-bc95-cd2f7abc4418",
                    SubCategoryName = "HIGIENE PERSONAL",
                    Description = "Se encuentra todo sobre perfumeria",
                    Id = "8126f485-7a77-49c9-a3cb-de1be3b682bd",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "9fc02177-e0ba-42cf-bc95-cd2f7abc4418",
                    SubCategoryName = "HIGIENE PERSONAL",
                    Description = "Se encuentra todo sobre perfumeria",
                    Id = "85bb728e-2c64-4d40-9189-735313307bf8",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "9fc02177-e0ba-42cf-bc95-cd2f7abc4418",
                    SubCategoryName = "HIGIENE PERSONAL",
                    Description = "Se encuentra todo sobre perfumeria",
                    Id = "b71dd199-bb0d-44d2-98a1-71466e29b4ae",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "9fc02177-e0ba-42cf-bc95-cd2f7abc4418",
                    SubCategoryName = "HIGIENE PERSONAL",
                    Description = "Se encuentra todo sobre perfumeria",
                    Id = "70bc49ab-7e64-461a-a350-d18323fe6743",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "9fc02177-e0ba-42cf-bc95-cd2f7abc4418",
                    SubCategoryName = "HIGIENE PERSONAL",
                    Description = "Se encuentra todo sobre perfumeria",
                    Id = "b9d66a36-38d6-4d57-bad3-b0e949a5a574",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "9fc02177-e0ba-42cf-bc95-cd2f7abc4418",
                    SubCategoryName = "HIGIENE PERSONAL",
                    Description = "Se encuentra todo sobre perfumeria",
                    Id = "08bf4c2a-55b9-4449-ba44-7a18e61157fa",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "9fc02177-e0ba-42cf-bc95-cd2f7abc4418",
                    SubCategoryName = "HIGIENE PERSONAL",
                    Description = "Se encuentra todo sobre perfumeria",
                    Id = "65749701-c848-42a3-8549-b90938b0a98f",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "9fc02177-e0ba-42cf-bc95-cd2f7abc4418",
                    SubCategoryName = "HIGIENE PERSONAL",
                    Description = "Se encuentra todo sobre perfumeria",
                    Id = "c90a0767-fb77-4136-ab65-7719945e803a",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "9fc02177-e0ba-42cf-bc95-cd2f7abc4418",
                    SubCategoryName = "HIGIENE PERSONAL",
                    Description = "Se encuentra todo sobre perfumeria",
                    Id = "a77e5bf6-0d96-4922-999e-09b4909ebae5",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "9fc02177-e0ba-42cf-bc95-cd2f7abc4418",
                    SubCategoryName = "HIGIENE PERSONAL",
                    Description = "Se encuentra todo sobre perfumeria",
                    Id = "cb924254-4f5b-4e25-aafc-b3c6e51a26a7",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
            #endregion

            #region Sub category USO DOMÉSTICO
                new SubCategory()
                {
                    CategoryId = "21fcbb68-3e40-4550-b142-a302fc264a47",
                    SubCategoryName = "Suavizante de telas",
                    Description = "Suavizante de telas",
                    Id = "e7af707d-2029-4d1d-a10b-9a5c55d98ca2",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "21fcbb68-3e40-4550-b142-a302fc264a47",
                    SubCategoryName = "Ácido muriático",
                    Description = "Ácido muriático",
                    Id = "fec5fe83-b884-4d56-a5fe-6d7ab2156574",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "21fcbb68-3e40-4550-b142-a302fc264a47",
                    SubCategoryName = "Sosa caustica",
                    Description = "Sosa caustica",
                    Id = "a2a399bc-e461-40b5-85e0-dddc7b5ddea4",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "21fcbb68-3e40-4550-b142-a302fc264a47",
                    SubCategoryName = "Aluminio",
                    Description = "Aluminio",
                    Id = "b0a7966c-e4ab-426c-8628-c86106fbf3fe",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "21fcbb68-3e40-4550-b142-a302fc264a47",
                    SubCategoryName = "Pilas",
                    Description = "Pilas",
                    Id = "7be30abf-7504-480b-b0af-580ccc0be9ec",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "21fcbb68-3e40-4550-b142-a302fc264a47",
                    SubCategoryName = "Shampoo para ropa",
                    Description = "Shampoo para ropa",
                    Id = "a8e6b961-8f12-4679-a05c-0d72fdb4f755",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "21fcbb68-3e40-4550-b142-a302fc264a47",
                    SubCategoryName = "Servilletas",
                    Description = "Servilletas",
                    Id = "7e36389e-2514-4c1a-9b02-956cccb72b7a",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "21fcbb68-3e40-4550-b142-a302fc264a47",
                    SubCategoryName = "Servitoallas",
                    Description = "Servitoallas",
                    Id = "f7f2a895-0a64-4e47-bbab-9bd914eaa86e",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "21fcbb68-3e40-4550-b142-a302fc264a47",
                    SubCategoryName = "Aromatizantes",
                    Description = "Aromatizantes",
                    Id = "d295440a-24c8-4a8f-879a-41f9c883fa4b",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "21fcbb68-3e40-4550-b142-a302fc264a47",
                    SubCategoryName = "Cera para automóvil",
                    Description = "Cera para automóvil",
                    Id = "65bb2650-2d2a-46b4-841b-39bc67d3b132",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "21fcbb68-3e40-4550-b142-a302fc264a47",
                    SubCategoryName = "Cera para calzados",
                    Description = "Cera para calzados",
                    Id = "b83339e8-ec1b-44a4-8045-cb6e22905cd7",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "21fcbb68-3e40-4550-b142-a302fc264a47",
                    SubCategoryName = "Pastillas sanitarias",
                    Description = "Pastillas sanitarias",
                    Id = "d6d038ac-c428-4761-8d24-dc0703e8e4c2",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "21fcbb68-3e40-4550-b142-a302fc264a47",
                    SubCategoryName = "Limpiadores líquidos",
                    Description = "Limpiadores líquidos",
                    Id = "0dee8e1a-a3a8-411a-864a-542bf690fb34",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "21fcbb68-3e40-4550-b142-a302fc264a47",
                    SubCategoryName = "Limpiadores para pisos",
                    Description = "Limpiadores para pisos",
                    Id = "76ac4c24-9bc2-4897-a9a2-60529d306a14",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "21fcbb68-3e40-4550-b142-a302fc264a47",
                    SubCategoryName = "Jabón de barra",
                    Description = "Jabón de barra",
                    Id = "63eaca83-cacf-4d84-9b29-2fa454a9c206",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "21fcbb68-3e40-4550-b142-a302fc264a47",
                    SubCategoryName = "Detergentes para trastes",
                    Description = "Detergentes para trastes",
                    Id = "4c1f4d08-7a4b-43d3-beca-4959700e41bc",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "21fcbb68-3e40-4550-b142-a302fc264a47",
                    SubCategoryName = "Detergente para ropa",
                    Description = "Detergente para ropa",
                    Id = "2267271b-d123-4f63-8e8e-c1719a4ad20d",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "21fcbb68-3e40-4550-b142-a302fc264a47",
                    SubCategoryName = "Cerillos",
                    Description = "Cerillos",
                    Id = "b0c6bb87-7bb1-43d4-b6fa-43eb67694604",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "21fcbb68-3e40-4550-b142-a302fc264a47",
                    SubCategoryName = "Cloro/Blanqueador",
                    Description = "Cloro/Blanqueador",
                    Id = "bb40a622-9e9e-4c19-ae9f-545dc86bef0d",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "21fcbb68-3e40-4550-b142-a302fc264a47",
                    SubCategoryName = "Cloro para ropa",
                    Description = "Cloro para ropa",
                    Id = "cdea20ca-087d-4fb5-8553-105c1e2d9a84",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "21fcbb68-3e40-4550-b142-a302fc264a47",
                    SubCategoryName = "Insecticidas",
                    Description = "Insecticidas",
                    Id = "add2357f-a4bd-480d-9652-df476b521e4c",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "21fcbb68-3e40-4550-b142-a302fc264a47",
                    SubCategoryName = "Fibras limpiadoras",
                    Description = "Fibras limpiadoras",
                    Id = "11ae28fa-b2e2-44fb-8d65-aba73b937ead",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "21fcbb68-3e40-4550-b142-a302fc264a47",
                    SubCategoryName = "Desinfectantes",
                    Description = "Desinfectantes",
                    Id = "b4f45ffb-8b76-4304-bd06-706a228b5b10",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
            #endregion

            #region Sub category HELADOS
                new SubCategory()
                {
                    CategoryId = "db2ca371-5ba5-49d9-81cf-f04f49a61b0e",
                    SubCategoryName = "Paletas/ Helados",
                    Description = "Paletas/ Helados",
                    Id = "0c64f205-d9ca-4a4b-90ec-eac98fbf523c",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
            #endregion

            #region Sub category JARCERÍA / PRODUCTOS DE LIMPIEZA
                new SubCategory()
                {
                    CategoryId = "27d5e91e-1229-49cd-964b-cc812a81faeb",
                    SubCategoryName = "Veladoras/Velas",
                    Description = "Veladoras/Velas",
                    Id = "f66ac072-f4db-4bae-9ad3-25afe5d653b8",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "27d5e91e-1229-49cd-964b-cc812a81faeb",
                    SubCategoryName = "Cepillo de plástico",
                    Description = "Cepillo de plástico",
                    Id = "422edf4a-d9e6-40f4-9cc1-9b0dcd0756ac",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "27d5e91e-1229-49cd-964b-cc812a81faeb",
                    SubCategoryName = "Vasos desechables",
                    Description = "Vasos desechables",
                    Id = "66c6219a-a5eb-49d5-9a73-d36bb76d821a",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "27d5e91e-1229-49cd-964b-cc812a81faeb",
                    SubCategoryName = "Cinta adhesiva",
                    Description = "Cinta adhesiva",
                    Id = "8ef9734c-7ed8-4ce0-9899-d96b3da864eb",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "27d5e91e-1229-49cd-964b-cc812a81faeb",
                    SubCategoryName = "Cucharas de plástico",
                    Description = "Cucharas de plástico",
                    Id = "fb894ec4-3008-46d0-bcbd-10c66df049af",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "27d5e91e-1229-49cd-964b-cc812a81faeb",
                    SubCategoryName = "Escobas/Trapeadores/Mechudos",
                    Description = "Escobas/Trapeadores/Mechudos",
                    Id = "9538e426-3d8a-4575-aaeb-671bfadfcf4c",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "27d5e91e-1229-49cd-964b-cc812a81faeb",
                    SubCategoryName = "Trampas para ratas",
                    Description = "Trampas para ratas",
                    Id = "df953e9b-49b2-4c98-bf43-c0b89ffd2671",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "27d5e91e-1229-49cd-964b-cc812a81faeb",
                    SubCategoryName = "Tenedores de plástico",
                    Description = "Tenedores de plástico",
                    Id = "6eea4362-7ae5-4631-b3ca-571d523b3176",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "27d5e91e-1229-49cd-964b-cc812a81faeb",
                    SubCategoryName = "Extensiones/Multicontacto",
                    Description = "Extensiones/Multicontacto",
                    Id = "3b2730ed-eee3-4d6a-b7e2-46934dd2cd25",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "27d5e91e-1229-49cd-964b-cc812a81faeb",
                    SubCategoryName = "Recogedor de metal/plástico",
                    Description = "Recogedor de metal/plástico",
                    Id = "4636fd58-00ad-4f6c-ab97-6a91a2a6e210",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "27d5e91e-1229-49cd-964b-cc812a81faeb",
                    SubCategoryName = "Popotes",
                    Description = "Popotes",
                    Id = "3ba56596-8256-46a0-85b1-fcedb255c8a2",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "27d5e91e-1229-49cd-964b-cc812a81faeb",
                    SubCategoryName = "Platos desechables",
                    Description = "Platos desechables",
                    Id = "b1aac6b6-1e84-45a6-ac41-52e14a8ea1fa",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "27d5e91e-1229-49cd-964b-cc812a81faeb",
                    SubCategoryName = "Focos",
                    Description = "Focos",
                    Id = "19634b95-60be-45ec-8ca8-e508e273af05",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "27d5e91e-1229-49cd-964b-cc812a81faeb",
                    SubCategoryName = "Fusibles",
                    Description = "Fusibles",
                    Id = "aae444bc-4a86-4e9f-bfbd-71ad73da07a2",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "27d5e91e-1229-49cd-964b-cc812a81faeb",
                    SubCategoryName = "Jergas/Franelas",
                    Description = "Jergas/Franelas",
                    Id = "0d54b411-6a42-49b1-8a8a-ee2ac22aa1be",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "27d5e91e-1229-49cd-964b-cc812a81faeb",
                    SubCategoryName = "Matamoscas",
                    Description = "Matamoscas",
                    Id = "8c066537-f8d7-4031-9172-872081e1d0a3",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "27d5e91e-1229-49cd-964b-cc812a81faeb",
                    SubCategoryName = "Pegamento",
                    Description = "Pegamento",
                    Id = "591bac37-162a-4314-b0ae-46e9db02f691",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "27d5e91e-1229-49cd-964b-cc812a81faeb",
                    SubCategoryName = "Mecate/cuerda",
                    Description = "Mecate/cuerda",
                    Id = "dfce1885-ecbe-432e-9148-8a2d34809082",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
            #endregion

            #region Sub category OTROS PRODUCTOS
                new SubCategory()
                {
                    CategoryId = "9cb3d8c8-226e-4f1a-b04d-258db3329c75",
                    SubCategoryName = "Hielo",
                    Description = "Hielo",
                    Id = "98a5dd90-ba52-4534-998f-5da2e95e38b4",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "9cb3d8c8-226e-4f1a-b04d-258db3329c75",
                    SubCategoryName = "Tarjetas telefónicas",
                    Description = "Tarjetas telefónicas",
                    Id = "60366d57-cfe4-473a-a473-6e58fce5c928",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "9cb3d8c8-226e-4f1a-b04d-258db3329c75",
                    SubCategoryName = "Recargas móviles",
                    Description = "Recargas móviles",
                    Id = "24a39fa6-79d3-47c7-9e55-180bf92c2d89",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                },
                new SubCategory()
                {
                    CategoryId = "9cb3d8c8-226e-4f1a-b04d-258db3329c75",
                    SubCategoryName = "Cigarros",
                    Description = "Cigarros",
                    Id = "62433dfd-835e-4651-99f5-78ea6eefec3f",
                    CreatedDate = DateTime.Now,
                    state = (Int32)StateEnum.Activeted
                }
                #endregion
            );
        }
    }
}
