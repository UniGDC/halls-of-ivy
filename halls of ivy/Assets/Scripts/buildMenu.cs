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

    void Start()
    {
        buildingSelect = normalBuildingPre;
    }
    private GameObject buildingSelect;

    public GameObject selectingBuilding()
    {
        return buildingSelect;

    }
}
