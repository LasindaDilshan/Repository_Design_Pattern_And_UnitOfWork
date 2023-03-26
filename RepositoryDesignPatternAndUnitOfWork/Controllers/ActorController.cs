using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieRepository.Domain.Repository;

namespace RepositoryDesignPatternAndUnitOfWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ActorController(IUnitOfWork unitOfWork)
        {
               _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public ActionResult Get()
        {
            var actorsFromRepo = _unitOfWork.ActorRepository.GetAll();
            return Ok(actorsFromRepo);
        }


        [HttpGet("movies")]
        public ActionResult GetWitMovies()
        {
            var actorswithmovies = _unitOfWork.ActorRepository.GetActorsWihMovies();
            return Ok(actorswithmovies);
        }

    }
}
