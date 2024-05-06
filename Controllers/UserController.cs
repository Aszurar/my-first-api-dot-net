using Microsoft.AspNetCore.Mvc;
using MyFirstAPI.Communication.Requests;
using MyFirstAPI.Communication.Responses;

namespace MyFirstAPI.Controllers;
public class UserController : MyFirstApiBaseController
{
    /*
       [HttpGet]
       [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
       [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
       public IActionResult Get()
       {
           return Ok("Sorvete");
       }

        header params 
        [HttpGet]
        [ProducesResponseType(typeof(Usuario), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public IActionResult Get([FromHeader] string language, [FromHeader] string permission)
        {
            var response = new Usuario
            {
                Id = 1,
                age = "20",
                nickname = "John"
            };

            return Ok(response);
        }  
      */

    /* query params  */
    [HttpGet]
    [ProducesResponseType(typeof(Usuario), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public IActionResult Get( string filter,  string? order)
    //public IActionResult Get([FromQuery] string filter, [FromQuery] string? order)
    {
        var response = new Usuario{
            Id = 1,
            age = "20",
            nickname = "John",
            key = GetCustomKey()
        };

        return Ok(response);
    } 

   

    /* route params */
    [HttpGet]
    [Route("{id}/person/{nickname}")]
    [ProducesResponseType(typeof(Usuario), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public IActionResult Get(int id, string nickname)
    {
        var response = new Usuario
        {
            Id = 1,
            age = "20",
            nickname = "John"
        };

        return Ok(response);
    }

    // Listagem de todos os usuários
    [HttpGet("all-users")]
    [ProducesResponseType(typeof(List<Usuario>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public IActionResult GetAll()
    {
        var response = new List<Usuario>
        {
            new Usuario
            {
                Id = 1,
                age = "20",
                nickname = "John"
            },
            new Usuario
            {
                Id = 2,
                age = "25",
                nickname = "Doe"
            }
        };

        return Ok(response);
    }   



    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisteredUserJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public IActionResult Create([FromBody] RequestRegisterUserJson request)
    {
        var response = new ResponseRegisteredUserJson
        {
            Id = 1,
            Nickname = request.Nickname,
            Age = request.Age
        };

        return Created(string.Empty, response);
    }

    //Contexto de usuário atualizando suas próprias informações
    [HttpPut]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public IActionResult Update([FromBody] RequestUpdateUserProfileJson request)
    {
        var response = new RequestUpdateUserProfileJson
        {
            Nickname = request.Nickname,
            Age = request.Age
        };

        return NoContent();
    }

    //Contexto de admnistrador atualizando várias informações
    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public IActionResult Update([FromRoute] int id, [FromBody] RequestUpdateUserProfileJson request)
    {

        return NoContent();
    }

    // Mudança de senha
    [HttpPut("change-password")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public IActionResult ChangePassword([FromBody] RequestChangePasswordJson request)
    {
        return NoContent();
    }

    //Contexto de usuário deletando suas próprias informações
    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public IActionResult Delete()
    {
        return NoContent();
    }

    //Contexto de admnistrador deletando várias informações
    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public IActionResult Delete([FromRoute] int id)
    {
        return NoContent();
    }
}
