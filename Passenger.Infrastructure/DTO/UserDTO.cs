using System;

namespace Passenger.Infrastructure.DTO
{
    public class UserDTO
    {
        //stworzyliśmy to dlatego, że chcemy aby modele z domeny były mapowane właśnie na takie
        //modele płaskie, które będą wykorzystywane przez nasze API, które w założeniu nie powinno 
        //nic wiedzieć o istnieniu domeny

        public Guid Id {get;  set;}
        //stworzenie unikalnego numeru id użytkownika
        public string Email {get; set;}
        
        public string Username {get; set;}
        public string FullName{get; set;}
        public DateTime CreatedAt{get; set;}

        //nasz zmapowany user będzie posiadał te pola 
    }
}