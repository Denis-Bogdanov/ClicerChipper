using UnityEngine;

public class CloudMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;

    private float _speed;
    private void OnEnable()
    {
        _speed = Random.Range(1f, 7f);
    }

    // Update is called once per frame
    private void Update()
    {
        gameObject.transform.position += Vector3.right * _speed * Time.deltaTime;
        if (gameObject.transform.position.x >= 4.5)
        {
            Destroy(gameObject);
        }
    }
}