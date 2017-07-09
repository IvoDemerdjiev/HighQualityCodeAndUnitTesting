namespace Computers.UI
{
    using System;

    using Logic;
    using Logic.Computers;
    using Logic.Manufacturers;
                    
    public static class Computers
    {
        private static PersonalComputer pc;
        private static Laptop laptop;
        private static Server server;

        public static void Main()
        {
            CreateComputers();
            ProcessCommands();
        }

        public static void CreateComputers()
        {
            var manufacturer = Console.ReadLine();
            IComputersFactory computersFactory;
            if (manufacturer == "HP")
            {
                computersFactory = new HpComputersFactory();
            }
            else if (manufacturer == "Dell")
            {
                computersFactory = new DellComputersFactory();
            }
            else if (manufacturer == "Lenovo")
            {
                computersFactory = new LenovoComputersFactory();
            }
            else
            {
                throw new InvalidArgumentException("Invalid manufacturer!");
            }

            pc = computersFactory.CreatePersonalComputer();
            laptop = computersFactory.CreteLaptop();
            server = computersFactory.CreateServer();
        }

        public static void ProcessCommands()
        {
            while (true)
            {
                var c = Console.ReadLine();
                if (c == null)
                {
                    break;
                }

                if (c.StartsWith("Exit"))
                {
                    break;
                }

                var cp = c.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (cp.Length != 2)
                {
                    throw new ArgumentException("Invalid command!");
                }

                var commandName = cp[0];
                var commandArgument = int.Parse(cp[1]);

                if (commandName == "Charge")
                {
                    laptop.ChargeBattery(commandArgument);
                }
                else if (commandName == "Process")
                {
                    server.Process(commandArgument);
                }
                else if (commandName == "Play")
                {
                    pc.Play(commandArgument);
                }
                else
                {
                    Console.WriteLine("Invalid command!");
                }
            }
        }
    }
}
