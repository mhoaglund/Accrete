
using System;
using UnityEngine;
namespace Assets.Scripts.Game.Compounds{
    ///Compound settings: hard to say what this really is right now.
    public class CompoundSettings{    
        public CompoundSettings()
        {
            
        }
    }




    ///A Compound has... gameplay stuff? A mesh? Does this really need to be a monobehavior?
    public class Compound : MonoBehavior{
        public CompoundStatus status = new CompoundStatus();
        public Compound(LevelGraphNode node, CompoundSettings settings = null)
        {
            //Initialize, maybe call for the mesh and set gameplay stuff up, then...
            
        }

        ///QOL class.
        private class CompoundStatus{
            private bool _Traversable;
            public bool Traversable
            {
                get { return _Traversable; }
                set { _Traversable = value; }
            }

            private bool _Loaded;
            public bool Loaded
            {
                get { return _Loaded; }
                set { _Loaded = value; }
            }

            private bool _Occupied;
            public bool Occupied
            {
                get { return _Occupied; }
                set { _Occupied = value; }
            }

            private bool _Isolated;
            public bool Isolated
            {
                get { return _Isolated; }
                set { _Isolated = value; }
            }

            public CompoundSettings()
            {
                Traversable = Loaded = Occupied = Isolated = false;
            }
        }
    }
}

