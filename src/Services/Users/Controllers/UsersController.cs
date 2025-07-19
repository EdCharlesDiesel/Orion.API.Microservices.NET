using System.Net;
using Microsoft.AspNetCore.Mvc;
using Orion.Services.Users.Entities;
using Orion.Services.Users.Repositories;


namespace Orion.Services.Users.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController(IUserRepository repository) : ControllerBase
    {
        private readonly IUserRepository _repository = repository ?? throw new ArgumentNullException(nameof(repository));

        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<User>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            var users = await _repository.GetUsers();
            return Ok(users);
        }


        [HttpGet("{id:length(24)}", Name = "GetUser")]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(User), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<User>> GetUserById(string id)
        {
            var User = await _repository.GetUser(id);
            return Ok(User);
        }

        [Route("[action]/{category}", Name = "GetUserByCategory")]
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<User>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<User>>> GetUserByCategory(string category)
        {
            var users = await _repository.GetUserByCategory(category);
            return Ok(users);
        }

        [HttpPost]
        [ProducesResponseType(typeof(User), (int)HttpStatusCode.Created)]
        public async Task<ActionResult<User>> CreateUser([FromBody] User User)
        {
            await _repository.CreateUser(User);

            return CreatedAtRoute("GetUser", new { id = User.Id }, User);
        }

        [HttpPut]
        [ProducesResponseType(typeof(User), (int)HttpStatusCode.NoContent)]
        public async Task<IActionResult> UpdateUser([FromBody] User User)
        {
            return Ok(await _repository.UpdateUser(User));
        }

        [HttpDelete("{id:length(24)}", Name = "DeleteUser")]
        [ProducesResponseType(typeof(User), (int)HttpStatusCode.NoContent)]
        public async Task<IActionResult> DeleteUserById(string id)
        {
            return Ok(await _repository.DeleteUser(id));
        }
    }

}
