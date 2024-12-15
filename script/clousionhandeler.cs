using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class clousionhandeler : MonoBehaviour
{
   /// <summary>
   /// OnCollisionEnter is called when this collider/rigidbody has begun
   /// touching another rigidbody/collider.
   /// </summary>
   /// <param name="other">The Collision data associated with this collision.</param>
   void OnCollisionEnter(Collision other)
   { string vari = other.gameObject.tag;
       switch (vari)
       {
        case "Friendly":
            Debug.Log("ready to lanch");
            break;
        case "fuel":
            Debug.Log("you got fuel");
            break;
        case "Finish":
            Debug.Log("congrats, you have done");
            break;
        default :
            Debug.Log("booom");
            int currentsceneindex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentsceneindex);
            break;
       }
   }
}
