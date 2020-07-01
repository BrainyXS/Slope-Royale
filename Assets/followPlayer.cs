using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 ofset;

    private void Update()
    {
        transform.position = new Vector3(player.position.x + ofset.x, player.position.y + ofset.y, player.position.z + ofset.z);
    }
}