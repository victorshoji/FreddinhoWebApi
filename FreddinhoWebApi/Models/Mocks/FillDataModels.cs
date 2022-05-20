using FreddinhoWebApi.Models.Entity;

namespace FreddinhoWebApi.Models.Mocks
{
    public static class FillDataModels
    {
        public static IList<PsychologistModel> CreatePsychologistGroup()
        {
            try
            {
                IList<PsychologistModel> psychologistsGroup = new List<PsychologistModel>();

                psychologistsGroup.Add(new PsychologistModel()
                {
                    Id = 1,
                    CelphoneNumber = 11985547771,
                    Name = "Débora Amaral Cerqueira",
                    Email = "deb.amaral@gmail.com",
                    Location = "23°37'49.8\"S 46°35'57.1\"W"
                });

                psychologistsGroup.Add(new PsychologistModel()
                {
                    Id = 2,
                    CelphoneNumber = 11985320014,
                    Name = "Fábio Andrade dos Santos",
                    Email = "fabio.a.santos@gmail.com",
                    Location = "23°30'56.4\"S 46°29'36.1\"W"
                });

                psychologistsGroup.Add(new PsychologistModel()
                {
                    Id = 3,
                    CelphoneNumber = 11974586621,
                    Name = "Patrícia Duarte",
                    Email = "pat_duarte@gmail.com",
                    Location = "23°34'46.9\"S 46°24'30.2\"W"
                });

                psychologistsGroup.Add(new PsychologistModel()
                {
                    Id = 4,
                    CelphoneNumber = 11996568653,
                    Name = "Ana Maria Souza",
                    Email = "anamaria.psicologa@gmail.com",
                    Location = "23°34'46.9\"S 46°24'30.2\"W"
                });

                psychologistsGroup.Add(new PsychologistModel()
                {
                    Id = 5,
                    CelphoneNumber = 11986579776,
                    Name = "Luisa Lima Matins",
                    Email = "luisamartins@psicologiaeducar.com.br",
                    Location = "23°34'40.5\"S 46°25'45.2\"W"
                });

                return psychologistsGroup;
            }
            catch
            {
                throw;
            }
        }

        public static PictureMapRange GetPictureMap(int id)
        {
            try 
            {
                IList<string> coordinate = new List<string>() { 
                    "107,178,119,175,122,181,124,189,123,194,108,196,106,193,103,189,102,184,104,179",
                    "15,59,36,57,63,54,86,53,124,51,145,50,164,51,187,50,188,55,183,58,163,56,141,58,125,62,119,68,125,73,125,76,118,77,26,86",
                    "84,93,88,91,93,94,97,95,97,98,93,98,92,101,89,99,86,101,84,99,79,98,81,95",
                    "241,168,248,171,257,170,254,174,251,177,241,175,239,175",
                    "172,192,177,178,183,171,195,166,204,164,214,165,216,169,207,170,199,171,194,177,184,180,179,184",
                    "179,67,180,60,185,56,190,56,195,58,199,61,201,67,199,69,193,70,186,72,181,70",
                    "234,36,243,27,239,39,237,46,240,51,247,55,260,57,276,60,297,63,319,67,331,73,341,80,339,89,337,95,329,83,314,73,295,67,284,66,269,63,253,61,241,57,233,52,233,43"
                };

                return new PictureMapRange() { CoordinateMap = coordinate };
            } 
            catch
            {
                throw;
            }
        }

        public static int GetRandomId()
        {
            try
            {
                return 1;
            }
            catch
            {
                throw;
            }
        }
    }
}