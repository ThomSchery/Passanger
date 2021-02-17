using System;
using Passenger.Core;
using Passenger.Core.Repositories;
using Passenger.Infrastructure.DTO;

namespace Passenger.Infrastructure.Services
//na Servisach będzie pracowało nasz API (nie będzie widziało Cora ani Repozytorii)
{
  public class UserService : IUserService
  {
    private readonly IUserRepository _userRepository;
    public UserService(IUserRepository userRepository)
    //1-tworzymy konstruktor,powołujący się na Repozytoria z Cora
    {
      _userRepository = userRepository;
    }

    public UserDTO Get(string email)
    {
      var user = _userRepository.Get(email);
      return new UserDTO
      {
        Id=user.Id,
        Username = user.Username,
        Email = user.Email,
        FullName = user.FullName
      };
    }

    public void Register(string email, string username, string password)
    {
      var user = _userRepository.Get(email);
        if(user != null)
        {
          throw new System.Exception($"User with email: {email} already exists.");
        }

        var salt = Guid.NewGuid().ToString("N");
        user = new User(email, username, password, salt );
        _userRepository.Add(user);
    }
  }
}