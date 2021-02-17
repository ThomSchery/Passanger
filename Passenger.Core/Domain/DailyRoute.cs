using System;
using System.Collections.Generic;

namespace Passenger.Core.Domain
{
    public class DailyRoute
    //to jest nasza trasa, którą będziemy jechać
    {
        public Guid Id {get; protected set;}
        public Route Route {get; protected set;}
        public IEnumerable<PassengerNode> PassengerNodes{get; private set;}
        //tutaj będą pasażerowie naszej trasy
    }
}