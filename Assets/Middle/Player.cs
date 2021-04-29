using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum eKeycodeType
{
    Skill1,
    Skill2,
    Skill3,
    Skill4,
    Spell1,
    Spell2,
    Item1,
    Item2,
    Item3,
    Item4,
    Item5,
    Item6,
    Accessory
}

public class Player : MonoBehaviour
{
    Command Com_skill1, Com_skill2, Com_skill3, Com_skill4, Com_spell1, Com_spell2, Com_item1, Com_item2, Com_item3, Com_item4, Com_item5, Com_item6, Com_accessory;
    private void Start()
    {
        Set_command();
    }

    private void Update()
    {
        if (!CustomInputManager.Instance.isKeychange)
        {
            Command command = Get_command();
            if (command != null)
            {
                command.execute();
            }
        }
    }

    void Set_command()
    {
        Com_skill1 = new Skill1();
        Com_skill2 = new Skill2();
        Com_skill3 = new Skill3();
        Com_skill4 = new Skill4();
        Com_spell1 = new Spell1();
        Com_spell2 = new Spell2();
        Com_item1 = new Item1();
        Com_item2 = new Item2();
        Com_item3 = new Item3();
        Com_item4 = new Item4();
        Com_item5 = new Item5();
        Com_item6 = new Item6();
        Com_accessory = new Accessory();
    }

    Command Get_command()
    {
        if (CustomInputManager.Instance.GetKeyDown((int)eKeycodeType.Skill1)) return Com_skill1;
        else if (CustomInputManager.Instance.GetKeyDown((int)eKeycodeType.Skill2)) return Com_skill2;
        else if (CustomInputManager.Instance.GetKeyDown((int)eKeycodeType.Skill3)) return Com_skill3;
        else if (CustomInputManager.Instance.GetKeyDown((int)eKeycodeType.Skill4)) return Com_skill4;
        else if (CustomInputManager.Instance.GetKeyDown((int)eKeycodeType.Spell1)) return Com_spell1;
        else if (CustomInputManager.Instance.GetKeyDown((int)eKeycodeType.Spell2)) return Com_spell2;
        else if (CustomInputManager.Instance.GetKeyDown((int)eKeycodeType.Item1)) return Com_item1;
        else if (CustomInputManager.Instance.GetKeyDown((int)eKeycodeType.Item2)) return Com_item2;
        else if (CustomInputManager.Instance.GetKeyDown((int)eKeycodeType.Item3)) return Com_item3;
        else if (CustomInputManager.Instance.GetKeyDown((int)eKeycodeType.Item4)) return Com_item4;
        else if (CustomInputManager.Instance.GetKeyDown((int)eKeycodeType.Item5)) return Com_item5;
        else if (CustomInputManager.Instance.GetKeyDown((int)eKeycodeType.Item6)) return Com_item6;
        else if (CustomInputManager.Instance.GetKeyDown((int)eKeycodeType.Accessory)) return Com_accessory;
        return null;
    }
}
