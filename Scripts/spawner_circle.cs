using UnityEngine;

public class spawner_circle : MonoBehaviour
{
    public float speed;
    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}
