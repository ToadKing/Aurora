﻿using Aurora.EffectsEngine;
using Aurora.Profiles.CSGO.GSI;
using Aurora.Profiles.CSGO.GSI.Nodes;
using Aurora.Settings;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aurora.Profiles.CSGO
{
    public class GameEvent_CSGO : LightEvent
    {
        public GameEvent_CSGO() : base()
        {
        }

        public override void UpdateLights(EffectFrame frame)
        {
            Queue<EffectLayer> layers = new Queue<EffectLayer>();

            CSGOProfile settings = (CSGOProfile)this.Application.Profile;

            foreach (var layer in Application.Profile.Layers.Reverse().ToArray())
            {
                if (layer.Enabled && layer.LogicPass)
                    layers.Enqueue(layer.Render(_game_state));
            }

            //Scripts
            this.Application.UpdateEffectScripts(layers, _game_state);

            //ColorZones
            layers.Enqueue(new EffectLayer("CSGO - Color Zones").DrawColorZones((this.Application.Profile as CSGOProfile).lighting_areas.ToArray()));

            frame.AddLayers(layers.ToArray());
        }

        public override void SetGameState(IGameState new_game_state)
        {
            if (new_game_state is GameState_CSGO)
            {
                _game_state = new_game_state;
            }
        }

        public override void ResetGameState()
        {
            _game_state = new GameState_CSGO();
        }
    }
}
