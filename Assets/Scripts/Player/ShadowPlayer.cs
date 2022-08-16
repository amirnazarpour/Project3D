using System.Collections;
using System.Collections.Generic;
using Obstacle;
using UnityEngine;


public class ShadowPlayer : MonoBehaviour
{
    [SerializeField] ObstacleSpawn obstacleSpawn;
    [SerializeField] LogicCheck logicCheck;


    ObstacleObject obstacle;
    Transform Target;

    void Start()
    {
        logicCheck.PassObstacle += PassObstacle;
        obstacle = obstacleSpawn.GetFirst();
        Target = obstacle.Middle.transform;
    }

    public void PassObstacle()
    {
        obstacle = obstacleSpawn.GetFirst();
        Target = obstacle.Middle.transform;
    }
    void FixedUpdate()
    {
        if (Target != null)
        {
            float distance = Vector3.Distance(transform.position, Target.position);
            transform.localScale = new Vector3(0.5f, obstacle.highest, distance);
        }
    }
}
