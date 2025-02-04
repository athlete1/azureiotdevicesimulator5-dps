﻿using IoT.Simulator.Settings.DPS;

using Newtonsoft.Json;

namespace IoT.Simulator.Settings
{
    public class DeviceSettings : SettingsBase
    {
        public string ArtifactId
        {
            get { return base.DeviceId; }
        }

        [JsonProperty("simulationSettings")]
        public SimulationSettingsDevice SimulationSettings
        { get; set; }

        [JsonProperty("certpfxbase64data")]
        public string Certpfxbase64data { get; set; }


    }
}
