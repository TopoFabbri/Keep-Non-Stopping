using System.Collections.Generic;
using UnityEngine;

public class BarsController : MonoBehaviour
{
    [SerializeField] private List<GameObject> objects = new();

    [SerializeField] private float dis = 1f;
    [SerializeField] private float speed = 1f;

    private void Start()
    {
        for (int i = 0; i < objects.Count; i++)
            objects[i].transform.position = new Vector3(objects[i].transform.position.x, objects[i].transform.position.y, (i - 1) * dis);
    }

    private void Update()
    {
        foreach (GameObject t in objects)
        {
            t.transform.Translate(Vector3.back * Time.deltaTime * speed);

            if (t.transform.position.z < -dis)
                t.transform.position = new Vector3(t.transform.position.x, t.transform.position.y, (objects.Count - 1) * dis);
        }
    }
}
