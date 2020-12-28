# Azure IoT Device Simulator (.NET5) - DPS version - Readme

## New features
This project is the next step of a set of simulators which were born with the purpose to help IoT developers and testers. This new version takes the regular simulator and adds to him Device Provisioning Capabilities (DPS). For now, the supported provisioning mode is of type:
 - group
 - symmetric key

This responds to more "enterprise" oriented use cases but without the complexity of adding certificates.
This said, upcoming updates will add the support of X509 certificates.

## Description
The solution is an Azure IoT Device simulator that implements different types of Cloud To Device (C2D) / Device To Cloud (D2C) flows between [Microsoft Azure IoT Hub](https://azure.microsoft.com/en-us/services/iot-hub/) and the simulated device.

<br/>

For more information:
 - [*How to (Quickstart)*](sources/IoT.Simulator/IoT.Simulator/docs/HowTo.md)
 - [*Help  and details*](sources/IoT.Simulator/IoT.Simulator/docs/Help.md) 
 
 <br/>

Example of uses:
 - development tool for developers working in Microsoft Azure IoT solutions (cloud)
 - tester tool in IoT-oriented projects
 - scalable IoT simulation platforms
 - fast and simple development of IoT devices
 - etc

<br/>

Technical information:
 - .NET 5
 - Microsoft Azure IoT SDK (Device capabilities, including IoT Hub modules)

<br/>

*Azure IoT Device Simulator logs*

![Azure IoT Device Simulator Logs](sources/IoT.Simulator/IoT.Simulator/docs/images/AzureIoTDeviceSimulatorLos.gif)

<br/>

## Global features
 - device level simulation (C2D/D2C)
 - module level simulation (C2M/M2C)
 - device simulation configuration based on JSON files
 - module simulation configuration based on JSON files
 - no specific limitation on the number of modules (only limited by Microsoft Azure IoT Hub constraints)
 - simple and lightweight application, containerizable
 - message templates based on JSON (3 message types by default in this first version)
 - implementation of full IoT flows (C2D, D2C, C2M, M2C) - see below for more details


## Functional features

### Device level (C2D/D2C)

*Commands*
 - request latency test
 - reboot device
 - device On/Off
 - read device Twin
 - generic command (with JSON payload)
 - generic command
 - update telemetry interval
 
 *Messages*
 D2C: The device can send messages of different types (telemetry, error, commissioning).
 
 C2D: Microsoft Azure IoT Hub can send messages to a given device.
 
 *Twin*
 Any change in the Desired properties is notified and handled by the device.

 The device reports changes in different types of information to the Microsoft Azure IoT Hub.


### Module level (C2M/M2C)
The features at the module level are the identical to the device features except for the latency tests.


[details](sources/IoT.Simulator/IoT.Simulator/docs/Help.md).

  
## Global technical features

Functional features are based on these generic technical features:
 - telemetry sent from a device.
 - a device can contain one or many modules.
 - each module behaves independently with its own flows (C2M/M2C) and its configuration settings.
 - the device that contains the modules has its own behavior (based on its own configuration file).
 - telemetry sent from a module.
 - messages received by a device.
 - messages received by a module.
 - commands received by a device.
 - commands received by a module.
 - Twin Desired properties changed notification (for devices).
 - Twin Desired properties changed notification (for modules).
 - Twin Reported properties updates from a device.
 - Twin Reported properties updates from a module.


### D2C
#### Device level
 - IoT Messages
 - Twins (Reported)

#### Module level (M2C)
 - IoT Messages
 - Twins (Reported)

### C2D
#### Device level
 - Twins (Desired)
 - Twins (Tags)
 - Direct Methods
 - Messages

#### Module level (C2M)
 - Twins (Desired)
 - Twins (Tags)
 - Direct Methods
 - Messages

## Upcoming features
- IoT Plug and Play integration. An especial version totally IoT Plug and Play-oriented has been released [here](https://github.com/jonmikeli/azureiotdevicesimulator5-pnp).
- "fileupload" feature implementation.

## More information

- Details about **HOW the solution WORKS** are provided in the [help](sources/IoT.Simulator/IoT.Simulator/docs/Help.md) section.
- Details about **HOW the solution can be USED** are provided in the [how to](sources/IoT.Simulator/IoT.Simulator/docs/HowTo.md) section.
