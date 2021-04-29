using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Command
{
    public abstract void execute();
}

public class Skill1 : Command
{
    public override void execute()
    {
        Debug.Log("스킬 1 사용");
    }
}

public class Skill2 : Command
{
    public override void execute()
    {
        Debug.Log("스킬 2 사용");
    }
}

public class Skill3 : Command
{
    public override void execute()
    {
        Debug.Log("스킬 3 사용");
    }
}

public class Skill4 : Command
{
    public override void execute()
    {
        Debug.Log("스킬 4 사용");
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