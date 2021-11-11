uniform vec2 resolution;
uniform sampler2D image;
void main(void)
{
    vec2 coord = (0.5 * gl_FragCoord.xy - 0.5) / resolution;
    vec2 delta = (32.0 * coord - 0.5)  - floor(32.0 * coord);
    float len = 1.1 - 1.7 * length(delta);
    vec4 color = texture2D(image, coord);
    gl_FragColor = len * vec4(color.rgb, 1.0);
}
