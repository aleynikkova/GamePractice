using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abricos : MonoBehaviour
{
    public GameObject abricosPrefab;
    public float TimeToAbricos, minYposition, maxYposition;
    private float timer;
    public GameObject circle;
    private void Start()
    {
        timer = TimeToAbricos;
    }
    private void Update()
    {
        if (timer <= 0)
        {
            timer = TimeToAbricos;
            circle = Instantiate(abricosPrefab, transform.position, Quaternion.identity);
            float rand = Random.Range(minYposition, maxYposition);
            circle.transform.position = new Vector3(circle.transform.position.x, rand, 0);
        }
        else
            timer -= Time.deltaTime;

    }
}
