using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feedback : MonoBehaviour
{
    public GameObject feedbackIndexDaumen;
    Renderer m_Renderer_FeedbackIndexDaumen;
    public GameObject feedbackMittelDaumen;
    Renderer m_Renderer_FeedbackMittelDaumen;
    public GameObject feedbackRingDaumen;
    Renderer m_Renderer_FeedbackRingDaumen;
    public GameObject feedbackFaustWeg;
    Renderer m_Renderer_FeedbackFaustWeg;
    public GameObject feedbackFaustHer;
    Renderer m_Renderer_FeedbackFaustHer;
    public GameObject feedbackOffenWeg;  
    Renderer m_Renderer_FeedbackOffenWeg;        
    public GameObject feedbackOffenHer;       
    Renderer m_Renderer_FeedbackOffenHer;    
    [Space(10)]
    
    
    public float indexDaumenAbstand;
    public float indexPalmAbstand;
    public float indexDaumenTrigger;
    public float indexPalmTrigger;
    public float indexDaumenPalmTrigger; //das ist die Position des Daumen während der Index-Daumen Geste - wichtig um zu unterscheiden ob eine Faust gebildet wird oder Index-Daumen Geste
    [Space(10)]
    
    public float mittelDaumenAbstand;
    public float mittelPalmAbstand;
    public float mittelDaumenTrigger;
    public float mittelPalmTrigger;
    public float mittelDaumenPalmTrigger;
    
    [Space(10)]
    public float ringDaumenAbstand;
    public float ringPalmAbstand;
    public float ringDaumenTrigger;
    public float ringPalmTrigger;
    public float ringDaumenPalmTrigger;

    [Space(10)]
    public float daumenPalmAbstand;
    public float daumenPalmTrigger;
    
    [Space(10)]     
    public float indexMittelAbstand;
    public float mittelRingAbstand;
    public float indexMittelTrigger; 
    public float mittelRingTrigger; 
    public float offenDaumenPalmTrigger;      
    
    [Space(10)]
    public float blickrichtungHand;



    void Start()
    {
        //Fetch the Renderer component of the GameObject
        m_Renderer_FeedbackIndexDaumen = feedbackIndexDaumen.GetComponent<Renderer>();
        m_Renderer_FeedbackMittelDaumen = feedbackMittelDaumen.GetComponent<Renderer>();
        m_Renderer_FeedbackRingDaumen = feedbackRingDaumen.GetComponent<Renderer>();
        m_Renderer_FeedbackFaustWeg = feedbackFaustWeg.GetComponent<Renderer>();
        m_Renderer_FeedbackFaustHer = feedbackFaustHer.GetComponent<Renderer>();
        m_Renderer_FeedbackOffenWeg = feedbackOffenWeg.GetComponent<Renderer>();     
        m_Renderer_FeedbackOffenHer = feedbackOffenHer.GetComponent<Renderer>();     
    }
    

    private void Update()
    {
        
        indexDaumenAbstand = (float) ((Mathf.Round(GetComponent<Distance>().abstandindexDaumen * 100)) / 100.0); //gerundet auf 0.00
        indexPalmAbstand = (float) ((Mathf.Round(GetComponent<Distance>().abstandindexPalm * 100)) / 100.0);
        
        mittelDaumenAbstand = (float) ((Mathf.Round(GetComponent<Distance>().abstandmittelDaumen * 100)) / 100.0);
        mittelPalmAbstand = (float) ((Mathf.Round(GetComponent<Distance>().abstandmittelPalm * 100)) / 100.0);
        
        ringDaumenAbstand = (float) ((Mathf.Round(GetComponent<Distance>().abstandringDaumen * 100)) / 100.0);
        ringPalmAbstand = (float) ((Mathf.Round(GetComponent<Distance>().abstandringPalm * 100)) / 100.0);
        
        indexMittelAbstand = (float) ((Mathf.Round(GetComponent<Distance>().abstandIndexMittel * 100)) / 100.0); 
        mittelRingAbstand = (float) ((Mathf.Round(GetComponent<Distance>().abstandMittelRing * 100)) / 100.0); 
        
        daumenPalmAbstand = (float) ((Mathf.Round(GetComponent<Distance>().abstandDaumenPalm * 100)) / 100.0);
        
        
        
        
        blickrichtungHand = (float) ((Mathf.Round(this.GetComponent<Distance>().handRichtungX * 10)) / 10.0);
        
        
        
        if (indexDaumenAbstand <= indexDaumenTrigger)
        {
            if (mittelDaumenAbstand > mittelDaumenTrigger)
            {
                if (ringDaumenAbstand > ringDaumenTrigger)
                {
                    if (daumenPalmAbstand >= indexDaumenPalmTrigger)
                    {
                        if (blickrichtungHand < 0f)
                        {
                            m_Renderer_FeedbackIndexDaumen.material.color = Color.green;
                        }
                    }
                }
            }
        }
        else
        {
            m_Renderer_FeedbackIndexDaumen.material.color = Color.grey;
        }
        
        
        
        if (mittelDaumenAbstand <= mittelDaumenTrigger)
        {
            if (indexDaumenAbstand > indexDaumenTrigger)
            {
                if (ringDaumenAbstand > ringDaumenTrigger)
                {
                    if (daumenPalmAbstand > mittelDaumenPalmTrigger)
                    {
                        if (blickrichtungHand < 0f)
                        {
                            m_Renderer_FeedbackMittelDaumen.material.color = Color.green;
                        }
                    }
                }
            }
        }
        else
        {
            m_Renderer_FeedbackMittelDaumen.material.color = Color.grey;
        }
        
        
        
        if (ringDaumenAbstand <= mittelDaumenTrigger)
        {
            if (indexDaumenAbstand > indexDaumenTrigger)
            {
                if (mittelDaumenAbstand > mittelDaumenTrigger)
                {
                    if (daumenPalmAbstand >= ringDaumenPalmTrigger)
                    {
                        if (blickrichtungHand < 0f)
                        {
                            m_Renderer_FeedbackRingDaumen.material.color = Color.green;
                        }
                    }
                }
            }
        }
        else
        {
            m_Renderer_FeedbackRingDaumen.material.color = Color.grey;
        }

        
        
        if (indexPalmAbstand <= indexPalmTrigger)
        {
            if (mittelPalmAbstand <= mittelPalmTrigger)
            {
                if (ringPalmAbstand <= ringPalmTrigger )
                {
                    if (daumenPalmAbstand <= daumenPalmTrigger )
                    {
                        if (blickrichtungHand < 0f)
                        {
                            m_Renderer_FeedbackFaustHer.material.color = Color.green;
                        }
                    }
                }
            }
        }
        else
        {
            m_Renderer_FeedbackFaustHer.material.color = Color.gray;
        }
        
        
        
        if (indexPalmAbstand <= indexPalmTrigger)
        {
            if (mittelPalmAbstand <= mittelPalmTrigger)
            {
                if (ringPalmAbstand <= ringPalmTrigger )
                {
                    if (daumenPalmAbstand <= daumenPalmTrigger )
                    {
                        if (blickrichtungHand > 0f)
                        {
                            m_Renderer_FeedbackFaustWeg.material.color = Color.green;
                        }
                    }
                }
            }
        }
        else
        {
            m_Renderer_FeedbackFaustWeg.material.color = Color.gray;
        }

        
        
        
        if (indexMittelAbstand <= indexMittelTrigger)                                      
        {                                                                                  
            if (mittelRingAbstand > mittelRingTrigger)                                 
            {                                                                              
                if (blickrichtungHand < 0f)                                                         
                {
                    if (daumenPalmAbstand >= offenDaumenPalmTrigger )                                    
                    {                                                                               
                        if (blickrichtungHand < 0f)                                                 
                        {                                                                           
                            m_Renderer_FeedbackOffenHer.material.color = Color.green;              
                        }                                                                           
                    }                                                                               
                }
            }                                                                              
        }                                                                                  
        else                                                                               
        {                                                                                  
            m_Renderer_FeedbackOffenHer.material.color = Color.grey;                    
        }                                                                                  
        

        
        if (indexMittelAbstand <= indexMittelTrigger)                                     
        {                                                                                 
            if (mittelRingAbstand > mittelRingTrigger)                                    
            {                                                                             
                if (blickrichtungHand > 0f)                                               
                {
                    if (daumenPalmAbstand >= offenDaumenPalmTrigger )                       
                    {                                                                       
                        if (blickrichtungHand > 0f)                                         
                        {                                                                   
                            m_Renderer_FeedbackOffenWeg.material.color = Color.green;          
                        }                                                                   
                    }                                                                       
                }                                                                         
            }                                                                             
        }                                                                                 
        else                                                                              
        {                                                                                 
            m_Renderer_FeedbackOffenWeg.material.color = Color.grey;                      
        }                                                                                 


        
        
    }
    
    
    
}
