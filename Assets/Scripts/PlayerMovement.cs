using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float forwardForce = 2000f;
    [SerializeField] private float sidewaysForce = 20f;

    private int halfScreenWidth;

    private void Start() => halfScreenWidth = Screen.width / 2;

    private void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.position.x >= halfScreenWidth)
                rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            else if (touch.position.x < halfScreenWidth)
                rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (Input.GetMouseButton(0))
        {
            Vector3 click = Input.mousePosition;

            if (click.x >= halfScreenWidth)
                rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            else if (click.x < halfScreenWidth)
                rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1)
            FindObjectOfType<GameManager>().EndGame();
    }
}
