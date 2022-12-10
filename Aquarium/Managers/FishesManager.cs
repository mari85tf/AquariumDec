using Aquarium.Models;

namespace Aquarium.Managers
{
    public class FishesManager
    {
        private static int _nextId = 1;
        private static readonly List<Fish> Data = new List<Fish>
        {
            new Fish {Id = _nextId++, Name="Mariana", Length=23},
            new Fish {Id=_nextId++, Name="Dilnaz", Length=12},
            new Fish {Id=_nextId, Name="Nemo", Length=9}
            // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers
        };

        public List<Fish> GetAll()
        {
            return new List<Fish>(Data);
            // copy constructor
            // Callers should no get a reference to the Data object, but rather get a copy
        }

        public Fish GetById(int id)
        {
            return Data.Find(fish => fish.Id == id);
        }

        public Fish Add(Fish newFish)
        {
            newFish.Id = _nextId++;
            Data.Add(newFish);
            return newFish;
        }

        public Fish Delete(int id)
        {
            Fish fish = Data.Find(fish1 => fish1.Id == id);
            if (fish == null) return null;
            Data.Remove(fish);
            return fish;
        }

        public Fish Update(int id, Fish updates)
        {
            Fish fish = Data.Find(fish1 => fish1.Id == id);
            if (fish == null) return null;
            fish.Name = updates.Name;
            fish.Length = updates.Length;
            return fish;
        }
    }
}
