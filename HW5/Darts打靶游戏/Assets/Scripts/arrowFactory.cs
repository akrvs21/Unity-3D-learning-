using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public int getFreeArrowId()
{
    for (int i = 0; i < arrowList.Count; i++)
    {
        if (!arrowList[i].activeInHierarchy)
        {
            return i;
        }
    }
    GameObject temp = GameObject.Instantiate(arrow) as GameObject;
    temp.SetActive(true);
    if (temp.GetComponent<Rigidbody>() == null)
        temp.AddComponent<Rigidbody>();
    Component[] comp = temp.GetComponentsInChildren<CapsuleCollider>();
    foreach (CapsuleCollider i in comp)
    {
        i.enabled = true;
    }
    temp.GetComponent<CapsuleCollider>().isTrigger = true;
    arrowList.Add(temp);
    return arrowList.Count - 1;
}


public GameObject getFreeArrow(int id)
{
    if (id >= 0 && id < arrowList.Count)
    {
        return arrowList[id];
    }
    return null;
}