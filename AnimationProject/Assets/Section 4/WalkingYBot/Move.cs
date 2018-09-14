using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// THIS SCRIPT IS CALLED "DRIVE" IN THE VIDEO, IT IS "MOVE" HERE TO SEPARATE IT FROM THE OTHER SCENE'S "DRIVE" SCRIPT.

public class Move : MonoBehaviour {

    float speed = 5.0f;
    float rotationSpeed = 100.0f;
    Animator anim;

    private void Start()
    {
        anim = gameObject.GetComponent<Animator>(); // could also use keyword "this" instead of gameObject
    }

    // Update is called once per frame
    void Update()
    { 
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        transform.Rotate(0, rotation, 0);

        if (translation != 0)
        {
            anim.SetBool("isWalking", true);
        }
        else
        {
            anim.SetBool("isWalking", false);
        }
        
    }
}
