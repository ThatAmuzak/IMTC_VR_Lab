using UnityEngine;

public class Rocket : MonoBehaviour
{
    [SerializeField] private Transform myTransform;
    [SerializeField] private float speed = 2f;
    [SerializeField] private float radius = 2f;

    private Vector3 startPosition;
    private float angle = 0f;

    void Start()
    {
        if (myTransform == null)
        {
            myTransform = transform;
        }
        startPosition = myTransform.position;
    }

    void Update()
    {
        angle += speed * Time.deltaTime;

        float x = startPosition.x + Mathf.Cos(angle) * radius;
        float y = startPosition.y;
        float z = startPosition.z + Mathf.Sin(angle) * radius;

        myTransform.position = new Vector3(x, y, z);
    }
}