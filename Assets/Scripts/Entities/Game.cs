using Storages.Entities;

namespace Entities
{
    public interface IGame
    {
        LevelPath LevelPath { get; }
    }

    public class Game : IGame
    {
        public LevelPath LevelPath { get; init; }
    }
}