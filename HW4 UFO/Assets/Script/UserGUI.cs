﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserGUI : MonoBehaviour
{
    
    private IUserAction action;
    bool isFirst = true;
    // Use this for initialization  
    void Start()
    {
        action = Director.getInstance().currentSceneControl as IUserAction;
    }

    private void OnGUI()
    {
        if (Input.GetButtonDown("Fire1"))
        {

            Vector3 pos = Input.mousePosition;
            action.hit(pos);

        }

        GUI.Label(new Rect(1000, 0, 400, 400), action.GetScore().ToString());

        if (isFirst && GUI.Button(new Rect(370, 80, 60, 60), "PLAY"))
        {
            isFirst = false;
            action.setGameState(GameState.ROUND_START);
        }

        if (!isFirst && action.getGameState() == GameState.ROUND_FINISH && GUI.Button(new Rect(370, 80, 110, 110), "NEXT ROUND"))
        {
            action.setGameState(GameState.ROUND_START);
        }

    }
}