using System;
using System.Collections.Generic;
using System.Linq;
using Passenger.Core;
using Passenger.Core.Repositories;

namespace Passenger.Infrastructure.Repositories
{
  public class InMemoryUserRepository : IUserRepository
  {
      private static ISet<User> _users = new HashSet<User>()
      {
          //6-stwarzamy sobie na potrzebe testowania już jakaś kolekcje użytkowników
          new User("user1@email.com", "user1", "secret", "salt"),
          new User("user2@email.com", "user2", "secret", "salt"),
          new User("user3@email.com", "user3", "secret", "salt"),
      };
      //stwarzamy sobie nową listę usersów
    public void Add(User user)
    {
        _users.Add(user);
    }

    public User Get(Guid id)
    
        =>_users.Single(x => x.Id == id);
        //linq
    

    public User Get(string email)
    
        =>_users.Single(x=>x.Email == email.ToLowerInvariant());
        //linq
    

    public IEnumerable<User> GetAll()
        => _users;
        //zwracamy usersów
    public void Remove(Guid id)
    {
        var user = Get(id);
        _users.Remove(user);
    }

    public void Update(User user)
    {
        throw new NotImplementedException();
    }
  }
}