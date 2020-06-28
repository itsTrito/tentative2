using UnityEngine;

public class EnnemyPatrol : MonoBehaviour
{
public float speed;
private Transform target;
public GameObject destination;
private bool isDead = false;

    // Start is called before the first frame update
    void Start()
    {
        target = destination.transform;
        target.position = RandomCircle(transform.position, 5.0f);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime);
        /* rb.MovePosition(rb.position + dir * speed * Time.deltaTime); */
        
        if(dir == Vector3.zero){
            target.position = RandomCircle(transform.position, 5.0f);
        }
    }

    Vector3 RandomCircle(Vector3 center, float radius){
        float ang = Random.value * 360;
        Vector3 pos;
        pos.x = center.x + radius * Mathf.Sin(ang * Mathf.Deg2Rad);
        pos.y = center.y + radius * Mathf.Cos(ang * Mathf.Deg2Rad);
        pos.z = center.z;
        return pos;
    }

   /*  Vector3 newPoint( Vector3 center){
        Vector3 pos = RandomCircle(center, 5.0f);
        Quaternion rot = Quaternion.identity;
        destination = Instantiate(destination,pos,rot);
        return pos;
    } */
}
