using Microsoft.EntityFrameworkCore;
using RegonSearchApi.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegonSearchApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<VoivodeshipTbl>().HasData(new VoivodeshipTbl
            {
                VoivodeshipID = new Guid("242a57d2-89b6-4cd5-bba3-17c0796d57c7"),
                NameVoivodeship = "dolnośląskie"
            },
                new VoivodeshipTbl
                {
                    VoivodeshipID = new Guid("8b25122f-8667-4224-940b-c8c7e3a7f6ec"),
                    NameVoivodeship = "kujawsko-pomorskie"
                },
                new VoivodeshipTbl
                {
                    VoivodeshipID = new Guid("4af0cbd5-d35d-43c0-81e4-a56e5fa6c78a"),
                    NameVoivodeship = "lubelskie"
                },
                new VoivodeshipTbl
                {
                    VoivodeshipID = new Guid("a81dc8b1-915e-4a2e-8d36-e5724f7933f0"),
                    NameVoivodeship = "lubulskie"
                }, new VoivodeshipTbl
                {
                    VoivodeshipID = new Guid("0c4fad76-822b-4048-a6ab-ddbe2b07fcba"),
                    NameVoivodeship = "łódzkie"
                }, new VoivodeshipTbl
                {
                    VoivodeshipID = new Guid("ca72d518-6b27-46a8-8086-570fd0c9c433"),
                    NameVoivodeship = "małopolskie"
                }, new VoivodeshipTbl
                {
                    VoivodeshipID = new Guid("4674fedd-399f-4dd6-abdf-dbacf801f34d"),
                    NameVoivodeship = "mazowieckie"
                }, new VoivodeshipTbl
                {
                    VoivodeshipID = new Guid("7f808e29-7863-43d8-ab0d-7294475a4a42"),
                    NameVoivodeship = "opolskie"
                }, new VoivodeshipTbl
                {
                    VoivodeshipID = new Guid("af866bfb-a1ef-456f-bb53-0811a3b6fd6d"),
                    NameVoivodeship = "podkarpackie"
                }, new VoivodeshipTbl
                {
                    VoivodeshipID = new Guid("625e6a5b-40e4-4337-a315-d4fd2f2a4408"),
                    NameVoivodeship = "podlaskie"
                }, new VoivodeshipTbl
                {
                    VoivodeshipID = new Guid("a0f11602-8d86-429a-9e77-7cec71bd2d11"),
                    NameVoivodeship = "pomorskie"
                }, new VoivodeshipTbl
                {
                    VoivodeshipID = new Guid("3d7950c3-693c-42c2-a975-0bc1bb572f8e"),
                    NameVoivodeship = "śląskie"
                }, new VoivodeshipTbl
                {
                    VoivodeshipID = new Guid("f011d8cc-db4c-4165-8d61-8f8408286f36"),
                    NameVoivodeship = "świętokrzyskie"
                }, new VoivodeshipTbl
                {
                    VoivodeshipID = new Guid("e857b3e0-99f3-4ff0-b924-b7074c82947d"),
                    NameVoivodeship = "warmińsko-mazurskie"
                }, new VoivodeshipTbl
                {
                    VoivodeshipID = new Guid("1ad19f6a-070b-46f6-aff9-61667bbe2de7"),
                    NameVoivodeship = "wielkopolskie"
                }, new VoivodeshipTbl
                {
                    VoivodeshipID = new Guid("5687bbe7-08b9-4744-b62f-4a14f4ecbaf8"),
                    NameVoivodeship = "zachodniopomorskie"
                });

                builder.Entity<CityTbl>().HasData(
                new CityTbl
                {
                    CityID = new Guid("7f7fe442-017c-4a9c-ad2c-e796d9b6766c"),
                    VoivodeshipID = new Guid("4674fedd-399f-4dd6-abdf-dbacf801f34d"),
                    CityName = "Warszawa",
                    PostalCode = "00-004"
                },
                new CityTbl
                {
                    CityID = new Guid("0cdb8b1d-af2f-4152-b3c2-5127a26b3d09"),
                    VoivodeshipID = new Guid("ca72d518-6b27-46a8-8086-570fd0c9c433"),
                    CityName = "Kraków",
                    PostalCode = "30-001"
                }, new CityTbl
                {
                    CityID = new Guid("2e43a9c2-7a8e-47f2-aa8c-b3b8afbfa53d"),
                    VoivodeshipID = new Guid("0c4fad76-822b-4048-a6ab-ddbe2b07fcba"),
                    CityName = "Łódź",
                    PostalCode = "90-001"
                }, new CityTbl
                {
                    CityID = new Guid("898cea68-0ead-44d7-bd18-153de6e9c0a3"),
                    VoivodeshipID = new Guid("242a57d2-89b6-4cd5-bba3-17c0796d57c7"),
                    CityName = "Wrocław",
                    PostalCode = "50-001"
                }, new CityTbl
                {
                    CityID = new Guid("456214cc-8a84-403c-a8a9-e663930aba96"),
                    VoivodeshipID = new Guid("1ad19f6a-070b-46f6-aff9-61667bbe2de7"),
                    CityName = "Poznań",
                    PostalCode = "60-001"
                }, new CityTbl
                {
                    CityID = new Guid("851c78ed-3c17-4615-a4ff-3b8397bc2690"),
                    VoivodeshipID = new Guid("a0f11602-8d86-429a-9e77-7cec71bd2d11"),
                    CityName = "Gdańsk",
                    PostalCode = "80-008"
                }, new CityTbl
                {
                    CityID = new Guid("cba9b6f1-5525-4db0-bf12-cf7c5be75119"),
                    VoivodeshipID = new Guid("4674fedd-399f-4dd6-abdf-dbacf801f34d"),
                    CityName = "Radom",
                    PostalCode = "26-600 "
                }, new CityTbl
                {
                    CityID = new Guid("5ab5c3bc-d446-4982-b9fe-597d33afdd0b"),
                    VoivodeshipID = new Guid("5687bbe7-08b9-4744-b62f-4a14f4ecbaf8"),
                    CityName = "Szczecin",
                    PostalCode = "70-001"
                }, new CityTbl
                {
                    CityID = new Guid("697d4e2d-81b5-4534-ab9b-c3973067e44f"),
                    VoivodeshipID = new Guid("8b25122f-8667-4224-940b-c8c7e3a7f6ec"),
                    CityName = "Bydgoszcz",
                    PostalCode = "85-001"
                }, new CityTbl
                {
                    CityID = new Guid("ab48ffb4-cf77-41de-8cab-5f910facd057"),
                    VoivodeshipID = new Guid("a81dc8b1-915e-4a2e-8d36-e5724f7933f0"),
                    CityName = "Lublin",
                    PostalCode = "20-001"
                }, new CityTbl
                {
                    CityID = new Guid("22b495f0-13a3-4e32-a392-a7580e8aa056"),
                    VoivodeshipID = new Guid("625e6a5b-40e4-4337-a315-d4fd2f2a4408"),
                    CityName = "Białystok",
                    PostalCode = "15-001"
                }, new CityTbl
                {
                    CityID = new Guid("cf1f0746-7168-44b1-8fa6-38b6594a4a11"),
                    VoivodeshipID = new Guid("3d7950c3-693c-42c2-a975-0bc1bb572f8e"),
                    CityName = "Katowice",
                    PostalCode = "40-001"
                }, new CityTbl
                {
                    CityID = new Guid("e47ce57a-5d4d-41d2-9489-a799260dedd6"),
                    VoivodeshipID = new Guid("a0f11602-8d86-429a-9e77-7cec71bd2d11"),
                    CityName = "Gdynia",
                    PostalCode = "81-000"
                }, new CityTbl
                {
                    CityID = new Guid("527dc626-9cb4-4a19-bd44-f18a9f1821bf"),
                    VoivodeshipID = new Guid("3d7950c3-693c-42c2-a975-0bc1bb572f8e"),
                    CityName = "Częstochowa",
                    PostalCode = "42-200"
                });
        }

        public DbSet<VoivodeshipTbl> Voivodeships { get; set; }
        public DbSet<CityTbl> Cities { get; set; }
        public DbSet<CompanyTbl> Companies { get; set; }
        public DbSet<CompanyDetailTbl> CompanyDetails { get; set; }
    }
}
