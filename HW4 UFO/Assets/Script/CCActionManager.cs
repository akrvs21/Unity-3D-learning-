﻿
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCActionManager : SSActionManager, ISSActionCallback
{
   public FirstSceneControl sceneController;
    public List<CCFlyAction> Fly;
    public int DiskNumber = 0;
    
    private List<SSAction> used = new List<SSAction>();
    private List<SSAction> free = new List<SSAction>();

    SSAction GetSSAction()
    {
        SSAction action = null;
        if (free.Count > 0)
        {
            action = free[0];
            free.Remove(free[0]);
        }
        else
        {
            action = ScriptableObject.Instantiate<CCFlyAction>(Fly[0]);
        }

        used.Add(action);
        return action;
    }

    public void FreeSSAction(SSAction action)
    {
        SSAction tmp = null;
        foreach (SSAction i in used)
        {
            if (action.GetInstanceID() == i.GetInstanceID())
            {
                tmp = i;
            }
        }
        if (tmp != null)
        {
            tmp.reset();
            free.Add(tmp);
            used.Remove(tmp);
        }
    }

    protected new void Start()
    {
        sceneController = (FirstSceneControl)Director.getInstance().currentSceneControl;
        sceneController.actionManager = this;
        Fly.Add(CCFlyAction.GetSSAction());

    }

    public void SSActionEvent(SSAction source,SSActionEventType events = SSActionEventType.Competeted,int intParam = 0,string strParam = null,UnityEngine.Object objectParam = null)
    {
        if (source is CCFlyAction)
        {
            DiskNumber--;
            DiskFactory df = Singleton<DiskFactory>.Instance;
            df.FreeDisk(source.gameobject);
            FreeSSAction(source);
        }
    }

    public void StartThrow(Queue<GameObject> diskQueue)
    {
        foreach (GameObject tmp in diskQueue)
        {
            RunAction(tmp, GetSSAction(), (ISSActionCallback)this);
        }
    }
}
