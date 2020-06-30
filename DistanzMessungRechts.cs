using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using TMPro;
// ReSharper disable Unity.InefficientPropertyAccess
// ReSharper disable IdentifierTypo
// ReSharper disable CommentTypo
// ReSharper disable RedundantBoolCompare
#pragma warning disable 414

public class DistanzMessungRechts : MonoBehaviour
{
    public Transform indexFingerRechts;
    public Transform mittelFingerRechts;
    public Transform daumenRechts;
    public Transform handgelenkRechts;
    public bool inTriggerBoxRight = false;

    
    [Space] 
    public GameObject slider1Feedback;
    Renderer m_Renderer_slider1;
    public GameObject slider2Feedback;
    Renderer m_Renderer_slider2;
    public GameObject bestaetigungFeedback;
    Renderer m_Renderer_bestaetigung;

    
    [Space] 
    public bool funktionSlider1;
    public bool funktionSlider2;
    public bool funktionBestaetigung;
    
    public GameObject linkeHand;


    [Space] 
    public int framesToCheck;
    [Space] 
    public float timerSlider1 = 0.0f;
    public float timerSlider2 = 0.0f;
    public float timerBestaetigung = 0.0f;
    public float waitTimeRechts = 0.25f;
    [Space] 
    [Space] 
    
    
    [Space] 
    public float slider1AbstandZielDM;
    public float slider2AbstandZielDM;
    public float bestaetigungAbstandZielDM;
    public float wertMinDM;
    [Space]
    public float slider1AbstandZielHI;
    public float slider2AbstandZielHI;
    public float bestaetigungAbstandZielHI;
    public float wertMinHI;
    [Space]
    public float slider1AbstandZielHM;
    public float slider2AbstandZielHM;
    public float bestaetigungAbstandZielHM;
    public float wertMinHM;
    [Space]
    public float slider1AbstandZielIM;
    public float slider2AbstandZielIM;
    public float bestaetigungAbstandZielIM;
    public float wertMinIM;
    [Space] 
    public float slider1HandrichtungMin;
    public float slider1HandrichtungMax;
    public float slider2HandrichtungMin;
    public float slider2HandrichtungMax;
    public float bestaetigenHandrichtungMin;
    public float bestaetigenHandrichtungMax;
    [Space] 
    public float handRichtungXRechts;
    [Space] 

    


    //AKTUELLER IST-WERT DER ABSTÄNDE
    private float abstandRechtsDM;
    private float abstandRechtsHI;
    private float abstandRechtsHM;
    private float abstandRechtsIM;
    
    
    //ARRAY LISTEN
    private List<float> distanzRechtsListDM = new List<float>();
    private List<float> distanzRechtsListHI = new List<float>();
    private List<float> distanzRechtsListHM = new List<float>();
    private List<float> distanzRechtsListIM = new List<float>();
    private int messungNummer = 0;
    
    

    void Start()
    {
        m_Renderer_slider1 = slider1Feedback.GetComponent<Renderer>();
        m_Renderer_slider2 = slider2Feedback.GetComponent<Renderer>();
        m_Renderer_bestaetigung = bestaetigungFeedback.GetComponent<Renderer>();
    }


    void Update()
    {

        //DAUMEN-MITTELFINGER RECHTS SETUP
        if (daumenRechts)
        {
            abstandRechtsDM = Vector3.Distance(daumenRechts.position, mittelFingerRechts.position);
            distanzRechtsListDM.Add(abstandRechtsDM);
        }

        
        if (distanzRechtsListDM.Count >= framesToCheck)
        {
            distanzRechtsListDM.Clear();
        }
        
        
        if(distanzRechtsListDM.Count != 0) 
        {
            wertMinDM = distanzRechtsListDM.Min();
        }
        
        
        
        //INDEX-HANDGELENK RECHTS SETUP
        if (indexFingerRechts)
        {
            abstandRechtsHI = Vector3.Distance(indexFingerRechts.position, handgelenkRechts.position);
            distanzRechtsListHI.Add(abstandRechtsHI);
        }

        
        if (distanzRechtsListHI.Count >= framesToCheck) 
        {
            distanzRechtsListHI.Clear();
        }
        
        
        if(distanzRechtsListHI.Count != 0) 
        {
            wertMinHI = distanzRechtsListHI.Min();
        }
        
        
        
        //MITTELFINGER-HANDGELENK RECHTS SETUP
        if (mittelFingerRechts)
        {
            abstandRechtsHM = Vector3.Distance(mittelFingerRechts.position, handgelenkRechts.position);
            distanzRechtsListHM.Add(abstandRechtsHM);
        }

        
        if (distanzRechtsListHM.Count >= framesToCheck) 
        {
            distanzRechtsListHM.Clear();
        }
        
        
        if(distanzRechtsListHM.Count != 0) 
        {
            wertMinHM = distanzRechtsListHM.Min();
        }
        
        
        
        //INDEX-MITTELFINGER RECHTS SETUP
        if (indexFingerRechts)
        {
            abstandRechtsIM = Vector3.Distance(indexFingerRechts.position, mittelFingerRechts.position);
            distanzRechtsListIM.Add(abstandRechtsIM);
        }

        
        if (distanzRechtsListIM.Count >= framesToCheck) 
        {
            distanzRechtsListIM.Clear();
        }
        
        
        if(distanzRechtsListIM.Count != 0) 
        {
            wertMinIM = distanzRechtsListIM.Min();
        }
        
        
        //HANDRICHTUNG ERKENNEN
        var forward = transform.forward;
        handRichtungXRechts = forward.x;
        
        

        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        //SLIDER 1 

        if (inTriggerBoxRight == true)
        {
            if (handRichtungXRechts > slider1HandrichtungMin)
            {
                if (handRichtungXRechts < slider1HandrichtungMax)
                {
                    if (abstandRechtsDM > slider1AbstandZielDM)
                    {
                        if (abstandRechtsHI < slider1AbstandZielHI)
                        {
                            if (abstandRechtsHM > slider1AbstandZielHM)
                            {
                                if (abstandRechtsIM > slider1AbstandZielIM)
                                {
                                    timerSlider1 += Time.deltaTime;

                                    if (timerSlider1 > waitTimeRechts)
                                    {
                                        Slider1();
                                        funktionSlider1 = true;
                                        funktionSlider2 = false;
                                        funktionBestaetigung = false;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        else

        {
            timerSlider1 = 0.0f;
            funktionSlider1 = false;
            m_Renderer_slider1.material.color = Color.gray;
        }
        
        
        
        
        //SLIDER 2

        if (inTriggerBoxRight == true)
        {
            if (handRichtungXRechts > slider2HandrichtungMin)
            {
                if (handRichtungXRechts < slider2HandrichtungMax)
                {
                    if (abstandRechtsDM < slider2AbstandZielDM)
                    {
                        if (abstandRechtsHI < slider2AbstandZielHI)
                        {
                            if (abstandRechtsHM < slider2AbstandZielHM)
                            {
                                if (abstandRechtsIM < slider2AbstandZielIM)
                                {
                                    timerSlider2 += Time.deltaTime;

                                    if (timerSlider2 > waitTimeRechts)
                                    {
                                        Slider2();
                                        funktionSlider1 = false;
                                        funktionSlider2 = true;
                                        funktionBestaetigung = false;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        else

        {
            timerSlider2 = 0.0f;
            funktionSlider2 = false;
            m_Renderer_slider2.material.color = Color.gray;
        }

        
        
        //BESTÄTIGUNG
        if (inTriggerBoxRight == true)
        {
            if (handRichtungXRechts > bestaetigenHandrichtungMin)
            {
                if (handRichtungXRechts < bestaetigenHandrichtungMax)
                {
                    if (abstandRechtsDM < bestaetigungAbstandZielDM)
                    {
                        if (abstandRechtsHI < bestaetigungAbstandZielHI)
                        {
                            if (abstandRechtsHM < bestaetigungAbstandZielHM)
                            {
                                if (abstandRechtsIM < bestaetigungAbstandZielIM)
                                {
                                    timerBestaetigung += Time.deltaTime;

                                    if (timerBestaetigung > waitTimeRechts)
                                    {
                                        Bestaetigung();
                                        funktionSlider1 = false;
                                        funktionSlider2 = false;
                                        funktionBestaetigung = true;

                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        else

        {
            timerBestaetigung = 0.0f;
            funktionBestaetigung = false;
            m_Renderer_bestaetigung.material.color = Color.gray;
        }


 

    }

    void Slider1 ()
    {
        m_Renderer_slider2.material.color = Color.gray;
        m_Renderer_bestaetigung.material.color = Color.gray;
        m_Renderer_slider1.material.color = Color.green;
        
        timerSlider2 = 0.0f;
        timerBestaetigung = 0.0f;
    }
        

    
    void Slider2 ()
    {
        m_Renderer_slider2.material.color = Color.green;
        m_Renderer_bestaetigung.material.color = Color.gray;
        m_Renderer_slider1.material.color = Color.gray;
        
        timerSlider1 = 0.0f;
        timerBestaetigung = 0.0f;
    }
        
        
    void Bestaetigung ()
    {
        m_Renderer_slider2.material.color = Color.gray;
        m_Renderer_bestaetigung.material.color = Color.green;
        m_Renderer_slider1.material.color = Color.gray;
        
        timerSlider1 = 0.0f;
        timerSlider2 = 0.0f;
    }


    
    
    // ABFRAGE OB DIE HAND INNERHALB DER INTERACTION-BOUNDRY UND SLIDER BOX IST
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("INNERHALB RIGHT");
            inTriggerBoxRight = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("AUSSERHALB RIGHT");
            inTriggerBoxRight = false;
        }
    }


    
    
    
}
