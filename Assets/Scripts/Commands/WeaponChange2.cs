using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponChange2 : Command
{
    WaeponManager waepon;
    public override void execute()
    {
        waepon.ChangeMissile();
    }

    public override void Setting()
    {
        waepon = GetComponent<WaeponManager>();
    }
}