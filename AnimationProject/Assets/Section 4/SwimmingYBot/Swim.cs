using UnityEngine;
using System.Collections;

// THIS IS CALLED "DRIVE" IN THE LECTURE

public class Swim : MonoBehaviour {

    float speed = 5.0F;
    float rotationSpeed = 100.0F;
    float currentSpeed = 0.0f;
    Animator anim;

    void Start()
    {
    	anim = this.GetComponent<Animator>();
    }

    void Update() 
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        
        currentSpeed += translation;
        if(currentSpeed > 5) currentSpeed = 5;
        anim.SetFloat("Speed", currentSpeed);
        transform.Rotate(0, rotation, 0);

        if(translation != 0)
        {
        	anim.SetBool("isSwimming",true);
        }
        else
        {
        	anim.SetBool("isSwimming",false);
            currentSpeed = 0;
        }
    }
}
