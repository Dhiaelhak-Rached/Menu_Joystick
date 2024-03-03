using UnityEngine;
using UnityEngine.EventSystems;

public class Jump : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private GameObject player;
    [SerializeField] private float force;

    private bool isPressed = false;

    private void Update()
    {
        if (isPressed)
        {
            JumpPlayer();
        }
    }

    private void JumpPlayer()
    {
        player.transform.Translate(0, force * Time.deltaTime, 0);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isPressed = false;
    }
}
