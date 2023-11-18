using HospitalManagementSystem.Data.Models;

namespace HospitalManagementSystem.Data
{
    public static class FakeDb
    {
        public static List<Hospital> hospitalDb = new List<Hospital>()
        {
            new Hospital()
            {
                Id = 1,
                DateCreated = DateTime.UtcNow,
                DateUpdated = DateTime.UtcNow,
                HospitalName="Wellness Albania Clinic",
                EstablishedYear=2021,
                Address="Rruga Prokop Mima",
                ContactNumber="069 700 9090",
                Email="info@ohc.al",
                Website="https://wellnessalbania.al/"
            },
            new Hospital()
            {
                Id = 2,
                DateCreated = DateTime.UtcNow,
                DateUpdated = DateTime.UtcNow,
                HospitalName="Spitali Amerikan",
                EstablishedYear=2006,
                Address="Rruga e Dibrës 3",
                ContactNumber="04 235 7535",
                Email="info@spitaliamerikan.com",
                Website="https://al.spitaliamerikan.com/rreth-nesh/kontakt/"
            },
            new Hospital()
            {
                Id = 3,
                DateCreated = DateTime.UtcNow,
                DateUpdated = DateTime.UtcNow,
                HospitalName="Spitali Hygeia",
                EstablishedYear=2010,
                Address="Tiranë Kashar MËZEZ",
                ContactNumber="04 239 0000",
                Email="info@hygeia.com",
                Website="https://hygeia.al/"
            },
            new Hospital()
            {
                Id = 4,
                DateCreated = DateTime.UtcNow,
                DateUpdated = DateTime.UtcNow,
                HospitalName="Spitali Salus",
                EstablishedYear=2012,
                Address="Rruga Vidhe Gjata ",
                ContactNumber="04 239 0500",
                Email="info@salus.com",
                Website="https://salus.al/?lang=en"
            },
            new Hospital()
            {
                Id = 5,
                DateCreated = DateTime.UtcNow,
                DateUpdated = DateTime.UtcNow,
                HospitalName="Spitali GVM",
                EstablishedYear=2011,
                Address="Autostrata Tiranë - Durrës",
                ContactNumber="+355 69 40 56 150",
                Email="info@gvm.al",
                Website="https://gvm.al/kontakt"
            },
             new Hospital()
            {
                Id = 6,
                DateCreated = DateTime.UtcNow,
                DateUpdated = DateTime.UtcNow,
                HospitalName="Spitali Gjerman",
                EstablishedYear=2010,
                Address="Rruga Nikolla Lena",
                ContactNumber="067 200 4282",
                Email="recepsioni@spitaligjerman.com",
                Website="https://spitaligjerman.com/"
            },

        };
        // Metoda qe kthen listen e spitaleve
        public static List<Hospital> GetAllHospitals()
        {
            return hospitalDb;
        }

        public static List<MedicalService> medicalServiceDb = new List<MedicalService>()
        {
            new MedicalService()
            {
                Id = 1,
                ServiceName="Alergologji",
                Description="Specialitet që merret me parandalimin, diagnostikimin dhe trajtimin e sëmundjeve alergjike",
                Price=5000l,
                Category=new List<string> { "Konsulta me mjekun alergolog", "Ekzaminimet laboratorike", "Ekzaminimet në lëkurë", "Spirometria", "Trajtimi i sëmundjeve alergjike"},
                Doctors=new List<string> { "Alketa Bakiri", "Ornela Marko (Plaku)", "Aurora Skenderi" }
            },
            new MedicalService()
            {
                Id = 2,
                ServiceName="Anesteziologji",
                Description="Shërbime anesteziologjike për të gjitha kirurgjitë që zhvillohen në spital",
                Price=10000l,
                Category=new List<string> { "Anestezi e ndërhyrjeve kirurgjikale", "Anestezi e ndërhyrjeve ditore", "Sedatim në metodat invazive diagnostikuese", "Menaxhim i dhembjeve kronike", "Anestezi te të miturit dhe fëmijët"},
                Doctors=new List<string> { "Blerim Arapi", "Enton Bregasi", "Jonida Peci Shehaj" }
            },
            new MedicalService()
            {
                Id = 3,
                ServiceName="Kardiokirurgji",
                Description="Operacione për të trajtuar ndërlikimet e sëmundjeve ishemike të zemrës",
                Price=50000l,
                Category=new List<string> { "Bypass koronar ", "Riparim apo zëvendësim i valvulës së aortës", "Riparim apo zëvendësim i valvulës mitrale", "Ndërhyrje multivalvulare", "Çarjet e aortës"},
                Doctors=new List<string> { "Bledar Hodo", "Artan Jahollari", "Ilir Tanku" }
            },
            new MedicalService()
            {
                Id = 4,
                ServiceName="Imazheri e Avancuar",
                Description="Ofrojmë maksimumin e precizionit në mbështetjen me imazhe të diagnostikimit të saktë.",
                Price=5000l,
                Category=new List<string> { "Tomografi e Kompjuterizuar (Skaner) 64 detektorë", "CT kardiake", "Rezonancë Magnetike 1.5 Tesla", "Shintigrafi", "Mamografi"},
                Doctors=new List<string> { "Iris Allajbeu", "Bledi Cekrezi", "Fjorda Tuka" }
            },
            new MedicalService()
            {
                Id = 5,
                ServiceName="Reumatologji",
                Description="Trajtim i sëmundjeve reumatizmale",
                Price=4000l,
                Category=new List<string> { "Vizitë reumatologu", "Ekzaminime laboratorike/imazherike", "Kapilaroskopi", "Osteodensitometri", "Fizioterapi"},
                Doctors=new List<string> { "Laerta Kakariqi (Pepa)", "Ilektra Xhafa" }
            },
            new MedicalService()
            {
                Id = 6,
                ServiceName="Kardiologji",
                Description="Shërbimi i sëmundjeve të zemrës.",
                Price=100000l,
                Category=new List<string> { "Vizitë mjekësore", "EKG", "Kateterizim i zemrës", "EKO zemre transtorakale", "Koronarografi"},
                Doctors=new List<string> { "Nereida Ulqini Xhabija", "Indrit Temali", " Fatmir Sula" }
            },
        };
        // Metoda qe kthen listen e sherbimeve mjekesore
        public static List<MedicalService> GetAllMedicalServices()
        {
            return medicalServiceDb;
        }

    }
}
