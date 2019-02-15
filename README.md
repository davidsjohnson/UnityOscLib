# UnityOscLib
### A simple Open Sound Control library for Unity

UnityOscLib build's on the Core OSC C# classes of Jorge Garcia's [UnityOSC library](https://github.com/jorgegarcia/UnityOSC) but simplifies the configuration process for Unity.  

To add OSC support to any Unity application simply add the `OSCManagers` prefab to the game heirarchy and configure as needed. This prefab includes scripts for both sending OSC messages, as well as, receiving OSC messages.  More details on each script are below.

To see an example of UnityOscLib in action, open the `TestScene` in the Examples folder and review the `OSCManagers GameObject`.  Attached to this `GameObject` is a script called `OscTests` that show the use of the library.

See the new [OSC-XR toolkit](https://github.com/fortjohnson/osc-xr) for an example Unity application built with UnityLibOsc

Developed and Tested on Unity 2018.3.2f1

## Sending OSC Messages

## Receiving OSC Messages