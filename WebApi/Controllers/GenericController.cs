using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericController<T, R> : ControllerBase where T : BaseModel where R : BaseRepository<T>
    {
        private R repository;

        public GenericController(R repository)
        {
            this.repository = repository;
        }
        [HttpGet]
        public List<T> Get()
        {

            return repository.GetAll();
        }

        [HttpGet("{id}")]
        public T GetById(int id)
        {

            return repository.GetById(id);
        }


        [HttpPost]
        public string Post(T model)
        {

            return repository.Create(model);
        }

        [HttpPut]
        public string Put(T model)
        {
            return repository.Update(model);
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return repository.Delete(id);
        }
    }
}
