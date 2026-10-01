using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float radius = 5f;
    [SerializeField] private float speed = 2f;
    [SerializeField] private float maxAngle = 45f;
    [SerializeField] private float initialAngleOffset = 0f;

    private float timer = 0f;

    void LateUpdate()
    {
        if (target == null) return;

        timer += Time.deltaTime * speed;

        float angleInDegrees = initialAngleOffset + Mathf.Sin(timer) * maxAngle;
        float angleInRadians = angleInDegrees * Mathf.Deg2Rad;

        float y = target.position.y + Mathf.Sin(angleInRadians) * radius;
        float z = target.position.z - Mathf.Cos(angleInRadians) * radius;

        transform.position = new Vector3(target.position.x, y, z);
        transform.LookAt(target);
    }
}