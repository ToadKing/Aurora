﻿using System.Collections.Generic;
using Aurora.EffectsEngine;
using System.Drawing;
using Aurora.Profiles.Aurora_Wrapper;
using System.Linq;

namespace Aurora.Profiles.LeagueOfLegends
{
    public class GameEvent_LoL : GameEvent_Aurora_Wrapper
    {
        public GameEvent_LoL()
        {
        }

        protected override void UpdateExtraLights(Queue<EffectLayer> layers)
        {
            //ColorZones
            if (!((this.Application.Profile as LoLProfile).disable_cz_on_dark && last_fill_color.Equals(Color.Black)))
            {
                layers.Enqueue(new EffectLayer("League - Color Zones").DrawColorZones((this.Application.Profile as LoLProfile).lighting_areas.ToArray()));
            }
        }
    }
}
