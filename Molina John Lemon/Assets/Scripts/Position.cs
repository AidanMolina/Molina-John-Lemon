using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position : MonoBehaviour
{
    [SerializeField] GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = player.transform.position;
        if(Input.GetKeyDown("space")){
            player.SetActive(false);
        }
        if(Input.GetKeyUp("space")){
            player.SetActive(true);
        }    
    }
}
