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

    


    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>();
        //buildingRend = buildings.GetComponent<Renderer>();

        
        
    }
	
	// Update is called once per frame
    void OnMouseEnter()
    {
        rend.material.color = hoverColor;
    }
    private void OnMouseExit()
    {
        rend.material.color = idleColor;
    }

    private void OnMouseDown()
    {
        GameObject buildingToBuild = buildMenu.instance.selectingBuilding();

        buildings =(GameObject)Instantiate(buildingToBuild, transform.position, buildingToBuild.transform.rotation);
    }

}
