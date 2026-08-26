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

class RedAllele : IAllele
{
    public RedAllele(Byte _colourPair)
    {
        colourPair = _colourPair;
    }

    public AlleleType AlleleType => AlleleType.Colour;
    public Byte colourPair { get; }

}

class BlueAllele : IAllele
{
    public BlueAllele(Byte _colourPair)
    {
        colourPair = _colourPair;
    }

    public AlleleType AlleleType => AlleleType.Colour;
    public Byte colourPair { get; }

}

class GreenAllele : IAllele
{
    public GreenAllele(Byte _colourPair)
    {
        colourPair = _colourPair;
    }

    public AlleleType AlleleType => AlleleType.Colour;
    public Byte colourPair { get; }

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
