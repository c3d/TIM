uniform sampler2D image;
void main(void)
{
    vec2 coord = vec2(0.34,0.4) + 0.1 * gl_TexCoord[0].xy;
    vec4 color = texture2D(image, coord);
    gl_FragColor = vec4(color.r, color.g, color.b, color.a);
}
