using System;

namespace Passenger.Core
{
    public class User
    {
        public Guid Id {get; protected set;}
        //stworzenie unikalnego numeru id użytkownika
        public string Email {get; protected set;}
        public string Password {get; protected set;}
        public string Salt {get; protected set;}
        public string Username {get; protected set;}
        public string FullName{get; protected set;}
        public DateTime CreatedAt{get; protected set;}

        
    protected User()
    // protected bo nie chcemy żeby stworzył ktoś klasę bez parametrów.
    // przyjęło się, że tworzone są dwa konstruktory jeden protected drugi public
    // protected tworzymy dlatego, iż może być to potrzebne do operacji związanych z naszą
    // bazą danych
    {
    }

    public User(string email, string username, string password, string salt)
    //tutaj będzie trzeba przeprowadzić walidację, może ona być realizowana za pomocą
    // regeksów
    {
        Id = Guid.NewGuid();
        //tworzymy nowego guida dla nowego użytkownika
        //Po co używać guidów? Na nie się powołujemy jak wykorzystujemy, gdzieś Usera, jak User
        // zmieni maila to nie musimy go wszędzie aktualizwoać tylko odnośnik czyli nasz Gudid
        //będzie od razu to zawierał
        Email = email.ToLowerInvariant();
        Username = username;
        Password = password;
        Salt = salt;
        CreatedAt = DateTime.UtcNow;
    }


    }

}