﻿using CommandLine;

using Microsoft.Azure.Devices.Client;

namespace IoT.Simulator.Settings.DPS
{
    /// <summary>
    /// Parameters for the application
    /// </summary>
    internal class DPSCAX509CommandParameters : DPSCommandParametersBase
    {
        [Option(
           'c',
           "DeviceCertificate",
           HelpText = "The device X509 certificate relative path (leaf) for DPS group enrollment. Required for X509CA security type.")]
        public string DeviceCertificatePath { get; set; }

        [Option(
           'p',
           "CertificatePassword",
           HelpText = "The device X509 certificate password. Required for X509CA security type.")]
        public string DeviceCertificatePassword { get; set; }
    }
}
