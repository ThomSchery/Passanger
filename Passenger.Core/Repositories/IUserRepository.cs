using System;
using System.Collections.Generic;

namespace Passenger.Core.Repositories
{
    //w core nie implementujemy niczego, tworzymy sobie tylko byty abstrakcyjne, poza naszymi modelami
    //domenowymi oraz zdarzeniami, robimy to za pomocą Interfejsów
    public interface IUserRepository
    {
         //będziemy mogli pobrać sobie naszego użytkownika za pomocą emailu
         User Get(Guid Id);
         User Get(string email);
         //stwarzamy sobie użytkownika, sqs osobno metody do tworzenia, odczytu
         void Add(User user);
         void Update(User user);
         void Remove(Guid Id);
         //metoda, która pobieże nam wszystkich użytkowników
         IEnumerable<User> GetAll();
         //może tutaj dojść jakaś paginacja, która zwraca tylko np 10 użtytkowników żeby nie obciążać
         //zbytnio bazy danych
    }
}