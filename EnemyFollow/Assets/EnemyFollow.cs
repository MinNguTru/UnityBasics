using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public GameObject player;
    private float speed = 1f;
    private float minDist = 3f;

    private void Update()
    {
        if (Vector2.Distance(transform.position, player.transform.position) > minDist)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, step);
        }
    }
}
