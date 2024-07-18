using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ScoreSS : MonoBehaviour
{

    public Text Scoretext;
    public static int Score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addScore()
    {
        Score++;
        print("score  --->  "+Score);
        Scoretext.text = "" + Score;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //print("=-=--=--=-=-= ");
        addScore();
    }

}
