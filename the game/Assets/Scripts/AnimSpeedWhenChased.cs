using UnityEngine;

public class AnimSpeedWhenChased : MonoBehaviour
{
	public Animator animator;

	public float animSpeedMultip;

	private Vector3 lastPosition;

	private float lastTime;

	private void Start()
	{
		Transform transform = GetComponent<Transform>();
        if (transform != null)
        {
            lastPosition = transform.position;
            lastTime = Time.time;
        }
        else
        {
            Debug.LogError("Transform component not found on the GameObject.");
        }
    
	}

	private void Update()
	{
		        float currentTime = Time.time;
        float deltaTime = currentTime - lastTime;

        if (deltaTime > 0)
        {
            Transform transform = GetComponent<Transform>();
            if (transform == null)
            {
                Debug.LogError("Transform component not found in Update.");
                return;
            }

            Vector3 currentPosition = transform.position;
            Vector3 displacement = currentPosition - lastPosition;
            float speed = (displacement.magnitude / deltaTime) * animSpeedMultip;

            if (animator != null)
            {
                animator.speed = speed;
            }
            else
            {
                Debug.LogError("Animator component is missing.");
            }

            lastPosition = currentPosition;
            lastTime = currentTime;
        }
	}
}
