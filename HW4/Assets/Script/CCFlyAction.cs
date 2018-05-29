
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCFlyAction : SSAction
{
   
    float acceleration;

    float horizontalSpeed;

    Vector3 direction;

    float time;

    public override void Start()
    {
        enable = true;
        acceleration = 4.0f;
        time = 0;
        horizontalSpeed = gameobject.GetComponent<DiskData>().speed;
        direction = gameobject.GetComponent<DiskData>().direction;
    }

    public override void Update()
    {
        if (gameobject.activeSelf)
        {
            
            time += Time.deltaTime;

            
            transform.Translate(Vector3.down * acceleration * time * Time.deltaTime);

            
            transform.Translate(direction * horizontalSpeed * Time.deltaTime);

            
            if (this.transform.position.y < -4)
            {
                this.destroy = true;
                this.enable = false;
                this.callback.SSActionEvent(this);
            }
        }

    }

    public static CCFlyAction GetSSAction()
    {
        CCFlyAction action = ScriptableObject.CreateInstance<CCFlyAction>();
        return action;
    }
}
