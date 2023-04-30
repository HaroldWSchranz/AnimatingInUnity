using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Lets add some controller code to her now. Make a new class called PlayerController and add the
// following code in Update to talk to the Animator (which you find in the usual manner in Start using
// GetComponent).
public class PlayerController : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float fwd = Input.GetAxis("Vertical");
        animator.SetFloat("Forward", Mathf.Abs(fwd));
        animator.SetFloat("Sense", Mathf.Sign(fwd));
        animator.SetFloat("Turn", Input.GetAxis("Horizontal"));
    }
}
