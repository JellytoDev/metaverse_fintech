using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    public float speed;
    public float rotateSpeed = 10.0f;
    float hAxis;
    float vAxis;

    Vector3 moveVec;

    Animator anim;

    int aniNum = 1;


    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        hAxis = Input.GetAxisRaw("Horizontal");
        vAxis = Input.GetAxisRaw("Vertical");

        moveVec = new Vector3(hAxis, 0, vAxis).normalized;


        if (!(hAxis == 0 && vAxis == 0))
        {
            transform.position += moveVec * speed * Time.deltaTime;
            transform.LookAt(transform.position + moveVec);

            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(moveVec), Time.deltaTime * rotateSpeed);
        }
        

    출처: https://mayquartet.tistory.com/44 [MayQing Study]

        if (hAxis != 0 ||vAxis != 0)
        {
            aniNum = 2;
            anim.SetInteger("aniKind", aniNum);
        }
        else
        {
            aniNum = 1;
            anim.SetInteger("aniKind", aniNum);
        }


    }
}