using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Obstacle
{

    public class ObstacleMove : MonoBehaviour
    {
        [SerializeField] private float Speed;
        [SerializeField] private float IncraiseSpeed;
        LogicCheck logic;
        void Start()
        {
            logic = GetComponent<LogicCheck>();
            logic.PassObstacle += PassObstacle;
        }
        void Update()
        {
            if (LogicCheck.IsPlay)
            {
                transform.Translate(Vector3.back * Speed * Time.deltaTime);
            }
        }
        public void PassObstacle()
        {
            Speed += IncraiseSpeed;
        }
    }
}
