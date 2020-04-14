uniform sampler2D image;
uniform float rotate;
void main(void)
{
      vec2 coord = gl_TexCoord[0].xy;
      coord -= 0.5;
      float r = length(coord) * rotate;
      mat2 rot = mat2(cos(r), sin(r), -sin(r), cos(r));
      coord = rot * coord * (0.7 + 0.3 * cos(r));
      coord += 0.5;
      vec4 color = texture2D(image, coord);
      gl_FragColor = vec4(color.r, color.g, color.b, color.a);
}
