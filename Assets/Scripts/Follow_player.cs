
using UnityEngine;

public class Follow_player : MonoBehaviour
{
    public Transform Player;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = Player.position + offset;
    }
}
