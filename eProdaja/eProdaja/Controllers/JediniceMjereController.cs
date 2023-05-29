using eProdaja.Model;
using eProdaja.Services;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JediniceMjereController
    {
        private readonly IJediniceMjere _service;

        public JediniceMjereController(IJediniceMjere service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<JediniceMjere> Get()
        {
           return _service.Get();
        }

        [HttpGet("{id}")]
        public JediniceMjere GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}
