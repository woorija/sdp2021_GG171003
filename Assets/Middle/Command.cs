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
        Debug.Log("������ 1 ���");
    }
}

public class Item2 : Command
{
    public override void execute()
    {
        Debug.Log("������ 2 ���");
    }
}

public class Item3 : Command
{
    public override void execute()
    {
        Debug.Log("������ 3 ���");
    }
}

public class Item4 : Command
{
    public override void execute()
    {
        Debug.Log("������ 4 ���");
    }
}

public class Item5 : Command
{
    public override void execute()
    {
        Debug.Log("������ 5 ���");
    }
}

public class Item6 : Command
{
    public override void execute()
    {
        Debug.Log("������ 6 ���");
    }
}

public class Spell1 : Command
{
    public override void execute()
    {
        Debug.Log("�ֹ� 1 ���");
    }
}

public class Spell2 : Command
{
    public override void execute()
    {
        Debug.Log("�ֹ� 2 ���");
    }
}

public class Accessory : Command
{
    public override void execute()
    {
        Debug.Log("��ű� ���");
    }
}