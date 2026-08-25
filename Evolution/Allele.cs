using System.Drawing;

enum AlleleType
{
  Body,
  Eye,
  Colour
}
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


interface IAllele
{
  AlleleType AlleleType { get; }
}

class ColourAllele : IAllele
{
  public ColourAllele(RGBColours _colour, Byte _colourPair)
  {
    colour = _colour;
    colourPair = _colourPair;
  }

  public AlleleType AlleleType => AlleleType.Colour;

  public RGBColours colour { get; }
  private Byte colourPair { get; }

}

class BodyAllele : IAllele
{
  public BodyAllele(BodyShapes _bodyType, SizeValues _bodySize)
  {
    bodyType = _bodyType;
    bodySize = _bodySize;
  }

  public AlleleType AlleleType => AlleleType.Body;
  public BodyShapes bodyType { get; }
  public SizeValues bodySize { get; }
}

class EyeAllele : IAllele
{
  public EyeAllele(EyeShape _eyeType, SizeValues _eyeSize)
  {
    eyeType = _eyeType;
    eyeSize = _eyeSize;
  }

  public AlleleType AlleleType => AlleleType.Body;
  public EyeShape eyeType {get;}
  public SizeValues eyeSize {get;}
}
