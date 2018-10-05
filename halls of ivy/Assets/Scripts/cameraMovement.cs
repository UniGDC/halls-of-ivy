using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour {

    [SerializeField]
    private BoxCollider2D boundary;//boundary of the map

    public float panSpeed = 10f;
    public float panBorder = 10f;

    private Vector3 minBounds;
    private Vector3 maxBounds;
    private Camera cam;
    private float halfHeight;
    private float halfWidth;

	void Start () {
        cam = GetComponent<Camera>();
        halfHeight = cam.orthographicSize;
        halfWidth = cam.orthographicSize * Screen.width / Screen.height;

        //setting boundarys with box collider;
        minBounds = boundary.bounds.min;
        maxBounds = boundary.bounds.max;


	}
	
	
	void Update () {
        Vector3 camPosition = transform.position;

        if (Input.GetKey("w") || Input.mousePosition.y >= Screen.height - panBorder)
        {
            camPosition.y += panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("s") || Input.mousePosition.y <= panBorder)
        {
            camPosition.y -= panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("d") || Input.mousePosition.x >= Screen.width - panBorder)
        {
            camPosition.x += panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("a") || Input.mousePosition.x <= panBorder)
        {
            camPosition.x -= panSpeed * Time.deltaTime;
        }

        transform.position = camPosition;


        //clamp camera positions
        float xClamp = Mathf.Clamp(transform.position.x, minBounds.x + halfWidth, maxBounds.x - halfWidth);
        float yClamp = Mathf.Clamp(transform.position.y, minBounds.y + halfWidth, maxBounds.y - halfHeight);
        transform.position = new Vector3(xClamp, yClamp, transform.position.z);
    }

}
