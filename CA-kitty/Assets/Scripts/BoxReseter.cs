using UnityEngine;

public class BoxReseter : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private GameObject box;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void Hit()
    {
        box.gameObject.GetComponent<BoxScript>().resetBoxPos();
    }
    public void Fly(Vector2 positionEnd)
    {
        Vector2 position = transform.position;
        box.gameObject.GetComponent<BoxScript>().boxMoveDown();
        while (position != positionEnd)
        {
            //this is a really bad way to do this but i have no other ideas and this ide has a heart attack every time i make a typo, it froze 3 times writing this
            position = transform.position;
            if (position.y > positionEnd.y)
            {
                position.y -= 0.51f;
            }
            if (position.y < positionEnd.y)
            {
                position.y += 0.50f;
            }
            if (position.x > positionEnd.x)
            {
                position.x -= 0.51f;
            }
            if (position.x < positionEnd.x)
            {
                position.x += 0.50f;
            }
            rb.transform.position = position;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
