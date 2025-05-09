using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_23_24_25.Facade
{
    public class CPU { public void Freeze() => Console.WriteLine("CPU freeze"); }
    public class Memory { public void Load() => Console.WriteLine("Memory load"); }
    public class HardDrive { public void Read() => Console.WriteLine("HDD read"); }

    public class ComputerFacade
    {
        private readonly CPU _cpu = new();
        private readonly Memory _mem = new();
        private readonly HardDrive _hdd = new();

        public void Start()
        {
            _cpu.Freeze();
            _mem.Load();
            _hdd.Read();
        }
    }
}
