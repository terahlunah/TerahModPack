using Merlin;
using UnityEngine;

using Merlin.Extensions;

namespace NoFog
{
    public class NoFogMod : MerlinMod
    {
        public override void OnLoad()
        {
            Weather.DisableFog();
        }
    }
}
