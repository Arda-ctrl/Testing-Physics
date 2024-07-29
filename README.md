>This is test project in Unity.
>My goal is learning applicaitons and more.
>I learned a lot about this project.
>Let's see what I learned.

1-You have a player and how he moves.This is so simple look at this.
public class ball : MonoBehaviour
{
    public float velocity = 5f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {     
            transform.Translate(Vector3.left * velocity * Time.deltaTime);
        }}}
        
 2-In the game I also learned : rigidbody,physics metarial,tags,virtual cams.
 >The first is the physics of the solid world, you can put it on any object you want.
 >Secondly physics metarial is collision is what makes us aware of concepts such as acceleration and constant velocity.
 >Third "tags" for example your name is Jack but I call you killer and killer only kills people. So you add a new tag killer and write code that only uses killers.
 >Fourth "virtual cameras" for example you play mario and mario go right 5 meters and you say ee whats your purpose and I say cameras doesnt come with you but virtual cams fallowing you allways.
 3-We go to second scene and I learned one important code.
 >I learned about "Gizmos" and I think we use gizmos in bullet systems for example when we are firing a gun and the bullet's speed is 5 m/s we don't see the frames but gizmos show that frame but only in a test game.
 >So what is the code for the gizmos?

 void OnDrawGizmos()
 {
     // Display the explosion radius when selected   
     Gizmos.color = new Color(1, 1, 0, 0.75F);
     foreach(var item in noktalar)
     Gizmos.DrawSphere(item, radius);        
 }
 void FixedUpdate()
 {
     tick = ++tick % frameCount;
     if (tick != 0)
     return;
     points.Add(transform.position);

     if (points.Count > maxCount)
     {
         points.RemoveAt(0);
     }
 }

 And that's it, thank you very much for reading. :)
        
