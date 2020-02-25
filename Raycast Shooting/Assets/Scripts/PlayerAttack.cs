using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Weapon[] weapons;
    int activeWeaponIndex = -1;
    Weapon activeWeapon;

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    private void HandleWeaponSwitching()
    {

    }

    private void SetActiveWeapon(int index)
    {
        if(index != activeWeaponIndex)
        {
            if(index >= 0 && index <= weapons.Length)
            {
                if (activeWeapon)
                    Destroy(activeWeapon.gameObject);

                activeWeapon = Instantiate(weapons[index], transform);

                activeWeaponIndex = index;
            }
        }
    }

}
