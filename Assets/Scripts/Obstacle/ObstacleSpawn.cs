using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Obstacle
{
    public class ObstacleSpawn : MonoBehaviour
    {
        [SerializeField] Transform parent;
        [SerializeField] ObstacleObject[] obstacles;

        [SerializeField] private float Offset;
        [SerializeField] private float DecraiseOffset;

        [SerializeField] private float firstOffset;

        List<ObstacleObject> li;

        void Awake()
        {
            li = new List<ObstacleObject>();
            for (int i = 0; i < 10; i++)
            {
                if (li.Count > 0)
                {
                    li.Add(Spawn(Offset + li[li.Count - 1].transform.position.z));
                }
                else
                {
                    li.Add(Spawn(firstOffset));
                }
            }
        }
    
        public ObstacleObject Spawn(float offset)
        {
            int _random = Random.Range(0, obstacles.Length);
            ObstacleObject _gameObject = Instantiate(obstacles[_random], parent);
            _gameObject.transform.position = Vector3.forward * offset;
            return _gameObject;
        }

        public void SpawnObstacle()
        {
            li.Add(Spawn(Offset + li[li.Count - 1].transform.position.z));
            Offset -= DecraiseOffset;
        }

        public ObstacleObject GetFirst()
        {
            return li[0];
        }
        public ObstacleObject GetLast()
        {
            return li[li.Count - 1];
        }
        public void DeleteFirst()
        {
            li.RemoveAt(0);
        }

    }
}
