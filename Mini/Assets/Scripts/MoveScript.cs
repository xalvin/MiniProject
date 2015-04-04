using UnityEngine;

/// <summary>
/// Simply moves the current game object
/// </summary>
public class MoveScript : MonoBehaviour
{
  // 0 - Designer variables

  /// <summary>
  /// Projectile speed
  /// </summary>
  public Vector2 speed = new Vector2(10, 10);

  /// <summary>
  /// Moving direction
  /// </summary>
  public Vector2 direction = new Vector2(-1, 0);
	
  private Vector2 movement;
	float myscale =0;
	float facedir =1;
	void Start(){
		myscale = transform.localScale.x;
		
	}


  void Update()
  {
    // 1 - Movement
    movement = new Vector2(
      speed.x * direction.x,
      speed.y * direction.y);
		//player face direction
		if (direction.x < 0) {
			//face left
			facedir = 1;
		}else{
			//face right
			facedir = -1;
		}
		transform.localScale = new Vector3(myscale*facedir,transform.localScale.y);

  }

  void FixedUpdate()
  {
	// Apply movement to the rigidbody
	rigidbody2D.velocity = movement;
  }
}