using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabObject : MonoBehaviour
{
    public GameObject sword;
    public GameObject hand;

    bool inHands = false;
    Vector3 swordPos;


    void Start()
    {
        swordPos = sword.transform.position;
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            if (!inHands)
            {
                sword.transform.SetParent(hand.transform);
                sword.transform.localPosition = new Vector3(0.059f, -0.019f, 0.026f);
                sword.transform.localEulerAngles = new Vector3(0, 90f, 12f);
                sword.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                inHands = true;
            }
        }
        if (Input.GetButtonDown("Fire2"))
        {
            if (inHands)
            {
                this.GetComponent<GrabObject>().enabled = false;
                sword.transform.SetParent(null);
                sword.transform.localPosition = new Vector3(0.059f, 1.262f, 1.352f);
                sword.transform.localEulerAngles = new Vector3(0, 0, 180f);
                sword.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                inHands = false;
            }
        }
    }
}
