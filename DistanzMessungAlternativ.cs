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

public class DistanzMessungAlternativ : MonoBehaviour
{
    public Transform indexFinger;
    public Transform mittelFinger;
    public Transform pinkyFinger;
    public Transform daumen;
    public Transform handgelenk;

    public GameObject UIrotationXKreis;
    public GameObject UIrotationYKreis;
    public GameObject UIrotationZKreis;
    public GameObject UIskalierungXPfeil;
    public GameObject UIskalierungYPfeil;
    public GameObject UIskalierungZPfeil;
    public GameObject UIbackground;
    public GameObject UIbackgroundSmall;
    
    public GameObject rechteHand;

    public GameObject cube;

    public GameObject uiFunctionText;
    private TextMeshProUGUI uiFunctionTextMesh;
    
    public GameObject uiFunctionTextDetail;
    private TextMeshProUGUI uiFunctionTextDetailMesh;
    
    public GameObject uiFunctionTextInfo;
    private TextMeshProUGUI uiFunctionTextInfoMesh;
    
    public GameObject uiValueText;
    private TextMeshProUGUI uiValueTextMesh;
    
    public float uiFunctionValue;
    
    public bool inTriggerBoxLeft = false;
    
    
    [Space] 
    public bool funktionRotation;
    public bool funktionSkalierung;
    public bool funktionFarbe;
    public bool funktionSchliessen;

    [Space] 
    public bool SkalierungInX;
    public bool SkalierungInY;
    public bool SkalierungInZ;
    [Space] 
    public bool RotationInX;
    public bool RotationInY;
    public bool RotationInZ;



    [Space] 
    public GameObject rotationFeedback;
    Renderer m_Renderer_Rotation;
    
    public GameObject skalierungFeedback;
    Renderer m_Renderer_Skalierung;
    
    public GameObject FarbeFeedback;
    Renderer m_Renderer_Farbe;
    
    public GameObject SchliessenFeedback;
    Renderer m_Renderer_Schliessen;
    
    
    [Space] 
    public int framesToCheck;
    [Space]
    private float handRichtungForwardX;

    [Space] 
    public float handRichtungForwardYzielSkalX;
    public float handRichtungForwardYzielSkalY;
    public float handRichtungForwardYzielSkalZ;
    public float handRichtungForwardYzielRotaX;
    public float handRichtungForwardYzielRotaY;
    public float handRichtungForwardYzielRotaZ;
    public float handRichtungForwardY;
    [Space] 
    public float handRichtungRightXzielSkalX;
    public float handRichtungRightXzielSkalY;
    public float handRichtungRightXzielSkalZ;
    public float handRichtungRightXzielRotaX;
    public float handRichtungRightXzielRotaY;
    public float handRichtungRightXzielRotaZ;
    public float handRichtungRightX;
    [Space] 
    public float handRichtungRightZzielSkalX;
    public float handRichtungRightZzielSkalY;
    public float handRichtungRightZzielSkalZ;
    public float handRichtungRightZzielRotaX;
    public float handRichtungRightZzielRotaY;
    public float handRichtungRightZzielRotaZ;
    public float handRichtungRightZ;
    [Space]

    public float timerSkalierung = 0.0f;
    public float timerRotation = 0.0f;
    public float timerSchliessen = 0.0f;
    public float timerFarbe = 0.0f;
    public float waitTime = 1.0f;
    public float waitTimeAxis = 3.0f;
    [Space] 
    public float timerSkalierungAxis = 0f;
    public float timerRotationAxis = 0f;
    [Space] 
    
    
    [Space] 
    public float rotationAbstandZielDI;
    public float skalierungAbstandZielDI;
    public float farbeAbstandZielDI;
    public float schliessenAbstandZielDI;
    public float abstandMinDI;
    [Space]
    public float farbeAbstandZielDM;
    public float schliessenAbstandZielDM;
    public float abstandMinDM;
    [Space]
    public float farbeAbstandZielIM;
    public float schliessenAbstandZielIM;
    public float abstandMinIM;
    [Space]
    public float rotationAbstandZielHI;
    public float skalierungAbstandZielHI;
    public float farbeAbstandZielHI;
    public float schliessenAbstandZielHI;
    public float abstandMinHI;
    [Space]
    public float farbeAbstandZielHM;
    public float schliessenAbstandZielHM;
    public float abstandMinHM;
    [Space]
    public float farbeAbstandZielHP;
    public float schliessenAbstandZielHP;
    public float abstandMinHP;
    [Space]
    public float rotationAbstandZielHD;
    public float skalierungAbstandZielHD;
    public float farbeAbstandZielHD;
    public float schliessenAbstandZielHD;
    public float abstandMinHD;
    [Space]
    public float skalierungHandrichtungMin;
    public float skalierungHandrichtungMax;
    public float rotationHandrichtungMin;
    public float rotationHandrichtungMax;
    

    //AKTUELLER IST-WERT DER ABSTÄNDE
    private float abstandDI;
    private float abstandDM;
    private float abstandIM;
    private float abstandHI;
    private float abstandHM;
    private float abstandHP;
    private float abstandHD;
    
    
    //ARRAY LISTEN
    private List<float> distanzListDI = new List<float>();
    private List<float> distanzListIM = new List<float>();
    private List<float> distanzListDM = new List<float>();
    private List<float> distanzListHI = new List<float>();
    private List<float> distanzListHM = new List<float>();
    private List<float> distanzListHD = new List<float>();
    private List<float> distanzListHP = new List<float>();
    private int messungNummer = 0;
    
    
    //RENDERER FÜR UI
    private Renderer rendererRotationUIx;
    private Renderer rendererRotationUIy;
    private Renderer rendererRotationUIz;
    
    private Renderer rendererSkalierungUIx;
    private Renderer rendererSkalierungUIy;
    private Renderer rendererSkalierungUIz;

    private Renderer rendererUIbackground;
    private Renderer rendererUIbackgroundSmall;

    
    [Space]
    
    //MATERIALS
    public Material transparentGrey;
    public Material indicatorYellow;
    public Material indicatorGreen;
    

    void Start()
    {
        uiFunctionTextMesh = uiFunctionText.GetComponent<TextMeshProUGUI>();
        uiFunctionTextDetailMesh = uiFunctionTextDetail.GetComponent<TextMeshProUGUI>();
        uiFunctionTextInfoMesh = uiFunctionTextInfo.GetComponent<TextMeshProUGUI>();
        uiValueTextMesh = uiValueText.GetComponent<TextMeshProUGUI>();
        
        rendererRotationUIx = UIrotationXKreis.GetComponent<Renderer>();
        rendererRotationUIy = UIrotationYKreis.GetComponent<Renderer>();
        rendererRotationUIz = UIrotationZKreis.GetComponent<Renderer>();
        
        rendererSkalierungUIx = UIskalierungXPfeil.GetComponent<Renderer>();
        rendererSkalierungUIy = UIskalierungYPfeil.GetComponent<Renderer>();
        rendererSkalierungUIz = UIskalierungZPfeil.GetComponent<Renderer>();

        rendererUIbackground = UIbackground.GetComponent<Renderer>();
        rendererUIbackgroundSmall = UIbackgroundSmall.GetComponent<Renderer>();

        rendererRotationUIx.enabled = false;
        rendererRotationUIy.enabled = false;
        rendererRotationUIz.enabled = false;
        
        rendererSkalierungUIx.enabled = false;
        rendererSkalierungUIy.enabled = false;
        rendererSkalierungUIz.enabled = false;

        rendererUIbackground.enabled = false;
        rendererUIbackgroundSmall.enabled = false;

        m_Renderer_Rotation = rotationFeedback.GetComponent<Renderer>();
        m_Renderer_Skalierung = skalierungFeedback.GetComponent<Renderer>();
        m_Renderer_Farbe = FarbeFeedback.GetComponent<Renderer>();
        m_Renderer_Schliessen = SchliessenFeedback.GetComponent<Renderer>();
    }


    void Update()
    {

        //DAUMEN-INDEXFINGER SETUP
        if (indexFinger)
        {
            abstandDI = Vector3.Distance(indexFinger.position, daumen.position); //misst Abstand zwischen Ziel und dem GameObject auf dem das Script liegt
            distanzListDI.Add(abstandDI);
        }

        
        if (distanzListDI.Count >= framesToCheck) //checkt die Liste nach dem kleinsten Wert
        {
            distanzListDI.Clear();
        }
        
        
        if(distanzListDI.Count != 0) //checkt ob die liste leer ist, wenn nicht geprüft wird kommt ein Fehler in der Console
        {
            abstandMinDI = distanzListDI.Min();
        }
        
        
        
        //DAUMEN-MITTELFINGER SETUP
        if (mittelFinger)
        {
            abstandDM = Vector3.Distance(mittelFinger.position, daumen.position);
            distanzListDM.Add(abstandDM);
        }

        
        if (distanzListDM.Count >= framesToCheck)
        {
            distanzListDM.Clear();
        }
        
        
        if(distanzListDM.Count != 0)
        {
            abstandMinDM = distanzListDM.Min();
        }
        
        
        
        //INDEX-MITTELFINGER SETUP
        if (indexFinger)
        {
            abstandIM = Vector3.Distance(indexFinger.position, mittelFinger.position);
            distanzListIM.Add(abstandIM);
        }

        
        if (distanzListIM.Count >= framesToCheck)
        {
            distanzListIM.Clear();
        }
        
        
        if(distanzListIM.Count != 0)
        {
            abstandMinIM = distanzListIM.Min();
        }
        

   
        //HANDGELENK-INDEXFINGER SETUP
        if (indexFinger)
        {
            abstandHI = Vector3.Distance(indexFinger.position, handgelenk.position);
            distanzListHI.Add(abstandHI);
        }

        
        if (distanzListHI.Count >= framesToCheck)
        {
            distanzListHI.Clear();
        }
        
        
        if(distanzListHI.Count != 0)
        {
            abstandMinHI = distanzListHI.Min();
        }
        
        
        
        
        //HANDGELENK-MITTELFINGER SETUP
        if (mittelFinger)
        {
            abstandHM = Vector3.Distance(mittelFinger.position, handgelenk.position);
            distanzListHM.Add(abstandHM);
        }

        
        if (distanzListHM.Count >= framesToCheck)
        {
            distanzListHM.Clear();
        }
        
        
        if(distanzListHM.Count != 0)
        {
            abstandMinHM = distanzListHM.Min();
        }
        
        
        
        //HANDGELENK-DAUMEN SETUP
        if (daumen)
        {
            abstandHD = Vector3.Distance(daumen.position, handgelenk.position);
            distanzListHD.Add(abstandHD);
        }

        
        if (distanzListHD.Count >= framesToCheck)
        {
            distanzListHD.Clear();
        }
        
        
        if(distanzListHD.Count != 0)
        {
            abstandMinHD = distanzListHD.Min();
        }
        
        
        //HANDGELENK-PINKY SETUP
        if (daumen)
        {
            abstandHP = Vector3.Distance(pinkyFinger.position, handgelenk.position);
            distanzListHP.Add(abstandHP);
        }

        
        if (distanzListHP.Count >= framesToCheck)
        {
            distanzListHP.Clear();
        }
        
        
        if(distanzListHP.Count != 0)
        {
            abstandMinHP = distanzListHP.Min();
        }


        //WENN NICHT IN DER TRIGGER BOX
        if (inTriggerBoxLeft == false)
        {
              RotationInX = false;
              RotationInY = false;
              RotationInZ = false;

              SkalierungInX = false;
              SkalierungInY = false;
              SkalierungInZ = false;
              
              rendererSkalierungUIx.material = transparentGrey;
              rendererSkalierungUIy.material = transparentGrey;
              rendererSkalierungUIz.material = transparentGrey;
              
              rendererRotationUIx.material = transparentGrey;
              rendererRotationUIy.material = transparentGrey;
              rendererRotationUIz.material = transparentGrey;
              
        }
 
        
        
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        //FARBE (HAT PRIO 1)
        if (inTriggerBoxLeft == true)
        {
            if (abstandMinDI > farbeAbstandZielDI)
            {
                if (abstandMinDM > farbeAbstandZielDM)
                {
                    if (abstandMinIM > farbeAbstandZielIM)
                    {
                        if (abstandMinHI > farbeAbstandZielHI)
                        {
                            if (abstandMinHM > farbeAbstandZielHM)
                            {
                                if (abstandMinHP > farbeAbstandZielHP)
                                {
                                    if (abstandMinHD > farbeAbstandZielHD)
                                    {
                                        timerFarbe += Time.deltaTime;

                                        if (timerFarbe > waitTime)
                                        {
                                            Farbe();
                                            funktionFarbe = true;
                                            funktionSchliessen = false;
                                            uiFunctionTextMesh.text = "";
                                            uiFunctionTextDetailMesh.text = "";
                                            uiFunctionTextInfoMesh.text = "";
                                            uiValueTextMesh.text = "";
                                        }
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
            timerFarbe = 0.0f;
            m_Renderer_Farbe.material.color = Color.gray;
            funktionFarbe = false;
        }
        
        
        
        //SCHLIESSEN (HAT PRIO 2)
        if (inTriggerBoxLeft == true)
        {
            if (abstandMinDI < schliessenAbstandZielDI)
            {
                if (abstandMinDM < schliessenAbstandZielDM)
                {
                    if (abstandMinIM < schliessenAbstandZielIM)
                    {
                        if (abstandMinHI < schliessenAbstandZielHI)
                        {
                            if (abstandMinHM < schliessenAbstandZielHM)
                            {
                                if (abstandMinHP < schliessenAbstandZielHP)
                                {
                                    if (abstandMinHD < schliessenAbstandZielHD)
                                    {
                                        timerSchliessen += Time.deltaTime;

                                        if (timerSchliessen > waitTime)
                                        {
                                            uiFunctionTextMesh.text = "";
                                            uiFunctionTextDetailMesh.text = "";
                                            uiFunctionTextInfoMesh.text = "";
                                            uiValueTextMesh.text = "";
                                            
                                            Schliessen();
                                            funktionRotation = false;
                                            funktionSkalierung = false;
                                            funktionFarbe = false;
                                            funktionSchliessen = true;
                                            
                                            rendererRotationUIx.enabled = false;
                                            rendererRotationUIy.enabled = false;
                                            rendererRotationUIz.enabled = false;
                                            m_Renderer_Rotation.material.color = Color.gray;

                                            rendererSkalierungUIx.enabled = false;
                                            rendererSkalierungUIy.enabled = false;
                                            rendererSkalierungUIz.enabled = false;
                                            m_Renderer_Skalierung.material.color = Color.gray;

                                            rendererUIbackground.enabled = false;
                                            rendererUIbackgroundSmall.enabled = false;

                                            SkalierungInX = false;
                                            SkalierungInY = false;
                                            SkalierungInZ = false;
                                            
                                            RotationInX = false;
                                            RotationInY = false;
                                            RotationInZ = false;
                                         
                                            timerSkalierungAxis = 0f;
                                            timerRotationAxis = 0f;
                                        }
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
            timerSchliessen = 0.0f;
            m_Renderer_Schliessen.material.color = Color.gray;
            funktionSchliessen = false;
        }
        
        
        
        //ROTATION (PRIO 3)
        if (inTriggerBoxLeft == true)
        {
            if (handRichtungForwardX > rotationHandrichtungMin)
            {
                if (handRichtungForwardX < rotationHandrichtungMax)
                {
                    if (abstandMinDI < rotationAbstandZielDI)
                    {
                        if (abstandMinHI < rotationAbstandZielHI)
                        {
                            if (abstandMinHD < rotationAbstandZielHD)
                            {
                                timerRotation += Time.deltaTime;

                                if (timerRotation > waitTime)
                                {
                                    Rotation();
                                    funktionRotation = true;
                                    funktionSkalierung = false;
                                    funktionFarbe = false;
                                    funktionSchliessen = false;
                                }
                            }
                        }
                    }
                }
            }
        }
        
        else

        {
            timerRotation = 0.0f;
        }
        

        
        //SKALIERUNG (PRIO 4)
        if (inTriggerBoxLeft == true)
        {
            if (handRichtungForwardX > skalierungHandrichtungMin)
            {
                if (handRichtungForwardX < skalierungHandrichtungMax)
                {
                    if (abstandMinDI > skalierungAbstandZielDI)
                    {
                        if (abstandMinHI < skalierungAbstandZielHI)
                        {
                            if (abstandMinHD > skalierungAbstandZielHD)
                            {
                                timerSkalierung += Time.deltaTime;

                                if (timerSkalierung > waitTime)
                                {
                                    Skalierung();
                                    funktionRotation = false;
                                    funktionSkalierung = true;
                                    funktionFarbe = false;
                                    funktionSchliessen = false;
                                }
                            }
                        }
                    }
                }
            }
        }
        
        else

        {
            timerSkalierung = 0.0f;
        }
        
        
        
        //HANDRICHTUNG ERKENNEN
        var forward = transform.forward;
        var right = transform.right;

        handRichtungForwardX = forward.x;
        handRichtungForwardY = forward.y;
        handRichtungRightX = right.x;
        handRichtungRightZ = right.z;

        
        
        
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        // NUR FUNKTIONS BOOL AUF TRUE IST
        
        // SKALIERUNG ALLGEMEIN

        
        if (funktionSkalierung == true)
        {
            uiFunctionTextMesh.text = "Scale Object";
            uiFunctionTextDetailMesh.text = "Select all Axis";
            uiFunctionTextInfoMesh.text = "Scale all axis. To scale each axis\nindividually, please unlock proportions\nscaling and select desired axis.";
            uiValueTextMesh.text = "";
            rendererUIbackgroundSmall.enabled = true;
            rendererUIbackground.enabled = false;
            
            rendererSkalierungUIx.material = indicatorGreen;
            rendererSkalierungUIy.material = indicatorGreen;
            rendererSkalierungUIz.material = indicatorGreen;
        }
        
        
        
        
        // BESTÄTIGUNG CONDITION
        if (rechteHand.GetComponent<DistanzMessungRechts>().funktionBestaetigung == true)
        {
            if (funktionSkalierung == true || funktionRotation == true)
            {
                uiFunctionTextMesh.text = "";
                uiFunctionTextDetailMesh.text = "";
                uiFunctionTextInfoMesh.text = "";
                uiValueTextMesh.text = "";

                Schliessen();
                funktionRotation = false;
                funktionSkalierung = false;
                funktionFarbe = false;
                funktionSchliessen = true;

                rendererRotationUIx.enabled = false;
                rendererRotationUIy.enabled = false;
                rendererRotationUIz.enabled = false;
                m_Renderer_Rotation.material.color = Color.gray;

                rendererSkalierungUIx.enabled = false;
                rendererSkalierungUIy.enabled = false;
                rendererSkalierungUIz.enabled = false;
                m_Renderer_Skalierung.material.color = Color.gray;

                rendererUIbackground.enabled = false;
                rendererUIbackgroundSmall.enabled = false;

                SkalierungInX = false;
                SkalierungInY = false;
                SkalierungInZ = false;

                RotationInX = false;
                RotationInY = false;
                RotationInZ = false;

                timerSkalierungAxis = 0f;
                timerRotationAxis = 0f;
            }
        }
        
        
        
        
        // ROTATION ALLGEMEIN

        if (funktionRotation == true)
        {
            uiFunctionTextMesh.text = "Rotate Object";
            uiFunctionTextDetailMesh.text = "Select Axis";
            uiFunctionTextInfoMesh.text = "Select the axis you want to rotate.\nHold it for more than 2 seconds\nto lock-in the desired axis.";
            uiValueTextMesh.text = "";
            rendererUIbackgroundSmall.enabled = true;
            rendererUIbackground.enabled = false;
        }

        if (rechteHand.GetComponent<DistanzMessungRechts>().funktionBestaetigung == true)
        {
            RotationInX = false;
            RotationInY = false;
            RotationInZ = false;
            funktionRotation = false;

            rendererRotationUIx.enabled = false;
            rendererRotationUIy.enabled = false;
            rendererRotationUIz.enabled = false;
            
            
        }



        // SKALIERUNG SELEKTION DER ACHSEN

        if (SkalierungInX == true)
        {
            rendererSkalierungUIx.material = indicatorGreen;
            rendererSkalierungUIy.material = transparentGrey;
            rendererSkalierungUIz.material = transparentGrey;

            if (rechteHand.GetComponent<Slider>().scaleAllAxis == true)
            {
                rendererSkalierungUIx.material = indicatorGreen;
                rendererSkalierungUIy.material = indicatorGreen;
                rendererSkalierungUIz.material = indicatorGreen;
            }
        
            uiFunctionTextMesh.text = "Scale Object";
            uiFunctionTextDetailMesh.text = "in X-Axis";
            uiFunctionTextInfoMesh.text = "Move the slider with 1 finger to\nscale the object. Alternatively use\n2 fingers for smaller scaling steps.";
            uiValueTextMesh.text = rechteHand.GetComponent<Slider>().CubeObjektWert.ToString("#.") + "%";
            
            rendererUIbackgroundSmall.enabled = false;
            rendererUIbackground.enabled = true;
        }
        
        
        if (SkalierungInY == true)
        {
            rendererSkalierungUIx.material = transparentGrey;
            rendererSkalierungUIy.material = indicatorGreen;
            rendererSkalierungUIz.material = transparentGrey;
            
            if (rechteHand.GetComponent<Slider>().scaleAllAxis == true)
            {
                rendererSkalierungUIx.material = indicatorGreen;
                rendererSkalierungUIy.material = indicatorGreen;
                rendererSkalierungUIz.material = indicatorGreen;
            }
            
            uiFunctionTextMesh.text = "Scale Object";
            uiFunctionTextDetailMesh.text = "in Y-Axis";
            uiFunctionTextInfoMesh.text = "Move the slider with 1 finger to\nscale the object. Alternatively use\n2 fingers for smaller scaling steps.";
            uiValueTextMesh.text = rechteHand.GetComponent<Slider>().CubeObjektWert.ToString("#.") + "%";
            
            rendererUIbackgroundSmall.enabled = false;
            rendererUIbackground.enabled = true;
        }
        
        
        if (SkalierungInZ == true)
        {
            rendererSkalierungUIx.material = transparentGrey;
            rendererSkalierungUIy.material = transparentGrey;
            rendererSkalierungUIz.material = indicatorGreen;
            
            if (rechteHand.GetComponent<Slider>().scaleAllAxis == true)
            {
                rendererSkalierungUIx.material = indicatorGreen;
                rendererSkalierungUIy.material = indicatorGreen;
                rendererSkalierungUIz.material = indicatorGreen;
            }
            
            uiFunctionTextMesh.text = "Scale Object";
            uiFunctionTextDetailMesh.text = "in Z-Axis";
            uiFunctionTextInfoMesh.text = "Move the slider with 1 finger to\nscale the object. Alternatively use\n2 fingers for smaller scaling steps.";
            uiValueTextMesh.text = rechteHand.GetComponent<Slider>().CubeObjektWert.ToString("#.") + "%";
                                   
            rendererUIbackgroundSmall.enabled = false;
            rendererUIbackground.enabled = true;
        }
        
        
        // ROTATION SELEKTION DER ACHSEN

        if (RotationInX == true)
        {
            rendererRotationUIx.material = indicatorGreen;
            rendererRotationUIy.material = transparentGrey;
            rendererRotationUIz.material = transparentGrey;
            
            uiFunctionTextMesh.text = "Rotate Object";
            uiFunctionTextDetailMesh.text = "in X-Axis";
            uiFunctionTextInfoMesh.text = "Move the slider with 1 finger to\nrotate the object. Alternatively use\n2 fingers for smaller rotation steps.";
            uiValueTextMesh.text = rechteHand.GetComponent<Slider>().CubeObjektWert.ToString("#.") + "°";
            
            rendererUIbackgroundSmall.enabled = false;
            rendererUIbackground.enabled = true;
        }

        
        if (RotationInY == true)
        {
            rendererRotationUIx.material = transparentGrey;
            rendererRotationUIy.material = indicatorGreen;
            rendererRotationUIz.material = transparentGrey;
            
            uiFunctionTextMesh.text = "Rotate Object";
            uiFunctionTextDetailMesh.text = "in Y-Axis";
            uiFunctionTextInfoMesh.text = "Move the slider with 1 finger to\nrotate the object. Alternatively use\n2 fingers for smaller rotation steps.";
            uiValueTextMesh.text = rechteHand.GetComponent<Slider>().CubeObjektWert.ToString("#.") + "°";
            
            rendererUIbackgroundSmall.enabled = false;
            rendererUIbackground.enabled = true;
        }
        
        
        if (RotationInZ == true)
        {
            rendererRotationUIx.material = transparentGrey;
            rendererRotationUIy.material = transparentGrey;
            rendererRotationUIz.material = indicatorGreen;
            
            uiFunctionTextMesh.text = "Rotate Object";
            uiFunctionTextDetailMesh.text = "in Z-Axis";
            uiFunctionTextInfoMesh.text = "Move the slider with 1 finger to\nrotate the object. Alternatively use\n2 fingers for smaller rotation steps.";
            uiValueTextMesh.text = rechteHand.GetComponent<Slider>().CubeObjektWert.ToString("#.") + "°";
            
            rendererUIbackgroundSmall.enabled = false;
            rendererUIbackground.enabled = true;
        }



        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        // HANDROTATION ERKENNEN 
        // SKALIERUNG IN X
        if (inTriggerBoxLeft == true)
        {
            if (handRichtungForwardY < handRichtungForwardYzielSkalX)
            {
                if (handRichtungRightX < handRichtungRightXzielSkalX)
                {
                    if (handRichtungRightZ < handRichtungRightZzielSkalX)
                    {
                        if (funktionSkalierung == true)
                        {
                            if (SkalierungInX == false)
                            {
                                uiFunctionTextDetailMesh.text = "in X-Axis";
                                timerSkalierungAxis += Time.deltaTime;
                                rendererSkalierungUIx.material = indicatorYellow;
                                rendererSkalierungUIy.material = transparentGrey;
                                rendererSkalierungUIz.material = transparentGrey;

                                if (timerSkalierungAxis > waitTimeAxis)
                                {
                                    SkalierungInX = true;
                                    SkalierungInY = false;
                                    SkalierungInZ = false;
                                }
                            }

                        }
                    }
                    else
                    {
                        timerSkalierungAxis = 0f;
                        rendererSkalierungUIx.material = transparentGrey;
                        rendererSkalierungUIy.material = transparentGrey;
                        rendererSkalierungUIz.material = transparentGrey;
                    }
                }
            }
        }


        
        // SKALIERUNG IN Y
        if (inTriggerBoxLeft == true)
        {
            if (handRichtungForwardY > handRichtungForwardYzielSkalY)
            {
                if (handRichtungRightX > handRichtungRightXzielSkalY)
                {
                    if (handRichtungRightZ < handRichtungRightZzielSkalY)
                    {
                        if (funktionSkalierung == true)
                        {
                            if (SkalierungInY == false)
                            {
                                uiFunctionTextDetailMesh.text = "in Y-Axis";
                                timerSkalierungAxis += Time.deltaTime;
                                rendererSkalierungUIx.material = transparentGrey;
                                rendererSkalierungUIy.material = indicatorYellow;
                                rendererSkalierungUIz.material = transparentGrey;

                                if (timerSkalierungAxis > waitTimeAxis)
                                {
                                    SkalierungInX = false;
                                    SkalierungInY = true;
                                    SkalierungInZ = false;
                                }
                            }

                        }
                    }
                    else
                    {
                        timerSkalierungAxis = 0f;
                        rendererSkalierungUIx.material = transparentGrey;
                        rendererSkalierungUIy.material = transparentGrey;
                        rendererSkalierungUIz.material = transparentGrey;
                    }
                }
            }
        }



        // SKALIERUNG IN Z
        if (inTriggerBoxLeft == true)
        {
            if (handRichtungForwardY < handRichtungForwardYzielSkalZ)
            {
                if (handRichtungRightX > handRichtungRightXzielSkalZ)
                {
                    if (handRichtungRightZ > handRichtungRightZzielSkalZ)
                    {
                        if (funktionSkalierung == true)
                        {
                            if (SkalierungInZ == false)
                            {
                                uiFunctionTextDetailMesh.text = "in Z-Axis";
                                timerSkalierungAxis += Time.deltaTime;
                                rendererSkalierungUIx.material = transparentGrey;
                                rendererSkalierungUIy.material = transparentGrey;
                                rendererSkalierungUIz.material = indicatorYellow;

                                if (timerSkalierungAxis > waitTimeAxis)
                                {
                                    SkalierungInX = false;
                                    SkalierungInY = false;
                                    SkalierungInZ = true;
                                }
                            }
                        }
                    }
                    else
                    {
                        timerSkalierungAxis = 0f;
                        rendererSkalierungUIx.material = transparentGrey;
                        rendererSkalierungUIy.material = transparentGrey;
                        rendererSkalierungUIz.material = transparentGrey;
                    }
                }
            }
        }








        // ROTATION IN X
        if (inTriggerBoxLeft == true)
        {
            if (handRichtungForwardY < handRichtungForwardYzielRotaX)
            {
                if (handRichtungRightX < handRichtungRightXzielRotaX)
                {
                    if (handRichtungRightZ > handRichtungRightZzielRotaX)
                    {
                        if (funktionRotation == true)
                        {
                            if (RotationInX == false)
                            {
                                uiFunctionTextDetailMesh.text = "in X-Axis";
                                timerRotationAxis += Time.deltaTime;
                                rendererRotationUIx.material = indicatorYellow;
                                rendererRotationUIy.material = transparentGrey;
                                rendererRotationUIz.material = transparentGrey;

                                if (timerRotationAxis > waitTimeAxis)
                                {
                                    RotationInX = true;
                                    RotationInY = false;
                                    RotationInZ = false;
                                }
                            }
                        }
                    }
                    else
                    {
                        timerRotationAxis = 0f;
                        rendererRotationUIx.material = transparentGrey;
                        rendererRotationUIy.material = transparentGrey;
                        rendererRotationUIz.material = transparentGrey;
                    }
                }
            }
        }
        
        
        // ROTATION IN Y
        if (inTriggerBoxLeft == true)
        {
            if (handRichtungForwardY < handRichtungForwardYzielRotaY)
            {
                if (handRichtungRightX > handRichtungRightXzielRotaY)
                {
                    if (handRichtungRightZ > handRichtungRightZzielRotaZ)
                    {
                        if (funktionRotation == true)
                        {
                            if (RotationInY == false)
                            {
                                uiFunctionTextDetailMesh.text = "in Y-Axis";
                                timerRotationAxis += Time.deltaTime;
                                rendererRotationUIx.material = transparentGrey;
                                rendererRotationUIy.material = indicatorYellow;
                                rendererRotationUIz.material = transparentGrey;

                                if (timerRotationAxis > waitTimeAxis)
                                {
                                    RotationInX = false;
                                    RotationInY = true;
                                    RotationInZ = false;
                                }
                            }
                        }
                    }
                    else
                    {
                        timerRotationAxis = 0f;
                        rendererRotationUIx.material = transparentGrey;
                        rendererRotationUIy.material = transparentGrey;
                        rendererRotationUIz.material = transparentGrey;
                    }
                }
            }
        }
      
        
        // ROTATION IN Z
        if (inTriggerBoxLeft == true)
        {
            if (handRichtungForwardY > handRichtungForwardYzielRotaZ)
            {
                if (handRichtungRightX > handRichtungRightXzielRotaZ)
                {
                    if (handRichtungRightZ < handRichtungRightZzielRotaZ)
                    {
                        if (funktionRotation == true)
                        {
                            if (RotationInZ == false)
                            {
                                uiFunctionTextDetailMesh.text = "in Z-Axis";
                                timerRotationAxis += Time.deltaTime;
                                rendererRotationUIx.material = transparentGrey;
                                rendererRotationUIy.material = transparentGrey;
                                rendererRotationUIz.material = indicatorYellow;

                                if (timerRotationAxis > waitTimeAxis)
                                {
                                    RotationInX = false;
                                    RotationInY = false;
                                    RotationInZ = true;
                                }
                            }
                        }
                    }
                    else
                    {
                        timerRotationAxis = 0f;
                        rendererRotationUIx.material = transparentGrey;
                        rendererRotationUIy.material = transparentGrey;
                        rendererRotationUIz.material = transparentGrey;
                    }
                }
            }
        }
        
        
    }
    
    
    

    void Farbe ()
    {
        m_Renderer_Skalierung.material.color = Color.gray;
        m_Renderer_Rotation.material.color = Color.gray;
        m_Renderer_Schliessen.material.color = Color.gray;
        m_Renderer_Farbe.material = indicatorGreen;
        
        timerSkalierung = 0.0f;
        timerRotation = 0.0f;
        timerSchliessen = 0.0f;
    }
    
    
    void Schliessen ()
    {
        m_Renderer_Skalierung.material.color = Color.gray;
        m_Renderer_Rotation.material.color = Color.gray;
        m_Renderer_Schliessen.material = indicatorGreen;
        m_Renderer_Farbe.material.color = Color.grey;
        
        timerSkalierung = 0.0f;
        timerRotation = 0.0f;
        timerFarbe = 0.0f;
    }
    
    
    void Rotation ()
    {
        m_Renderer_Skalierung.material.color = Color.gray;
        m_Renderer_Rotation.material = indicatorGreen;
        m_Renderer_Schliessen.material.color = Color.gray;
        m_Renderer_Farbe.material.color = Color.gray;

        rendererRotationUIx.enabled = true;
        rendererRotationUIy.enabled = true;
        rendererRotationUIz.enabled = true;

        rendererRotationUIx.material = transparentGrey;
        rendererRotationUIy.material = transparentGrey;
        rendererRotationUIz.material = transparentGrey;
        
        rendererSkalierungUIx.enabled = false;
        rendererSkalierungUIy.enabled = false;
        rendererSkalierungUIz.enabled = false;
        
        timerSkalierung = 0.0f;
        timerSchliessen = 0.0f;
        timerFarbe = 0.0f;
    }
    
    
    void Skalierung ()
    {
        m_Renderer_Skalierung.material = indicatorGreen;
        m_Renderer_Rotation.material.color = Color.gray;
        m_Renderer_Schliessen.material.color = Color.gray;
        m_Renderer_Farbe.material.color = Color.gray;
        
        rendererSkalierungUIx.enabled = true;
        rendererSkalierungUIy.enabled = true;
        rendererSkalierungUIz.enabled = true;

        rendererSkalierungUIx.material = transparentGrey;
        rendererSkalierungUIy.material = transparentGrey;
        rendererSkalierungUIz.material = transparentGrey;
        
        rendererRotationUIx.enabled = false;
        rendererRotationUIy.enabled = false;
        rendererRotationUIz.enabled = false;
        
        timerRotation = 0.0f;
        timerSchliessen = 0.0f;
        timerFarbe = 0.0f;
        }

    
    
    /////////////////////////////////////////////////////////////////////////////////////////////////////////
    // ABFRAGE OB DIE HÄNDE INNERHALB DER TRIGGER BOX SIND
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("INNERHALB LEFT");
            inTriggerBoxLeft = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("AUSSERHALB LEFT");
            inTriggerBoxLeft = false;
        }
    }

}
