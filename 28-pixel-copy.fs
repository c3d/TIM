uniform vec2 resolution;
uniform sampler2D image;
void main(void)
{
    vec2 coord = (0.5 * gl_FragCoord.xy - 0.5) / resolution;
    vec4 color = texture2D(image, coord);
    gl_FragColor = vec4(color.r, color.g, color.b, color.a);
}
