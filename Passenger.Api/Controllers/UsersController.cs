using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Passenger.Infrastructure.DTO;
using Passenger.Infrastructure.Services;

namespace Passenger.Api.Controllers
{
    // ten plik został skopiowany z valuescontroller i wywalone to czego nie widac
    [Route("[controller]")]
    public class UsersController : Controller
    {
        //3-przypisujemy go do prywatnego pola
        private readonly IUserService _userService;
        //2-definiujemy konstruktor
        public UsersController(IUserService userService)
        //(kontroler powołuje się na serwis)
        {
            //4-przypisujemy
            _userService = userService;
        }

        [HttpGet("{email}")]
        //5-chcemy zwrócić naszego użytkownika, zmieniamy:
        // public string Get(int id)
        // {
        //     return "value";
        // }
        public UserDTO Get(string email)
        {
            return _userService.Get(email);
        }
    }

}