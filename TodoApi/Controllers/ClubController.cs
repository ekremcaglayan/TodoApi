using Microsoft.AspNetCore.Mvc;
using TodoApi.Model;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("club")]
    public class ClubController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public List<Club> GetList()
        {
            return Storage.clubList;
        }

        [HttpGet]
        [Route("{clubId}")]
        public List<Footballer> Get(int clubId)
        {
            return Storage.footballerList.FindAll(player => player.ClubId == clubId);
        }

        [HttpPost]
        [Route("")]
        public List<Club> Post(Club createClubRequest)
        {
            var existClub = Storage.clubList.Any(club => club.Id == createClubRequest.Id);
            if (!existClub)
            {
                Storage.clubList.Add(createClubRequest);
            }
            return Storage.clubList;
        }

        [HttpPut]
        [Route("")]
        public void Put(Club createClubRequest)
        {
            var existClub = Storage.clubList.FirstOrDefault(club => club.Id == createClubRequest.Id);
            if (existClub == null)
            {
                throw new Exception();
            }
            existClub.Name = createClubRequest.Name;
            existClub.Year = createClubRequest.Year;
        }

        [HttpDelete]
        [Route("")]
        public void Delete(int id)
        {
            Storage.clubList.RemoveAll(club => club.Id == id);
        }
    }
}