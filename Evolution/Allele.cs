namespace Evolution;

enum AlleleType
{
    Body,
    Eye,
    Red,
    Blue,
    Green
}

enum BodyShapes : int
{
    TwoLegs = 0,
    FourLegs = 1
}

enum EyeShape : int
{
    OneEye = 0,
    TwoEyes = 1,
    ThreeEyes = 2
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
    bool IsDominant(IAllele comparedAllele, Dictionary<AlleleType, int[]> dominanceDictionary);
}

class RedAllele(Byte _colourPair) : IAllele
{
    public bool IsDominant(RedAllele comparedAllele, Dictionary<AlleleType, int[]> dominanceDictionary)
    {
        Byte dominantValue = (byte)dominanceDictionary[AlleleType][0];
        if (Math.Abs(colourPair - dominantValue) > Math.Abs(comparedAllele.colourPair - dominantValue))
            return false;
        else
            return true;
    }

    public AlleleType AlleleType => AlleleType.Red;
    public Byte colourPair { get; } = _colourPair;

}

class BlueAllele(Byte _colourPair) : IAllele
{
    public bool IsDominant(BlueAllele comparedAllele, Dictionary<AlleleType, int[]> dominanceDictionary)
    {
        Byte dominantValue = (byte)dominanceDictionary[AlleleType][0];
        if (Math.Abs(colourPair - dominantValue) > Math.Abs(comparedAllele.colourPair - dominantValue))
            return false;
        else
            return true;
    }

    public AlleleType AlleleType => AlleleType.Blue;
    public Byte colourPair { get; } = _colourPair;

}

class GreenAllele(Byte _colourPair) : IAllele
{
    public bool IsDominant(GreenAllele comparedAllele, Dictionary<AlleleType, int[]> dominanceDictionary)
    {
        Byte dominantValue = (byte)dominanceDictionary[AlleleType][0];
        if (Math.Abs(colourPair - dominantValue) > Math.Abs(comparedAllele.colourPair - dominantValue))
            return false;
        else
            return true;
    }
    public AlleleType AlleleType => AlleleType.Green;
    public Byte colourPair { get; } = _colourPair;

}

class BodyAllele(BodyShapes _bodyType, SizeValues _bodySize) : IAllele
{
    public bool IsDominant(BodyAllele comparedAllele, Dictionary<AlleleType, int[]> dominanceDictionary)
    {
        int[] dominanceOrder = dominanceDictionary[AlleleType];
        int ownPositionInDominance = dominanceOrder.IndexOf((int)bodyType);
        int comparedPositionInDominance = dominanceOrder.IndexOf((int)comparedAllele.bodyType);

        if (ownPositionInDominance > comparedPositionInDominance)
            return false;
        else
            return true;
    }
    public AlleleType AlleleType => AlleleType.Body;
    public BodyShapes bodyType { get; } = _bodyType;
}

class EyeAllele(EyeShape _eyeType, SizeValues _eyeSize) : IAllele
{
    public bool IsDominant(EyeAllele comparedAllele, Dictionary<AlleleType, int[]> dominanceDictionary)
    {
        int[] dominanceOrder = dominanceDictionary[AlleleType];
        int ownPositionInDominance = dominanceOrder.IndexOf((int)eyeType);
        int comparedPositionInDominance = dominanceOrder.IndexOf((int)comparedAllele.eyeType);

        if (ownPositionInDominance > comparedPositionInDominance)
            return false;
        else
            return true;
    }
    public AlleleType AlleleType => AlleleType.Eye;
    public EyeShape eyeType { get; } = _eyeType;
}
