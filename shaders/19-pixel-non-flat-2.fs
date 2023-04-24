uniform sampler2D image;
uniform float rotate;

vec2 hash(float n) {
    return fract(sin(n)*vec2(43758.5453123, 31774.99282211));
}

vec2 noise(in vec2 x) {
    vec2 p = floor(x);
    vec2 f = fract(x);
    f = f*f*(3.0-2.0*f);
    float n = p.x + p.y*157.0;
    return mix(mix( hash(n+  0.0), hash(n+  1.0),f.x),
               mix( hash(n+157.0), hash(n+158.0),f.x),f.y);
}


void main(void)
{
      vec2 coord = gl_TexCoord[0].xy;
      coord -= 0.5;
      coord = fract(vec2(coord.x * fract(coord.y * rotate * 77.0), coord.y * fract(coord.x * rotate * 50.0)));
      vec4 color = texture2D(image, coord);
      coord += 0.5;
      gl_FragColor = vec4(color.r, color.g, color.b, color.a);
}
