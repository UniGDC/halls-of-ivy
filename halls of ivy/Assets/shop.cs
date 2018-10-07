using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shop : MonoBehaviour {

    buildMenu buildMenu;

    private void Start()
    {
        buildMenu = buildMenu.instance;
    }
    public void normalBuilidngPurchase()
    {
        Debug.Log("normalt building");
        buildMenu.setBuildingtoBuild(buildMenu.normalBuildingPre);

    }
    public void secondBuilidingPurchase()
    {

        Debug.Log("2normalt building");
        buildMenu.setBuildingtoBuild(buildMenu.secondBuldingPre);
    }
   
}
