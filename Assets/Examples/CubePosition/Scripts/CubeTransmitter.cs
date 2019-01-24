using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTransmitter : OSCTransmitterObjectBase
{

    // Update is called once per frame
    void Update()
    {
        if (sendWorldPos) { SendOSCMessage("pos/world", transform.position.x, transform.position.y, transform.position.z); }
        if (sendLocalPos) { SendOSCMessage("pos/local", transform.localPosition.x, transform.localPosition.y, transform.localPosition.z); }
    }
}
