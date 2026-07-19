using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    //private float leftLimit = -30;
    private float sideLimit = 20;

    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit
        /*if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        }*/


        // Destroy balls if y position is less than bottomLimit
        if (transform.position.x > sideLimit)
        {
            Destroy(gameObject);
        }
    }
}
