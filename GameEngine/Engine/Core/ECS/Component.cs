using System.Collections.Generic;
using System.Numerics;
using Core;

namespace Core
{
    public abstract class Component
    {
        public GameEntity gameEntity = new();

        public virtual void Start() { }
        public virtual void Update() { }
        public virtual void OnDestroy() { }

        public virtual void OnTrigger() { }
    }
}