using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildMenu : MonoBehaviour {

    public static buildMenu instance;
    
    void Awake()
    {
        instance = this;
    }

    public GameObject normalBuildingPre;
    public GameObject secondBuldingPre;

    /*void Start()
    {
        buildingSelect = normalBuildingPre;
    }*/
    private GameObject buildingSelect;

    public GameObject selectingBuilding()
    {
        return buildingSelect;

    }
    public void setBuildingtoBuild(GameObject building)
    {

        buildingSelect = building; 
    }
}
