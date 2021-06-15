using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponChange3 : Command
{
    WaeponManager waepon;
    public override void execute()
    {
        waepon.ChangeArrow();
    }

    public override void Setting()
    {
        waepon = GetComponent<WaeponManager>();
    }
}