using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Slider : MonoBehaviour
{
    
    public bool inSliderBox = false;
    public Transform sliderBoxLeft;
    public Transform indexFinger;
    private TextMeshProUGUI sliderValueTextMesh;
    private TextMeshProUGUI colorTextMesh;
    public GameObject sliderValue;
    public GameObject sliderFunktion;
    public float sliderBoxAbstand;
    public float CubeObjektWert;
    public float sliderBoxStartWert;
    public GameObject CubeObjekt;
    public GameObject SliderObject;
    public Collider SliderBoxCollider;
    public float sliderStartPosition;
    public bool startPositionGemessen;
    public GameObject LeftHand;
    public GameObject RightHand;

    public GameObject colorCubes;

    public GameObject blackCube;
    public GameObject blueCube;
    public GameObject cyanCube;
    public GameObject greyCube;
    public GameObject magentaCube;
    public GameObject redCube;
    public GameObject whiteCube;
    public GameObject yellowCube;

    public GameObject sliderBackground;
    public GameObject colorBackground;

    public GameObject sliderButton;
    public GameObject sliderButtonKontur;
    public GameObject sliderGrip1;
    public GameObject sliderGrip2;
    public GameObject sliderGrip3;

    public GameObject sliderRasterungFein1;
    public GameObject sliderRasterungFein2;
    public GameObject sliderRasterungFein3;
    public GameObject sliderRasterungFein4;
    public GameObject sliderRasterungFein5;
    public GameObject sliderRasterungFein6;
    public GameObject sliderRasterungFein7;
    public GameObject sliderRasterungFein8;
    public GameObject sliderRasterungFein9;
    public GameObject sliderRasterungFein10;
    public GameObject sliderRasterungFein11;
    public GameObject sliderRasterungFein12;
    public GameObject sliderRasterungFein13;
    public GameObject sliderRasterungFein14;
    public GameObject sliderRasterungFein15;
    public GameObject sliderRasterungFein16;
    public GameObject sliderRasterungFein17;
    public GameObject sliderRasterungFein18;
    public GameObject sliderRasterungFein21;
    public GameObject sliderRasterungFein24;
    public GameObject sliderRasterungFein25;
    public GameObject sliderRasterungFein26;
    public GameObject sliderRasterungFein27;
    public GameObject sliderRasterungFein28;
    public GameObject sliderRasterungFein29;
    public GameObject sliderRasterungFein30;
    public GameObject sliderRasterungFein31;
    public GameObject sliderRasterungFein32;
    public GameObject sliderRasterungFein33;
    public GameObject sliderRasterungFein34;
    public GameObject sliderRasterungFein35;
    public GameObject sliderRasterungFein36;
    public GameObject sliderRasterungFein37;
    public GameObject sliderRasterungFein38;
    
    public GameObject sliderRasterungGrob1;
    public GameObject sliderRasterungGrob2;
    public GameObject sliderRasterungGrob3;
    public GameObject sliderRasterungGrob4;
    public GameObject sliderRasterungGrob5;
    public GameObject sliderRasterungGrob6;
    public GameObject sliderRasterungGrob7;
    public GameObject sliderRasterungGrob8;
    public GameObject sliderRasterungGrob9;
    public GameObject sliderRasterungGrob10;
    public GameObject sliderRasterungGrob11;
    
    public GameObject sliderMinus;
    public GameObject sliderPlus1;
    public GameObject sliderPlus2;
    
    private Renderer m_Renderer_Slider;
    private Renderer m_Renderer_ColorBlack;
    private Renderer m_Renderer_ColorBLue;
    private Renderer m_Renderer_ColorCyan;
    private Renderer m_Renderer_ColorGrey;
    private Renderer m_Renderer_ColorMagenta;
    private Renderer m_Renderer_ColorRed;
    private Renderer m_Renderer_ColorWhite;
    private Renderer m_Renderer_ColorYellow;

    private Renderer m_Renderer_sliderBackground;
    private Renderer m_Renderer_colorBackground;

    private Renderer m_Renderer_rasterungFein;
    private Renderer m_Renderer_rasterungGrob;

    private Renderer m_Renderer_Cube;
    
    private Renderer m_Renderer_SliderButton;
    private Renderer m_Renderer_SliderButtonKontur;
    private Renderer m_Renderer_SliderGrip1;
    private Renderer m_Renderer_SliderGrip2;
    private Renderer m_Renderer_SliderGrip3;

    private Renderer m_Renderer_sliderRasterungFein1;
    private Renderer m_Renderer_sliderRasterungFein2;
    private Renderer m_Renderer_sliderRasterungFein3;
    private Renderer m_Renderer_sliderRasterungFein4;
    private Renderer m_Renderer_sliderRasterungFein5;
    private Renderer m_Renderer_sliderRasterungFein6;
    private Renderer m_Renderer_sliderRasterungFein7;
    private Renderer m_Renderer_sliderRasterungFein8;
    private Renderer m_Renderer_sliderRasterungFein9;
    private Renderer m_Renderer_sliderRasterungFein10;
    private Renderer m_Renderer_sliderRasterungFein11;
    private Renderer m_Renderer_sliderRasterungFein12;
    private Renderer m_Renderer_sliderRasterungFein13;
    private Renderer m_Renderer_sliderRasterungFein14;
    private Renderer m_Renderer_sliderRasterungFein15;
    private Renderer m_Renderer_sliderRasterungFein16;
    private Renderer m_Renderer_sliderRasterungFein17;
    private Renderer m_Renderer_sliderRasterungFein18;
    private Renderer m_Renderer_sliderRasterungFein19;
    private Renderer m_Renderer_sliderRasterungFein20;
    private Renderer m_Renderer_sliderRasterungFein21;
    private Renderer m_Renderer_sliderRasterungFein22;
    private Renderer m_Renderer_sliderRasterungFein23;
    private Renderer m_Renderer_sliderRasterungFein24;
    private Renderer m_Renderer_sliderRasterungFein25;
    private Renderer m_Renderer_sliderRasterungFein26;
    private Renderer m_Renderer_sliderRasterungFein27;
    private Renderer m_Renderer_sliderRasterungFein28;
    private Renderer m_Renderer_sliderRasterungFein29;
    private Renderer m_Renderer_sliderRasterungFein30;
    private Renderer m_Renderer_sliderRasterungFein31;
    private Renderer m_Renderer_sliderRasterungFein32;
    private Renderer m_Renderer_sliderRasterungFein33;
    private Renderer m_Renderer_sliderRasterungFein34;
    private Renderer m_Renderer_sliderRasterungFein35;
    private Renderer m_Renderer_sliderRasterungFein36;
    private Renderer m_Renderer_sliderRasterungFein37;
    private Renderer m_Renderer_sliderRasterungFein38;
    
    private Renderer m_Renderer_sliderRasterungGrob1;
    private Renderer m_Renderer_sliderRasterungGrob2;
    private Renderer m_Renderer_sliderRasterungGrob3;
    private Renderer m_Renderer_sliderRasterungGrob4;
    private Renderer m_Renderer_sliderRasterungGrob5;
    private Renderer m_Renderer_sliderRasterungGrob6;
    private Renderer m_Renderer_sliderRasterungGrob7;
    private Renderer m_Renderer_sliderRasterungGrob8;
    private Renderer m_Renderer_sliderRasterungGrob9;
    private Renderer m_Renderer_sliderRasterungGrob10;
    private Renderer m_Renderer_sliderRasterungGrob11;
    private Renderer m_Renderer_sliderRasterungGrob12;
    private Renderer m_Renderer_sliderRasterungGrob13;
    
    private Renderer m_Renderer_sliderMinus;
    private Renderer m_Renderer_sliderPlus1;
    private Renderer m_Renderer_sliderPlus2;

    public Collider FingerTipRechts;

    public GameObject buttonAllAxis;
    public GameObject buttonAllAxisKontur;
    public GameObject backgroundScaleAll;
    public GameObject buttonTextScaleAll;

    public bool scaleAllAxis = true;

    private Renderer m_Renderer_buttonAllAxis;
    private Renderer m_Renderer_buttonAllAxisKontur;
    private TextMeshProUGUI  buttonTextMeshScaleAll;
    private Renderer m_Renderer_backgroundScaleAll;

    public GameObject checkmark;
    private Renderer m_Renderer_checkmark;


    [Space]

    //MATERIALS
    public Material pastellRed;
    public Material pastellPink;
    public Material pastellWhite;
    public Material pastellYellow;
    public Material pastellGrey;
    public Material pastellAqua;
    public Material pastellBlack;
    public Material pastellBlue;
    
    public Material pastellRedKonturColor;
    public Material pastellPinkKonturColor;
    public Material pastellWhiteKonturColor;
    public Material pastellYellowKonturColor;
    public Material pastellGreyKonturColor;
    public Material pastellAquaKonturColor;
    public Material pastellBlackKonturColor;
    public Material pastellBlueKonturColor;

    public Material colorPaletteHighlight;
    
    public GameObject pastellRedKontur;
    public GameObject pastellPinkKontur;
    public GameObject pastellWhiteKontur;
    public GameObject pastellYellowKontur;
    public GameObject pastellGreyKontur;
    public GameObject pastellAquaKontur;
    public GameObject pastellBlackKontur;
    public GameObject pastellBlueKontur;
    
    private Renderer m_Renderer_pastellRedKontur;
    private Renderer m_Renderer_pastellPinkKontur;
    private Renderer m_Renderer_pastellWhiteKontur;
    private Renderer m_Renderer_pastellYellowKontur;
    private Renderer m_Renderer_pastellGreyKontur;
    private Renderer m_Renderer_pastellAquaKontur;
    private Renderer m_Renderer_pastellBlackKontur;
    private Renderer m_Renderer_pastellBlueKontur;
    
    public Material sliderGrey;
    public Material sliderGreen;
    public Material sliderYellow;
    public Material sliderRasterung;
    public Material PlusMinusGreen;
   
    
    


    void Start()
    {
        sliderValueTextMesh = sliderValue.GetComponent<TextMeshProUGUI>();
        colorTextMesh = sliderFunktion.GetComponent<TextMeshProUGUI>();
        
        
        m_Renderer_Slider = SliderObject.GetComponent<Renderer>();
        m_Renderer_ColorBlack = blackCube.GetComponent<Renderer>();
        m_Renderer_ColorBLue = blueCube.GetComponent<Renderer>();
        m_Renderer_ColorCyan = cyanCube.GetComponent<Renderer>();
        m_Renderer_ColorGrey = greyCube.GetComponent<Renderer>();
        m_Renderer_ColorMagenta = magentaCube.GetComponent<Renderer>();
        m_Renderer_ColorRed = redCube.GetComponent<Renderer>();
        m_Renderer_ColorWhite = whiteCube.GetComponent<Renderer>();
        m_Renderer_ColorYellow = yellowCube.GetComponent<Renderer>();

        m_Renderer_pastellRedKontur = pastellRedKontur.GetComponent<Renderer>();
        m_Renderer_pastellPinkKontur = pastellPinkKontur.GetComponent<Renderer>();
        m_Renderer_pastellWhiteKontur = pastellWhiteKontur.GetComponent<Renderer>();
        m_Renderer_pastellYellowKontur = pastellYellowKontur.GetComponent<Renderer>();
        m_Renderer_pastellGreyKontur = pastellGreyKontur.GetComponent<Renderer>();
        m_Renderer_pastellAquaKontur = pastellAquaKontur.GetComponent<Renderer>();
        m_Renderer_pastellBlackKontur = pastellBlackKontur.GetComponent<Renderer>();
        m_Renderer_pastellBlueKontur = pastellBlueKontur.GetComponent<Renderer>();
        

        m_Renderer_sliderBackground = sliderBackground.GetComponent<Renderer>();
        m_Renderer_colorBackground = colorBackground.GetComponent<Renderer>();

        m_Renderer_Cube = CubeObjekt.GetComponent<Renderer>();

        m_Renderer_SliderButton = sliderButton.GetComponent<Renderer>();
        m_Renderer_SliderButtonKontur = sliderButtonKontur.GetComponent<Renderer>();
        m_Renderer_SliderGrip1 = sliderGrip1.GetComponent<Renderer>();
        m_Renderer_SliderGrip2 = sliderGrip2.GetComponent<Renderer>();
        m_Renderer_SliderGrip3 = sliderGrip3.GetComponent<Renderer>();

        m_Renderer_sliderRasterungFein1 = sliderRasterungFein1.GetComponent<Renderer>();
        m_Renderer_sliderRasterungFein2 = sliderRasterungFein2.GetComponent<Renderer>();
        m_Renderer_sliderRasterungFein3 = sliderRasterungFein3.GetComponent<Renderer>();
        m_Renderer_sliderRasterungFein4 = sliderRasterungFein4.GetComponent<Renderer>();
        m_Renderer_sliderRasterungFein5 = sliderRasterungFein5.GetComponent<Renderer>();
        m_Renderer_sliderRasterungFein6 = sliderRasterungFein6.GetComponent<Renderer>();
        m_Renderer_sliderRasterungFein7 = sliderRasterungFein7.GetComponent<Renderer>();
        m_Renderer_sliderRasterungFein8 = sliderRasterungFein8.GetComponent<Renderer>();
        m_Renderer_sliderRasterungFein9 = sliderRasterungFein9.GetComponent<Renderer>();
        m_Renderer_sliderRasterungFein10 = sliderRasterungFein10.GetComponent<Renderer>();
        m_Renderer_sliderRasterungFein11 = sliderRasterungFein11.GetComponent<Renderer>();
        m_Renderer_sliderRasterungFein12 = sliderRasterungFein12.GetComponent<Renderer>();
        m_Renderer_sliderRasterungFein13 = sliderRasterungFein13.GetComponent<Renderer>();
        m_Renderer_sliderRasterungFein14 = sliderRasterungFein14.GetComponent<Renderer>();
        m_Renderer_sliderRasterungFein15 = sliderRasterungFein15.GetComponent<Renderer>();
        m_Renderer_sliderRasterungFein16 = sliderRasterungFein16.GetComponent<Renderer>();
        m_Renderer_sliderRasterungFein17 = sliderRasterungFein17.GetComponent<Renderer>();
        m_Renderer_sliderRasterungFein18 = sliderRasterungFein18.GetComponent<Renderer>();
        m_Renderer_sliderRasterungFein21 = sliderRasterungFein21.GetComponent<Renderer>();
        m_Renderer_sliderRasterungFein24 = sliderRasterungFein24.GetComponent<Renderer>();
        m_Renderer_sliderRasterungFein25 = sliderRasterungFein25.GetComponent<Renderer>();
        m_Renderer_sliderRasterungFein26 = sliderRasterungFein26.GetComponent<Renderer>();
        m_Renderer_sliderRasterungFein27 = sliderRasterungFein27.GetComponent<Renderer>();
        m_Renderer_sliderRasterungFein28 = sliderRasterungFein28.GetComponent<Renderer>();
        m_Renderer_sliderRasterungFein29 = sliderRasterungFein29.GetComponent<Renderer>();
        m_Renderer_sliderRasterungFein30 = sliderRasterungFein30.GetComponent<Renderer>();
        m_Renderer_sliderRasterungFein31 = sliderRasterungFein31.GetComponent<Renderer>();
        m_Renderer_sliderRasterungFein32 = sliderRasterungFein32.GetComponent<Renderer>();
        m_Renderer_sliderRasterungFein33 = sliderRasterungFein33.GetComponent<Renderer>();
        m_Renderer_sliderRasterungFein34 = sliderRasterungFein34.GetComponent<Renderer>();
        m_Renderer_sliderRasterungFein35 = sliderRasterungFein35.GetComponent<Renderer>();
        m_Renderer_sliderRasterungFein36 = sliderRasterungFein36.GetComponent<Renderer>();
        m_Renderer_sliderRasterungFein37 = sliderRasterungFein37.GetComponent<Renderer>();
        m_Renderer_sliderRasterungFein38 = sliderRasterungFein38.GetComponent<Renderer>();
        
        m_Renderer_sliderRasterungGrob1 = sliderRasterungGrob1.GetComponent<Renderer>();
        m_Renderer_sliderRasterungGrob2 = sliderRasterungGrob2.GetComponent<Renderer>();
        m_Renderer_sliderRasterungGrob3 = sliderRasterungGrob3.GetComponent<Renderer>();
        m_Renderer_sliderRasterungGrob4 = sliderRasterungGrob4.GetComponent<Renderer>();
        m_Renderer_sliderRasterungGrob5 = sliderRasterungGrob5.GetComponent<Renderer>();
        m_Renderer_sliderRasterungGrob6 = sliderRasterungGrob6.GetComponent<Renderer>();
        m_Renderer_sliderRasterungGrob7 = sliderRasterungGrob7.GetComponent<Renderer>();
        m_Renderer_sliderRasterungGrob8 = sliderRasterungGrob8.GetComponent<Renderer>();
        m_Renderer_sliderRasterungGrob9 = sliderRasterungGrob9.GetComponent<Renderer>();
        m_Renderer_sliderRasterungGrob10 = sliderRasterungGrob10.GetComponent<Renderer>();
        m_Renderer_sliderRasterungGrob11 = sliderRasterungGrob11.GetComponent<Renderer>();

        m_Renderer_sliderMinus = sliderMinus.GetComponent<Renderer>();
        m_Renderer_sliderPlus1 = sliderPlus1.GetComponent<Renderer>();
        m_Renderer_sliderPlus2 = sliderPlus2.GetComponent<Renderer>();

        m_Renderer_buttonAllAxis = buttonAllAxis.GetComponent<Renderer>();
        m_Renderer_buttonAllAxisKontur = buttonAllAxisKontur.GetComponent<Renderer>();
        buttonTextMeshScaleAll = buttonTextScaleAll.GetComponent<TextMeshProUGUI>();
        m_Renderer_backgroundScaleAll = backgroundScaleAll.GetComponent<Renderer>();

        m_Renderer_checkmark = checkmark.GetComponent<Renderer>();

    }

  
    void Update()
    {

        if (LeftHand.GetComponent<DistanzMessungAlternativ>().funktionSkalierung == true)
        {
            if (LeftHand.GetComponent<DistanzMessungAlternativ>().SkalierungInX == true || LeftHand.GetComponent<DistanzMessungAlternativ>().SkalierungInY == true || LeftHand.GetComponent<DistanzMessungAlternativ>().SkalierungInZ == true)
            {
                m_Renderer_buttonAllAxis.enabled = true;
                m_Renderer_buttonAllAxisKontur.enabled = false;
                m_Renderer_checkmark.enabled = false;
                scaleAllAxis = false;
                buttonTextMeshScaleAll.text = "Proportions locked";
                buttonTextMeshScaleAll.color = Color.gray;
                m_Renderer_backgroundScaleAll.enabled = true;

                sliderBoxStartWert = 0f;
            }
            
            
            if (LeftHand.GetComponent<DistanzMessungAlternativ>().SkalierungInX == false && LeftHand.GetComponent<DistanzMessungAlternativ>().SkalierungInY == false && LeftHand.GetComponent<DistanzMessungAlternativ>().SkalierungInZ == false)
            {
                m_Renderer_buttonAllAxis.enabled = true;
                m_Renderer_buttonAllAxisKontur.enabled = true;
                m_Renderer_checkmark.enabled = true;
                scaleAllAxis = true;
                buttonTextMeshScaleAll.text = "Proportions locked";
                buttonTextMeshScaleAll.color = Color.white;
                m_Renderer_backgroundScaleAll.enabled = true;

                sliderBoxStartWert = 0f;
            }
            

        }
        
        

        
        
        if (LeftHand.GetComponent<DistanzMessungAlternativ>().RotationInX == true || LeftHand.GetComponent<DistanzMessungAlternativ>().RotationInY == true || LeftHand.GetComponent<DistanzMessungAlternativ>().RotationInZ == true)
        {
            m_Renderer_sliderBackground.enabled = true;
            
            sliderBoxStartWert = 0f;
        }
        
        
        if (LeftHand.GetComponent<DistanzMessungAlternativ>().funktionSkalierung == true || LeftHand.GetComponent<DistanzMessungAlternativ>().SkalierungInX == true || LeftHand.GetComponent<DistanzMessungAlternativ>().SkalierungInY == true || LeftHand.GetComponent<DistanzMessungAlternativ>().SkalierungInZ == true || 
            LeftHand.GetComponent<DistanzMessungAlternativ>().RotationInX == true || LeftHand.GetComponent<DistanzMessungAlternativ>().RotationInY == true || LeftHand.GetComponent<DistanzMessungAlternativ>().RotationInZ == true)
        {
            m_Renderer_Slider.enabled = true;
            m_Renderer_SliderButton.enabled = true;
            m_Renderer_SliderButtonKontur.enabled = true;
            m_Renderer_checkmark.enabled = true;
            m_Renderer_SliderGrip1.enabled = true;
            m_Renderer_SliderGrip2.enabled = true;
            m_Renderer_SliderGrip3.enabled = true;
            m_Renderer_sliderMinus.enabled = true;
            m_Renderer_sliderPlus1.enabled = true;
            m_Renderer_sliderPlus2.enabled = true;
            

            sliderBoxStartWert = 0f;
        }

        
        
        if (LeftHand.GetComponent<DistanzMessungAlternativ>().funktionSkalierung == false && LeftHand.GetComponent<DistanzMessungAlternativ>().SkalierungInX == false && LeftHand.GetComponent<DistanzMessungAlternativ>().SkalierungInY == false && LeftHand.GetComponent<DistanzMessungAlternativ>().SkalierungInZ == false)
        {
            m_Renderer_buttonAllAxis.enabled = false;
            m_Renderer_buttonAllAxisKontur.enabled = false;
            m_Renderer_checkmark.enabled = false;
            buttonTextMeshScaleAll.text = "";
            m_Renderer_backgroundScaleAll.enabled = false;

            sliderBoxStartWert = 0f;
        }
        
        
        if (LeftHand.GetComponent<DistanzMessungAlternativ>().RotationInX == false && LeftHand.GetComponent<DistanzMessungAlternativ>().RotationInY == false && LeftHand.GetComponent<DistanzMessungAlternativ>().RotationInZ == false)
        {
            m_Renderer_sliderBackground.enabled = false;

            sliderBoxStartWert = 0f;
        }

        
        if (LeftHand.GetComponent<DistanzMessungAlternativ>().funktionSkalierung == false && LeftHand.GetComponent<DistanzMessungAlternativ>().SkalierungInX == false && LeftHand.GetComponent<DistanzMessungAlternativ>().SkalierungInY == false && LeftHand.GetComponent<DistanzMessungAlternativ>().SkalierungInZ == false && 
            LeftHand.GetComponent<DistanzMessungAlternativ>().RotationInX == false && LeftHand.GetComponent<DistanzMessungAlternativ>().RotationInY == false && LeftHand.GetComponent<DistanzMessungAlternativ>().RotationInZ == false)
        {
            m_Renderer_Slider.enabled = false;
            m_Renderer_Slider.material = sliderGrey;
            sliderValueTextMesh.text = "";
            m_Renderer_SliderButton.enabled = false;
            m_Renderer_SliderButtonKontur.enabled = false;
            m_Renderer_checkmark.enabled = false;
            m_Renderer_SliderGrip1.enabled = false;
            m_Renderer_SliderGrip2.enabled = false;
            m_Renderer_SliderGrip3.enabled = false;

            m_Renderer_sliderRasterungFein1.enabled = false;
            m_Renderer_sliderRasterungFein2.enabled = false;
            m_Renderer_sliderRasterungFein3.enabled = false;
            m_Renderer_sliderRasterungFein4.enabled = false;
            m_Renderer_sliderRasterungFein5.enabled = false;
            m_Renderer_sliderRasterungFein6.enabled = false;
            m_Renderer_sliderRasterungFein7.enabled = false;
            m_Renderer_sliderRasterungFein8.enabled = false;
            m_Renderer_sliderRasterungFein9.enabled = false;
            m_Renderer_sliderRasterungFein10.enabled = false;
            m_Renderer_sliderRasterungFein11.enabled = false;
            m_Renderer_sliderRasterungFein12.enabled = false;
            m_Renderer_sliderRasterungFein13.enabled = false;
            m_Renderer_sliderRasterungFein14.enabled = false;
            m_Renderer_sliderRasterungFein15.enabled = false;
            m_Renderer_sliderRasterungFein16.enabled = false;
            m_Renderer_sliderRasterungFein17.enabled = false;
            m_Renderer_sliderRasterungFein18.enabled = false;
            m_Renderer_sliderRasterungFein21.enabled = false;
            m_Renderer_sliderRasterungFein24.enabled = false;
            m_Renderer_sliderRasterungFein25.enabled = false;
            m_Renderer_sliderRasterungFein26.enabled = false;
            m_Renderer_sliderRasterungFein27.enabled = false;
            m_Renderer_sliderRasterungFein28.enabled = false;
            m_Renderer_sliderRasterungFein29.enabled = false;
            m_Renderer_sliderRasterungFein30.enabled = false;
            m_Renderer_sliderRasterungFein31.enabled = false;
            m_Renderer_sliderRasterungFein32.enabled = false;
            m_Renderer_sliderRasterungFein33.enabled = false;
            m_Renderer_sliderRasterungFein34.enabled = false;
            m_Renderer_sliderRasterungFein35.enabled = false;
            m_Renderer_sliderRasterungFein36.enabled = false;
            m_Renderer_sliderRasterungFein37.enabled = false;
            m_Renderer_sliderRasterungFein38.enabled = false;
            
            m_Renderer_sliderRasterungGrob1.enabled = false;
            m_Renderer_sliderRasterungGrob2.enabled = false;
            m_Renderer_sliderRasterungGrob3.enabled = false;
            m_Renderer_sliderRasterungGrob4.enabled = false;
            m_Renderer_sliderRasterungGrob5.enabled = false;
            m_Renderer_sliderRasterungGrob6.enabled = false;
            m_Renderer_sliderRasterungGrob7.enabled = false;
            m_Renderer_sliderRasterungGrob8.enabled = false;
            m_Renderer_sliderRasterungGrob9.enabled = false;
            m_Renderer_sliderRasterungGrob10.enabled = false;
            m_Renderer_sliderRasterungGrob11.enabled = false;
            
            m_Renderer_sliderMinus.enabled = false;
            m_Renderer_sliderPlus1.enabled = false;
            m_Renderer_sliderPlus2.enabled = false;
            
            sliderBoxStartWert = 0f;
        }


        if (LeftHand.GetComponent<DistanzMessungAlternativ>().funktionRotation == false)
        {
            m_Renderer_sliderRasterungFein1.enabled = false;
            m_Renderer_sliderRasterungFein2.enabled = false;
            m_Renderer_sliderRasterungFein3.enabled = false;
            m_Renderer_sliderRasterungFein4.enabled = false;
            m_Renderer_sliderRasterungFein5.enabled = false;
            m_Renderer_sliderRasterungFein6.enabled = false;
            m_Renderer_sliderRasterungFein7.enabled = false;
            m_Renderer_sliderRasterungFein8.enabled = false;
            m_Renderer_sliderRasterungFein9.enabled = false;
            m_Renderer_sliderRasterungFein10.enabled = false;
            m_Renderer_sliderRasterungFein11.enabled = false;
            m_Renderer_sliderRasterungFein12.enabled = false;
            m_Renderer_sliderRasterungFein13.enabled = false;
            m_Renderer_sliderRasterungFein14.enabled = false;
            m_Renderer_sliderRasterungFein15.enabled = false;
            m_Renderer_sliderRasterungFein16.enabled = false;
            m_Renderer_sliderRasterungFein17.enabled = false;
            m_Renderer_sliderRasterungFein18.enabled = false;
            m_Renderer_sliderRasterungFein21.enabled = false;
            m_Renderer_sliderRasterungFein24.enabled = false;
            m_Renderer_sliderRasterungFein25.enabled = false;
            m_Renderer_sliderRasterungFein26.enabled = false;
            m_Renderer_sliderRasterungFein27.enabled = false;
            m_Renderer_sliderRasterungFein28.enabled = false;
            m_Renderer_sliderRasterungFein29.enabled = false;
            m_Renderer_sliderRasterungFein30.enabled = false;
            m_Renderer_sliderRasterungFein31.enabled = false;
            m_Renderer_sliderRasterungFein32.enabled = false;
            m_Renderer_sliderRasterungFein33.enabled = false;
            m_Renderer_sliderRasterungFein34.enabled = false;
            m_Renderer_sliderRasterungFein35.enabled = false;
            m_Renderer_sliderRasterungFein36.enabled = false;
            m_Renderer_sliderRasterungFein37.enabled = false;
            m_Renderer_sliderRasterungFein38.enabled = false;

            m_Renderer_sliderRasterungGrob1.enabled = false;
            m_Renderer_sliderRasterungGrob2.enabled = false;
            m_Renderer_sliderRasterungGrob3.enabled = false;
            m_Renderer_sliderRasterungGrob4.enabled = false;
            m_Renderer_sliderRasterungGrob5.enabled = false;
            m_Renderer_sliderRasterungGrob6.enabled = false;
            m_Renderer_sliderRasterungGrob7.enabled = false;
            m_Renderer_sliderRasterungGrob8.enabled = false;
            m_Renderer_sliderRasterungGrob9.enabled = false;
            m_Renderer_sliderRasterungGrob10.enabled = false;
            m_Renderer_sliderRasterungGrob11.enabled = false;
        }
        
        
        

        if (RightHand.GetComponent<DistanzMessungRechts>().funktionSlider1 == true && LeftHand.GetComponent<DistanzMessungAlternativ>().funktionFarbe == false)
        {
            m_Renderer_sliderRasterungGrob1.enabled = true;
            m_Renderer_sliderRasterungGrob2.enabled = true;
            m_Renderer_sliderRasterungGrob3.enabled = true;
            m_Renderer_sliderRasterungGrob4.enabled = true;
            m_Renderer_sliderRasterungGrob5.enabled = true;
            m_Renderer_sliderRasterungGrob6.enabled = true;
            m_Renderer_sliderRasterungGrob7.enabled = true;
            m_Renderer_sliderRasterungGrob8.enabled = true;
            m_Renderer_sliderRasterungGrob9.enabled = true;
            m_Renderer_sliderRasterungGrob10.enabled = true;
            m_Renderer_sliderRasterungGrob11.enabled = true;

            m_Renderer_sliderRasterungFein1.enabled = false;
            m_Renderer_sliderRasterungFein2.enabled = false;
            m_Renderer_sliderRasterungFein3.enabled = false;
            m_Renderer_sliderRasterungFein4.enabled = false;
            m_Renderer_sliderRasterungFein5.enabled = false;
            m_Renderer_sliderRasterungFein6.enabled = false;
            m_Renderer_sliderRasterungFein7.enabled = false;
            m_Renderer_sliderRasterungFein8.enabled = false;
            m_Renderer_sliderRasterungFein9.enabled = false;
            m_Renderer_sliderRasterungFein10.enabled = false;
            m_Renderer_sliderRasterungFein11.enabled = false;
            m_Renderer_sliderRasterungFein12.enabled = false;
            m_Renderer_sliderRasterungFein13.enabled = false;
            m_Renderer_sliderRasterungFein14.enabled = false;
            m_Renderer_sliderRasterungFein15.enabled = false;
            m_Renderer_sliderRasterungFein16.enabled = false;
            m_Renderer_sliderRasterungFein17.enabled = false;
            m_Renderer_sliderRasterungFein18.enabled = false;
            m_Renderer_sliderRasterungFein21.enabled = false;
            m_Renderer_sliderRasterungFein24.enabled = false;
            m_Renderer_sliderRasterungFein25.enabled = false;
            m_Renderer_sliderRasterungFein26.enabled = false;
            m_Renderer_sliderRasterungFein27.enabled = false;
            m_Renderer_sliderRasterungFein28.enabled = false;
            m_Renderer_sliderRasterungFein29.enabled = false;
            m_Renderer_sliderRasterungFein30.enabled = false;
            m_Renderer_sliderRasterungFein31.enabled = false;
            m_Renderer_sliderRasterungFein32.enabled = false;
            m_Renderer_sliderRasterungFein33.enabled = false;
            m_Renderer_sliderRasterungFein34.enabled = false;
            m_Renderer_sliderRasterungFein35.enabled = false;
            m_Renderer_sliderRasterungFein36.enabled = false;
            m_Renderer_sliderRasterungFein37.enabled = false;
            m_Renderer_sliderRasterungFein38.enabled = false;
        }


        if (RightHand.GetComponent<DistanzMessungRechts>().funktionSlider2 == true && LeftHand.GetComponent<DistanzMessungAlternativ>().funktionFarbe == false)
        {
            m_Renderer_sliderRasterungFein1.enabled = true;
            m_Renderer_sliderRasterungFein2.enabled = true;
            m_Renderer_sliderRasterungFein3.enabled = true;
            m_Renderer_sliderRasterungFein4.enabled = true;
            m_Renderer_sliderRasterungFein5.enabled = true;
            m_Renderer_sliderRasterungFein6.enabled = true;
            m_Renderer_sliderRasterungFein7.enabled = true;
            m_Renderer_sliderRasterungFein8.enabled = true;
            m_Renderer_sliderRasterungFein9.enabled = true;
            m_Renderer_sliderRasterungFein10.enabled = true;
            m_Renderer_sliderRasterungFein11.enabled = true;
            m_Renderer_sliderRasterungFein12.enabled = true;
            m_Renderer_sliderRasterungFein13.enabled = true;
            m_Renderer_sliderRasterungFein14.enabled = true;
            m_Renderer_sliderRasterungFein15.enabled = true;
            m_Renderer_sliderRasterungFein16.enabled = true;
            m_Renderer_sliderRasterungFein17.enabled = true;
            m_Renderer_sliderRasterungFein18.enabled = true;
            m_Renderer_sliderRasterungFein21.enabled = true;
            m_Renderer_sliderRasterungFein24.enabled = true;
            m_Renderer_sliderRasterungFein25.enabled = true;
            m_Renderer_sliderRasterungFein26.enabled = true;
            m_Renderer_sliderRasterungFein27.enabled = true;
            m_Renderer_sliderRasterungFein28.enabled = true;
            m_Renderer_sliderRasterungFein29.enabled = true;
            m_Renderer_sliderRasterungFein30.enabled = true;
            m_Renderer_sliderRasterungFein31.enabled = true;
            m_Renderer_sliderRasterungFein32.enabled = true;
            m_Renderer_sliderRasterungFein33.enabled = true;
            m_Renderer_sliderRasterungFein34.enabled = true;
            m_Renderer_sliderRasterungFein35.enabled = true;
            m_Renderer_sliderRasterungFein36.enabled = true;
            m_Renderer_sliderRasterungFein37.enabled = true;
            m_Renderer_sliderRasterungFein38.enabled = true;

            m_Renderer_sliderRasterungGrob1.enabled = false;
            m_Renderer_sliderRasterungGrob2.enabled = false;
            m_Renderer_sliderRasterungGrob3.enabled = false;
            m_Renderer_sliderRasterungGrob4.enabled = false;
            m_Renderer_sliderRasterungGrob5.enabled = false;
            m_Renderer_sliderRasterungGrob6.enabled = false;
            m_Renderer_sliderRasterungGrob7.enabled = false;
            m_Renderer_sliderRasterungGrob8.enabled = false;
            m_Renderer_sliderRasterungGrob9.enabled = false;
            m_Renderer_sliderRasterungGrob10.enabled = false;
            m_Renderer_sliderRasterungGrob11.enabled = false;
        }
        
        

        if (RightHand.GetComponent<DistanzMessungRechts>().funktionBestaetigung == true)
        {
            
            m_Renderer_Slider.enabled = false;
            m_Renderer_sliderBackground.enabled = false;
            sliderValueTextMesh.text = "";
            
            
            RightHand.GetComponent<DistanzMessungRechts>().funktionSlider1 = false;
            RightHand.GetComponent<DistanzMessungRechts>().funktionSlider2 = false;
            RightHand.GetComponent<DistanzMessungRechts>().funktionBestaetigung = false;

            LeftHand.GetComponent<DistanzMessungAlternativ>().funktionFarbe = false;
        
            LeftHand.GetComponent<DistanzMessungAlternativ>().SkalierungInX = false;
            LeftHand.GetComponent<DistanzMessungAlternativ>().SkalierungInY = false;
            LeftHand.GetComponent<DistanzMessungAlternativ>().SkalierungInZ = false;

            LeftHand.GetComponent<DistanzMessungAlternativ>().RotationInX = false;
            LeftHand.GetComponent<DistanzMessungAlternativ>().RotationInY = false;
            LeftHand.GetComponent<DistanzMessungAlternativ>().RotationInZ = false;
            LeftHand.GetComponent<DistanzMessungAlternativ>().funktionRotation = false;
            
            m_Renderer_Slider.material = sliderGrey;
            m_Renderer_SliderButton.enabled = false;
            m_Renderer_SliderButtonKontur.enabled = false;
            m_Renderer_checkmark.enabled = false;
            m_Renderer_SliderGrip1.enabled = false;
            m_Renderer_SliderGrip2.enabled = false;
            m_Renderer_SliderGrip3.enabled = false;

            m_Renderer_sliderRasterungFein1.enabled = false;
            m_Renderer_sliderRasterungFein2.enabled = false;
            m_Renderer_sliderRasterungFein3.enabled = false;
            m_Renderer_sliderRasterungFein4.enabled = false;
            m_Renderer_sliderRasterungFein5.enabled = false;
            m_Renderer_sliderRasterungFein6.enabled = false;
            m_Renderer_sliderRasterungFein7.enabled = false;
            m_Renderer_sliderRasterungFein8.enabled = false;
            m_Renderer_sliderRasterungFein9.enabled = false;
            m_Renderer_sliderRasterungFein10.enabled = false;
            m_Renderer_sliderRasterungFein11.enabled = false;
            m_Renderer_sliderRasterungFein12.enabled = false;
            m_Renderer_sliderRasterungFein13.enabled = false;
            m_Renderer_sliderRasterungFein14.enabled = false;
            m_Renderer_sliderRasterungFein15.enabled = false;
            m_Renderer_sliderRasterungFein16.enabled = false;
            m_Renderer_sliderRasterungFein17.enabled = false;
            m_Renderer_sliderRasterungFein18.enabled = false;
            m_Renderer_sliderRasterungFein21.enabled = false;
            m_Renderer_sliderRasterungFein24.enabled = false;
            m_Renderer_sliderRasterungFein25.enabled = false;
            m_Renderer_sliderRasterungFein26.enabled = false;
            m_Renderer_sliderRasterungFein27.enabled = false;
            m_Renderer_sliderRasterungFein28.enabled = false;
            m_Renderer_sliderRasterungFein29.enabled = false;
            m_Renderer_sliderRasterungFein30.enabled = false;
            m_Renderer_sliderRasterungFein31.enabled = false;
            m_Renderer_sliderRasterungFein32.enabled = false;
            m_Renderer_sliderRasterungFein33.enabled = false;
            m_Renderer_sliderRasterungFein34.enabled = false;
            m_Renderer_sliderRasterungFein35.enabled = false;
            m_Renderer_sliderRasterungFein36.enabled = false;
            m_Renderer_sliderRasterungFein37.enabled = false;
            m_Renderer_sliderRasterungFein38.enabled = false;
            
            m_Renderer_sliderRasterungGrob1.enabled = false;
            m_Renderer_sliderRasterungGrob2.enabled = false;
            m_Renderer_sliderRasterungGrob3.enabled = false;
            m_Renderer_sliderRasterungGrob4.enabled = false;
            m_Renderer_sliderRasterungGrob5.enabled = false;
            m_Renderer_sliderRasterungGrob6.enabled = false;
            m_Renderer_sliderRasterungGrob7.enabled = false;
            m_Renderer_sliderRasterungGrob8.enabled = false;
            m_Renderer_sliderRasterungGrob9.enabled = false;
            m_Renderer_sliderRasterungGrob10.enabled = false;
            m_Renderer_sliderRasterungGrob11.enabled = false;
            
            m_Renderer_sliderMinus.enabled = false;
            m_Renderer_sliderPlus1.enabled = false;
            m_Renderer_sliderPlus2.enabled = false;

        }


        if (LeftHand.GetComponent<DistanzMessungAlternativ>().funktionFarbe == true)
        {
            colorTextMesh.text = "Change Color";
                
            m_Renderer_ColorBlack.enabled = true;
            m_Renderer_ColorBLue.enabled = true;
            m_Renderer_ColorCyan.enabled = true;
            m_Renderer_ColorGrey.enabled = true;
            m_Renderer_ColorMagenta.enabled = true;
            m_Renderer_ColorRed.enabled = true;
            m_Renderer_ColorWhite.enabled = true;
            m_Renderer_ColorYellow.enabled = true;
            m_Renderer_colorBackground.enabled = true;

            m_Renderer_pastellRedKontur.enabled = true;
            m_Renderer_pastellPinkKontur.enabled = true;
            m_Renderer_pastellWhiteKontur.enabled = true;
            m_Renderer_pastellYellowKontur.enabled = true;
            m_Renderer_pastellGreyKontur.enabled = true;
            m_Renderer_pastellAquaKontur.enabled = true;
            m_Renderer_pastellBlackKontur.enabled = true;
            m_Renderer_pastellBlueKontur.enabled = true;
        }
        else
        {
            colorTextMesh.text = "";
            
            m_Renderer_ColorBlack.enabled = false;
            m_Renderer_ColorBLue.enabled = false;
            m_Renderer_ColorCyan.enabled = false;
            m_Renderer_ColorGrey.enabled = false;
            m_Renderer_ColorMagenta.enabled = false;
            m_Renderer_ColorRed.enabled = false;
            m_Renderer_ColorWhite.enabled = false;
            m_Renderer_ColorYellow.enabled = false;
            m_Renderer_colorBackground.enabled = false;
            
            m_Renderer_pastellRedKontur.enabled = false;
            m_Renderer_pastellPinkKontur.enabled = false;
            m_Renderer_pastellWhiteKontur.enabled = false;
            m_Renderer_pastellYellowKontur.enabled = false;
            m_Renderer_pastellGreyKontur.enabled = false;
            m_Renderer_pastellAquaKontur.enabled = false;
            m_Renderer_pastellBlackKontur.enabled = false;
            m_Renderer_pastellBlueKontur.enabled = false;
        }
        
        
        
        // SLIDER - SKALIEREN IN ALLE ACHSEN

        if (LeftHand.GetComponent<DistanzMessungAlternativ>().funktionSkalierung && scaleAllAxis == true)
        {
            CubeObjektWert = CubeObjekt.transform.localScale.x * 200;
                
            sliderValueTextMesh.text = "Scale all Axis: " + CubeObjektWert.ToString("#.") + "%";
                

            if (inSliderBox)
            {
                sliderBoxAbstand = Vector3.Distance(indexFinger.position, sliderBoxLeft.position);
                sliderBoxStartWert = sliderBoxAbstand - sliderStartPosition;

                if (startPositionGemessen == false)
                {
                    sliderStartPosition = sliderBoxAbstand;
                    startPositionGemessen = true;
                }
            
                if (RightHand.GetComponent<DistanzMessungRechts>().funktionSlider1 == true)
                {
                    CubeObjekt.gameObject.transform.localScale = CubeObjekt.gameObject.transform.localScale + new Vector3(sliderBoxStartWert/20,sliderBoxStartWert/20,sliderBoxStartWert/20);
                    sliderValueTextMesh.text = "Scale all Axis: " + CubeObjektWert.ToString("#.") + "%";
                    m_Renderer_Slider.material = sliderGreen;
                }


                if (RightHand.GetComponent<DistanzMessungRechts>().funktionSlider2 == true)
                {
                    CubeObjekt.gameObject.transform.localScale = CubeObjekt.gameObject.transform.localScale + new Vector3(sliderBoxStartWert/300,sliderBoxStartWert/300,sliderBoxStartWert/300);
                    sliderValueTextMesh.text = "Scale all Axis: " + CubeObjektWert.ToString("#.") + "%";
                    m_Renderer_Slider.material = sliderGreen;
                }
                    
            }
                
        }
        
        
        // SLIDER - SKALIEREN IN X

            if (LeftHand.GetComponent<DistanzMessungAlternativ>().SkalierungInX && scaleAllAxis == false)
            {
                CubeObjektWert = CubeObjekt.transform.localScale.x * 200;
                
                sliderValueTextMesh.text = "Scale in X-Axis: " + CubeObjektWert.ToString("#.") + "%";
                

                if (inSliderBox)
                {
                    sliderBoxAbstand = Vector3.Distance(indexFinger.position, sliderBoxLeft.position);
                    sliderBoxStartWert = sliderBoxAbstand - sliderStartPosition;

                    if (startPositionGemessen == false)
                    {
                        sliderStartPosition = sliderBoxAbstand;
                        startPositionGemessen = true;
                    }
            
                    if (RightHand.GetComponent<DistanzMessungRechts>().funktionSlider1 == true)
                    {
                        CubeObjekt.gameObject.transform.localScale = CubeObjekt.gameObject.transform.localScale + new Vector3(sliderBoxStartWert/20,0,0);
                        sliderValueTextMesh.text = "Scale in X-Axis: " + CubeObjektWert.ToString("#.") + "%";
                        m_Renderer_Slider.material = sliderGreen;
                    }


                    if (RightHand.GetComponent<DistanzMessungRechts>().funktionSlider2 == true)
                    {
                        CubeObjekt.gameObject.transform.localScale = CubeObjekt.gameObject.transform.localScale + new Vector3(sliderBoxStartWert/300,0,0);
                        sliderValueTextMesh.text = "Scale in X-Axis: " + CubeObjektWert.ToString("#.") + "%";
                        m_Renderer_Slider.material = sliderGreen;
                    }
                    
                }
                
            }




            // SLIDER - SKALIEREN IN Y
            if (LeftHand.GetComponent<DistanzMessungAlternativ>().SkalierungInY && scaleAllAxis == false)
            {
                CubeObjektWert = CubeObjekt.transform.localScale.y * 200;
                
                sliderValueTextMesh.text = "Scale in Y-Axis: " + CubeObjektWert.ToString("#.") + "%";
                

                if (inSliderBox)
                {
                    sliderBoxAbstand = Vector3.Distance(indexFinger.position, sliderBoxLeft.position);
                    sliderBoxStartWert = sliderBoxAbstand - sliderStartPosition;
            
                    if (startPositionGemessen == false)
                    {
                        sliderStartPosition = sliderBoxAbstand;
                        startPositionGemessen = true;
                    }
            
                    if (RightHand.GetComponent<DistanzMessungRechts>().funktionSlider1 == true)
                    {
                        CubeObjekt.gameObject.transform.localScale = CubeObjekt.gameObject.transform.localScale + new Vector3(0,sliderBoxStartWert/20,0);
                        sliderValueTextMesh.text = "Scale in Y-Axis: " + CubeObjektWert.ToString("#.") + "%";
                        m_Renderer_Slider.material = sliderGreen;
                    }


                    if (RightHand.GetComponent<DistanzMessungRechts>().funktionSlider2 == true)
                    {
                        CubeObjekt.gameObject.transform.localScale = CubeObjekt.gameObject.transform.localScale + new Vector3(0,sliderBoxStartWert/300,0);
                        sliderValueTextMesh.text = "Scale in Y-Axis: " + CubeObjektWert.ToString("#.") + "%";
                        m_Renderer_Slider.material = sliderGreen;
                    }
                    
                }
                
            }
            
   
            
            
            // SLIDER - SKALIEREN IN Z
            if (LeftHand.GetComponent<DistanzMessungAlternativ>().SkalierungInZ && scaleAllAxis == false)
            {
                CubeObjektWert = CubeObjekt.transform.localScale.z * 200;
                
                sliderValueTextMesh.text = "Scale in Z-Axis: " + CubeObjektWert.ToString("#.") + "%";
                
                
                if (inSliderBox)
                {
                    sliderBoxAbstand = Vector3.Distance(indexFinger.position, sliderBoxLeft.position);
                    sliderBoxStartWert = sliderBoxAbstand - sliderStartPosition;
            
                    if (startPositionGemessen == false)
                    {
                        sliderStartPosition = sliderBoxAbstand;
                        startPositionGemessen = true;
                    }
            
                    if (RightHand.GetComponent<DistanzMessungRechts>().funktionSlider1 == true)
                    {
                        CubeObjekt.gameObject.transform.localScale = CubeObjekt.gameObject.transform.localScale + new Vector3(0,0,sliderBoxStartWert/20);
                        sliderValueTextMesh.text = "Scale in Z-Axis: " + CubeObjektWert.ToString("#.") + "%";
                        m_Renderer_Slider.material = sliderGreen;
                    }


                    if (RightHand.GetComponent<DistanzMessungRechts>().funktionSlider2 == true)
                    {
                        CubeObjekt.gameObject.transform.localScale = CubeObjekt.gameObject.transform.localScale + new Vector3(0,0,sliderBoxStartWert/300);
                        sliderValueTextMesh.text = "Scale in Z-Axis: " + CubeObjektWert.ToString("#.") + "%";
                        m_Renderer_Slider.material = sliderGreen;
                    }
                    
                }

            }
            
    
            
            
            // SLIDER - ROTATION IN X
            if (LeftHand.GetComponent<DistanzMessungAlternativ>().RotationInX)
            {
                CubeObjektWert = CubeObjekt.transform.eulerAngles.x;
                
                sliderValueTextMesh.text = "Rotate in X-Axis: " + CubeObjektWert.ToString("#.") + "°";
                

                if (inSliderBox)
                {
                    sliderBoxAbstand = Vector3.Distance(indexFinger.position, sliderBoxLeft.position);
                    sliderBoxStartWert = sliderBoxAbstand - sliderStartPosition;
            
                    if (startPositionGemessen == false)
                    {
                        sliderStartPosition = sliderBoxAbstand;
                        startPositionGemessen = true;
                    }
            
                    if (RightHand.GetComponent<DistanzMessungRechts>().funktionSlider1 == true)
                    {
                        CubeObjekt.gameObject.transform.eulerAngles = CubeObjekt.gameObject.transform.eulerAngles + new Vector3(sliderBoxStartWert*4,0,0);
                        sliderValueTextMesh.text = "Rotate in X-Axis: " + CubeObjektWert.ToString("#.") + "°";
                        m_Renderer_Slider.material = sliderGreen;
                    }


                    if (RightHand.GetComponent<DistanzMessungRechts>().funktionSlider2 == true)
                    {
                        CubeObjekt.gameObject.transform.eulerAngles = CubeObjekt.gameObject.transform.eulerAngles + new Vector3(sliderBoxStartWert/2,0,0);
                        CubeObjektWert = CubeObjekt.transform.eulerAngles.x;
                        sliderValueTextMesh.text = "Rotate in X-Axis: " + CubeObjektWert.ToString("#.") + "°";
                        m_Renderer_Slider.material = sliderGreen;
                    }

                }
                
            }
            
            
            
            // SLIDER - ROTATION IN Y
            if (LeftHand.GetComponent<DistanzMessungAlternativ>().RotationInY)
            {
                CubeObjektWert = CubeObjekt.transform.eulerAngles.y;
                
                sliderValueTextMesh.text = "Rotate in Y-Axis: " + CubeObjektWert.ToString("#.") + "°";
                

                if (inSliderBox)
                {
                    sliderBoxAbstand = Vector3.Distance(indexFinger.position, sliderBoxLeft.position);
                    sliderBoxStartWert = sliderBoxAbstand - sliderStartPosition;
            
                    if (startPositionGemessen == false)
                    {
                        sliderStartPosition = sliderBoxAbstand;
                        startPositionGemessen = true;
                    }
            
                    if (RightHand.GetComponent<DistanzMessungRechts>().funktionSlider1 == true)
                    {
                        CubeObjekt.gameObject.transform.eulerAngles = CubeObjekt.gameObject.transform.eulerAngles + new Vector3(0,sliderBoxStartWert*4,0);
                        sliderValueTextMesh.text = "Rotate in Y-Axis: " + CubeObjektWert.ToString("#.") + "°";
                        m_Renderer_Slider.material = sliderGreen;
                    }


                    if (RightHand.GetComponent<DistanzMessungRechts>().funktionSlider2 == true)
                    {
                        CubeObjekt.gameObject.transform.eulerAngles = CubeObjekt.gameObject.transform.eulerAngles + new Vector3(0,sliderBoxStartWert/2,0);
                        sliderValueTextMesh.text = "Rotate in Y-Axis: " + CubeObjektWert.ToString("#.") + "°";
                        m_Renderer_Slider.material = sliderGreen;
                    }
                    
                }
                
            }
            
            
            
            
            // SLIDER - ROTATION IN Z
            if (LeftHand.GetComponent<DistanzMessungAlternativ>().RotationInZ)
            {
                CubeObjektWert = CubeObjekt.transform.eulerAngles.z;
                
                sliderValueTextMesh.text = "Rotate in Z-Axis: " + CubeObjektWert.ToString("#.") + "°";
                
                
                if (inSliderBox)
                {
                    sliderBoxAbstand = Vector3.Distance(indexFinger.position, sliderBoxLeft.position);
                    sliderBoxStartWert = sliderBoxAbstand - sliderStartPosition;
            
                    if (startPositionGemessen == false)
                    {
                        sliderStartPosition = sliderBoxAbstand;
                        startPositionGemessen = true;
                    }
            
                    if (RightHand.GetComponent<DistanzMessungRechts>().funktionSlider1 == true)
                    {
                        CubeObjekt.gameObject.transform.eulerAngles = CubeObjekt.gameObject.transform.eulerAngles + new Vector3(0,0,sliderBoxStartWert*4);
                        sliderValueTextMesh.text = "Rotate in Z-Axis: " + CubeObjektWert.ToString("#.") + "°";
                        m_Renderer_Slider.material = sliderGreen;
                    }


                    if (RightHand.GetComponent<DistanzMessungRechts>().funktionSlider2 == true)
                    {
                        CubeObjekt.gameObject.transform.eulerAngles = CubeObjekt.gameObject.transform.eulerAngles + new Vector3(0,0,sliderBoxStartWert/2);
                        sliderValueTextMesh.text = "Rotate in Z-Axis: " + CubeObjektWert.ToString("#.") + "°";
                        m_Renderer_Slider.material = sliderGreen;
                    }
                    
                }
                
            }
            
            
            
            // SLIDER - BUTTON
            sliderButton.gameObject.transform.localPosition = new Vector3((sliderBoxStartWert * -1), 0.02f, 0.01f);
            
            
            //AUSSERHALB DER SLIDER-BOX
            if (inSliderBox == false)
            {
                m_Renderer_Slider.material = sliderGrey;
            }

            
            //INNERHALB DER SLIDER-BOX
            if (inSliderBox == true)
            {
                if (sliderBoxStartWert > 0f)
                {
                    m_Renderer_sliderMinus.material = sliderRasterung;
                    m_Renderer_sliderPlus1.material = PlusMinusGreen;
                    m_Renderer_sliderPlus2.material = PlusMinusGreen;
                }
                
                if (sliderBoxStartWert < 0f)
                {
                    m_Renderer_sliderMinus.material = PlusMinusGreen;
                    m_Renderer_sliderPlus1.material = sliderRasterung;
                    m_Renderer_sliderPlus2.material = sliderRasterung;
                }
            }
            
            
            if (sliderBoxStartWert == 0f)
            {
                m_Renderer_sliderMinus.material = sliderRasterung;
                m_Renderer_sliderPlus1.material = sliderRasterung;
                m_Renderer_sliderPlus2.material = sliderRasterung;
            }


            if (scaleAllAxis)
            {
                m_Renderer_buttonAllAxisKontur.material = sliderGreen;
            }

            if (scaleAllAxis == false)
            {
                m_Renderer_buttonAllAxisKontur.material = pastellGreyKonturColor;
                m_Renderer_checkmark.enabled = false;
            }
            
    }


    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Slider"))
        {
            Debug.Log("INNERHALB RIGHT");
            inSliderBox = true;
        }


        if (LeftHand.GetComponent<DistanzMessungAlternativ>().funktionFarbe == true)
        {
            if (other.CompareTag("Blue"))
            {
                m_Renderer_Cube.material = pastellBlue;

                m_Renderer_pastellBlackKontur.material = pastellBlackKonturColor;
                m_Renderer_pastellGreyKontur.material = pastellGreyKonturColor;
                m_Renderer_pastellWhiteKontur.material = pastellWhiteKonturColor;
                m_Renderer_pastellRedKontur.material = pastellRedKonturColor;
                m_Renderer_pastellBlueKontur.material = colorPaletteHighlight;
                m_Renderer_pastellAquaKontur.material = pastellAquaKonturColor;
                m_Renderer_pastellYellowKontur.material = pastellYellowKonturColor;
                m_Renderer_pastellPinkKontur.material = pastellPinkKonturColor;
            }

            if (other.CompareTag("Black"))
            {
                m_Renderer_Cube.material = pastellBlack;
                
                m_Renderer_pastellBlackKontur.material = colorPaletteHighlight;
                m_Renderer_pastellGreyKontur.material = pastellGreyKonturColor;
                m_Renderer_pastellWhiteKontur.material = pastellWhiteKonturColor;
                m_Renderer_pastellRedKontur.material = pastellRedKonturColor;
                m_Renderer_pastellBlueKontur.material = pastellBlueKonturColor;
                m_Renderer_pastellAquaKontur.material = pastellAquaKonturColor;
                m_Renderer_pastellYellowKontur.material = pastellYellowKonturColor;
                m_Renderer_pastellPinkKontur.material = pastellPinkKonturColor;
            }

            if (other.CompareTag("Yellow"))
            {
                m_Renderer_Cube.material = pastellYellow;
                
                m_Renderer_pastellBlackKontur.material = pastellBlackKonturColor;
                m_Renderer_pastellGreyKontur.material = pastellGreyKonturColor;
                m_Renderer_pastellWhiteKontur.material = pastellWhiteKonturColor;
                m_Renderer_pastellRedKontur.material = pastellRedKonturColor;
                m_Renderer_pastellBlueKontur.material = pastellBlueKonturColor;
                m_Renderer_pastellAquaKontur.material = pastellAquaKonturColor;
                m_Renderer_pastellYellowKontur.material = colorPaletteHighlight;
                m_Renderer_pastellPinkKontur.material = pastellPinkKonturColor;
            }

            if (other.CompareTag("Green"))
            {
                m_Renderer_Cube.material = pastellAqua;
                
                m_Renderer_pastellBlackKontur.material = pastellBlackKonturColor;
                m_Renderer_pastellGreyKontur.material = pastellGreyKonturColor;
                m_Renderer_pastellWhiteKontur.material = pastellWhiteKonturColor;
                m_Renderer_pastellRedKontur.material = pastellRedKonturColor;
                m_Renderer_pastellBlueKontur.material = pastellBlueKonturColor;
                m_Renderer_pastellAquaKontur.material = colorPaletteHighlight;
                m_Renderer_pastellYellowKontur.material = pastellYellowKonturColor;
                m_Renderer_pastellPinkKontur.material = pastellPinkKonturColor;
            }

            if (other.CompareTag("Grey"))
            {
                m_Renderer_Cube.material = pastellGrey;
                
                m_Renderer_pastellBlackKontur.material = pastellBlackKonturColor;
                m_Renderer_pastellGreyKontur.material = colorPaletteHighlight;
                m_Renderer_pastellWhiteKontur.material = pastellWhiteKonturColor;
                m_Renderer_pastellRedKontur.material = pastellRedKonturColor;
                m_Renderer_pastellBlueKontur.material = pastellBlueKonturColor;
                m_Renderer_pastellAquaKontur.material = pastellAquaKonturColor;
                m_Renderer_pastellYellowKontur.material = pastellYellowKonturColor;
                m_Renderer_pastellPinkKontur.material = pastellPinkKonturColor;
            }

            if (other.CompareTag("Red"))
            {
                m_Renderer_Cube.material = pastellRed;
                
                m_Renderer_pastellBlackKontur.material = pastellBlackKonturColor;
                m_Renderer_pastellGreyKontur.material = pastellGreyKonturColor;
                m_Renderer_pastellWhiteKontur.material = pastellWhiteKonturColor;
                m_Renderer_pastellRedKontur.material = colorPaletteHighlight;
                m_Renderer_pastellBlueKontur.material = pastellBlueKonturColor;
                m_Renderer_pastellAquaKontur.material = pastellAquaKonturColor;
                m_Renderer_pastellYellowKontur.material = pastellYellowKonturColor;
                m_Renderer_pastellPinkKontur.material = pastellPinkKonturColor;
            }

            if (other.CompareTag("Magenta"))
            {
                m_Renderer_Cube.material = pastellPink;
                
                m_Renderer_pastellBlackKontur.material = pastellBlackKonturColor;
                m_Renderer_pastellGreyKontur.material = pastellGreyKonturColor;
                m_Renderer_pastellWhiteKontur.material = pastellWhiteKonturColor;
                m_Renderer_pastellRedKontur.material = pastellRedKonturColor;
                m_Renderer_pastellBlueKontur.material = pastellBlueKonturColor;
                m_Renderer_pastellAquaKontur.material = pastellAquaKonturColor;
                m_Renderer_pastellYellowKontur.material = pastellYellowKonturColor;
                m_Renderer_pastellPinkKontur.material = colorPaletteHighlight;
            }

            if (other.CompareTag("White"))
            {
                m_Renderer_Cube.material = pastellWhite;
                
                m_Renderer_pastellBlackKontur.material = pastellBlackKonturColor;
                m_Renderer_pastellGreyKontur.material = pastellGreyKonturColor;
                m_Renderer_pastellWhiteKontur.material = colorPaletteHighlight;
                m_Renderer_pastellRedKontur.material = pastellRedKonturColor;
                m_Renderer_pastellBlueKontur.material = pastellBlueKonturColor;
                m_Renderer_pastellAquaKontur.material = pastellAquaKonturColor;
                m_Renderer_pastellYellowKontur.material = pastellYellowKonturColor;
                m_Renderer_pastellPinkKontur.material = pastellPinkKonturColor;
            }
        }
    }

    
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Slider"))
        {
            Debug.Log("AUSSERHALB RIGHT");
            inSliderBox = false;
            startPositionGemessen = false;
        }
        
        
    }
    
    
}


