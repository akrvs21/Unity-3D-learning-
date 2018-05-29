using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public void shoot(GameObject arrow, Vector3 dir)
{
    arrow.transform.up = dir;
    arrow.GetComponent<Rigidbody>().velocity = dir * speed;
    Force = Random.Range(-100, 100);
    setWindForce(arrow);
}

private void setWindForce(GameObject arrow)
{
    arrow.GetComponent<Rigidbody>().AddForce(new Vector3(Force, 0, 0), ForceMode.Force);
}

public float getWindForce()
{
    return Force;
}

public string getWindDirection()
{
    if (Force < 0)
    {
        return "Wind Direction : Left";
    }
    else if (Force > 0)
    {
        return "Wind Direction : Right";
    }
    else
    {
        return "Wind Direction : No Wind";
    }
}