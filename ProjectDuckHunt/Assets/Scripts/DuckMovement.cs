using UnityEngine;

public class DuckMovement : MonoBehaviour
{
  
    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
