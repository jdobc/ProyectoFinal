using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambiarTrack : MonoBehaviour
{
    public AudioClip newTrack;
    public AudioClip newTrack1;
    public AudioClip newTrack2;
    public AudioClip newTrack3;
    public int TrackSelector=1;
    private AudioManager theAM;
       // Start is called before the first frame update
    void Start()
    {
        theAM = FindObjectOfType<AudioManager>();   
    }

    // Update is called once per frame
    void Update()
    {
    }
      void OnMouseOver(){
        if(Input.GetMouseButtonUp(0))
        {
             if(newTrack1 !=null && TrackSelector ==1)
             {
                 theAM.ChangeBGM(newTrack1);
                 TrackSelector++;
             }
             else if(newTrack2 !=null && TrackSelector ==2)
             {
                 theAM.ChangeBGM(newTrack2);
                 TrackSelector++;
             }
             else if(newTrack3 !=null && TrackSelector ==3)
             {
                 theAM.ChangeBGM(newTrack3);
                 TrackSelector++;
             }
            else  if(newTrack !=null && TrackSelector ==4)
             {
                 theAM.ChangeBGM(newTrack);
                 TrackSelector=1;
             }
         }

                 if(Input.GetMouseButtonUp(1))
        {
             if(newTrack1 !=null && TrackSelector ==1)
             {
                 theAM.ChangeBGM(newTrack1);
                 TrackSelector=4;
             }
             else if(newTrack2 !=null && TrackSelector ==2)
             {
                 theAM.ChangeBGM(newTrack2);
                 TrackSelector--;
             }
             else if(newTrack3 !=null && TrackSelector ==3)
             {
                 theAM.ChangeBGM(newTrack3);
                 TrackSelector--;
             }
            else  if(newTrack !=null && TrackSelector ==4)
             {
                 theAM.ChangeBGM(newTrack);
                 TrackSelector--;
             }
         }
     }   
 
}

