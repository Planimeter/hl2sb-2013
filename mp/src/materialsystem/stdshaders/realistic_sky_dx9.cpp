//https://papers.cumincad.org/data/works/att/74bb.content.pdf
#include "BaseVSShader.h"
#include "realistic_sky_vs20.inc"
#include "realistic_sky_ps30.inc"
#include "convar.h"

DEFINE_FALLBACK_SHADER(realistic_Sky, realistic_Sky_HDR_DX9)

BEGIN_VS_SHADER(Realistic_Sky_HDR_DX9, "Sky shader based on the Preetham sky model")

BEGIN_SHADER_PARAMS
    SHADER_PARAM(SUN_PITCH, SHADER_PARAM_TYPE_FLOAT, "45", "Sun Zenith")
    SHADER_PARAM(SUN_YAW, SHADER_PARAM_TYPE_FLOAT, "0", "Sun Azimuth")
    SHADER_PARAM(EXPOSURE, SHADER_PARAM_TYPE_FLOAT, "25", "Decrease exposure by this much")
    SHADER_PARAM(TURBIDITY, SHADER_PARAM_TYPE_FLOAT, "2", "Turbidity of the sky")
END_SHADER_PARAMS


SHADER_INIT_PARAMS()
{
    SET_FLAGS(MATERIAL_VAR_NOFOG);
    SET_FLAGS(MATERIAL_VAR_IGNOREZ);
}

SHADER_INIT
{
}

SHADER_FALLBACK
{
    // Requires DX9 or above
    if (g_pHardwareConfig->GetDXSupportLevel() < 90)
    {
        Assert(0);
        return "Wireframe";
    }
    return 0;
}
    
SHADER_DRAW
{
    SHADOW_STATE
    {
        SetInitialShadowState();
        pShaderShadow->VertexShaderVertexFormat(VERTEX_POSITION, 1, NULL, 0);

        DECLARE_STATIC_VERTEX_SHADER(realistic_sky_vs20);
        SET_STATIC_VERTEX_SHADER(realistic_sky_vs20);

        DECLARE_STATIC_PIXEL_SHADER(realistic_sky_ps30);
        SET_STATIC_PIXEL_SHADER(realistic_sky_ps30);

        pShaderShadow->EnableSRGBWrite(false);
        pShaderShadow->EnableAlphaWrites(true);
    }


    DYNAMIC_STATE
    {
        // light_environment shines from the opposite direction provided like so:
        // For Yaw: start west, move counter clockwise.
        // For Pitch: -90 for pointing straight down, 0 for Horizon.

        // Spin the sun around to start West, and move counterclockwise.
        float sun_azimuth = M_PI - params[SUN_YAW]->GetFloatValue() * (M_PI / 180);

        // Flip the numbers around to get -90 noon 0 sunset.
        float sun_inclination = (90 + params[SUN_PITCH]->GetFloatValue()) * (M_PI / 180);

        float sin_incl = sin(sun_inclination);
        float cos_incl = cos(sun_inclination);
        float sin_az = sin(sun_azimuth);
        float cos_az = cos(sun_azimuth);

        float computedSunDir[3] = {
            sin_incl * cos_az,
            cos_incl,
            sin_incl * sin_az 
        };

        pShaderAPI->SetPixelShaderConstant(0, computedSunDir, 1);

        float intensity = params[EXPOSURE]->GetFloatValue();
        pShaderAPI->SetPixelShaderConstant(1, &intensity, 1);

        float turbidity = params[TURBIDITY]->GetFloatValue();
        turbidity = (turbidity >= 2) ? turbidity : 2;
        pShaderAPI->SetPixelShaderConstant(2, &turbidity, 1);

        DECLARE_DYNAMIC_VERTEX_SHADER(realistic_sky_vs20);
        SET_DYNAMIC_VERTEX_SHADER(realistic_sky_vs20);

        DECLARE_DYNAMIC_PIXEL_SHADER(realistic_sky_ps30);
        SET_DYNAMIC_PIXEL_SHADER(realistic_sky_ps30);
    }
    Draw();
}
END_SHADER
