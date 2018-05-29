using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{

    private string Cname;
    private ScoreController scoreController;

    void OnTriggerEnter(Collider other)
    {
        if (Cname == "")
        {
            Cname = other.gameObject.name;
            Destroy(GetComponent<Rigidbody>());
            Component[] comp = GetComponentsInChildren<CapsuleCollider>();
            foreach (CapsuleCollider i in comp)
            {
                i.enabled = false;
            }
            GetComponent<CapsuleCollider>().isTrigger = false;
            scoreController.countScore(Cname);
        }
    }

    // Use this for initialization  
    void Awake()
    {
        Cname = "";
        scoreController = ScoreController.getInstance();
    }
}