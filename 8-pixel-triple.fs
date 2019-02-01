uniform sampler2D image;
void main(void)
{
      vec2 coord = gl_TexCoord[0].xy;
      vec4 color = texture2D(image, 3.0 * coord);
      gl_FragColor = vec4(color.r, color.g, color.b, color.a);
}
