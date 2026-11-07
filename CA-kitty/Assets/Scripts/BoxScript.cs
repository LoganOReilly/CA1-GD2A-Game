using Unity.VisualScripting;
using UnityEngine;

public class BoxScript : MonoBehaviour
{
    private Rigidbody2D rb; 
    private Vector2 StartPosition;
    //[SerializeField] private GameManager gm;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartPosition = rb.transform.position;
    }

    // Update is called once per frame
    public void resetBoxPos()
    {
        rb.transform.position = StartPosition;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "boxDetector")
        {
            rb.bodyType= RigidbodyType2D.Static;
            //gm.AddBox();
        }
    }
}
