using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drive : MonoBehaviour {
    float speed = 5.0f;
    float rotationSpeed = 5.0f;
    Animator anim;

    private void Start()
    {
        anim = gameObject.GetComponent<Animator>(); // could also use keyword "this" instead of gameObject
    }

    // Update is called once per frame
    void Update () {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);

        if(translation != 0)
        {
            anim.SetBool("isWalking", true);
            anim.SetFloat("characterSpeed", translation); // this makes the animation to play backwards when walking backwards (animation plays at the rate of translation).
        }
        else
        {
            anim.SetBool("isWalking", false);
            anim.SetFloat("characterSpeed", 0);
        }
	}
}
