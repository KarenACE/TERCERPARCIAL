using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class indoors : MonoBehaviour
{
   public int SCENE;

   private void OnTriggerEnter(Collider other)
   {
       if(other.tag == "Player")
       {
           SceneManager.LoadScene(SCENE);
       }
   }
}