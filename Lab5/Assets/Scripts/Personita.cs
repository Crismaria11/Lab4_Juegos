using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personita : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hitInfo;
        Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Input.GetMouseButtonDown(0))
            if(Physics.Raycast(myRay, out hitInfo))
            {
                if (hitInfo.collider.gameObject.CompareTag("Blancos"))
                {
                    Destroy(hitInfo.collider.gameObject);
                }
            }
    }
}
