namespace Computers.Logic.Manufacturers
{
    using Computers;

    public interface IComputersFactory
    {
        PersonalComputer CreatePersonalComputer();

        Laptop CreteLaptop();

        Server CreateServer();
    }
}
