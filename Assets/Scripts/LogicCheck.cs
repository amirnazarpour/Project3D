using System.Collections;
using System.Collections.Generic;
using Obstacle;
using UnityEngine;
using System;


[RequireComponent(typeof(ObstacleSpawn))]
public class LogicCheck : MonoBehaviour
{
    public static bool IsPlay;
    public int Score { get; private set; }
    [SerializeField] private float looseOffset;
    [SerializeField] Transform Player;
    ObstacleSpawn spawn;

    public Action Loose;

    public Action PassObstacle;
    ObstacleObject obstacle;
    void Awake()
    {
        IsPlay = true;
    }
    void Start()
    {
        spawn = GetComponent<ObstacleSpawn>();
    }
    void FixedUpdate()
    {
        obstacle = spawn.GetFirst();
        if (obstacle.transform.position.z < Player.position.z)
        {
            float y = Player.localScale.y;
            if (obstacle.highest < y + looseOffset && obstacle.highest > y - looseOffset)
            {
                spawn.DeleteFirst();
                Destroy(obstacle.Middle.gameObject);
                Destroy(obstacle.gameObject, 3);
                spawn.SpawnObstacle();
                Score++;
                PassObstacle();
            }
            else
            {
                if (Score > PlayerPrefs.GetInt("TopScore"))
                {
                    PlayerPrefs.SetInt("TopScore", Score);
                }
                IsPlay = false;
                Loose();
            }
        }
    }
    public void Restart()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}
