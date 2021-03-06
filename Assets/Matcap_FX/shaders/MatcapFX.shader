Shader "MatcapFX/MatcapFX" {

 Properties {
      _MainTex ("Matcap", 2D) = "white" {}
      _Emission ("Emission", Range (0,1)) = 1
    }
    SubShader {
    Tags { "Queue" = "Geometry" "RenderType" = "Opaque" }
    Cull Back
	ZWrite On
	ZTest LEqual
	ColorMask RGBA
	Lighting Off  

      CGPROGRAM
      #pragma surface surf Lambert vertex:vert keepalpha
      struct Input {
          float2 uv_MainTex;
          float3 customUV;
      };
      void vert (inout appdata_full v, out Input o) {
       	UNITY_INITIALIZE_OUTPUT(Input, o);
          o.customUV =( mul((float3x3)UNITY_MATRIX_IT_MV,v.normal) * 0.5 + 0.5) ;
      }
      sampler2D _MainTex;
      float _Alpha;
      float _Emission;
      void surf (Input IN, inout SurfaceOutput o) {
          o.Albedo = tex2D (_MainTex, IN.customUV).rgb;
          o.Emission = tex2D (_MainTex, IN.customUV).rgb * _Emission;
      }
      ENDCG
     
      
    } 
   
    
    Fallback "Diffuse"
  }

