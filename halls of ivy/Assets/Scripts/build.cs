using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class build : MonoBehaviour {
    //color edit
    [SerializeField]
    private Color hoverColor;
    [SerializeField]
    private Color idleColor;

    
    private Renderer rend;
    private Renderer buildingRend;

    public GameObject buildings;

    buildMenu buildMenu;


    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>();
        //buildingRend = buildings.GetComponent<Renderer>();

        buildMenu = buildMenu.instance;
        
    }
	
	// Update is called once per frame
    void OnMouseEnter()
    {
        rend.material.color = hoverColor;
        if (buildMenu.selectingBuilding() == null)
        {
            return;
        }
    }
    private void OnMouseExit()
    {
        rend.material.color = idleColor;
    }

    private void OnMouseDown()
    {
        if(buildMenu.selectingBuilding() == null)
        {
            return;
        }
        GameObject buildingToBuild = buildMenu.selectingBuilding();

        buildings =(GameObject)Instantiate(buildingToBuild, transform.position, buildingToBuild.transform.rotation);
    }

}
