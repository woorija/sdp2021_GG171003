using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum eKeycodeType
{
    Attack,
    WeaponChange1,
    WeaponChange2,
    WeaponChange3,
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
    Command Com_Attack, Com_WeaponChange1, Com_WeaponChange2, Com_WeaponChange3, Com_spell1, Com_spell2, Com_item1, Com_item2, Com_item3, Com_item4, Com_item5, Com_item6, Com_accessory;
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
        Com_Attack = new Attack();
        Com_WeaponChange1 = new WeaponChange1();
        Com_WeaponChange2 = new WeaponChange2();
        Com_WeaponChange3 = new WeaponChange3();

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
        if (CustomInputManager.Instance.GetKeyDown((int)eKeycodeType.Attack)) return Com_Attack;
        else if (CustomInputManager.Instance.GetKeyDown((int)eKeycodeType.WeaponChange1)) return Com_WeaponChange1;
        else if (CustomInputManager.Instance.GetKeyDown((int)eKeycodeType.WeaponChange2)) return Com_WeaponChange2;
        else if (CustomInputManager.Instance.GetKeyDown((int)eKeycodeType.WeaponChange3)) return Com_WeaponChange3;
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
