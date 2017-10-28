using Merlin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flatlands
{
    public class FlatlandsMod : MerlinMod
    {
        public override void OnGenerateFertileTiles(TerrainGen terrain)
        {
            for (int x = 0; x < World.inst.GridWidth; x++)
            {
                for (int y = 0; y < World.inst.GridHeight; y++)
                {
                    terrain.SetFertileTile(x, y, 2);
                }
            }
        }

        public override void OnGenerateWater(TerrainGen terrain)
        {
            for (int x = 0; x < World.inst.GridWidth; x++)
            {
                for (int y = 0; y < World.inst.GridHeight; y++)
                {
                    terrain.SetLandTile(x, y);
                    Cell cell = World.inst.GetCellData(x, y);
                    cell.Type = ResourceType.None;
                }
            }
        }

        public override void OnGenerateTrees(TreeGrowth treeGrowth)
        {
            treeGrowth.MaxTreesOnMap = 3200;
        }
    }
}
