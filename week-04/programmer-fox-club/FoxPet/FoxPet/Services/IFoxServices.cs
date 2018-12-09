using FoxPet.Models;
using System.Collections.Generic;

namespace FoxPet.Services
{
    public interface IFoxServices
    {
        List<Fox> FoxList { get; }

        void Add(string name);
        Fox Find(string name);
        bool Contains(Fox fox);
    }
}