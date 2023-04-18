using Microsoft.AspNetCore.Mvc;

namespace modul9_1302210032.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private static List<string> courses = new List<string>
        {
            "KPL", "BD", "PBO"
        };

        private static List<Mahasiswa> mahasiswas = new List<Mahasiswa>
        {
            new Mahasiswa("Herdi Ardana", "1302210078", courses, 2023),
            new Mahasiswa("Iqnaz Nadhif", "1302210104", courses, 2023),
            new Mahasiswa("Mochamad Rizky Evan Ramadhan", "1302213058", courses, 2023),
            new Mahasiswa("Rahman Ar Rasyid", "1302213088", courses, 2023),
            new Mahasiswa("Kamal Maulaazka Sidhqi", "1302210032", courses, 2023)
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return mahasiswas;
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa value)
        {
            mahasiswas.Add(value);
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return mahasiswas[id];
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            mahasiswas.RemoveAt(id);
        }
    }
}