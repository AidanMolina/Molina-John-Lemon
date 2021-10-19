using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    bool playerInside;
    GameObject BackDoor;
    GameObject FrontDoor;

    // Start is called before the first frame update
    void Start()
    {
        playerInside = false;
        BackDoor = gameObject.transform.GetChild(0).gameObject;
        FrontDoor = gameObject.transform.GetChild(1).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if(playerInside){
            if(Input.GetKeyDown("e")){
                FrontDoor.transform.position += new Vector3(0.6f, 0f, 0.5f);
                FrontDoor.transform.Rotate(0f, 90f, 0f);
                BackDoor.transform.position += new Vector3(0.4f, 0f, 0.702f);
                BackDoor.transform.Rotate(0f, 90f, 0f);
                Destroy(gameObject.GetComponent<BoxCollider>());
                Destroy(BackDoor.GetComponent<BoxCollider>());
                playerInside = false;
            }
        }
    }

    void OnTriggerEnter(){
        playerInside = true;
    }

    void OnTriggerExit(){
        playerInside = false;
    }
}
