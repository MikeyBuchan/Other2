using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour 
{
    [Header("PlayerMovement")]
    public float movementSpeed = 3;
    private Vector3 mov;

    [Header("CameraMovement")]
    public GameObject cam;
    public float heightOffset;
    public float camRange;

    [Header("Optional")]
    public bool rotationSpeedActive;
    public float rotationSpeed;

	void Start () 
	{
        cam = GameObject.FindGameObjectWithTag("MainCamera");
    }
	

	void Update () 
	{

	}

    void FixedUpdate()
    {
        CameraMovement();
        PlayerMovement();
    }

    public void PlayerMovement()
    {
        mov.x = Input.GetAxis("Horizontal");
        mov.z = Input.GetAxis("Vertical");
        transform.Translate(mov * movementSpeed * Time.deltaTime,Space.World);
    }

    public void CameraMovement()
    {
        Plane playerPlane = new Plane(Vector3.up, transform.position);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        float hitDist = 0.0f;

        if (playerPlane.Raycast(ray,out hitDist))
        {
            Vector3 targetPoint = ray.GetPoint(hitDist);

            Quaternion targetRotation = Quaternion.LookRotation(targetPoint - transform.position);

            if (rotationSpeedActive == true)
            {
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
            }
            else
            {
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 1000 * Time.deltaTime);
            }
        }

        cam.transform.position = transform.position + (Vector3.up * 7.5f) + new Vector3(Input.mousePosition.x - (Screen.width / 2), 0, Input.mousePosition.y - (Screen.height / heightOffset)) * camRange;
    }
}
