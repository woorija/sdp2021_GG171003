using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : Command
{
    WaeponManager waepon;
    public override void execute()
    {
        waepon.Fire();
    }

    public override void Setting()
    {
        waepon = GetComponent<WaeponManager>();
    }
}