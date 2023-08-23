using System.Collections.Generic;
using System.Numerics;
using Core;

namespace Core
{
    public class ScriptSystem : GameSystem
    {
        public override void InnitSystem()
        {

        }
        public override void Update()
        {
            foreach (GameEntity gameEntity in ECSSystem.gameEntities)
            {
                foreach (Component component in gameEntity.components.Values)
                {
                    component.Update();
                }
            }
        }
    }
}