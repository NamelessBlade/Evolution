enum BodyShapes
{
  TwoLegs,
  FourLegs
}

enum RGBColours
{
  Red,
  Green,
  Blue
}

enum EyeShape
{
  OneEye,
  TwoEyes,
  ThreeEyes
}

enum SizeValues
{
  Small,
  Medium,
  Large
}

class Allele{}

class ColourAllele : Allele
{
  ColourAllele(RGBColours _colour, Byte _colourPair)
  {
    colour = _colour;
    colourPair = _colourPair;
  }

  public RGBColours colour
  {get;}
  private Byte colourPair
  {get;}

}

class BodyPartAllele : Allele
{
  BodyPartAllele(System.Enum _bodyPartType, SizeValues _bodyPartSize)
  {
    bodyPartType = _bodyPartType;
    bodyPartSize = _bodyPartSize;
  }

  public Type AlleleType()
  {
    return bodyPartType.GetType();
  }
  public System.Enum bodyPartType
  {get;}
  public SizeValues bodyPartSize
  {get;}
}
