using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Command
{
    public abstract void execute();
}

public class Attack : Command
{
    public override void execute()
    {
        WaeponManager.Instance.Fire();
    }
}

public class WeaponChange1 : Command
{
    public override void execute()
    {
        WaeponManager.Instance.ChangeBullet();
    }
}

public class WeaponChange2 : Command
{
    public override void execute()
    {
        WaeponManager.Instance.ChangeMissile();
    }
}

public class WeaponChange3 : Command
{
    public override void execute()
    {
        WaeponManager.Instance.ChangeArrow();
    }
}

public class Item1 : Command
{
    public override void execute()
    {
        Debug.Log("아이템 1 사용");
    }
}

public class Item2 : Command
{
    public override void execute()
    {
        Debug.Log("아이템 2 사용");
    }
}

public class Item3 : Command
{
    public override void execute()
    {
        Debug.Log("아이템 3 사용");
    }
}

public class Item4 : Command
{
    public override void execute()
    {
        Debug.Log("아이템 4 사용");
    }
}

public class Item5 : Command
{
    public override void execute()
    {
        Debug.Log("아이템 5 사용");
    }
}

public class Item6 : Command
{
    public override void execute()
    {
        Debug.Log("아이템 6 사용");
    }
}

public class Spell1 : Command
{
    public override void execute()
    {
        Debug.Log("주문 1 사용");
    }
}

public class Spell2 : Command
{
    public override void execute()
    {
        Debug.Log("주문 2 사용");
    }
}

public class Accessory : Command
{
    public override void execute()
    {
        Debug.Log("장신구 사용");
    }
}