using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public int maxReserves;
    public int Reserves;

    public int maxMagazine;
    public int Magazine;

    public int AmmouUserPerShot;
    public bool isAutomatic;

    void Start()
    {
        Magazine = maxMagazine;
        Reserves = maxReserves;
        
    }

    public virtual void Fire(Vector3 fireFromPosition)
    {

   

        //if (Magazine >= 1)
        //    //Magazine - AmmouUserPerShot;
        //else
        //    Reload();

        //if (Keyboard.IsKeyPressed(Key.A)





    }

    public bool HasAmmo()
    {
        if (Magazine >= AmmouUserPerShot)
            return true;
        else
            return false;
    }

    public void Reload()
    {
        
        bool reload;
        if (Reserves > Magazine)
            reload = true;
        else
            reload = false;

        while (reload is true)
            maxReserves--;
        Magazine = 100;

            

    }


    void Update()
    {

        
        
    }
}
