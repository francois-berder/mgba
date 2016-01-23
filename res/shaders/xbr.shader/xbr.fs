/*
   Hyllian's xBR-lv3 Shader
   
   Copyright (C) 2011-2015 Hyllian - sergiogdb@gmail.com

   Permission is hereby granted, free of charge, to any person obtaining a copy
   of this software and associated documentation files (the "Software"), to deal
   in the Software without restriction, including without limitation the rights
   to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
   copies of the Software, and to permit persons to whom the Software is
   furnished to do so, subject to the following conditions:

   The above copyright notice and this permission notice shall be included in
   all copies or substantial portions of the Software.

   THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
   IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
   FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
   AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
   LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
   OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
   THE SOFTWARE.


   Incorporates some of the ideas from SABR shader. Thanks to Joshua Street.
*/
// GLSL shader autogenerated by cg2glsl.py.
#if __VERSION__ >= 130
#define COMPAT_VARYING in
#define COMPAT_TEXTURE texture
out vec4 FragColor;
#else
#define COMPAT_VARYING varying
#define FragColor gl_FragColor
#define COMPAT_TEXTURE texture2D
#endif

#ifdef GL_ES
#ifdef GL_FRAGMENT_PRECISION_HIGH
precision highp float;
#else
precision mediump float;
#endif
#define COMPAT_PRECISION mediump
#else
#define COMPAT_PRECISION
#endif
vec4 _ret_0;
float _TMP57;
float _TMP56;
float _TMP55;
vec3 _TMP54;
vec3 _TMP53;
vec3 _TMP52;
vec3 _TMP51;
vec3 _TMP50;
vec3 _TMP49;
vec3 _TMP48;
vec3 _TMP47;
vec4 _TMP46;
vec4 _TMP45;
vec4 _TMP44;
vec4 _TMP37;
vec4 _TMP36;
vec4 _TMP65;
bvec4 _TMP35;
bvec4 _TMP34;
bvec4 _TMP33;
bvec4 _TMP32;
bvec4 _TMP31;
bvec4 _TMP30;
bvec4 _TMP29;
bvec4 _TMP28;
bvec4 _TMP27;
bvec4 _TMP26;
bvec4 _TMP25;
bvec4 _TMP24;
bvec4 _TMP23;
bvec4 _TMP22;
bvec4 _TMP21;
vec4 _TMP20;
vec4 _TMP19;
vec4 _TMP18;
vec4 _TMP17;
vec4 _TMP16;
vec4 _TMP15;
vec4 _TMP14;
vec4 _TMP13;
vec4 _TMP12;
vec4 _TMP11;
vec4 _TMP10;
vec4 _TMP9;
vec4 _TMP8;
vec4 _TMP7;
vec4 _TMP6;
vec4 _TMP5;
vec4 _TMP4;
vec4 _TMP3;
vec4 _TMP2;
vec4 _TMP1;
vec4 _TMP0;
uniform sampler2D tex;
vec2 _x0078;
vec4 _r0122;
vec4 _r0132;
vec4 _r0142;
vec4 _r0152;
vec4 _r0162;
vec4 _r0172;
vec4 _TMP183;
vec4 _a0186;
vec4 _TMP189;
vec4 _a0192;
vec4 _TMP195;
vec4 _a0198;
vec4 _TMP201;
vec4 _a0204;
vec4 _TMP207;
vec4 _a0210;
vec4 _TMP213;
vec4 _a0216;
vec4 _TMP219;
vec4 _a0222;
vec4 _TMP225;
vec4 _a0228;
vec4 _TMP231;
vec4 _a0234;
vec4 _TMP237;
vec4 _a0240;
vec4 _TMP243;
vec4 _a0246;
vec4 _TMP249;
vec4 _a0252;
vec4 _TMP255;
vec4 _a0258;
vec4 _TMP261;
vec4 _a0264;
vec4 _TMP267;
vec4 _a0270;
vec4 _x0274;
vec4 _TMP275;
vec4 _x0284;
vec4 _TMP285;
vec4 _x0294;
vec4 _TMP295;
vec4 _x0304;
vec4 _TMP305;
vec4 _x0314;
vec4 _TMP315;
vec4 _TMP323;
vec4 _a0326;
vec4 _TMP327;
vec4 _a0330;
vec4 _TMP331;
vec4 _a0334;
vec4 _TMP335;
vec4 _a0338;
vec4 _TMP339;
vec4 _a0342;
vec4 _TMP345;
vec4 _a0348;
vec4 _TMP349;
vec4 _a0352;
vec4 _TMP353;
vec4 _a0356;
vec4 _TMP357;
vec4 _a0360;
vec4 _TMP361;
vec4 _a0364;
vec4 _TMP365;
vec4 _a0368;
vec4 _TMP369;
vec4 _a0372;
vec4 _TMP373;
vec4 _a0376;
vec4 _TMP377;
vec4 _a0380;
vec4 _TMP381;
vec4 _a0384;
vec4 _TMP385;
vec4 _a0388;
vec3 _df0402;
vec3 _a0404;
vec3 _df0406;
vec3 _a0408;
COMPAT_VARYING vec4 TEX0;
COMPAT_VARYING vec4 TEX1;
COMPAT_VARYING vec4 TEX2;
COMPAT_VARYING vec4 TEX3;
COMPAT_VARYING vec4 TEX4;
COMPAT_VARYING vec4 TEX5;
COMPAT_VARYING vec4 TEX6;
COMPAT_VARYING vec4 TEX7;

const COMPAT_PRECISION vec2 TextureSize = vec2(240.0, 160.0);
void main()
{
    bvec4 _edr;
    bvec4 _edr_left;
    bvec4 _edr_up;
    bvec4 _px;
    bvec4 _interp_restriction_lv1;
    bvec4 _interp_restriction_lv2_left;
    bvec4 _interp_restriction_lv2_up;
    bvec4 _interp_restriction_lv3_left;
    bvec4 _interp_restriction_lv3_up;
    bvec4 _nc;
    bvec4 _nc30;
    bvec4 _nc60;
    bvec4 _nc45;
    bvec4 _nc15;
    bvec4 _nc75;
    vec4 _fx;
    vec4 _fx_left;
    vec4 _fx_up;
    vec4 _fx3_left;
    vec4 _fx3_up;
    vec3 _res1;
    vec3 _res2;
    vec3 _pix1;
    vec3 _pix2;
    float _blend1;
    float _blend2;
    vec2 _fp;
    vec4 _fx45;
    vec4 _fx30;
    vec4 _fx60;
    vec4 _fx15;
    vec4 _fx75;
    vec4 _final45;
    vec4 _final30;
    vec4 _final60;
    vec4 _final15;
    vec4 _final75;
    vec4 _maximo;
    vec3 _res;
    _x0078 = TEX0.xy*TextureSize;
    _fp = fract(_x0078);
    _TMP0 = COMPAT_TEXTURE(tex, TEX1.xw);
    _TMP1 = COMPAT_TEXTURE(tex, TEX1.yw);
    _TMP2 = COMPAT_TEXTURE(tex, TEX1.zw);
    _TMP3 = COMPAT_TEXTURE(tex, TEX2.xw);
    _TMP4 = COMPAT_TEXTURE(tex, TEX2.yw);
    _TMP5 = COMPAT_TEXTURE(tex, TEX2.zw);
    _TMP6 = COMPAT_TEXTURE(tex, TEX3.xw);
    _TMP7 = COMPAT_TEXTURE(tex, TEX3.yw);
    _TMP8 = COMPAT_TEXTURE(tex, TEX3.zw);
    _TMP9 = COMPAT_TEXTURE(tex, TEX4.xw);
    _TMP10 = COMPAT_TEXTURE(tex, TEX4.yw);
    _TMP11 = COMPAT_TEXTURE(tex, TEX4.zw);
    _TMP12 = COMPAT_TEXTURE(tex, TEX5.xw);
    _TMP13 = COMPAT_TEXTURE(tex, TEX5.yw);
    _TMP14 = COMPAT_TEXTURE(tex, TEX5.zw);
    _TMP15 = COMPAT_TEXTURE(tex, TEX6.xy);
    _TMP16 = COMPAT_TEXTURE(tex, TEX6.xz);
    _TMP17 = COMPAT_TEXTURE(tex, TEX6.xw);
    _TMP18 = COMPAT_TEXTURE(tex, TEX7.xy);
    _TMP19 = COMPAT_TEXTURE(tex, TEX7.xz);
    _TMP20 = COMPAT_TEXTURE(tex, TEX7.xw);
    _r0122.x = dot(_TMP4.xyz, vec3( 1.43519993E+01, 2.81760006E+01, 5.47200012E+00));
    _r0122.y = dot(_TMP6.xyz, vec3( 1.43519993E+01, 2.81760006E+01, 5.47200012E+00));
    _r0122.z = dot(_TMP10.xyz, vec3( 1.43519993E+01, 2.81760006E+01, 5.47200012E+00));
    _r0122.w = dot(_TMP8.xyz, vec3( 1.43519993E+01, 2.81760006E+01, 5.47200012E+00));
    _r0132.x = dot(_TMP5.xyz, vec3( 1.43519993E+01, 2.81760006E+01, 5.47200012E+00));
    _r0132.y = dot(_TMP3.xyz, vec3( 1.43519993E+01, 2.81760006E+01, 5.47200012E+00));
    _r0132.z = dot(_TMP9.xyz, vec3( 1.43519993E+01, 2.81760006E+01, 5.47200012E+00));
    _r0132.w = dot(_TMP11.xyz, vec3( 1.43519993E+01, 2.81760006E+01, 5.47200012E+00));
    _r0142.x = dot(_TMP7.xyz, vec3( 1.43519993E+01, 2.81760006E+01, 5.47200012E+00));
    _r0142.y = dot(_TMP7.xyz, vec3( 1.43519993E+01, 2.81760006E+01, 5.47200012E+00));
    _r0142.z = dot(_TMP7.xyz, vec3( 1.43519993E+01, 2.81760006E+01, 5.47200012E+00));
    _r0142.w = dot(_TMP7.xyz, vec3( 1.43519993E+01, 2.81760006E+01, 5.47200012E+00));
    _r0152.x = dot(_TMP20.xyz, vec3( 1.43519993E+01, 2.81760006E+01, 5.47200012E+00));
    _r0152.y = dot(_TMP2.xyz, vec3( 1.43519993E+01, 2.81760006E+01, 5.47200012E+00));
    _r0152.z = dot(_TMP15.xyz, vec3( 1.43519993E+01, 2.81760006E+01, 5.47200012E+00));
    _r0152.w = dot(_TMP12.xyz, vec3( 1.43519993E+01, 2.81760006E+01, 5.47200012E+00));
    _r0162.x = dot(_TMP14.xyz, vec3( 1.43519993E+01, 2.81760006E+01, 5.47200012E+00));
    _r0162.y = dot(_TMP18.xyz, vec3( 1.43519993E+01, 2.81760006E+01, 5.47200012E+00));
    _r0162.z = dot(_TMP0.xyz, vec3( 1.43519993E+01, 2.81760006E+01, 5.47200012E+00));
    _r0162.w = dot(_TMP17.xyz, vec3( 1.43519993E+01, 2.81760006E+01, 5.47200012E+00));
    _r0172.x = dot(_TMP13.xyz, vec3( 1.43519993E+01, 2.81760006E+01, 5.47200012E+00));
    _r0172.y = dot(_TMP19.xyz, vec3( 1.43519993E+01, 2.81760006E+01, 5.47200012E+00));
    _r0172.z = dot(_TMP1.xyz, vec3( 1.43519993E+01, 2.81760006E+01, 5.47200012E+00));
    _r0172.w = dot(_TMP16.xyz, vec3( 1.43519993E+01, 2.81760006E+01, 5.47200012E+00));
    _fx = vec4( 1.00000000E+00, -1.00000000E+00, -1.00000000E+00, 1.00000000E+00)*_fp.y + vec4( 1.00000000E+00, 1.00000000E+00, -1.00000000E+00, -1.00000000E+00)*_fp.x;
    _fx_left = vec4( 1.00000000E+00, -1.00000000E+00, -1.00000000E+00, 1.00000000E+00)*_fp.y + vec4( 5.00000000E-01, 2.00000000E+00, -5.00000000E-01, -2.00000000E+00)*_fp.x;
    _fx_up = vec4( 1.00000000E+00, -1.00000000E+00, -1.00000000E+00, 1.00000000E+00)*_fp.y + vec4( 2.00000000E+00, 5.00000000E-01, -2.00000000E+00, -5.00000000E-01)*_fp.x;
    _fx3_left = vec4( 6.00000000E+00, -2.00000000E+00, -6.00000000E+00, 2.00000000E+00)*_fp.y + vec4( 2.00000000E+00, 6.00000000E+00, -2.00000000E+00, -6.00000000E+00)*_fp.x;
    _fx3_up = vec4( 2.00000000E+00, -6.00000000E+00, -2.00000000E+00, 6.00000000E+00)*_fp.y + vec4( 6.00000000E+00, 2.00000000E+00, -6.00000000E+00, -2.00000000E+00)*_fp.x;
    _a0186 = _r0122.wxyz - _r0122;
    _TMP183 = abs(_a0186);
    _TMP21 = bvec4(_TMP183.x < 1.00000000E+01, _TMP183.y < 1.00000000E+01, _TMP183.z < 1.00000000E+01, _TMP183.w < 1.00000000E+01);
    _a0192 = _r0122.wxyz - _r0132;
    _TMP189 = abs(_a0192);
    _TMP22 = bvec4(_TMP189.x < 1.00000000E+01, _TMP189.y < 1.00000000E+01, _TMP189.z < 1.00000000E+01, _TMP189.w < 1.00000000E+01);
    _a0198 = _r0122.zwxy - _r0122.yzwx;
    _TMP195 = abs(_a0198);
    _TMP23 = bvec4(_TMP195.x < 1.00000000E+01, _TMP195.y < 1.00000000E+01, _TMP195.z < 1.00000000E+01, _TMP195.w < 1.00000000E+01);
    _a0204 = _r0122.zwxy - _r0132.zwxy;
    _TMP201 = abs(_a0204);
    _TMP24 = bvec4(_TMP201.x < 1.00000000E+01, _TMP201.y < 1.00000000E+01, _TMP201.z < 1.00000000E+01, _TMP201.w < 1.00000000E+01);
    _a0210 = _r0142 - _r0132.wxyz;
    _TMP207 = abs(_a0210);
    _TMP25 = bvec4(_TMP207.x < 1.00000000E+01, _TMP207.y < 1.00000000E+01, _TMP207.z < 1.00000000E+01, _TMP207.w < 1.00000000E+01);
    _a0216 = _r0122.wxyz - _r0172.yzwx;
    _TMP213 = abs(_a0216);
    _TMP26 = bvec4(_TMP213.x < 1.00000000E+01, _TMP213.y < 1.00000000E+01, _TMP213.z < 1.00000000E+01, _TMP213.w < 1.00000000E+01);
    _a0222 = _r0122.wxyz - _r0152;
    _TMP219 = abs(_a0222);
    _TMP27 = bvec4(_TMP219.x < 1.00000000E+01, _TMP219.y < 1.00000000E+01, _TMP219.z < 1.00000000E+01, _TMP219.w < 1.00000000E+01);
    _a0228 = _r0122.zwxy - _r0172;
    _TMP225 = abs(_a0228);
    _TMP28 = bvec4(_TMP225.x < 1.00000000E+01, _TMP225.y < 1.00000000E+01, _TMP225.z < 1.00000000E+01, _TMP225.w < 1.00000000E+01);
    _a0234 = _r0122.zwxy - _r0162;
    _TMP231 = abs(_a0234);
    _TMP29 = bvec4(_TMP231.x < 1.00000000E+01, _TMP231.y < 1.00000000E+01, _TMP231.z < 1.00000000E+01, _TMP231.w < 1.00000000E+01);
    _a0240 = _r0142 - _r0132.zwxy;
    _TMP237 = abs(_a0240);
    _TMP30 = bvec4(_TMP237.x < 1.00000000E+01, _TMP237.y < 1.00000000E+01, _TMP237.z < 1.00000000E+01, _TMP237.w < 1.00000000E+01);
    _a0246 = _r0142 - _r0132;
    _TMP243 = abs(_a0246);
    _TMP31 = bvec4(_TMP243.x < 1.00000000E+01, _TMP243.y < 1.00000000E+01, _TMP243.z < 1.00000000E+01, _TMP243.w < 1.00000000E+01);
    _interp_restriction_lv1 = bvec4(_r0142.x != _r0122.w && _r0142.x != _r0122.z && (!_TMP21.x && !_TMP22.x || !_TMP23.x && !_TMP24.x || _TMP25.x && (!_TMP26.x && !_TMP27.x || !_TMP28.x && !_TMP29.x) || _TMP30.x || _TMP31.x), _r0142.y != _r0122.x && _r0142.y != _r0122.w && (!_TMP21.y && !_TMP22.y || !_TMP23.y && !_TMP24.y || _TMP25.y && (!_TMP26.y && !_TMP27.y || !_TMP28.y && !_TMP29.y) || _TMP30.y || _TMP31.y), _r0142.z != _r0122.y && _r0142.z != _r0122.x && (!_TMP21.z && !_TMP22.z || !_TMP23.z && !_TMP24.z || _TMP25.z && (!_TMP26.z && !_TMP27.z || !_TMP28.z && !_TMP29.z) || _TMP30.z || _TMP31.z), _r0142.w != _r0122.z && _r0142.w != _r0122.y && (!_TMP21.w && !_TMP22.w || !_TMP23.w && !_TMP24.w || _TMP25.w && (!_TMP26.w && !_TMP27.w || !_TMP28.w && !_TMP29.w) || _TMP30.w || _TMP31.w));
    _interp_restriction_lv2_left = bvec4(_r0142.x != _r0132.z && _r0122.y != _r0132.z, _r0142.y != _r0132.w && _r0122.z != _r0132.w, _r0142.z != _r0132.x && _r0122.w != _r0132.x, _r0142.w != _r0132.y && _r0122.x != _r0132.y);
    _interp_restriction_lv2_up = bvec4(_r0142.x != _r0132.x && _r0122.x != _r0132.x, _r0142.y != _r0132.y && _r0122.y != _r0132.y, _r0142.z != _r0132.z && _r0122.z != _r0132.z, _r0142.w != _r0132.w && _r0122.w != _r0132.w);
    _a0252 = _r0132.zwxy - _r0162.wxyz;
    _TMP249 = abs(_a0252);
    _TMP32 = bvec4(_TMP249.x < 2.00000000E+00, _TMP249.y < 2.00000000E+00, _TMP249.z < 2.00000000E+00, _TMP249.w < 2.00000000E+00);
    _a0258 = _r0172.wxyz - _r0162.wxyz;
    _TMP255 = abs(_a0258);
    _TMP33 = bvec4(_TMP255.x < 2.00000000E+00, _TMP255.y < 2.00000000E+00, _TMP255.z < 2.00000000E+00, _TMP255.w < 2.00000000E+00);
    _interp_restriction_lv3_left = bvec4(_TMP32.x && !_TMP33.x, _TMP32.y && !_TMP33.y, _TMP32.z && !_TMP33.z, _TMP32.w && !_TMP33.w);
    _a0264 = _r0132 - _r0152.yzwx;
    _TMP261 = abs(_a0264);
    _TMP34 = bvec4(_TMP261.x < 2.00000000E+00, _TMP261.y < 2.00000000E+00, _TMP261.z < 2.00000000E+00, _TMP261.w < 2.00000000E+00);
    _a0270 = _r0172.zwxy - _r0152.yzwx;
    _TMP267 = abs(_a0270);
    _TMP35 = bvec4(_TMP267.x < 2.00000000E+00, _TMP267.y < 2.00000000E+00, _TMP267.z < 2.00000000E+00, _TMP267.w < 2.00000000E+00);
    _interp_restriction_lv3_up = bvec4(_TMP34.x && !_TMP35.x, _TMP34.y && !_TMP35.y, _TMP34.z && !_TMP35.z, _TMP34.w && !_TMP35.w);
    _x0274 = (_fx - vec4( 1.10000002E+00, 9.99999940E-02, -8.99999976E-01, 9.99999940E-02))/vec4( 7.99999952E-01, 7.99999952E-01, 7.99999952E-01, 7.99999952E-01);
    _TMP65 = min(vec4( 1.00000000E+00, 1.00000000E+00, 1.00000000E+00, 1.00000000E+00), _x0274);
    _TMP275 = max(vec4( 0.00000000E+00, 0.00000000E+00, 0.00000000E+00, 0.00000000E+00), _TMP65);
    _fx45 = _TMP275*_TMP275*(3.00000000E+00 - 2.00000000E+00*_TMP275);
    _x0284 = (_fx_left - vec4( 6.00000024E-01, 6.00000024E-01, -8.99999976E-01, -4.00000006E-01))/vec4( 7.99999952E-01, 7.99999952E-01, 7.99999952E-01, 8.00000012E-01);
    _TMP65 = min(vec4( 1.00000000E+00, 1.00000000E+00, 1.00000000E+00, 1.00000000E+00), _x0284);
    _TMP285 = max(vec4( 0.00000000E+00, 0.00000000E+00, 0.00000000E+00, 0.00000000E+00), _TMP65);
    _fx30 = _TMP285*_TMP285*(3.00000000E+00 - 2.00000000E+00*_TMP285);
    _x0294 = (_fx_up - vec4( 1.60000002E+00, -4.00000006E-01, -1.39999998E+00, 9.99999940E-02))/vec4( 8.00000072E-01, 8.00000012E-01, 7.99999952E-01, 7.99999952E-01);
    _TMP65 = min(vec4( 1.00000000E+00, 1.00000000E+00, 1.00000000E+00, 1.00000000E+00), _x0294);
    _TMP295 = max(vec4( 0.00000000E+00, 0.00000000E+00, 0.00000000E+00, 0.00000000E+00), _TMP65);
    _fx60 = _TMP295*_TMP295*(3.00000000E+00 - 2.00000000E+00*_TMP295);
    _x0304 = (_fx3_left - vec4( 4.59999990E+00, 2.59999990E+00, -3.40000010E+00, -1.39999998E+00))/vec4( 8.00000191E-01, 8.00000191E-01, 8.00000191E-01, 7.99999952E-01);
    _TMP65 = min(vec4( 1.00000000E+00, 1.00000000E+00, 1.00000000E+00, 1.00000000E+00), _x0304);
    _TMP305 = max(vec4( 0.00000000E+00, 0.00000000E+00, 0.00000000E+00, 0.00000000E+00), _TMP65);
    _fx15 = _TMP305*_TMP305*(3.00000000E+00 - 2.00000000E+00*_TMP305);
    _x0314 = (_fx3_up - vec4( 4.59999990E+00, -1.39999998E+00, -3.40000010E+00, 2.59999990E+00))/vec4( 8.00000191E-01, 7.99999952E-01, 8.00000191E-01, 8.00000191E-01);
    _TMP65 = min(vec4( 1.00000000E+00, 1.00000000E+00, 1.00000000E+00, 1.00000000E+00), _x0314);
    _TMP315 = max(vec4( 0.00000000E+00, 0.00000000E+00, 0.00000000E+00, 0.00000000E+00), _TMP65);
    _fx75 = _TMP315*_TMP315*(3.00000000E+00 - 2.00000000E+00*_TMP315);
    _a0326 = _r0142 - _r0132;
    _TMP323 = abs(_a0326);
    _a0330 = _r0142 - _r0132.zwxy;
    _TMP327 = abs(_a0330);
    _a0334 = _r0132.wxyz - _r0172;
    _TMP331 = abs(_a0334);
    _a0338 = _r0132.wxyz - _r0172.yzwx;
    _TMP335 = abs(_a0338);
    _a0342 = _r0122.zwxy - _r0122.wxyz;
    _TMP339 = abs(_a0342);
    _TMP36 = _TMP323 + _TMP327 + _TMP331 + _TMP335 + 4.00000000E+00*_TMP339;
    _a0348 = _r0122.zwxy - _r0122.yzwx;
    _TMP345 = abs(_a0348);
    _a0352 = _r0122.zwxy - _r0162;
    _TMP349 = abs(_a0352);
    _a0356 = _r0122.wxyz - _r0152;
    _TMP353 = abs(_a0356);
    _a0360 = _r0122.wxyz - _r0122;
    _TMP357 = abs(_a0360);
    _a0364 = _r0142 - _r0132.wxyz;
    _TMP361 = abs(_a0364);
    _TMP37 = _TMP345 + _TMP349 + _TMP353 + _TMP357 + 4.00000000E+00*_TMP361;
    _edr = bvec4(_TMP36.x < _TMP37.x && _interp_restriction_lv1.x, _TMP36.y < _TMP37.y && _interp_restriction_lv1.y, _TMP36.z < _TMP37.z && _interp_restriction_lv1.z, _TMP36.w < _TMP37.w && _interp_restriction_lv1.w);
    _a0368 = _r0122.wxyz - _r0132.zwxy;
    _TMP365 = abs(_a0368);
    _a0372 = _r0122.zwxy - _r0132;
    _TMP369 = abs(_a0372);
    _edr_left = bvec4((2.00000000E+00*_TMP365).x <= _TMP369.x && _interp_restriction_lv2_left.x, (2.00000000E+00*_TMP365).y <= _TMP369.y && _interp_restriction_lv2_left.y, (2.00000000E+00*_TMP365).z <= _TMP369.z && _interp_restriction_lv2_left.z, (2.00000000E+00*_TMP365).w <= _TMP369.w && _interp_restriction_lv2_left.w);
    _a0376 = _r0122.wxyz - _r0132.zwxy;
    _TMP373 = abs(_a0376);
    _a0380 = _r0122.zwxy - _r0132;
    _TMP377 = abs(_a0380);
    _edr_up = bvec4(_TMP373.x >= (2.00000000E+00*_TMP377).x && _interp_restriction_lv2_up.x, _TMP373.y >= (2.00000000E+00*_TMP377).y && _interp_restriction_lv2_up.y, _TMP373.z >= (2.00000000E+00*_TMP377).z && _interp_restriction_lv2_up.z, _TMP373.w >= (2.00000000E+00*_TMP377).w && _interp_restriction_lv2_up.w);
    _nc45 = bvec4(_edr.x && bool(_fx45.x), _edr.y && bool(_fx45.y), _edr.z && bool(_fx45.z), _edr.w && bool(_fx45.w));
    _nc30 = bvec4(_edr.x && _edr_left.x && bool(_fx30.x), _edr.y && _edr_left.y && bool(_fx30.y), _edr.z && _edr_left.z && bool(_fx30.z), _edr.w && _edr_left.w && bool(_fx30.w));
    _nc60 = bvec4(_edr.x && _edr_up.x && bool(_fx60.x), _edr.y && _edr_up.y && bool(_fx60.y), _edr.z && _edr_up.z && bool(_fx60.z), _edr.w && _edr_up.w && bool(_fx60.w));
    _nc15 = bvec4(_edr.x && _edr_left.x && _interp_restriction_lv3_left.x && bool(_fx15.x), _edr.y && _edr_left.y && _interp_restriction_lv3_left.y && bool(_fx15.y), _edr.z && _edr_left.z && _interp_restriction_lv3_left.z && bool(_fx15.z), _edr.w && _edr_left.w && _interp_restriction_lv3_left.w && bool(_fx15.w));
    _nc75 = bvec4(_edr.x && _edr_up.x && _interp_restriction_lv3_up.x && bool(_fx75.x), _edr.y && _edr_up.y && _interp_restriction_lv3_up.y && bool(_fx75.y), _edr.z && _edr_up.z && _interp_restriction_lv3_up.z && bool(_fx75.z), _edr.w && _edr_up.w && _interp_restriction_lv3_up.w && bool(_fx75.w));
    _a0384 = _r0142 - _r0122.wxyz;
    _TMP381 = abs(_a0384);
    _a0388 = _r0142 - _r0122.zwxy;
    _TMP385 = abs(_a0388);
    _px = bvec4(_TMP381.x <= _TMP385.x, _TMP381.y <= _TMP385.y, _TMP381.z <= _TMP385.z, _TMP381.w <= _TMP385.w);
    _nc = bvec4(_nc75.x || _nc15.x || _nc30.x || _nc60.x || _nc45.x, _nc75.y || _nc15.y || _nc30.y || _nc60.y || _nc45.y, _nc75.z || _nc15.z || _nc30.z || _nc60.z || _nc45.z, _nc75.w || _nc15.w || _nc30.w || _nc60.w || _nc45.w);
    _final45 = vec4(float(_nc45.x), float(_nc45.y), float(_nc45.z), float(_nc45.w))*_fx45;
    _final30 = vec4(float(_nc30.x), float(_nc30.y), float(_nc30.z), float(_nc30.w))*_fx30;
    _final60 = vec4(float(_nc60.x), float(_nc60.y), float(_nc60.z), float(_nc60.w))*_fx60;
    _final15 = vec4(float(_nc15.x), float(_nc15.y), float(_nc15.z), float(_nc15.w))*_fx15;
    _final75 = vec4(float(_nc75.x), float(_nc75.y), float(_nc75.z), float(_nc75.w))*_fx75;
    _TMP44 = max(_final15, _final75);
    _TMP45 = max(_final30, _final60);
    _TMP46 = max(_TMP44, _TMP45);
    _maximo = max(_TMP46, _final45);
    if (_nc.x) { 
        if (_px.x) { 
            _TMP47 = _TMP8.xyz;
        } else {
            _TMP47 = _TMP10.xyz;
        } 
        _pix1 = _TMP47;
        _blend1 = _maximo.x;
    } else {
        if (_nc.y) { 
            if (_px.y) { 
                _TMP48 = _TMP4.xyz;
            } else {
                _TMP48 = _TMP8.xyz;
            } 
            _pix1 = _TMP48;
            _blend1 = _maximo.y;
        } else {
            if (_nc.z) { 
                if (_px.z) { 
                    _TMP49 = _TMP6.xyz;
                } else {
                    _TMP49 = _TMP4.xyz;
                } 
                _pix1 = _TMP49;
                _blend1 = _maximo.z;
            } else {
                if (_nc.w) { 
                    if (_px.w) { 
                        _TMP50 = _TMP10.xyz;
                    } else {
                        _TMP50 = _TMP6.xyz;
                    } 
                    _pix1 = _TMP50;
                    _blend1 = _maximo.w;
                } 
            } 
        } 
    } 
    if (_nc.w) { 
        if (_px.w) { 
            _TMP51 = _TMP10.xyz;
        } else {
            _TMP51 = _TMP6.xyz;
        } 
        _pix2 = _TMP51;
        _blend2 = _maximo.w;
    } else {
        if (_nc.z) { 
            if (_px.z) { 
                _TMP52 = _TMP6.xyz;
            } else {
                _TMP52 = _TMP4.xyz;
            } 
            _pix2 = _TMP52;
            _blend2 = _maximo.z;
        } else {
            if (_nc.y) { 
                if (_px.y) { 
                    _TMP53 = _TMP4.xyz;
                } else {
                    _TMP53 = _TMP8.xyz;
                } 
                _pix2 = _TMP53;
                _blend2 = _maximo.y;
            } else {
                if (_nc.x) { 
                    if (_px.x) { 
                        _TMP54 = _TMP8.xyz;
                    } else {
                        _TMP54 = _TMP10.xyz;
                    } 
                    _pix2 = _TMP54;
                    _blend2 = _maximo.x;
                } 
            } 
        } 
    } 
    _res1 = _TMP7.xyz + _blend1*(_pix1 - _TMP7.xyz);
    _res2 = _TMP7.xyz + _blend2*(_pix2 - _TMP7.xyz);
    _a0404 = _TMP7.xyz - _res1;
    _df0402 = abs(_a0404);
    _TMP55 = _df0402.x + _df0402.y + _df0402.z;
    _a0408 = _TMP7.xyz - _res2;
    _df0406 = abs(_a0408);
    _TMP56 = _df0406.x + _df0406.y + _df0406.z;
    _TMP57 = float((_TMP56 >= _TMP55));
    _res = _res1 + _TMP57*(_res2 - _res1);
    _ret_0 = vec4(_res.x, _res.y, _res.z, 1.00000000E+00);
    FragColor = _ret_0;
    return;
} 
