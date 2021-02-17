namespace Passenger.Core.Domain
{
    public class PassengerNode
    //punkt zabrania pasażera, 
    {
        public Node Node {get; protected set;}
        //w jakim miejscu mam się zatrzymać
        public Passenger Passenger {get; protected set;}
    }
}