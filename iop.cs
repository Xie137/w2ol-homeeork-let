using UnityEngine;

public class iop : MonoBehaviour
{
    public float i = 5f;
    public float o = 1f;
    float p = 5f;
    float ii;

    void Update()
    {
        if (ii > 0f)
        {
            ii -= Time.deltaTime;
            return;
        }
        float io = i * (0.3f + 0.25f * transform.position.x * transform.position.x);
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(p, transform.position.y, transform.position.z), io * Time.deltaTime);
        if (Mathf.Abs(transform.position.x - p) < 0.001f)
        {
            p = -p;
            ii = o;
        }
    }
}
