using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session4homeworkpart2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Check if an obiect is seeing another obiect using Ray Casting
        //Get the position from where we are casting the ray
        Vector3 rayCastPosition = this.gameObject.transform.position;
        //Create a ray in the direction we want to cast
        Vector3 rayCastDrection = this.gameObject.transform.TransformDirection(Vector3.forward);
       //creat a varible that stores the information about what we are hitting
        RaycastHit objectSeenByRay;
        //Cast the ray
        if (Physics.Raycast(rayCastPosition, rayCastDrection, out objectSeenByRay))
        {
            Debug.Log("Obeject seen:" + objectSeenByRay.transform.name);
            Debug.Log("Obeject position:" + objectSeenByRay.transform.ToString());
            Debug.Log("Point where ray is hitting the object:" + objectSeenByRay.point);
            Destroy(objectSeenByRay.transform.gameObject);

        }

       


    }

    // Update is called once per frame
    void Update()
    {
        //Move object up
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.gameObject.transform.Translate(Vector3.up * 0.1f);
        }
        //Move object down
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            this.gameObject.transform.Translate(Vector3.down * 0.1f);
        }

    }
}
