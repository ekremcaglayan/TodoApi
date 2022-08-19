using Microsoft.AspNetCore.Mvc;
using TodoApi.Model;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("basketball")]
    public class BasketballerController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public List<Basketballer> GetList()
        {
            return Storage.basketballerList;
        }

        [HttpPost]
        [Route("")]
        public List<Basketballer> Post(Basketballer createPlayerRequest)
        {
            var existPlayer = Storage.basketballerList.Any(player => player.Id == createPlayerRequest.Id);
            if (!existPlayer)
            {
                Storage.basketballerList.Add(createPlayerRequest);
            }
            return Storage.basketballerList;
        }

        [HttpPut]
        [Route("")]
        public void Put(Basketballer createPlayerRequest)
        {
            var existPlayer = Storage.basketballerList.FirstOrDefault(player => player.Id == createPlayerRequest.Id);
            if (existPlayer == null)
            {
                throw new Exception();
            }
            existPlayer.Name = createPlayerRequest.Name;
            existPlayer.Surname = createPlayerRequest.Surname;
            existPlayer.Age = createPlayerRequest.Age;
            existPlayer.Position = createPlayerRequest.Position;
        }

        [HttpDelete]
        [Route("{id}")]
        public void Delete(int id)
        {
            Storage.basketballerList.RemoveAll(player => player.Id == id);
        }
    }
}