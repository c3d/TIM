uniform sampler2D image;
uniform vec2 resolution;
void main(void)
{
    vec2 coord = gl_TexCoord[0].xy * resolution.xy;
    float a = 0.3;
    float s = sin(a);
    float c = cos(a);
    mat2 m = mat2(c, -s, s, c);
    coord = m * coord / resolution.xy;
    vec4 color = texture2D(image, coord);
    gl_FragColor = color;
}
