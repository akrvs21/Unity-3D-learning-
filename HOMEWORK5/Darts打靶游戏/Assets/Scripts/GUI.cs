using System.Collections;
using System.Collections.Generic;
using UnityEngine;



void Start()
{
    sceneController = SceneController.getInstance();
    scoreController = ScoreController.getInstance();
    ScoreText.text = "Score : " + scoreController.getScore(); // 显示分数  
}

// Update is called once per frame    
void Update()
{
    WindDirectionText.text = sceneController.getGameModel().getWindDirection();
    WindForceText.text = "Wind Force : " + sceneController.getGameModel().getWindForce(); // 显示风力  
    if (Input.GetMouseButtonDown(0))
    {
        Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        sceneController.shootArrow(mouseRay.direction); //以点击的方向发射箭矢    
    }
    ScoreText.text = "Score : " + scoreController.getScore(); // 显示分数  
}