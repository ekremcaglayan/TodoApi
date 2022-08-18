using Microsoft.AspNetCore.Mvc;
using TodoApi.Model;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("football")]
    public class FootballerController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public List<Footballer> GetList()
        {
            return Storage.footballerList;
        }

        [HttpPost]
        [Route("")]
        public List<Footballer> Post(Footballer createPlayerRequest)
        {
            var existPlayer = Storage.footballerList.Any(player => player.Id == createPlayerRequest.Id);
            if (!existPlayer)
            {
                Storage.footballerList.Add(createPlayerRequest);
            }
            return Storage.footballerList;
        }

        [HttpPut]
        [Route("")]
        public void Put(Footballer createPlayerRequest)
        {
            var existPlayer = Storage.footballerList.FirstOrDefault(player => player.Id == createPlayerRequest.Id);
            if (existPlayer == null)
            {
                throw new Exception();
            }
            existPlayer.Name = createPlayerRequest.Name;
            existPlayer.Age = createPlayerRequest.Age;
            existPlayer.Position = createPlayerRequest.Position;
        }

        [HttpDelete]
        [Route("")]
        public void Delete(int id)
        {
            Storage.footballerList.RemoveAll(player => player.Id == id);
        }
    }
}