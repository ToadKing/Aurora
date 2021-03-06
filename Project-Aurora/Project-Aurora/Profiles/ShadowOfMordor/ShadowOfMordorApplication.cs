﻿using Aurora.Settings;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Aurora.Profiles.ShadowOfMordor
{
    public class ShadowOfMordor : Application
    {
        public ShadowOfMordor()
            : base(new LightEventConfig { Name = "Middle-earth: Shadow of Mordor", ID = "ShadowOfMordor", ProcessNames = new[] { "shadowofmordor.exe" }, SettingsType = typeof(FirstTimeApplicationSettings), ProfileType = typeof(ShadowOfMordorProfile), OverviewControlType = typeof(Control_ShadowOfMordor), GameStateType = typeof(GameState_Wrapper), Event = new GameEvent_ShadowOfMordor(), IconURI = "Resources/shadow_of_mordor_64x64.png" })
        {
            
        }
    }
}
