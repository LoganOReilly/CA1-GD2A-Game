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
    // Update is called once per frame
    void Update()
    {
        
    }
}
