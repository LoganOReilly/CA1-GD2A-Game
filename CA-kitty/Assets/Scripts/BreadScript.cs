using Unity.VisualScripting;
using UnityEngine;

public class BreadScript : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private GameObject crow;
    private bool deposited = false;
    private Vector2 StartPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartPosition = rb.transform.position;
    }

    // Update is called once per frame
    public void resetBoxPos()
    {
        if (deposited == false)
        {
            rb.transform.position = StartPosition;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "breadDetector")
        {
            rb.bodyType = RigidbodyType2D.Static;
            crow.gameObject.GetComponent<BoxReseter>().Fly(rb.transform.position);
            Destroy(rb);
        }
        if (collision.gameObject.tag == "breadDetector"&& collision.gameObject.tag == "BoxResetter")
        {
            Destroy(this);
        }
    }
}
