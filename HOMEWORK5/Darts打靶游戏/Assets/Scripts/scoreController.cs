using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public void countScore(string name)
{
    switch (name)
    {
        case "C1":
            score += 10;
            break;
        case "C2":
            score += 8;
            break;
        case "C3":
            score += 6;
            break;
        case "C4":
            score += 4;
            break;
        case "C5":
            score += 2;
            break;
        default:
            break;
    }
}

public int getScore()
{
    return score;
}