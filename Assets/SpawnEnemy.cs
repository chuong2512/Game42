using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public Transform[] points;
    public GameObject[] enemies;

    [SerializeField] public List<int>[] randomPoint;

    public float time = 2, timeCount = 2;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.currentState == State.Playing)
        {
            time -= Time.deltaTime;

            if (time <= 0)
            {
                time = timeCount;
                
                Spawn();
            }
        }
    }

    private void Spawn()
    {
        if (Random.Range(0, 4) == 0)
        {
            var rot = points[Random.Range(0, points.Length)].rotation;
            
            switch (Random.Range(0, 4))
            {
                case 0:
                    Instantiate(enemies[Random.Range(0, enemies.Length)],
                        points[0].position, rot);
                    Instantiate(enemies[Random.Range(0, enemies.Length)],
                        points[2].position, rot);
                    break;
                case 1:
                    Instantiate(enemies[Random.Range(0, enemies.Length)],
                        points[0].position, rot);
                    Instantiate(enemies[Random.Range(0, enemies.Length)],
                        points[3].position, rot);
                    break;
                case 2:
                    Instantiate(enemies[Random.Range(0, enemies.Length)],
                        points[1].position, rot);
                    Instantiate(enemies[Random.Range(0, enemies.Length)],
                        points[4].position, rot);
                    break;
                case 3:
                    Instantiate(enemies[Random.Range(0, enemies.Length)],
                        points[0].position, rot);
                    Instantiate(enemies[Random.Range(0, enemies.Length)],
                        points[4].position, rot);
                    break;
            }
        }
        else
        {
            var enemy = Instantiate(enemies[Random.Range(0, enemies.Length)],
                points[Random.Range(0, points.Length)].position, points[Random.Range(0, points.Length)].rotation);
        }
    }
}
