using System.Collections;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public float power;
    public Vector3 direction;
    public Rigidbody ball;
    public float cooldown;
    
    private IEnumerator Start()
    {
        var instBall = Instantiate(ball, new Vector3(transform.position.x, transform.position.y + 2, transform.position.z), Quaternion.identity);

        var RandomDir = new Vector3(Random.Range(direction.x - 2, direction.x + 2), direction.y,
            Random.Range(direction.z - 2, direction.z + 2));
        var RandomPow = Random.Range(power * 0.75f, power * 1.25f);
        
        instBall.AddForce(RandomDir*RandomPow);
        
        Destroy(instBall, 15f);

        yield return new WaitForSeconds(cooldown);

        StartCoroutine(Start());
    }
}
