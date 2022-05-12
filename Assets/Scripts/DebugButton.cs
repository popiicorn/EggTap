using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugButton : MonoBehaviour
{
    public GameObject Egg1;
    public GameObject Egg2;

    public void OnClic_EggChange()
    {
        Egg1.SetActive(true);
        Egg2.SetActive(false);
    }


}
