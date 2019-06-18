using System.Collections;
using UnityEngine;

public class CloudMove : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Cloud;
    public float speed;
    public float delay;


    private void Start()
    {
        StartCoroutine(SpawnCloud());
    }

    // Update is called once per frame
    private void Update()
    {
        gameObject.transform.position += Vector3.right * speed * Time.deltaTime;
        if (Cloud.transform.position.x >= 4.5)
        {
            Destroy(Cloud);
        }
    }

    private IEnumerator SpawnCloud()
    {
        yield return new WaitForSeconds(delay);
        Instantiate(Cloud, new Vector3(-3.65f, 2f, 0f), Quaternion.identity);
    }
}