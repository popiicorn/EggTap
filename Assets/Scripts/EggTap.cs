using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggTap : MonoBehaviour
{
    public GameObject Egg1;
    public GameObject Egg2;

    public void OnClic_Egg()
    {
        Invoke(nameof(ChangeEgg), 0.05f);
    }

    public void ChangeEgg()
    {
        {
            Egg1.SetActive(false);
            Egg2.SetActive(true);
        }
    }

}
