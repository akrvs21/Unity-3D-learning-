using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public void shootArrow(Vector3 dir)
{
    GameObject arrow = arrowFactory.getFreeArrow(arrowFactory.getFreeArrowId());
    arrow.transform.position = new Vector3(0, 0, -10);
    gameModel.shoot(arrow, dir);
}

