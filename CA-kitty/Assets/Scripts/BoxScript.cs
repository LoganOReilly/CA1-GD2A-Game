using Unity.VisualScripting;
using UnityEngine;

public class BoxScript : MonoBehaviour
{
    private Rigidbody2D rb;
    //[SerializeField] private GameObject gmInput;
    [SerializeField] private GameManager gm;
    private bool deposited = false;
    private Vector2 StartPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartPosition = rb.transform.position;
        //gm = gmInput.GetComponent<GameManager>();
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
        if (collision.gameObject.tag == "boxDetector")
        {
            rb.bodyType= RigidbodyType2D.Static;
            gm.AddBox();
            deposited = true;
        }
    }
    public void boxMoveDown()
    {
        Vector2 positionStart = transform.position;
        Vector2 position = transform.position;
        while (position.y >positionStart.y-5)
        {
            position = transform.position;
            position.y-=0.5f;
            rb.transform.position = position;
        }
        StartPosition = rb.transform.position;
    }
}
