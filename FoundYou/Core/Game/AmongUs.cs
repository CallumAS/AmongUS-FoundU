using FoundYou.Core.Memory;
using FoundYou.Core.Models;
using FoundYou.Core.Models.Enum;
using FoundYou.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FoundYou.Core.Game
{
    public class AmongUs
    {
        private readonly List<PPlayer> _players = new List<PPlayer>()
        {
            new PPlayer() { Name = "GameAssembly.dll+0x01468864,0x5C,0x0,0x24,0x8,0x10,0xC,0xC", Imposter = "GameAssembly.dll+0x01468864,0x5C,0x0,0x24,0x8,0x10,0x28", Dead = "GameAssembly.dll+0x01468864,0x5C,0x0,0x24,0x8,0x10,0x29", Colour = "GameAssembly.dll+0x01468864,0x5C,0x0,0x24,0x8,0x10,0x10"},
            new PPlayer() { Name = "GameAssembly.dll+0x01468864,0x5C,0x0,0x24,0x8,0x14,0xC,0xC", Imposter = "GameAssembly.dll+0x01468864,0x5C,0x0,0x24,0x8,0x14,0x28", Dead = "GameAssembly.dll+0x01468864,0x5C,0x0,0x24,0x8,0x14,0x29", Colour = "GameAssembly.dll+0x01468864,0x5C,0x0,0x24,0x8,0x14,0x10" },
            new PPlayer() { Name = "GameAssembly.dll+0x01468864,0x5C,0x0,0x24,0x8,0x18,0xC,0xC", Imposter = "GameAssembly.dll+0x01468864,0x5C,0x0,0x24,0x8,0x18,0x28", Dead = "GameAssembly.dll+0x01468864,0x5C,0x0,0x24,0x8,0x18,0x29", Colour = "GameAssembly.dll+0x01468864,0x5C,0x0,0x24,0x8,0x18,0x10" },
            new PPlayer() { Name = "GameAssembly.dll+0x01468864,0x5C,0x0,0x24,0x8,0x1C,0xC,0xC", Imposter = "GameAssembly.dll+0x01468864,0x5C,0x0,0x24,0x8,0x1C,0x28", Dead = "GameAssembly.dll+0x01468864,0x5C,0x0,0x24,0x8,0x1C,0x29", Colour = "GameAssembly.dll+0x01468864,0x5C,0x0,0x24,0x8,0x1C,0x10" },
            new PPlayer() { Name = "GameAssembly.dll+0x01468864,0x5C,0x0,0x24,0x8,0x20,0xC,0xC", Imposter = "GameAssembly.dll+0x01468864,0x5C,0x0,0x24,0x8,0x20,0x28", Dead = "GameAssembly.dll+0x01468864,0x5C,0x0,0x24,0x8,0x20,0x29", Colour = "GameAssembly.dll+0x01468864,0x5C,0x0,0x24,0x8,0x20,0x10" },
            new PPlayer() { Name = "GameAssembly.dll+0x01468864,0x5C,0x0,0x24,0x8,0x24,0xC,0xC", Imposter = "GameAssembly.dll+0x01468864,0x5C,0x0,0x24,0x8,0x24,0x28", Dead = "GameAssembly.dll+0x01468864,0x5C,0x0,0x24,0x8,0x24,0x29", Colour = "GameAssembly.dll+0x01468864,0x5C,0x0,0x24,0x8,0x24,0x10" },
            new PPlayer() { Name = "GameAssembly.dll+0x01468864,0x5C,0x0,0x24,0x8,0x28,0xC,0xC", Imposter = "GameAssembly.dll+0x01468864,0x5C,0x0,0x24,0x8,0x28,0x28", Dead = "GameAssembly.dll+0x01468864,0x5C,0x0,0x24,0x8,0x28,0x29", Colour = "GameAssembly.dll+0x01468864,0x5C,0x0,0x24,0x8,0x28,0x10" },
            new PPlayer() { Name = "GameAssembly.dll+0x01468864,0x5C,0x0,0x24,0x8,0x2C,0xC,0xC", Imposter = "GameAssembly.dll+0x01468864,0x5C,0x0,0x24,0x8,0x2C,0x28", Dead = "GameAssembly.dll+0x01468864,0x5C,0x0,0x24,0x8,0x2C,0x29", Colour = "GameAssembly.dll+0x01468864,0x5C,0x0,0x24,0x8,0x2C,0x10" },
            new PPlayer() { Name = "GameAssembly.dll+0x01468864,0x5C,0x0,0x24,0x8,0x30,0xC,0xC", Imposter = "GameAssembly.dll+0x01468864,0x5C,0x0,0x24,0x8,0x30,0x28", Dead = "GameAssembly.dll+0x01468864,0x5C,0x0,0x24,0x8,0x30,0x29", Colour = "GameAssembly.dll+0x01468864,0x5C,0x0,0x24,0x8,0x30,0x10" },
            new PPlayer() { Name = "GameAssembly.dll+0x01468864,0x5C,0x0,0x24,0x8,0x34,0xC,0xC", Imposter = "GameAssembly.dll+0x01468864,0x5C,0x0,0x24,0x8,0x34,0x28", Dead = "GameAssembly.dll+0x01468864,0x5C,0x0,0x24,0x8,0x34,0x29", Colour = "GameAssembly.dll+0x01468864,0x5C,0x0,0x24,0x8,0x34,0x10" }
        };
        private readonly string _killTimer = "GameAssembly.dll+0x01468910,0x5C,0x0,0x44";
        private readonly string _votingTimer = "GameAssembly.dll+0x01468910,0x5C,0x4,0x48";
        private readonly string _discussionTimer = "GameAssembly.dll+0x01468910,0x5C,0x4,0x44";
        private readonly string _activeColour = "GameAssembly.dll+0x01468910,0x5C,0x0,0x34,0x10";
        private readonly string _flashMode = "GameAssembly.dll+0x01468910,0x5C,0x4,0x14";
        private readonly string _x = "UnityPlayer.dll+0x12A86E0,0x80,0x5C,0x2C";
        private readonly string _y = "UnityPlayer.dll+0x12A86E0,0x80,0x5C,0x30";
        IntPtr BaseAddress = IntPtr.Zero;
        Mem Memory;
        public bool Connect() {
            Process[] processes = Process.GetProcessesByName("Among Us");
            if (processes.Length > 0)
            {
                Process myProc = processes[0];
                foreach (ProcessModule module in myProc.Modules)
                    if (module.ModuleName.Contains("GameAssembly"))
                        BaseAddress = module.BaseAddress;
                if (BaseAddress != IntPtr.Zero)
                {
                    Memory = new Mem();
                    if (Memory.OpenProcess("Among Us"))
                        return true;
                }
            } 
            return false;
        }
        public void ResetTimer() => Memory.WriteMemory(_killTimer, "Float", "0");
        public void NoVoting()
        {
            Memory.WriteBytes(_votingTimer, BitConverter.GetBytes(1));
            Memory.WriteBytes(_discussionTimer, BitConverter.GetBytes(1));
        }
        public void Teleport(int x, int y)
        {
            Memory.WriteMemory(_x, "Float", "0");
            Memory.WriteMemory(_y, "Float", "0");
        }
        public void Flash()
        {
            Memory.WriteMemory(_flashMode, "Float", "6");
        }

        public void Rainbow() => Memory.WriteBytes(_activeColour, BitConverter.GetBytes(Randomizer.Instance.Next(0,11)));
        public List<Player> Collect()
        {
            //Console.WriteLine(Memory.ReadInt(_x) + ", " + Memory.ReadInt(_y));
            List<Player> players = new List<Player>();
            foreach (var template in _players)
            {
                try
                {
                    Player player = new Player();
                    var name = Memory.ReadBytes(template.Name, 10 * 2);
                    if (name != null)
                    {
                        player.Name = Encoding.Unicode.GetString(name);
                        player.Dead = (Memory.ReadByte(template.Dead) == 1);
                        player.Imposter = (Memory.ReadByte(template.Imposter) == 1);
                        player.Colour = (PlayerColour)BitConverter.ToInt32(Memory.ReadBytes(template.Colour, 4), 0);
                        if (player.Imposter == true)
                            Console.WriteLine(player.Name + " | " + player.Colour);
                        players.Add(player);
                    }
                }
                catch { }
            }
            return players;
        }
    }
}
