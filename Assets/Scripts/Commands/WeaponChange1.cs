using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponChange1 : Command
{
    WaeponManager waepon;
    public override void execute()
    {
        waepon.ChangeBullet();
    }

    public override void Setting()
    {
        waepon = GetComponent<WaeponManager>();
    }
}