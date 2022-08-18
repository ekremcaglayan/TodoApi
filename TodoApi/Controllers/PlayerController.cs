using Microsoft.AspNetCore.Mvc;
using TodoApi.Model;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("player")]
    public class PlayerController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public List<Player> GetList()
        {
            return Storage.playerList;
        }

        [HttpGet]
        [Route("{id}")]
        // /player/1
        public Player Get(int id)
        {
            //GET -> /player/1
            var player = Storage.playerList.FirstOrDefault(player => player.Id == id);
            //Player selectPlayer = (from Player in playerList where Player.Id == id select Player).SingleOrDefault();
            return player;
        }

        [HttpGet]
        [Route("name/{name}")]
        // /player/name/ekrem
        public Player Get(string name)
        {
            var player = Storage.playerList.FirstOrDefault(player => player.Name == name);
            return player;
        }

        [HttpGet]
        [Route("age/{age}")]
        // /player/age/1
        public Player GetByAge(int age)
        {
            var player = Storage.playerList.FirstOrDefault(player => player.Age == age);
            return player;
        }

        [HttpPost]
        [Route("")]
        public List<Player> Post(Player createPlayerRequest)
        {
            var existPlayer = Storage.playerList.Any(player => player.Id == createPlayerRequest.Id);
            if (!existPlayer)
            {
                Storage.playerList.Add(createPlayerRequest);
            }
            return Storage.playerList;
        }

        [HttpPut]
        [Route("")]
        public void Put(Player createPlayerRequest)
        {
            var existPlayer = Storage.playerList.FirstOrDefault(player => player.Id == createPlayerRequest.Id);
            if (existPlayer == null)
            {
                throw new Exception();
            }
            existPlayer.Name = createPlayerRequest.Name;
            existPlayer.Surname = createPlayerRequest.Surname;
            existPlayer.Age = createPlayerRequest.Age;
        }

        [HttpDelete]
        [Route("")]
        public void Delete(int id)
        {
            Storage.playerList.RemoveAll(player => player.Id == id);
        }
    }
}