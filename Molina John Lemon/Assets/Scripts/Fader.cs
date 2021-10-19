using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fader : MonoBehaviour
{
    public bool fade;
    float fadeSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        fade = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space")){
            fade = true;
        }
        if(Input.GetKeyUp("space")){
            fade = false;
        }

        if(fade){
            Color objectColor = gameObject.GetComponent<SkinnedMeshRenderer>().material.color;
            float fadeAmount = objectColor.a - (fadeSpeed * Time.deltaTime);

            objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
            gameObject.GetComponent<SkinnedMeshRenderer>().material.color = objectColor;

            if(objectColor.a <= 0){
                objectColor.a = 0;
            }
        }
        else{
            Color objectColor = gameObject.GetComponent<SkinnedMeshRenderer>().material.color;
            float fadeAmount = objectColor.a + (fadeSpeed * Time.deltaTime);

            objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
            gameObject.GetComponent<SkinnedMeshRenderer>().material.color = objectColor;

            if(objectColor.a >= 1){
                objectColor.a = 1;
            }
        }
    }
}
