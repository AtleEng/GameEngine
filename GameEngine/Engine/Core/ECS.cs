using System.Collections.Generic;
using System.Numerics;
using Core;

namespace Core
{
    public static class ECSSystem
    {
        static public List<GameEntity> gameEntities = new();
        static public Dictionary<Type, GameSystem> systems = new();

        static public List<GameEntity> entitiesToAdd = new();
        static public List<GameEntity> entitiesToRemove = new();
    }
    

    

   
}