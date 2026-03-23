using UnityEngine;

public class CameraController : MonoBehaviour
{
    public string playerName = "Player";
    public float distance = 2.5f;       // zoomed in
    public float offsetY = 1.5f;        // height above player
    public float sensitivity = 3f;      // mouse look speed
    public float smoothSpeed = 5f;      // smooth camera follow

    private Transform player;
    private float yaw = 0f;
    private float pitch = 20f;

    void Start()
    {
        GameObject playerObj = GameObject.Find(playerName);
        if (playerObj != null)
            player = playerObj.transform;
        else
            Debug.LogError("Player object not found! Make sure a GameObject is named 'Player'.");
    }

    void LateUpdate()
    {
        if (player == null) return;

        // Right-click free look
        if (Input.GetMouseButton(1))
        {
            yaw += Input.GetAxis("Mouse X") * sensitivity;
            pitch -= Input.GetAxis("Mouse Y") * sensitivity;
            pitch = Mathf.Clamp(pitch, -30f, 60f);
        }

        // Desired camera position with height offset
        Vector3 offset = new Vector3(0, offsetY, -distance);
        Quaternion rotation = Quaternion.Euler(pitch, yaw, 0);
        Vector3 desiredPosition = player.position + rotation * offset;

        // Smooth follow
        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);

        // Camera looks slightly above player
        transform.LookAt(player.position + Vector3.up * offsetY);

        // Rotate player to match camera horizontal rotation (yaw)
        Vector3 playerEuler = player.eulerAngles;
        playerEuler.y = yaw;
        player.eulerAngles = playerEuler;
    }
}