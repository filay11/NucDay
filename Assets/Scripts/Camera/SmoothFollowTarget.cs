using UnityEngine;

public class SmoothFollowTarget : MonoBehaviour
{
    public GameObject Target;
    public float LeftBorder;
    public float RightBorder;
    [SerializeField] private float _speed = 5;

    private Vector3 _offset;
    private Vector3 _currentPos;
    
    private void Awake()
    {
        if (Target == null)
        {
            Target = GameObject.FindGameObjectWithTag("Player");
        }
    }

    private void Start()
    {
        _offset = transform.position - Target.transform.position;
    }

    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, Target.transform.position + _offset, Time.deltaTime * _speed);

        transform.position = new Vector3
            (
            Mathf.Clamp(transform.position.x, LeftBorder, RightBorder),
            transform.position.y,
            transform.position.z
            );
    }
}

