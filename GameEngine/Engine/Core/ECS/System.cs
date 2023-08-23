using System.Collections.Generic;
using System.Numerics;
using Core;

namespace Core
{
    public abstract class GameSystem
    {
        public virtual void InnitSystem() { }
        public virtual void Update() { }
    }
}