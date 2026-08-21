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
  public ColourAllele(RGBColours _colour, Byte _colourPair)
  {
    colour = _colour;
    colourPair = _colourPair;
  }

  public RGBColours colour
  {get;}
  private Byte colourPair
  {get;}

}

class BodyPartAllele<TEnum> : Allele where TEnum : System.Enum 
{
  public BodyPartAllele(TEnum _bodyPartType, SizeValues _bodyPartSize)
  {
    bodyPartType = _bodyPartType;
    bodyPartSize = _bodyPartSize;
  }

  public Type AlleleType()
  {
    return bodyPartType.GetType();
  }
  public TEnum bodyPartType
  {get;}
  public SizeValues bodyPartSize
  {get;}
}
